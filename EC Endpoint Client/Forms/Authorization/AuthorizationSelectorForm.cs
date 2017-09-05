using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationSelectorForm : SelectorBaseForm
    {
        public AuthorizationSelectorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorizationAdministrationForm aaF = new AuthorizationAdministrationForm();
            aaF.SelectedCertificate = SelectedCertificate;
            aaF.EndPointConfigurationNameList = GetEndPoints("Administration.IAuthorizationAdministrationEC");
            aaF.SelectedEndpointName = SelectedEndPointName;
            SetClientValues(aaF, "Administration.IAuthorizationAdministrationEC");
            ShowMethod1(aaF);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthorizationTokenForm form = new AuthorizationTokenForm();
            form.SelectedCertificate = SelectedCertificate;
            form.EndPointConfigurationNameList = GetEndPoints("Token.IAuthorizationTokenExternalEC");
            form.SelectedEndpointName = SelectedEndPointName;
            SetClientValues(form, "Token.IAuthorizationTokenExternalEC");
            ShowMethod1(form);
        }
    }
}
