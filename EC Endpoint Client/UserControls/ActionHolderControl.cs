using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;

namespace EC_Endpoint_Client.UserControls
{
    public partial class ActionHolderControl : UserControl
    {
        private Action _showShipment;
        private Action _saveShipment;
        private Action _loadShipment;
        private Action _invokeService;
        private Action _showResult;
        private Action _saveResult;

        private SortedSet<ActionSet> actionSet;

        public ActionHolderControl()
        {
            InitializeComponent();
        }

        public ActionHolderControl(Action showShipmentAction, Action saveShipmentAction, Action loadShipmentAction, 
            Action invokeServiceAction, Action showResultAction, Action saveResultAction) : base()
        {
            #region buttonhandling
            if (showShipmentAction != null)
                _showShipment = showShipmentAction;
            else
                btn_ShowShipment.Enabled = false;

            if (saveShipmentAction != null)
                _saveShipment = saveShipmentAction;
            else
                btn_SaveShipment.Enabled = false;

            if (loadShipmentAction != null)
                _loadShipment = loadShipmentAction;
            else
                btn_LoadShipment.Enabled = false;

            if (invokeServiceAction != null)
                _invokeService = invokeServiceAction;
            else
                btn_invoke.Enabled = false;

            if (showResultAction != null)
                _showResult = showResultAction;
            else
                btn_showResult.Enabled = false;

            if (saveResultAction != null)
                _saveResult = saveResultAction;
            else
                btn_saveResult.Enabled = false;
            #endregion
        }

        public void AssignCustomAction(CustomActionContainer customAction)
        {
            Button btn = new Button();
            EventHandler eh = (o, e) => { customAction.CustomAction(); };
            btn.Click += eh;

            if (customAction.Type == CustomActionType.Request)
                request.Controls.Add(btn);
            else
                invoke.Controls.Add(btn);
        }

        public void AssignActionSet(ActionSet set)
        {
            if (set == null)
                return;
            if (actionSet == null)
            {
                actionSet = new SortedSet<ActionSet>();
            }
            if (!actionSet.Contains(set))
            {
                actionSet.Add(set);
            }

            AssignActions(set.InvokeService, set.ShowShipment, set.SaveShipment, set.LoadShipment, set.ShowResult, set.SaveResult);
        }

        public void AssignActions(Action invokeServiceAction, Action showShipmentAction = null, Action saveShipmentAction = null, 
            Action loadShipmentAction = null, Action showResultAction = null, Action saveResultAction = null)
        {
            #region buttonhandling
            if (showShipmentAction != null)
                _showShipment = showShipmentAction;
            else
                btn_ShowShipment.Enabled = false;

            if (saveShipmentAction != null)
                _saveShipment = saveShipmentAction;
            else
                btn_SaveShipment.Enabled = false;

            if (loadShipmentAction != null)
                _loadShipment = loadShipmentAction;
            else
                btn_LoadShipment.Enabled = false;

            if (invokeServiceAction != null)
                _invokeService = invokeServiceAction;
            else
                btn_invoke.Enabled = false;

            if (showResultAction != null)
                _showResult = showResultAction;
            else
                btn_showResult.Enabled = false;

            if (saveResultAction != null)
                _saveResult = saveResultAction;
            else
                btn_saveResult.Enabled = false;
            #endregion
        }

        public void SwitchActionSet(string asId)
        {
            AssignActionSet(actionSet.FirstOrDefault(aset => aset.ActionSetName == asId));
        }

        private void btn_ShowShipment_Click(object sender, EventArgs e)
        {
            _showShipment();
        }

        private void btn_SaveShipment_Click(object sender, EventArgs e)
        {
            _saveShipment();
        }

        private void btn_LoadShipment_Click(object sender, EventArgs e)
        {
            _loadShipment();
        }

        private void btn_invoke_Click(object sender, EventArgs e)
        {
            _invokeService();
        }

        private void btn_showResult_Click(object sender, EventArgs e)
        {
            _showResult();
        }

        private void btn_saveResult_Click(object sender, EventArgs e)
        {
            _saveResult();
        }
    }
}
