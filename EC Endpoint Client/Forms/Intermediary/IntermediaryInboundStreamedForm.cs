using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class IntermediaryInboundStreamedForm : ClientBaseForm
    {
        public IntermediaryStreamedAttachmentResult result { get; set; }
        public Stream DataStream { get; set; }
        public IntermediaryStreamedSubmitAttachmentShipment shipment { get; set; }
        public BaseShipment testShipment { get; set; }
        public IntermediaryInboundStreamedEndPointFunctionality iisepFunc { get; set; }
        public IntermediaryInboundStreamedForm()
        {
            InitializeComponent();
            iisepFunc = new IntermediaryInboundStreamedEndPointFunctionality();
            iisepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            shipment = new IntermediaryStreamedSubmitAttachmentShipment();
            testShipment = new Classes.BaseShipment();
            result = new IntermediaryStreamedAttachmentResult();
        }

        private void Test()
        {
            SetBasicShipmentSettings(testShipment);
            iisepFunc.Test(testShipment);
        }

        private void ShowShipment()
        {
            SetViewedItem(shipment, "Shipment for SubmitAttachment");
        }

        private void ShowResult()
        {
            SetViewedItem(result, "Result from SubmitAttachment");
        }

        private void LoadAttachmentData()
        {
            Functionality.IOFunctionality.GetStreamedattachmentFromFile(shipment);
            ShowShipment();
        }

        public void SaveShipment()
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(shipment);
        }

        public void LoadShipment()
        {
            shipment = (IntermediaryStreamedSubmitAttachmentShipment)Functionality.IOFunctionality.GeneralizedLoadFile(shipment);
        }

        public void SaveResult()
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(result);
        }

        private void SubmitAttachmentData()
        {
            SetBasicShipmentSettings(shipment);
            result = iisepFunc.SubmitAttachmentStreamed(shipment);
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
