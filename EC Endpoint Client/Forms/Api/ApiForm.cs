using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms
{
    public partial class ApiForm : SelectorBaseForm
    {
        
        public new string Thumbprint
        {
            get { return base.Thumbprint; }
            set
            {
                base.Thumbprint = value;
                txtCertificate.Text = value;
            }
        }

        private ErrorProvider errorProvider = new ErrorProvider();
        private string _thumbPrint = string.Empty;
        private Cookie AuthCookie { get; set; }
        private List<DropDownItem> Environments = new List<DropDownItem>(); /* {
            new DropDownItem("DEV", "http://devenv.altinntest.no.accenture.com:85/"),
            new DropDownItem("DEV Https", "https://localhostapi:44/"),
            new DropDownItem("ST1", "https://st01.ai.basefarm.net/"),
            new DropDownItem("ST2", "https://st02.ai.basefarm.net/"),
            new DropDownItem("ST3", "https://st03.ai.basefarm.net/"),
            new DropDownItem("AT5", "https://at05.ai.basefarm.net/"),
            new DropDownItem("AT6", "https://at06.ai.basefarm.net/"),
            new DropDownItem("AT7", "https://at07.ai.basefarm.net/"),
            new DropDownItem("TT1", "https://tt01.altinn.no/"),
            new DropDownItem("TT2", "https://tt02.altinn.no/"),
            new DropDownItem("PROD", "https://www.altinn.no/")
        };*/

        private class DropDownItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public DropDownItem(string Text, object Value)
            {
                this.Text = Text;
                this.Value = Value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public ApiForm()
        {
            assignEnvironmentsFromConfig();
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            foreach (DropDownItem value in Environments)
            {
                ddlEnvironment.Items.Add(value);
            }

            ddlMethod.Items.Add(HttpMethod.Get);
            ddlMethod.Items.Add(HttpMethod.Post);
            ddlMethod.Items.Add(HttpMethod.Put);
            ddlMethod.Items.Add(HttpMethod.Delete);
        }

        private void assignEnvironmentsFromConfig()
        {
            Environments = new List<DropDownItem>();
            foreach (ApiEnvironment apiEnvironment in EcClientConfiguration.GetConfig().ApiEnvironmentCollection)
            {
                Environments.Add(new DropDownItem(apiEnvironment.Name, apiEnvironment.Environment));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            errorProvider.Clear();
            bool hasError = false;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Username is required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Password is required");
                hasError = true;
            }

            if (ddlEnvironment.SelectedIndex < 0)
            {
                errorProvider.SetError(ddlEnvironment, "Environment must be selected");
                hasError = true;
            }

            if (string.IsNullOrEmpty(txtCertificate.Text))
            {
                errorProvider.SetError(txtCertificate, "Certificate must be selected");
                hasError = true;
            }

            if (hasError)
            {
                return;
            }

            string body = "{UserName: \"" + txtUsername.Text + "\",UserPassword:\"" + txtPassword.Text + "\"}";

            DoRequest(((DropDownItem)ddlEnvironment.SelectedItem).Value.ToString()
                        + "api/serviceowner/authentication/authenticatewithpassword?ForceEIAuthentication",
                    HttpMethod.Post.ToString(),
                    string.Empty,
                    body,
                    true);
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            ShowCertificateForm();
        }

        private void ShowCertificateForm()
        {
            CertificateSelectorForm csF = SelectedCertificate == null ? new CertificateSelectorForm() : new CertificateSelectorForm(SelectedCertificate);

            csF.FormClosing += csF_FormClosing;
            csF.ShowDialog();
        }

        void csF_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelectedCertificate = ((CertificateSelectorForm)sender).SelectedCertificate;
            if (SelectedCertificate != null)
            {
                Thumbprint = SelectedCertificate.Thumbprint;
            }
        }

        private static void FixCookies(HttpWebRequest request, HttpWebResponse response)
        {
            for (int i = 0; i < response.Headers.Count; i++)
            {
                string name = response.Headers.GetKey(i);
                if (name != "Set-Cookie")
                    continue;
                string value = response.Headers.Get(i);
                foreach (var singleCookie in value.Split(','))
                {
                    Match match = Regex.Match(singleCookie, "(.+?)=(.+?);");
                    if (match.Captures.Count == 0)
                        continue;
                    response.Cookies.Add(
                        new Cookie(
                            match.Groups[1].ToString(),
                            match.Groups[2].ToString(),
                            "/",
                            request.Host.Split(':')[0]));
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool hasError = false;
            if (string.IsNullOrEmpty(txtAppKey.Text))
            {
                errorProvider.SetError(txtAppKey, "AppKey is required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(txtTargetMethod.Text))
            {
                errorProvider.SetError(txtTargetMethod, "Target method is required");
                hasError = true;
            }

            if (ddlEnvironment.SelectedIndex < 0)
            {
                errorProvider.SetError(ddlEnvironment, "Environment must be selected");
                hasError = true;
            }

            if (ddlMethod.SelectedIndex < 0)
            {
                errorProvider.SetError(ddlMethod, "Method must be selected");
                hasError = true;
            }

            if (AuthCookie == null)
            {
                errorProvider.SetError(lblLoginInfo, "Must be logged in");
            }

            if (hasError)
            {
                return;
            }

            DoRequest(((DropDownItem)ddlEnvironment.SelectedItem).Value.ToString()
                        + txtTargetMethod.Text,
                    ((HttpMethod)ddlMethod.SelectedItem).ToString(),
                    txtAppKey.Text,
                    txtBody.Text);
        }

        private void DoRequest(string target, string method, string appKey = null, string body = null, bool useCertificate = true)
        {
            HttpWebResponse response = null;
            
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(target);
                request.Accept = "application/hal+json";
                request.ContentType = "application/hal+json";
                request.Method = method;
                request.Headers.Add("ApiKey", appKey);

                if (useCertificate)
                {
                    request.ClientCertificates.Add(SelectedCertificate);
                }

                if (AuthCookie != null)
                {
                    request.CookieContainer = new CookieContainer();
                    request.CookieContainer.Add(new Uri(((DropDownItem)ddlEnvironment.SelectedItem).Value.ToString()), AuthCookie);
                }

                if (method == HttpMethod.Post.ToString() || method == HttpMethod.Put.ToString())
                {
                    byte[] bodyEncoded = UTF8Encoding.UTF8.GetBytes(body);
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(bodyEncoded, 0, bodyEncoded.Length);
                    }
                }

                response = (HttpWebResponse)request.GetResponse();
                var headers = response.Headers;
                txtResponse.Text = string.Empty;
                lsResponseHeaders.Clear();
                for (int i = 0; i < headers.Count; ++i)
                {
                    string header = headers.GetKey(i);
                    foreach (string value in headers.GetValues(i))
                    {
                        lsResponseHeaders.Items.Add(new ListViewItem(String.Format("{0}: {1}", header, value)));
                    }
                }

                FixCookies(request, response);

                if (response.Cookies[".ASPXAUTH"] != null)
                {
                    AuthCookie = response.Cookies[".ASPXAUTH"];
                    lblLoginInfo.Text = "Logged in";
                }

                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), UTF8Encoding.UTF8))
                {
                    txtResponse.Text = reader.ReadToEnd();
                }

            }
            catch (WebException e)
            {
                txtResponse.Text = e.Message + Environment.NewLine;

                WebResponse webResponse = e.Response;
                if (webResponse != null)
                {
                    Stream responseStream = webResponse.GetResponseStream();
                    if (responseStream != null)
                    {
                        using (var reader = new System.IO.StreamReader(responseStream, UTF8Encoding.UTF8))
                        {
                            txtResponse.Text += Environment.NewLine + reader.ReadToEnd();
                        }
                    }
                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
        }
    }
}
