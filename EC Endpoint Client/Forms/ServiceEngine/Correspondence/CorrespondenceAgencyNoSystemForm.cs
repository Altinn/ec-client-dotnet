using System;
using System.ComponentModel;
using System.Drawing.Design;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystem;
using EC_Endpoint_Client.Functionality;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    public partial class CorrespondenceAgencyNoSystemForm : AgencyBaseForm
    {
        private CorrespondenceAgencyNoSystemEndPointFunction caepFunc;
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        public InsertCorrespondenceShipmentAEC ShipmentIC { get; set; }
        private ReceiptExternal ResultIC { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private NotificationBEList Notifications { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private GetCorrespondenceStatus Filter { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private CorrespondenceStatusResultV3 CorrespondenceStatus { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private GetCorrespondenceStatusHistoryAECShipment GCHShipment { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        public CorrespondenceStatusHistoryAECResult GCHResult;
        public CorrespondenceAgencyNoSystemForm()
        {
            InitializeComponent();
            InitializeComponent();
            caepFunc = new CorrespondenceAgencyNoSystemEndPointFunction();
            caepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            ShipmentIC = new InsertCorrespondenceShipmentAEC {InsertCorrespondence = new InsertCorrespondenceV2()};
            ShipmentIC.InsertCorrespondence.SdpOptions = new SdpOptions();
            Notifications = new NotificationBEList();
            ShipmentIC.InsertCorrespondence.Notifications = Notifications;
            ShipmentIC.InsertCorrespondence.ReplyOptions = new CorrespondenceInsertLinkBEList();
            ShipmentIC.InsertCorrespondence.Content = new ExternalContentV2();
            ShipmentIC.InsertCorrespondence.Content.Attachments = new AttachmentsV2();
            Filter = new GetCorrespondenceStatus();
            CorrespondenceStatus = new CorrespondenceStatusResultV3();
            Filter.CorrespondenceStatusFilter = new CorrespondenceStatusFilterV3();
            Filter.CorrespondenceStatusFilter.SdpSearchOptions = new SdpStatusSearchOptions();
            GCHShipment = new GetCorrespondenceStatusHistoryAECShipment();
            SetUpObjForPropGrid();
            tb_userName.Enabled = false;
            tb_password.Enabled = false;
        }

        #region setup
        private void SetUpObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ExternalContentV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(AttachmentsV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InsertCorrespondenceV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(NotificationBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Notification), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiverEndPoint), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiverEndPointBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Notification), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(NotificationBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceInsertLinkBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReplyOption), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InsertCorrespondenceLinkArchiveRef), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InsertCorrespondenceLinkServiceCode), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(InsertCorrespondenceLinkServiceURL), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusFilterV3), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StatusV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StatusV2[]), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusResultV3), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpOptions), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpNotifications), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpEmailNotification), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpSmsNotification), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpStatusSearchOptions), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(GetCorrespondenceStatusHistoryAECShipment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusHistoryRequestExternalBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusHistoryResultExternalBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StatusV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpStatusDetails), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #endregion

        #region Invocation
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                caepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void InsertCorrespondenceInvoke()
        {
            SetBasicShipmentSettings(ShipmentIC);
            try
            {
                ResultIC = caepFunc.InsertCorrespondence(ShipmentIC);
                SetViewedItem(ResultIC, "Result from InsertCorrespondence");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during InsertCorrespondence");
            }
        }

        private void GetCorrespondenceDetailsInvoke()
        {
            SetBasicShipmentSettings(Filter);
            try
            {
                CorrespondenceStatus = caepFunc.GetCorrespondenceDetailsV3(Filter);
                SetViewedItem(CorrespondenceStatus, "GetCorrespondenceDetails - Result");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetCorrespondenceDetails");
            }
        }
        #endregion
        #region InsertCorrespondence
        private void btn_sdpOptions_Click(object sender, EventArgs e)
        {
            ShipmentIC.InsertCorrespondence.SdpOptions = ShipmentIC.InsertCorrespondence.SdpOptions == null
                ? ShipmentIC.InsertCorrespondence.SdpOptions = new SdpOptions() { SdpNotifications = new SdpNotifications() { EmailNotification = new SdpEmailNotification() } }
                : null;
            SetViewedItem(ShipmentIC, "Shipment for InsertCorrespondence");
        }

        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentIC, "Shipment for InsertCorrespondence");
        }

        private void btn_ICLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentIC = (InsertCorrespondenceShipmentAEC)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentIC);
            SetViewedItem(ShipmentIC, "Shipment for InsertCorrespondence");
        }

        private void btn_addBinaryAttach_Click(object sender, EventArgs e)
        {
            string filename;
            byte[] attachmentbytes = IOFunctionality.GeneralizedLoadAttachment(out filename);
            if (attachmentbytes != null)
            {
                BinaryAttachmentV2 attachment = new BinaryAttachmentV2();
                if (ShipmentIC.InsertCorrespondence.Content.Attachments == null)
                {
                    ShipmentIC.InsertCorrespondence.Content.Attachments = new AttachmentsV2();
                }
                if (ShipmentIC.InsertCorrespondence.Content.Attachments.BinaryAttachments == null)
                {
                    ShipmentIC.InsertCorrespondence.Content.Attachments.BinaryAttachments = new BinaryAttachmentExternalBEV2List();
                }

                ShipmentIC.InsertCorrespondence.Content.Attachments.BinaryAttachments.Add(new BinaryAttachmentV2()
                {
                    Data=attachmentbytes,
                    DestinationType=UserTypeRestriction.Default,
                    Encrypted = false,
                    ExtensionData = null,
                    FileName=filename,
                    FunctionType = AttachmentFunctionType.Unspecified,
                    SendersReference = "RandomReference " + Guid.NewGuid(),
                    Name = System.IO.Path.GetFileNameWithoutExtension(filename)
                });

                SetViewedItem(ShipmentIC, "Shipment for InsertCorrespondence");
            }
        }

        private void btn_attachmentsRemoveAdd_Click(object sender, EventArgs e)
        {
            if (ShipmentIC.InsertCorrespondence.Content.Attachments == null)
            {
                ShipmentIC.InsertCorrespondence.Content.Attachments = new AttachmentsV2();
                ShipmentIC.InsertCorrespondence.Content.Attachments.BinaryAttachments = new BinaryAttachmentExternalBEV2List();
                ShipmentIC.InsertCorrespondence.Content.Attachments.XmlAttachmentList = new XmlAttachmentListV2();
            }
            else
            {
                ShipmentIC.InsertCorrespondence.Content.Attachments = null;
            }

            SetViewedItem(ShipmentIC, "Shipment for InsertCorrespondence");
        }

        private void btn_ICSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentIC);
            Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentIC);
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            InsertCorrespondenceInvoke();
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultIC, "Result from InsertCorrespondence");
        }

        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultIC);
        }
        #endregion
        #region GetCorrespondenceDetails

        private void btn_sdpoptionsGCD_Click(object sender, EventArgs e)
        {
            Filter.CorrespondenceStatusFilter.SdpSearchOptions = Filter.CorrespondenceStatusFilter.SdpSearchOptions ==
                                                                 null
                ? new SdpStatusSearchOptions()
                : null;
            SetViewedItem(Filter, "Shipment for GetCorrespondenceDetails.");
        }
        private void GC_ShowShipment_btn_Click(object sender, EventArgs e)
        {
            SetViewedItem(Filter, "Filter for GetCorrespondenceStatus");
        }

        private void GC_LoadShipment_btn_Click(object sender, EventArgs e)
        {
            Filter = Functionality.IOFunctionality.GeneralizedLoadFile(Filter);
            SetViewedItem(Filter, "Shipment for InsertCorrespondence");
        }

        private void GC_SaveShipment_btn_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(Filter);
        }

        private void GC_InvokeShipment_btn_Click(object sender, EventArgs e)
        {
            GetCorrespondenceDetailsInvoke();
        }

        private void GC_ShowResult_btn_Click(object sender, EventArgs e)
        {
            SetViewedItem(CorrespondenceStatus, "Result from GetCorrespondenceStatus");
        }

        private void GC_SaveResult_btn_Click(object sender, EventArgs e)
        {

            Functionality.IOFunctionality.GeneralizedSaveFile(CorrespondenceStatus);
        }
        #endregion

        private void Test_Invoke_Click(object sender, EventArgs e)
        {
            Test();
        }
        #region GetCorrespondenceHistory click
        private void btn_GCH_ShS_Click(object sender, EventArgs e)
        {
            SetViewedItem(GCHShipment, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCH_SaS_Click(object sender, EventArgs e)
        {
            InvokeSave(GCHShipment);
        }

        private void btn_GCH_LS_Click(object sender, EventArgs e)
        {
            GCHShipment = InvokeLoad<GetCorrespondenceStatusHistoryAECShipment>();
        }

        private void btn_GCH_Invoke_Click(object sender, EventArgs e)
        {
            InvokeService(caepFunc.GetCorrespondenceStatusHistory, GCHShipment, ref GCHResult, "GetCorrespondenceHistory");
        }

        private void btn_GCH_ShR_Click(object sender, EventArgs e)
        {
            SetViewedItem(GCHResult, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCH_SaR_Click(object sender, EventArgs e)
        {
            InvokeSave(GCHResult);
        }
        #endregion
    }
}
