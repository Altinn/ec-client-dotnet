using System;
using System.ComponentModel;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence;
using EC_Endpoint_Client.CorrespondenceAgency;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    public partial class CorrespondenceAgencyForm : AgencyBaseForm
    {
        private readonly CorrespondenceAgencyEndPointFunction _caepFunc;
        private InsertCorrespondenceShipment ShipmentIc { get; set; }
        private ReceiptExternal _resultIc;
        private NotificationBEList Notifications { get; set; }
        private GetCorrespondenceStatusHistoryShipment GchShipment { get; set; }
        private GetCorrespondenceStatusDetailsShipment GcdShipment { get; set; }
        private CorrespondenceStatusResultV3 _gcdResult;
        private CorrespondenceStatusHistoryResultEx _gchResult;

        public CorrespondenceAgencyForm()
        {
            InitializeComponent();
            MyCollectionEditor.MyFormClosed += MyCollectionEditor_MyFormClosed;
            _caepFunc = new CorrespondenceAgencyEndPointFunction();
            _caepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            Notifications = new NotificationBEList();
            ShipmentIc = new InsertCorrespondenceShipment {InsertCorrespondence = new InsertCorrespondenceV2()};
            ShipmentIc.InsertCorrespondence.Notifications = Notifications;
            ShipmentIc.InsertCorrespondence.ReplyOptions = new CorrespondenceInsertLinkBEList();
            ShipmentIc.InsertCorrespondence.Content = new ExternalContentV2 { Attachments = new AttachmentsV2() };
            GchShipment = new GetCorrespondenceStatusHistoryShipment();
            GcdShipment = new GetCorrespondenceStatusDetailsShipment();
            _gchResult = new CorrespondenceStatusHistoryResultEx();
            // InvokeAssignTypeDescriptor(this.GetType());
            SetUpObjForPropGrid();
        }

        private static void MyCollectionEditor_MyFormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private static void SetUpObjForPropGrid()
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
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusHistoryRequest), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusFilterV3), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusHistoryResult), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(GetCorrespondenceStatusHistoryShipment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(GetCorrespondenceStatusDetailsShipment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpStatusInformation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StatusV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StatusChangeV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SdpStatusDetails), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        #region InsertCorrespondence
        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            InvokeService(_caepFunc.Test, ShipmentTest, "Test");
        }

        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentIc, "Shipment for InsertCorrespondence");
        }

        private void btn_ICSaveShipment_Click(object sender, EventArgs e)
        {
            InvokeSaveShipment(ShipmentIc);
        }

        private void btn_ICLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentIc = InvokeLoad<InsertCorrespondenceShipment>();
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            InvokeService(_caepFunc.InsertCorrespondence, ShipmentIc, ref _resultIc, "InsertCorrespondence");
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(_resultIc, "Result from InsertCorrespondence");
        }

        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            InvokeSave(_resultIc);
        }
        #endregion
        #region GetCorrespondenceDetails Click
        private void btn_GCD_ShS_Click(object sender, EventArgs e)
        {
            SetViewedItem(GcdShipment, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCD_ShR_Click(object sender, EventArgs e)
        {
            SetViewedItem(_gcdResult, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCD_Invoke_Click(object sender, EventArgs e)
        {
            InvokeService(_caepFunc.GetCorrespondenceDetailsV3, GcdShipment, ref _gcdResult, "GetCorrespondenceDetailsV3");
        }

        private void btn_GCD_SaR_Click(object sender, EventArgs e)
        {
            InvokeSave(_gcdResult);
        }

        private void btn_GCD_SaS_Click(object sender, EventArgs e)
        {
            InvokeSave(GcdShipment);
        }

        private void btn_GCD_LS_Click(object sender, EventArgs e)
        {
            GcdShipment = InvokeLoad<GetCorrespondenceStatusDetailsShipment>();
        }
        #endregion
        #region GetCorrespondenceHistory Click
        private void btn_GCH_ShS_Click(object sender, EventArgs e)
        {
            SetViewedItem(GchShipment, "Shipment for GetCorrespondenceStatusHistory");
        }

        private void btn_GCH_SaS_Click(object sender, EventArgs e)
        {
            InvokeSave(GchShipment);
        }

        private void btn_GCH_LS_Click(object sender, EventArgs e)
        {
            GchShipment = InvokeLoad<GetCorrespondenceStatusHistoryShipment>();
        }

        private void btn_GCH_Invoke_Click(object sender, EventArgs e)
        {
            InvokeService(_caepFunc.GetCorrespondenceStatusHistory, GchShipment, ref _gchResult, "GetCorrespondenceHistory");
        }

        private void btn_GCH_ShR_Click(object sender, EventArgs e)
        {
            SetViewedItem(_gchResult, "Result from GetCorrespondenceStatusHistory");
        }

        private void btn_GCH_SaR_Click(object sender, EventArgs e)
        {
            InvokeSave(_gchResult);
        }
        #endregion
    }
}
