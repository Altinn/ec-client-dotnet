using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Case;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Case;
using EC_Endpoint_Client.Case;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Case
{
    public partial class CaseForm : BaseForms.ClientBaseForm
    {
        private CaseEndPointFunction _caseEpFunc;
        public int ArchiveCase { get; set; }
        public ArchiveCaseShipment ShipmentArchiveCase { get; set; }
        public InstantiateCollaborationShipment ShipmentInstantiateCollaboration { get; set; }
        public CaseListShipment ShipmentCaseList { get; set; }
        private CaseBEList ResultCaseList { get; set; }
        private CaseBE[] ResultCaseListArray 
        {
            get { return ResultCaseList.ToArray(); }
        }

        public int ResultArchiveCase { get; set; }
        public int ResultInstantiateCollaboration { get; set; }
        public CaseForm()
        {
            InitializeComponent();
            _caseEpFunc = new CaseEndPointFunction();
            _caseEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            ShipmentArchiveCase = new ArchiveCaseShipment();
            ShipmentCaseList = new CaseListShipment();
            ShipmentInstantiateCollaboration = new InstantiateCollaborationShipment();
            ResultCaseList = new CaseBEList();
        }

        private void SetupObjForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(CaseBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region serviceInvocations
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                _caseEpFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }

        }

        private void GetCaseListInvoke()
        {
            SetBasicShipmentSettings(ShipmentCaseList);
            try
            {
                ResultCaseList = _caseEpFunc.GetCaseList(ShipmentCaseList);
                SetViewedItem(ResultCaseListArray, "Result from GetCaseList");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetCaseList");
            }
        }

        private void ArchiveCaseInvoke()
        {
            SetBasicShipmentSettings(ShipmentArchiveCase);
            try
            {
                ResultArchiveCase = _caseEpFunc.ArchiveCase(ShipmentArchiveCase);
                SetViewedItem(ResultArchiveCase, "Result from ArchiveCase");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during ArchiveCase");
            }
        }

        private void InstantiateCollaboration()
        {
            SetBasicShipmentSettings(ShipmentInstantiateCollaboration);
            try
            {
                ResultInstantiateCollaboration = _caseEpFunc.InstantiateCollaboration(ShipmentInstantiateCollaboration);
                SetViewedItem(ResultInstantiateCollaboration, "Result from InstantiateCollaboration");

            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during InstantiateCollaboration");
            }

        }
        #endregion
        #region CaseListClicks
        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void btn_GetCaseListInvoke_Click(object sender, EventArgs e)
        {
            GetCaseListInvoke();
        }

        private void btn_GetCaseListSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentCaseList);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentCaseList);
        }

        private void btn_GetCaseListLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentCaseList = (CaseListShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentCaseList);
        }

        private void btn_GetCaseListShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentCaseList, "Shipment for GetCaseList");
        }

        private void btn_GetCaseListShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultCaseListArray, "Result from GetCaseList");
        }

        private void btn_GetCaseListSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultCaseList);
        }
        #endregion
        #region InstantiateCollaborationClicks
        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentInstantiateCollaboration, "Shipment for InstantiateCollaboration");
        }

        private void btn_ICSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentInstantiateCollaboration);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentInstantiateCollaboration);
        }

        private void btn_ICLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentInstantiateCollaboration = (InstantiateCollaborationShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentInstantiateCollaboration);
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            InstantiateCollaboration();
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultInstantiateCollaboration, "Result from InstantiateCollaboration");
        }
        #endregion
        #region archivecaseClicks
        private void btn_ArchiveCaseShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentArchiveCase, "Shipment for ArchiveCase");
        }

        private void btn_ArchiveCaseSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentArchiveCase);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentArchiveCase);
        }

        private void btn_ArchiveCaseLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentArchiveCase = (ArchiveCaseShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentArchiveCase);
        }

        private void btn_ArchiveCaseInvoke_Click(object sender, EventArgs e)
        {
            ArchiveCaseInvoke();
        }

        private void btn_ArchiveCaseShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultArchiveCase, "Result from ArchiveCase");
        }
        #endregion

    }
}
