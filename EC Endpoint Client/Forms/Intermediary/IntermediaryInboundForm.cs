using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.IntermediaryInbound;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class IntermediaryInboundForm : ClientBaseForm
    {
        private Functionality.EndPoints.Intermediary.IntermediaryInboundEndPointFunctionality iiepFunc { get; set; }
        public Classes.Shipments.IntermediaryInboundShipment IIShipment { get; set; }
        public Classes.Shipments.IntermediarySignShipment SignShipment { get; set; }
        public Classes.BaseShipment TestShipment { get; set; }
        public int SubmissionStatus { get; set; }
        public Classes.BaseShipment SubmissionStatusShipment { get; set; }
        public ReceiptExternalBE SubmitReceipt { get; set; }
        public ReceiptExternal SignReceipt { get; set; }
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Text { get; set; }
        public IntermediaryInboundForm()
        {
            InitializeComponent();
            iiepFunc = new Functionality.EndPoints.Intermediary.IntermediaryInboundEndPointFunctionality();
            iiepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            IIShipment = new Classes.Shipments.IntermediaryInboundShipment();
            SignShipment = new Classes.Shipments.IntermediarySignShipment();
            IIShipment.FormTaskShipment = new FormTaskShipmentBE();
            IIShipment.FormTaskShipment.FormTasks = new FormTask();
            IIShipment.FormTaskShipment.Signatures = new Signature1();
            SetupObjectsForPropertyGrid();
            TestShipment = new Classes.BaseShipment();
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.ReceiptExternalBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.ReferenceBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.FormTaskShipmentBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.FormTask), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.Form), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.SignatureList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.Signature), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IntermediaryInbound.Signature1), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            
        }

        private void CheckSignature()
        {
            if (IIShipment.FormTaskShipment.Signatures == null)
                IIShipment.FormTaskShipment.Signatures = new Signature1();
            else
            {
                Signature1 sign = new Signature1();
                if (
                    IIShipment.FormTaskShipment.Signatures.EndUserSystemLoginDateTime == sign.EndUserSystemLoginDateTime
                    && IIShipment.FormTaskShipment.Signatures.EndUserSystemReference == sign.EndUserSystemReference
                    && IIShipment.FormTaskShipment.Signatures.EndUserSystemSignatureDateTime == sign.EndUserSystemSignatureDateTime
                    && IIShipment.FormTaskShipment.Signatures.EndUserSystemSignatureLogId == sign.EndUserSystemSignatureLogId
                    && IIShipment.FormTaskShipment.Signatures.EndUserSystemUserId == sign.EndUserSystemUserId
                    && IIShipment.FormTaskShipment.Signatures.EndUserSystemVersion == sign.EndUserSystemVersion
                    )
                {
                    IIShipment.FormTaskShipment.Signatures = null;
                }
            }
        }

        private void SubmitFormTask()
        {
            SetBasicShipmentSettings(IIShipment);
            CheckSignature();
            SubmitReceipt = iiepFunc.SubmitFormTaskEC(IIShipment);
            CheckSignature();
        }

        private void ViewSubmitShipment()
        {
            if (IIShipment.FormTaskShipment.Signatures == null)
                IIShipment.FormTaskShipment.Signatures = new Signature1();
            SetViewedItem(IIShipment, "Shipment for SubmitFormTask");
        }

        private void ViewSignShipment()
        {
            SetViewedItem(SignShipment, "Shipment for CompleteAndSign");
        }

        private void ViewFTReceipt()
        {
            SetViewedItem(SubmitReceipt, "Receipt for SubmitFormTask");
        }

        private void ViewSignReceipt()
        {
            SetViewedItem(SignReceipt, "Receipt for CompleteAndSign");
        }

        private void ViewSubmissionStatus()
        {
            SetViewedItem(SubmissionStatus, "SubmissionStatus");
        }

        private void ViewStatus()
        {
            SetViewedItem(SubmissionStatus, "Submission status");
        }

        private void btn_ShowFTShip_Click(object sender, EventArgs e)
        {
            ViewSubmitShipment();
        }

        private void btn_ViewSignShipment(object sender, EventArgs e)
        {
            ViewSignShipment();
        }

        private void CompleteAndSignShipment()
        {
            SetBasicShipmentSettings(SignShipment);
            SignReceipt = iiepFunc.CompleteAndSignShipment(SignShipment);
            btn_showSignReceipt.Enabled = true;
            btn_SaveSignReceipt.Enabled = true;
        }

        private void Test()
        {
            SetBasicShipmentSettings(TestShipment);
            iiepFunc.Test(TestShipment);
        }

        private void GetSubmissionStatus()
        {
            SetBasicShipmentSettings(TestShipment);
            SubmissionStatus = iiepFunc.GetAltinnSubmissionStatusEC(TestShipment);
        }

        private void btn_SubmitFormTask_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitFormTask();
                ViewFTReceipt();
                btn_SaveFTReceipt.Enabled = true;
                btn_ShowFTReceipt.Enabled = true;
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from SubmitFormTask");
            }
        }

        private void btn_CompleteAndSign_Click(object sender, EventArgs e)
        {
            try
            {
                CompleteAndSignShipment();
                ViewSignReceipt();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from CompleteAndSign");
            }
        }

        private void btn_SaveFTShipment_Click(object sender, EventArgs e)
        {
            CheckSignature();
            Functionality.IOFunctionality.GeneralizedSaveFile(IIShipment.FormTaskShipment);
            CheckSignature();
        }

        private void btn_LoadFTShipment_Click(object sender, EventArgs e)
        {
            IIShipment.FormTaskShipment = (EC_Endpoint_Client.IntermediaryInbound.FormTaskShipmentBE)Functionality.IOFunctionality.GeneralizedLoadFile(IIShipment.FormTaskShipment);
            CheckSignature();
            ViewSubmitShipment();
        }

        private void btn_SaveFTReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(SubmitReceipt);
        }

        private void btn_ShowFTReceipt_Click(object sender, EventArgs e)
        {
            ViewFTReceipt();
        }

        private void btn_SaveShipment_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(SignShipment);
        }

        private void btn_LoadShipment_Click(object sender, EventArgs e)
        {
            SignShipment = (Classes.Shipments.IntermediarySignShipment)Functionality.IOFunctionality.GeneralizedLoadFile(SignShipment);
        }

        private void btn_SaveSignReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(SignReceipt);
        }

        private void btn_showSignReceipt_Click(object sender, EventArgs e)
        {
            ViewSignReceipt();
        }

        private void btn_GetSubmissionStatus_Click(object sender, EventArgs e)
        {
            try
            {
                GetSubmissionStatus();
                ViewSubmissionStatus();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetSubmissionStatus");
            }
        }

        private void btn_ShowSubmissionStatus_Click(object sender, EventArgs e)
        {
            ViewSubmissionStatus();
        }

        private void btn_Test_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var attachment = Functionality.IOFunctionality.GeneralizedLoadAttachment();

            if (attachment != null)
            {
                if (IIShipment.FormTaskShipment.Attachments == null)
                {
                    IIShipment.FormTaskShipment.Attachments = new Attachment[1];
                    IIShipment.FormTaskShipment.Attachments[0] = new Attachment() { AttachementData = attachment };
                }
                else
                {
                    List<Attachment> attachments = IIShipment.FormTaskShipment.Attachments.ToList();
                    attachments.Add(new Attachment() { AttachementData = attachment });
                    IIShipment.FormTaskShipment.Attachments = attachments.ToArray();
                }
            }
        }
    }
}
