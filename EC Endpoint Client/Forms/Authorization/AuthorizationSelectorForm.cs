using System;
using System.Security.Cryptography.X509Certificates;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationSelectorForm : BaseForms.SelectorBaseForm
    {
        public AuthorizationSelectorForm(string thumb, X509Certificate2 cert, bool useEC2Interface) : base(thumb, cert, useEC2Interface)
        {
            InitializeComponent();
        }

        private void btn_AuthorizationAdministration_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                AuthorizationAdministrationFormEC2 aaF = new AuthorizationAdministrationFormEC2();
                aaF.Text = "AuthorizationAdministrationForm (EC2)";
                aaF.SelectedCertificate = SelectedCertificate;
                aaF.EndPointConfigurationNameList = GetEndPoints();
                aaF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(aaF, "Administration.IAuthorizationAdministrationEC2");
                ShowMethod1(aaF);
            }
            else
            {
                AuthorizationAdministrationForm aaF = new AuthorizationAdministrationForm();
                aaF.Text = "AuthorizationAdministrationForm (EC)";
                aaF.SelectedCertificate = SelectedCertificate;
                aaF.EndPointConfigurationNameList = GetEndPoints();
                aaF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(aaF, "Administration.IAuthorizationAdministrationEC");
                ShowMethod1(aaF);
            }
        }

        private void btn_AuthorizationToken_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                AuthorizationTokenFormEC2 form = new AuthorizationTokenFormEC2();
                form.Text = "AuthorizationTokenForm (EC2)";
                form.SelectedCertificate = SelectedCertificate;
                form.EndPointConfigurationNameList = GetEndPoints();
                form.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(form, "Token.IAuthorizationTokenExternalEC2");
                ShowMethod1(form);
            }
            else
            {
                AuthorizationTokenForm form = new AuthorizationTokenForm();
                form.Text = "AuthorizationTokenForm (EC)";
                form.SelectedCertificate = SelectedCertificate;
                form.EndPointConfigurationNameList = GetEndPoints();
                form.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(form, "Token.IAuthorizationTokenExternalEC");
                ShowMethod1(form);
            }
        }
    }
}
