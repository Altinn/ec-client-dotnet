using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Forms;

namespace EC_Endpoint_Client.BaseForms
{
    public partial class AgencyBaseForm : ClientBaseForm
    {
        public AgencyBaseForm()
        {
            InitializeComponent();
        }

        public override void SetUserState(EndPointState state)
        {
            SystemUsername = state.AgencyUserName;
            SystemPassword = state.AgencyPassword;
            SelectedEndpointName = state.SelectedEndPointName;
        }

        public override EndPointState GetUserState()
        {
            return new EndPointState() { AgencyUserName = SystemUsername, SelectedEndPointName = SelectedEndpointName, AgencyPassword = SystemPassword };
        }
    }
}
