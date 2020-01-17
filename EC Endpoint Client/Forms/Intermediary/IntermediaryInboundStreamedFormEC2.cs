using System;
using System.IO;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class IntermediaryInboundStreamedFormEC2 : BaseForms.ClientBaseForm
    {
        public IntermediaryStreamedAttachmentResult Result { get; set; }
        public Stream DataStream { get; set; }
        public IntermediaryStreamedSubmitAttachmentShipment Shipment { get; set; }
        public BaseShipment TestShipment { get; set; }
        public IntermediaryInboundStreamedEndPointFunctionalityEC2 IisepFunc { get; set; }
        public IntermediaryInboundStreamedFormEC2()
        {
            InitializeComponent();
            IisepFunc = new IntermediaryInboundStreamedEndPointFunctionalityEC2();
            IisepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            Shipment = new IntermediaryStreamedSubmitAttachmentShipment();
            TestShipment = new BaseShipment();
            Result = new IntermediaryStreamedAttachmentResult();
        }

        private void Test()
        {
            SetBasicShipmentSettings(TestShipment);
            IisepFunc.Test(TestShipment);
        }

        private void ShowShipment()
        {
            SetViewedItem(Shipment, "Shipment for SubmitAttachment");
        }

        private void ShowResult()
        {
            SetViewedItem(Result, "Result from SubmitAttachment");
        }

        private void LoadAttachmentData()
        {
            Functionality.IoFunctionality.GetStreamedattachmentFromFile(Shipment);
            ShowShipment();
        }

        public void SaveShipment()
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(Shipment);
        }

        public void LoadShipment()
        {
            Shipment = (IntermediaryStreamedSubmitAttachmentShipment)Functionality.IoFunctionality.GeneralizedLoadFile(Shipment);
        }

        public void SaveResult()
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(Result);
        }

        private void SubmitAttachmentData()
        {
            SetBasicShipmentSettings(Shipment);
            Result = IisepFunc.SubmitAttachmentStreamed(Shipment);
            //shipment.DataStream.Close();
        }

        private void btn_test_Click(object sender, EventArgs e)
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

        private void btn_showShipment_Click(object sender, EventArgs e)
        {
            ShowShipment();
        }

        private void btn_loadAttachment_Click(object sender, EventArgs e)
        {
            LoadAttachmentData();
        }

        private void btn_saveShipment_Click(object sender, EventArgs e)
        {
            SaveShipment();
        }

        private void btn_loadShipment_Click(object sender, EventArgs e)
        {
            LoadShipment();
        }

        private void btn_SubmitAttachmentData_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitAttachmentData();
                ShowResult();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from SubmitAttachment");
            }
        }

        private void btn_ShowResult_Click(object sender, EventArgs e)
        {
            ShowResult();
        }

        private void btn_saveResult_Click(object sender, EventArgs e)
        {
            SaveResult();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ShowShipment();
        }
    }
}
