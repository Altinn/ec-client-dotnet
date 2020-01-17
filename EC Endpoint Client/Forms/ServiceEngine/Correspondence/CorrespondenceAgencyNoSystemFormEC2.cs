using System;
using System.ComponentModel;
using System.Drawing.Design;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.Functionality;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystemEC2;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    //TODO: Update this class to handle the https://at03.ai.basefarm.net/ServiceEngineExternal/CorrespondenceAgencyExternalAEC2.svc?wsdl
    public partial class CorrespondenceAgencyNoSystemFormEC2 : AgencyBaseForm
    {
        private CorrespondenceAgencyNoSystemEndPointFunctionEC2 _caepFunc;
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        public InsertCorrespondenceShipmentAec2 ShipmentIc { get; set; }
        private ReceiptExternal ResultIc { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private NotificationBEList Notifications { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private GetCorrespondenceStatusEC2 Filter { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private CorrespondenceStatusResultV3 CorrespondenceStatus { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        private GetCorrespondenceStatusHistoryAec2Shipment GchShipment { get; set; }
        [Editor(typeof(MyCollectionEditor), typeof(UITypeEditor))]
        public CorrespondenceStatusHistoryAec2Result GchResult;
        public CorrespondenceAgencyNoSystemFormEC2()
        {
            InitializeComponent();
            InitializeComponent();
            _caepFunc = new CorrespondenceAgencyNoSystemEndPointFunctionEC2();
            _caepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            ShipmentIc = new InsertCorrespondenceShipmentAec2 {InsertCorrespondence = new InsertCorrespondenceV2()};
            ShipmentIc.InsertCorrespondence.SdpOptions = new SdpOptions();
            Notifications = new NotificationBEList();
            ShipmentIc.InsertCorrespondence.Notifications = Notifications;
            ShipmentIc.InsertCorrespondence.ReplyOptions = new CorrespondenceInsertLinkBEList();
            ShipmentIc.InsertCorrespondence.Content = new ExternalContentV2();
            ShipmentIc.InsertCorrespondence.Content.Attachments = new AttachmentsV2();
            Filter = new GetCorrespondenceStatusEC2();
            CorrespondenceStatus = new CorrespondenceStatusResultV3();
            Filter.CorrespondenceStatusFilter = new CorrespondenceStatusFilterV3();
            Filter.CorrespondenceStatusFilter.SdpSearchOptions = new SdpStatusSearchOptions();
            GchShipment = new GetCorrespondenceStatusHistoryAec2Shipment();
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
            TypeDescriptor.AddAttributes(typeof(GetCorrespondenceStatusHistoryAecShipment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
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
                _caepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void InsertCorrespondenceInvoke()
        {
            SetBasicShipmentSettings(ShipmentIc);
            try
            {
                ResultIc = _caepFunc.InsertCorrespondence(ShipmentIc);
                SetViewedItem(ResultIc, "Result from InsertCorrespondence");
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
                CorrespondenceStatus = _caepFunc.GetCorrespondenceDetailsV3(Filter);
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
            ShipmentIc.InsertCorrespondence.SdpOptions = ShipmentIc.InsertCorrespondence.SdpOptions == null
                ? ShipmentIc.InsertCorrespondence.SdpOptions = new SdpOptions() { SdpNotifications = new SdpNotifications() { EmailNotification = new SdpEmailNotification() } }
                : null;
            SetViewedItem(ShipmentIc, "Shipment for InsertCorrespondence");
        }

        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentIc, "Shipment for InsertCorrespondence");
        }

        private void btn_ICLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentIc = IoFunctionality.GeneralizedLoadFile(ShipmentIc);
            SetViewedItem(ShipmentIc, "Shipment for InsertCorrespondence");
        }

        private void btn_addBinaryAttach_Click(object sender, EventArgs e)
        {
            string filename;
            byte[] attachmentbytes = IoFunctionality.GeneralizedLoadAttachment(out filename);
            if (attachmentbytes != null)
            {
                BinaryAttachmentV2 attachment = new BinaryAttachmentV2();
                if (ShipmentIc.InsertCorrespondence.Content.Attachments == null)
                {
                    ShipmentIc.InsertCorrespondence.Content.Attachments = new AttachmentsV2();
                }
                if (ShipmentIc.InsertCorrespondence.Content.Attachments.BinaryAttachments == null)
                {
                    ShipmentIc.InsertCorrespondence.Content.Attachments.BinaryAttachments = new BinaryAttachmentExternalBEV2List();
                }

                ShipmentIc.InsertCorrespondence.Content.Attachments.BinaryAttachments.Add(new BinaryAttachmentV2()
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

                SetViewedItem(ShipmentIc, "Shipment for InsertCorrespondence");
            }
        }

        private void btn_attachmentsRemoveAdd_Click(object sender, EventArgs e)
        {
            if (ShipmentIc.InsertCorrespondence.Content.Attachments == null)
            {
                ShipmentIc.InsertCorrespondence.Content.Attachments = new AttachmentsV2();
                ShipmentIc.InsertCorrespondence.Content.Attachments.BinaryAttachments = new BinaryAttachmentExternalBEV2List();
                ShipmentIc.InsertCorrespondence.Content.Attachments.XmlAttachmentList = new XmlAttachmentListV2();
            }
            else
            {
                ShipmentIc.InsertCorrespondence.Content.Attachments = null;
            }

            SetViewedItem(ShipmentIc, "Shipment for InsertCorrespondence");
        }

        private void btn_ICSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentIc);
            IoFunctionality.GeneralizedSaveFile(ShipmentIc);
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            InsertCorrespondenceInvoke();
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultIc, "Result from InsertCorrespondence");
        }

        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            IoFunctionality.GeneralizedSaveFile(ResultIc);
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
            Filter = IoFunctionality.GeneralizedLoadFile(Filter);
            SetViewedItem(Filter, "Shipment for InsertCorrespondence");
        }

        private void GC_SaveShipment_btn_Click(object sender, EventArgs e)
        {
            IoFunctionality.GeneralizedSaveFile(Filter);
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

            IoFunctionality.GeneralizedSaveFile(CorrespondenceStatus);
        }
        #endregion

        private void Test_Invoke_Click(object sender, EventArgs e)
        {
            Test();
        }
        #region GetCorrespondenceHistory click
        private void btn_GCH_ShS_Click(object sender, EventArgs e)
        {
            SetViewedItem(GchShipment, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCH_SaS_Click(object sender, EventArgs e)
        {
            InvokeSave(GchShipment);
        }

        private void btn_GCH_LS_Click(object sender, EventArgs e)
        {
            GchShipment = InvokeLoad<GetCorrespondenceStatusHistoryAec2Shipment>();
        }

        private void btn_GCH_Invoke_Click(object sender, EventArgs e)
        {
            InvokeService(_caepFunc.GetCorrespondenceStatusHistory, GchShipment, ref GchResult, "GetCorrespondenceHistory");
        }

        private void btn_GCH_ShR_Click(object sender, EventArgs e)
        {
            SetViewedItem(GchResult, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCH_SaR_Click(object sender, EventArgs e)
        {
            InvokeSave(GchResult);
        }
        #endregion
    }
}
