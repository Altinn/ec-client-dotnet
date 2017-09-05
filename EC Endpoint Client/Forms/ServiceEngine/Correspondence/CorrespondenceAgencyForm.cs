using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgency;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    public partial class CorrespondenceAgencyForm : AgencyBaseForm
    {
        private readonly CorrespondenceAgencyEndPointFunction caepFunc;
        private InsertCorrespondenceShipment ShipmentIC { get; set; }
        private ReceiptExternal ResultIC;
        private NotificationBEList Notifications { get; set; }
        private GetCorrespondenceStatusHistoryShipment GCHShipment { get; set; }
        private GetCorrespondenceStatusDetailsShipment GCDShipment { get; set; }
        private CorrespondenceStatusResultV3 GCDResult;
        private CorrespondenceStatusHistoryResultEx GCHResult;

        public CorrespondenceAgencyForm()
        {
            InitializeComponent();
            MyCollectionEditor.MyFormClosed += MyCollectionEditor_MyFormClosed;
            caepFunc = new CorrespondenceAgencyEndPointFunction();
            caepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            Notifications = new NotificationBEList();
            ShipmentIC = new InsertCorrespondenceShipment {InsertCorrespondence = new InsertCorrespondenceV2()};
            ShipmentIC.InsertCorrespondence.Notifications = Notifications;
            ShipmentIC.InsertCorrespondence.ReplyOptions = new CorrespondenceInsertLinkBEList();
            ShipmentIC.InsertCorrespondence.Content = new ExternalContentV2 { Attachments = new AttachmentsV2() };
            GCHShipment = new GetCorrespondenceStatusHistoryShipment();
            GCDShipment = new GetCorrespondenceStatusDetailsShipment();
            GCHResult = new CorrespondenceStatusHistoryResultEx();
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
            InvokeService(caepFunc.Test, ShipmentTest, "Test");
        }

        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentIC, "Shipment for InsertCorrespondence");
        }

        private void btn_ICSaveShipment_Click(object sender, EventArgs e)
        {
            InvokeSaveShipment(ShipmentIC);
        }

        private void btn_ICLoadShipment_Click(object sender, EventArgs e)
        {
            ShipmentIC = InvokeLoad<InsertCorrespondenceShipment>();
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            InvokeService(caepFunc.InsertCorrespondence, ShipmentIC, ref ResultIC, "InsertCorrespondence");
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultIC, "Result from InsertCorrespondence");
        }

        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            InvokeSave(ResultIC);
        }
        #endregion
        #region GetCorrespondenceDetails Click
        private void btn_GCD_ShS_Click(object sender, EventArgs e)
        {
            SetViewedItem(GCDShipment, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCD_ShR_Click(object sender, EventArgs e)
        {
            SetViewedItem(GCDResult, "Result from GetCorrespondenceDetailsV3");
        }

        private void btn_GCD_Invoke_Click(object sender, EventArgs e)
        {
            InvokeService(caepFunc.GetCorrespondenceDetailsV3, GCDShipment, ref GCDResult, "GetCorrespondenceDetailsV3");
        }

        private void btn_GCD_SaR_Click(object sender, EventArgs e)
        {
            InvokeSave(GCDResult);
        }

        private void btn_GCD_SaS_Click(object sender, EventArgs e)
        {
            InvokeSave(GCDShipment);
        }

        private void btn_GCD_LS_Click(object sender, EventArgs e)
        {
            GCDShipment = InvokeLoad<GetCorrespondenceStatusDetailsShipment>();
        }
        #endregion
        #region GetCorrespondenceHistory Click
        private void btn_GCH_ShS_Click(object sender, EventArgs e)
        {
            SetViewedItem(GCHShipment, "Shipment for GetCorrespondenceStatusHistory");
        }

        private void btn_GCH_SaS_Click(object sender, EventArgs e)
        {
            InvokeSave(GCHShipment);
        }

        private void btn_GCH_LS_Click(object sender, EventArgs e)
        {
            GCHShipment = InvokeLoad<GetCorrespondenceStatusHistoryShipment>();
        }

        private void btn_GCH_Invoke_Click(object sender, EventArgs e)
        {
            InvokeService(caepFunc.GetCorrespondenceStatusHistory, GCHShipment, ref GCHResult, "GetCorrespondenceHistory");
        }

        private void btn_GCH_ShR_Click(object sender, EventArgs e)
        {
            SetViewedItem(GCHResult, "Result from GetCorrespondenceStatusHistory");
        }

        private void btn_GCH_SaR_Click(object sender, EventArgs e)
        {
            InvokeSave(GCHResult);
        }
        #endregion
    }
}
