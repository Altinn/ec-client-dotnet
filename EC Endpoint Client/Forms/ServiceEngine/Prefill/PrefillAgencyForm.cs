using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillAgency;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill;
using EC_Endpoint_Client.PrefillAgency;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Prefill
{
    public partial class PrefillAgencyForm : AgencyBaseForm
    {
        private PrefillAgencyEndPointFunction _paepFunc;
        public SubmitPrefillFormTaskShipment ShipmentSpf { get; set; }
        public SubmitAndInstantiatePrefillFormTaskShipment ShipmentSaipf { get; set; }
        private ReceiptExternal ResultSpf { get; set; }
        private ReceiptExternal ResultSaipf { get; set; }

        public PrefillAgencyForm()
        {
            InitializeComponent();
            _paepFunc = new PrefillAgencyEndPointFunction();
            _paepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentSpf = new SubmitPrefillFormTaskShipment();
            ShipmentSaipf = new SubmitAndInstantiatePrefillFormTaskShipment();
            ResultSpf = new ReceiptExternal();
            ResultSaipf = new ReceiptExternal();

            ShipmentSpf.PrefillFormTask = new PrefillFormTaskDetails();
            ShipmentSpf.PrefillFormTask.PreFillFormTasklist = new PreFillFormTaskBEList();
            SetupObjForPropGrid();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillAttachmentBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillFormBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PreFillIdentityFieldBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(NotificationBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Notification), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PreFillIdentityFieldBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillForm), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PreFillFormTaskBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillFormTaskDetails), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillFormTaskAttachment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillFormTask), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region ServiceInvocations
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                _paepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void SubmitAndInstantiatePrefilledFormTask()
        {
            SetBasicShipmentSettings(ShipmentSaipf);
            try
            {
                ResultSaipf = _paepFunc.SubmitAndInstantiatePrefilledFormTask(ShipmentSaipf);
                SetViewedItem(ResultSaipf, "Result from SubmitAndInstantiatePrefilledFormTask");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during SubmitAndInstantiatePrefilledFormTask");
            }
        }

        private void SubmitPrefilledFormTask()
        {
            SetBasicShipmentSettings(ShipmentSpf);
            try
            {
                ResultSpf = _paepFunc.SubmitPrefilledFormTasks(ShipmentSpf);
                SetViewedItem(ResultSpf, "Result from SubmitPrefilledFormTask");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during SubmitPrefilledFormTask");
            }
        }
        #endregion
        #region SubmitPrefillFormTasksClicks
        private void btn_SPFShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentSpf, "Shipment for SubmitPrefilledFormTasks");
        }

        private void btn_SPFSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSpf);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentSpf);
        }

        private void btn_SPFLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSpf = (SubmitPrefillFormTaskShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentSpf);
            SetViewedItem(ShipmentSpf, "Shipment for SubmitPrefilledFormTasks");
        }

        private void btn_SPFInvoke_Click(object sender, EventArgs e)
        {
            SubmitPrefilledFormTask();
        }

        private void btn_SPFShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultSpf, "Result from SubmitPrefilledFormTask");
        }

        private void btn_SPFSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultSpf);
        }
        #endregion
        #region SubmitAndInstantiatePreifllFormTask
        private void btn_SAIPFShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentSaipf, "Shipment for SubmitAndInstantiatePrefilledFormTask");
        }

        private void btn_SAIPFSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSaipf);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentSaipf);
        }

        private void btn_SAIPFLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSaipf = (SubmitAndInstantiatePrefillFormTaskShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentSaipf);
            SetViewedItem(ShipmentSaipf, "Shipment for SubmitAndInstantiatePrefilledFormTask");
        }

        private void btn_SAIPFInvoke_Click(object sender, EventArgs e)
        {
            SubmitAndInstantiatePrefilledFormTask();
        }

        private void btn_SAIPFShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultSaipf, "Result from SubmitAndInstantiatePrefilledFormTask");
        }

        private void btn_SAIPFSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultSaipf);
        }
        #endregion

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}
