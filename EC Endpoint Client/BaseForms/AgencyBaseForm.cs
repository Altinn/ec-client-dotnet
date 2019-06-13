using EC_Endpoint_Client.Classes;

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
