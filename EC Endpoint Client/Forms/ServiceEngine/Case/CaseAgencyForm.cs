using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CaseAgency;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Case;
using EC_Endpoint_Client.Service_References.CaseAgencySystem;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Case
{
    public partial class CaseAgencyForm : AgencyBaseForm
    {
        private CaseAgencySystemEndPointFunction FuncCasep { get; set; }
        public CaseListShipment ShipmentCaseList { get; set; }
        public ExternalCaseBEList ResultGetCaseList { get; set; }
        public ExternalCaseBE[] ResultGetCaseArray { get { return ResultGetCaseList.ToArray(); } }
        public InstantiateCollaborationShipment ShipmentInstantiateCollaboration { get; set; }
        public NotifyEventShipment ShipmentNotifyEvent { get; set; }
        public int ResultInstantiateCollaboration { get; set; }
        public StateMachineNotificationResultBEList ResultNotifyEvent { get; set; }
        public StateMachineNotificationResultBE[] ResultNotifyEventArray { get { return ResultNotifyEvent.ToArray(); } }
        public SetNoticeShipment ShipmentSetNotice { get; set; }
        
        public CaseAgencyForm()
        {
            InitializeComponent();
            FuncCasep = new CaseAgencySystemEndPointFunction();
            FuncCasep.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            ShipmentCaseList = new CaseListShipment();
            ShipmentSetNotice = new SetNoticeShipment();
            ShipmentNotifyEvent = new NotifyEventShipment();
            ShipmentInstantiateCollaboration = new InstantiateCollaborationShipment();
            SetupObjForPropGrid();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ExternalCaseBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StateMachineNotificationResultBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StateMachineNotificationResultBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ExternalCaseBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(NoticeBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        #region ServiceCalls
        public void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            FuncCasep.Test(ShipmentTest);
        }

        public void GetCaseList()
        {
            SetBasicShipmentSettings(ShipmentCaseList);
            ResultGetCaseList = FuncCasep.GetCaseList(ShipmentCaseList);
            
        }

        public void InstantiateCollaboration()
        {
            SetBasicShipmentSettings(ShipmentInstantiateCollaboration);
            ResultInstantiateCollaboration = FuncCasep.InstantiateCollaboration(ShipmentInstantiateCollaboration);
            
        }

        public void NotifyEvent()
        {
            SetBasicShipmentSettings(ShipmentNotifyEvent);
            ResultNotifyEvent = FuncCasep.NotifyEvent(ShipmentNotifyEvent);
        }

        public void SetNotice()
        {
            SetBasicShipmentSettings(ShipmentSetNotice);
            FuncCasep.SetNotice(ShipmentSetNotice);
        }
        #endregion
        #region ShowShipments
        private void GetCaseListShowShipment()
        {
            SetViewedItem(ShipmentCaseList, "Shipment for GetCaseList");
        }

        private void InstantiateCollaborationShowShipment()
        {
            SetViewedItem(ShipmentInstantiateCollaboration, "Shipment for InstantiateCollaboration");
        }

        private void NotifyEventShowShipment()
        {
            SetViewedItem(ShipmentNotifyEvent.NotificationInfo, "Shipment for NotifyEvent");
        }

        private void SetNoticeShowShipment()
        {
            SetViewedItem(ShipmentSetNotice, "Shipment for SetNotice");
        }
        #endregion
        #region Showresults
        private void GetCaseListShowResult()
        {
            SetViewedItem(ResultGetCaseArray, "Result from GetCaseList");
        }
        private void InstantiateCollaborationShowResult()
        {
            SetViewedItem(ResultInstantiateCollaboration, "Result from InstantiateCollaboration");
        }
        private void NotifyEventShowResult()
        {
            SetViewedItem(ResultNotifyEventArray, "Result from NotifyEvent");
        }
        private void SetNoticeShowResult()
        {
            SetViewedItem("OK", "SetNotice finished without error.");
        }
        #endregion
        #region GetCaseList
        private void btn_GetCaseListShowShipment_Click(object sender, EventArgs e)
        {
            GetCaseListShowShipment();
        }

        private void btn_GetCaseListShowResult_Click(object sender, EventArgs e)
        {
            GetCaseListShowResult();
        }

        private void btn_GetCaseListInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                GetCaseList();
                GetCaseListShowResult();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetCaseList");
            }

        }

        private void btn_GetCaseListLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentCaseList = (CaseListShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentCaseList);
        }

        private void btn_GetCaseListSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentCaseList);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentCaseList);
        }

        private void btn_GetCaseListSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultGetCaseList);
        }
#endregion
        #region InstantiateCollaboration
        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            InstantiateCollaborationShowShipment();
        }

        private void btn_ICLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentInstantiateCollaboration = (InstantiateCollaborationShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentInstantiateCollaboration);
        }

        private void btn_ICSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentInstantiateCollaboration);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentInstantiateCollaboration);
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                InstantiateCollaboration();
                InstantiateCollaborationShowResult();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during InstantiateCollaboration");
            }
        }
        #endregion
        #region NotifyEvent
        private void btn_NotifyEventShowShipment_Click(object sender, EventArgs e)
        {
            NotifyEventShowShipment();
        }

        private void btn_NotifyEventSaveShipment_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentNotifyEvent.NotificationInfo);
        }

        private void btn_NotifyEventLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentNotifyEvent.NotificationInfo = (StateMachineEventNotificationBE)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentNotifyEvent.NotificationInfo);
        }

        private void btn_NotifyEventInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                NotifyEvent();
                NotifyEventShowResult();
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Error from NotifyEvent");
            }
        }

        private void btn_NotifyEventShowResult_Click(object sender, EventArgs e)
        {
            NotifyEventShowResult();
        }

        private void btn_NotifyEventSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultNotifyEvent);
        }

#endregion
        #region SetNotice
        private void btn_SetNoticeShowShpiment_Click(object sender, EventArgs e)
        {
            SetNoticeShowShipment();
        }

        private void btn_SetNoticeSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSetNotice);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentSetNotice);
        }

        private void btn_SetNoticeLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentSetNotice = (SetNoticeShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentSetNotice);
        }

        private void btn_SetNoticeInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                SetNotice();
                SetViewedItem("OK", "SetNotice invoked without error");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during SetNotice Invoke");
            }
        }

#endregion

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                SetViewedItem("OK", "Test completed OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }

        }

    }
}
