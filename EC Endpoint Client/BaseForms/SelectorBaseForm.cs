using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;

namespace EC_Endpoint_Client.Forms
{
    public partial class SelectorBaseForm : Form
    {
        public string Thumbprint { get; set; }
        public X509Certificate2 SelectedCertificate { get; set; }
        public string SelectedEndPointName { get; set; }
        public EndPointState State { get; set; }
        public SelectorBaseForm()
        {
            InitializeComponent();
        }

        public SelectorBaseForm(string thumb, X509Certificate2 cert)
        {
            InitializeComponent();
            Thumbprint = thumb;
            SelectedCertificate = cert;
        }

        protected virtual void SetClientValues(ClientBaseForm cbf, string contractName)
        {
            cbf.SelectedCertificate = this.SelectedCertificate;
            cbf.Thumbprint = this.Thumbprint;
            cbf.EndPointConfigurationNameList = GetEndPoints(contractName);
            if(State != null)
                cbf.SetUserState(State);
            cbf.FormClosing += cbf_FormClosing;
        }

        void cbf_FormClosing(object sender, FormClosingEventArgs e)
        {
            EndPointState newState = ((ClientBaseForm)sender).GetUserState();
            if (State == null)
                State = newState;
            else
            {
                State.SelectedEndPointName = newState.SelectedEndPointName;
                State.UserName = newState.UserName != null ? newState.UserName : State.UserName;
                State.Password = newState.Password != null ? newState.Password : State.Password;
                State.AgencyUserName = newState.AgencyUserName != null ? newState.AgencyUserName : State.AgencyUserName;
                State.AgencyPassword = newState.AgencyPassword != null ? newState.AgencyPassword : State.AgencyPassword;
            }
        }

        public virtual List<string> GetEndPoints(string contract)
        {

            var clientSection = (ClientSection)ConfigurationManager.GetSection("system.serviceModel/client");
            var list = new List<string>();

            foreach (ChannelEndpointElement ep in clientSection.Endpoints)
            {
                if (ep.Contract == contract)
                    list.Add(ep.Name);
            }
            return list;
        }

        public virtual void ShowMethod1(System.Windows.Forms.Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
