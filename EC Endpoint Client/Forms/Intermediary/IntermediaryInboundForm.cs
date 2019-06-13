using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Service_References.IntermediaryInbound;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class IntermediaryInboundForm : BaseForms.ClientBaseForm
    {
        private Functionality.EndPoints.Intermediary.IntermediaryInboundEndPointFunctionality IiepFunc { get; set; }

        public IntermediaryInboundShipment IiShipment { get; set; }

        public IntermediarySignShipment SignShipment { get; set; }

        public BaseShipment TestShipment { get; set; }

        public int SubmissionStatus { get; set; }

        public BaseShipment SubmissionStatusShipment { get; set; }

        public ReceiptExternalBE SubmitReceipt { get; set; }

        public ReceiptExternal SignReceipt { get; set; }

        public UpdateFormDataInput FormTaskUpdate { get; set; }
        public ReceiptExternal FormTaskUpdateReceipt { get; set; }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public new string Text { get; set; }

        public IntermediaryInboundForm()
        {
            InitializeComponent();
            IiepFunc = new Functionality.EndPoints.Intermediary.IntermediaryInboundEndPointFunctionality();
            IiShipment = new IntermediaryInboundShipment();
            IiShipment.FormTaskShipment = new FormTaskShipmentBE();
            IiShipment.FormTaskShipment.FormTasks = new FormTask();
            IiShipment.FormTaskShipment.Signatures = new Signature1();
            FormTaskUpdate = new UpdateFormDataInput();
            FormTaskUpdate.FormTaskUpdate = new FormTaskUpdate();
            FormTaskUpdate.FormTaskUpdate.FormUpdateList = new FormUpdateList();
            IiepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SetupObjectsForPropertyGrid();

            AssignAction(controllerGetSubmissionStatus, IiepFunc.GetAltinnSubmissionStatusEc, SubmissionStatusShipment, SubmissionStatus, "Submission Status");
            AssignAction(controllerCompleteAndSign, IiepFunc.CompleteAndSignShipment, SignShipment, SignReceipt, "Complete/Sign Shipment");
            AssignAction(actionHolder_UpdateFormData, IiepFunc.UpdateFormData, FormTaskUpdate, FormTaskUpdateReceipt, "Update Form Data");
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReceiptExternalBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReferenceExternalBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormTaskShipmentBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormTask), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Form), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SignatureList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Signature), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Signature1), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormTaskUpdate), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormUpdateList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormUpdate), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void CheckSignature()
        {
            if (IiShipment.FormTaskShipment.Signatures == null)
                IiShipment.FormTaskShipment.Signatures = new Signature1();
            else
            {
                Signature1 sign = new Signature1();
                if (
                    IiShipment.FormTaskShipment.Signatures.EndUserSystemLoginDateTime == sign.EndUserSystemLoginDateTime
                    && IiShipment.FormTaskShipment.Signatures.EndUserSystemReference == sign.EndUserSystemReference
                    && IiShipment.FormTaskShipment.Signatures.EndUserSystemSignatureDateTime == sign.EndUserSystemSignatureDateTime
                    && IiShipment.FormTaskShipment.Signatures.EndUserSystemSignatureLogId == sign.EndUserSystemSignatureLogId
                    && IiShipment.FormTaskShipment.Signatures.EndUserSystemUserId == sign.EndUserSystemUserId
                    && IiShipment.FormTaskShipment.Signatures.EndUserSystemVersion == sign.EndUserSystemVersion
                    )
                {
                    IiShipment.FormTaskShipment.Signatures = null;
                }
            }
        }

        private void SubmitFormTask()
        {
            SetBasicShipmentSettings(IiShipment);
            CheckSignature();
            SubmitReceipt = IiepFunc.SubmitFormTaskEc(IiShipment);
            CheckSignature();
        }

        private void ViewSubmitShipment()
        {
            if (IiShipment.FormTaskShipment.Signatures == null)
                IiShipment.FormTaskShipment.Signatures = new Signature1();
            SetViewedItem(IiShipment, "Shipment for SubmitFormTask");
        }

        private void ViewFtReceipt()
        {
            SetViewedItem(SubmitReceipt, "Receipt for SubmitFormTask");
        }

        private void btn_ShowFTShip_Click(object sender, EventArgs e)
        {
            ViewSubmitShipment();
        }

        private void btn_SubmitFormTask_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitFormTask();
                ViewFtReceipt();
                btn_SaveFTReceipt.Enabled = true;
                btn_ShowFTReceipt.Enabled = true;
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from SubmitFormTask");
            }
        }

        private void btn_SaveFTShipment_Click(object sender, EventArgs e)
        {
            CheckSignature();
            Functionality.IoFunctionality.GeneralizedSaveFile(IiShipment.FormTaskShipment);
            CheckSignature();
        }

        private void btn_LoadFTShipment_Click(object sender, EventArgs e)
        {
            IiShipment.FormTaskShipment = Functionality.IoFunctionality.GeneralizedLoadFile(IiShipment.FormTaskShipment);
            CheckSignature();
            ViewSubmitShipment();
        }

        private void btn_SaveFTReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(SubmitReceipt);
        }

        private void btn_ShowFTReceipt_Click(object sender, EventArgs e)
        {
            ViewFtReceipt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var attachment = Functionality.IoFunctionality.GeneralizedLoadAttachment();

            if (attachment != null)
            {
                if (IiShipment.FormTaskShipment.Attachments == null)
                {
                    IiShipment.FormTaskShipment.Attachments = new Attachment[1];
                    IiShipment.FormTaskShipment.Attachments[0] = new Attachment() { AttachementData = attachment };
                }
                else
                {
                    List<Attachment> attachments = IiShipment.FormTaskShipment.Attachments.ToList();
                    attachments.Add(new Attachment() { AttachementData = attachment });
                    IiShipment.FormTaskShipment.Attachments = attachments.ToArray();
                }
            }
        }
    }
}
