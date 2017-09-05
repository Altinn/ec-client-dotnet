using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillAgency;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.PrefillAgency;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Prefill
{
    public partial class PrefillAgencyForm : AgencyBaseForm
    {
        private PrefillAgencyEndPointFunction paepFunc;
        public SubmitPrefillFormTaskShipment ShipmentSPF { get; set; }
        public SubmitAndInstantiatePrefillFormTaskShipment ShipmentSAIPF { get; set; }
        private ReceiptExternal ResultSPF { get; set; }
        private ReceiptExternal ResultSAIPF { get; set; }

        public PrefillAgencyForm()
        {
            InitializeComponent();
            paepFunc = new PrefillAgencyEndPointFunction();
            paepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentSPF = new SubmitPrefillFormTaskShipment();
            ShipmentSAIPF = new SubmitAndInstantiatePrefillFormTaskShipment();
            ResultSPF = new ReceiptExternal();
            ResultSAIPF = new ReceiptExternal();

            ShipmentSPF.PrefillFormTask = new PrefillFormTaskDetails();
            ShipmentSPF.PrefillFormTask.PreFillFormTasklist = new PreFillFormTaskBEList();
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
                paepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void SubmitAndInstantiatePrefilledFormTask()
        {
            SetBasicShipmentSettings(ShipmentSAIPF);
            try
            {
                ResultSAIPF = paepFunc.SubmitAndInstantiatePrefilledFormTask(ShipmentSAIPF);
                SetViewedItem(ResultSAIPF, "Result from SubmitAndInstantiatePrefilledFormTask");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during SubmitAndInstantiatePrefilledFormTask");
            }
        }

        private void SubmitPrefilledFormTask()
        {
            SetBasicShipmentSettings(ShipmentSPF);
            try
            {
                ResultSPF = paepFunc.SubmitPrefilledFormTasks(ShipmentSPF);
                SetViewedItem(ResultSPF, "Result from SubmitPrefilledFormTask");
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
            SetViewedItem(ShipmentSPF, "Shipment for SubmitPrefilledFormTasks");
        }

        private void btn_SPFSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSPF);
            Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentSPF);
        }

        private void btn_SPFLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSPF = (SubmitPrefillFormTaskShipment)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentSPF);
            SetViewedItem(ShipmentSPF, "Shipment for SubmitPrefilledFormTasks");
        }

        private void btn_SPFInvoke_Click(object sender, EventArgs e)
        {
            SubmitPrefilledFormTask();
        }

        private void btn_SPFShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultSPF, "Result from SubmitPrefilledFormTask");
        }

        private void btn_SPFSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultSPF);
        }
        #endregion
        #region SubmitAndInstantiatePreifllFormTask
        private void btn_SAIPFShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentSAIPF, "Shipment for SubmitAndInstantiatePrefilledFormTask");
        }

        private void btn_SAIPFSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSAIPF);
            Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentSAIPF);
        }

        private void btn_SAIPFLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSAIPF = (SubmitAndInstantiatePrefillFormTaskShipment)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentSAIPF);
            SetViewedItem(ShipmentSAIPF, "Shipment for SubmitAndInstantiatePrefilledFormTask");
        }

        private void btn_SAIPFInvoke_Click(object sender, EventArgs e)
        {
            SubmitAndInstantiatePrefilledFormTask();
        }

        private void btn_SAIPFShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultSAIPF, "Result from SubmitAndInstantiatePrefilledFormTask");
        }

        private void btn_SAIPFSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultSAIPF);
        }
        #endregion

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}
