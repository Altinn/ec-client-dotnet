using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EC_Endpoint_Client.Configuration;

namespace EC_Endpoint_Client.Forms.Api
{
    public partial class ApiForm : BaseForms.SelectorBaseForm
    {
        private const string AuthenticationURI = "api/authentication/authenticatewithpassword?ForceEIAuthentication";

        public new string Thumbprint
        {
            get { return base.Thumbprint; }
            set
            {
                base.Thumbprint = value;
                txtCertificate.Text = value;
            }
        }

        private ErrorProvider _errorProvider = new ErrorProvider();
        private Cookie AuthCookie { get; set; }
        private List<DropDownItem> _environments = new List<DropDownItem>();

        private class DropDownItem
        {
            public string Text { get; }
            public object Value { get; }

            public DropDownItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public ApiForm()
        {
            AssignEnvironmentsFromConfig();
            InitializeComponent();
            _errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            foreach (DropDownItem value in _environments)
            {
                ddlEnvironment.Items.Add(value);
            }

            ddlMethod.Items.Add(HttpMethod.Get);
            ddlMethod.Items.Add(HttpMethod.Post);
            ddlMethod.Items.Add(HttpMethod.Put);
            ddlMethod.Items.Add(HttpMethod.Delete);
        }

        private void AssignEnvironmentsFromConfig()
        {
            _environments = new List<DropDownItem>();
            foreach (EnvironmentUrl apiEnvironment in EcClientConfiguration.GetConfig().EnvironmentUrlCollection)
            {
                _environments.Add(new DropDownItem(apiEnvironment.Name, apiEnvironment.Environment));
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!cbxServiceOwner.Checked)
                DoLogin();
            else
                _errorProvider.SetError(cbxServiceOwner, "No login required for the serviceowner api");
        }

        private void DoLogin()
        {
            _errorProvider.Clear();
            bool hasError = false;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                _errorProvider.SetError(txtUsername, "Username is required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                _errorProvider.SetError(txtPassword, "Password is required");
                hasError = true;
            }

            if (ddlEnvironment.SelectedIndex < 0)
            {
                _errorProvider.SetError(ddlEnvironment, "Environment must be selected");
                hasError = true;
            }

            if (string.IsNullOrEmpty(txtCertificate.Text))
            {
                _errorProvider.SetError(txtCertificate, "Certificate must be selected");
                hasError = true;
            }

            if (hasError)
            {
                return;
            }

            string body = "{UserName: \"" + txtUsername.Text + "\",UserPassword:\"" + txtPassword.Text + "\"}";

            DoRequest(((DropDownItem) ddlEnvironment.SelectedItem).Value + AuthenticationURI,
                HttpMethod.Post.ToString(),
                string.Empty,
                body);
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
            _errorProvider.Clear();
            bool hasError = false;
            if (string.IsNullOrEmpty(txtAppKey.Text))
            {
                _errorProvider.SetError(txtAppKey, "AppKey is required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(txtTargetMethod.Text))
            {
                _errorProvider.SetError(txtTargetMethod, "Target method is required");
                hasError = true;
            }

            if (ddlEnvironment.SelectedIndex < 0)
            {
                _errorProvider.SetError(ddlEnvironment, "Environment must be selected");
                hasError = true;
            }

            if (ddlMethod.SelectedIndex < 0)
            {
                _errorProvider.SetError(ddlMethod, "Method must be selected");
                hasError = true;
            }

            if (AuthCookie == null && cbxServiceOwner.Checked == false)
            {
                _errorProvider.SetError(lblLoginInfo, "Must be logged in");
            }

            if (SelectedCertificate == null)
            {
                _errorProvider.SetError(btnCertificate, "Select certificate");
            }

            if (hasError)
            {
                return;
            }

            DoRequest(((DropDownItem) ddlEnvironment.SelectedItem).Value + txtTargetMethod.Text,
                ((HttpMethod) ddlMethod.SelectedItem).ToString(),
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
                    // ReSharper disable once AssignNullToNotNullAttribute
                    byte[] bodyEncoded = Encoding.UTF8.GetBytes(body);
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
                    var enumerable = headers.GetValues(i);
                    if (enumerable != null)
                        foreach (string value in enumerable)
                        {
                            lsResponseHeaders.Items.Add(new ListViewItem(String.Format("{0}: {1}", header, value)));
                        }
                }

                FixCookies(request, response);

                if (response.Cookies[".ASPXAUTH"] != null)
                {
                    AuthCookie = response.Cookies[".ASPXAUTH"];
                    lblLoginInfo.Text = @"Logged in";
                }

                // ReSharper disable once AssignNullToNotNullAttribute
                using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
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
                        using (var reader = new StreamReader(responseStream, Encoding.UTF8))
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
