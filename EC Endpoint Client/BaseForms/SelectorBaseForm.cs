using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Configuration;

namespace EC_Endpoint_Client.BaseForms
{
    public partial class SelectorBaseForm : Form
    {
        public string Thumbprint { get; set; }
        public X509Certificate2 SelectedCertificate { get; set; }
        public bool UseEC2Interface { get; set; }
        public string SelectedEndPointName { get; set; }
        public EndPointState State { get; set; }

        public SelectorBaseForm()
        {
            InitializeComponent();
        }

        public SelectorBaseForm(string thumb, X509Certificate2 cert, bool useEC2Interface)
        {
            Thumbprint = thumb;
            SelectedCertificate = cert;
            UseEC2Interface = useEC2Interface;
            InitializeComponent();
        }

        protected virtual void SetClientValues(BaseForms.ClientBaseForm cbf, string contractName)
        {
            cbf.SelectedCertificate = SelectedCertificate;
            cbf.Thumbprint = Thumbprint;
            cbf.EndPointConfigurationNameList = GetEndPoints();
            if(State != null)
                cbf.SetUserState(State);
            cbf.FormClosing += cbf_FormClosing;
        }

        void cbf_FormClosing(object sender, FormClosingEventArgs e)
        {
            EndPointState newState = ((BaseForms.ClientBaseForm)sender).GetUserState();
            if (State == null)
                State = newState;
            else
            {
                State.SelectedEndPointName = newState.SelectedEndPointName;
                State.UserName = newState.UserName ?? State.UserName;
                State.Password = newState.Password ?? State.Password;
                State.AgencyUserName = newState.AgencyUserName ?? State.AgencyUserName;
                State.AgencyPassword = newState.AgencyPassword ?? State.AgencyPassword;
            }
        }

        public virtual List<string> GetEndPoints()
        {
            return (from EnvironmentUrl eu in EcClientConfiguration.GetConfig().EnvironmentUrlCollection where !eu.IgnoreInWcf.HasValue || !eu.IgnoreInWcf.Value select eu.Name).ToList();
        }

        public virtual void ShowMethod1(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
