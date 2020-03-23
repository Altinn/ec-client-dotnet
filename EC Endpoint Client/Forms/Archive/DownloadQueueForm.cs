using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;
using EC_Endpoint_Client.DownloadQueue;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class DownloadQueueForm : AgencyBaseForm
    {
        public string SavedFilePath { get; set; }
        private GetDownloadQueueShipment getDqs;
        private DownloadQueueEndPointFunctionality DqEpFunc { get; set; }
        private DownloadQueueBaseShipment baseShipment;
        private DownloadQueueExtendedShipment extShipment;
        private BaseResult baseResult;
        public ArchivedFormTaskDQBE ArchivedFormTaskBe;
        public DownloadQueueItemBEList DqItemBeList;
        public DownloadQueueItemBE[] DqItems => DqItemBeList.ToArray();

        public DownloadQueueForm()
        {
            InitializeComponent();
            InitizializeMyForm();
        }

        public void InitizializeMyForm()
        {
            getDqs = new GetDownloadQueueShipment();
            baseShipment = new DownloadQueueBaseShipment();
            extShipment = new DownloadQueueExtendedShipment();
            baseResult = new BaseResult();
            DqItemBeList = new DownloadQueueItemBEList();
            ArchivedFormTaskBe = new ArchivedFormTaskDQBE();
            SetUpObjectsForPropertyGrid();
            DqEpFunc = new DownloadQueueEndPointFunctionality();
            DqEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            AssignActions();
        }

        public virtual void SetUpObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(DownloadQueueItemBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(DownloadQueueItemBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskDQBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormDQBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormListDQBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentExternalListDQBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentDQBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void AssignActions()
        {
            AssignAction(getDqi, DqEpFunc.GetDownloadQueueItemBeList, getDqs, DqItemBeList, "GetDownloadQueueItems");
            AssignAction(purgeItemCtrl, DqEpFunc.PurgeDqItem, baseShipment, baseResult, "PurgeItem");
            AssignAction(getArchivedFTctrl, DqEpFunc.GetArchivedFormTaskDqbe, extShipment, ArchivedFormTaskBe, "ArchivedFormTask");
        }

        private void Test()
        {
            DqEpFunc.TestDownloadQueue(SelectedEndpointName, SelectedCertificate);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }

        private void btn_GetFormSetPdf_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] pdfBytes = GetFormSetPdf();

                SavedFilePath = Functionality.IoFunctionality.WriteBytesToFile(pdfBytes);

                if (!string.IsNullOrEmpty(SavedFilePath))
                {
                    SetViewedItem(SavedFilePath, "Downloaded file saved successfully");
                }
                else
                {
                    SetViewedItem("Result not saved", "File downloaded, but not saved");
                }
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetFormSetPdf");
            }
        }

        private byte[] GetFormSetPdf()
        {
            return DqEpFunc.GetFormSetPdf(extShipment);
        }
    }
}
