using System;
using System.ComponentModel;

using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.DownloadQueue;

namespace EC_Endpoint_Client.Forms
{
    public partial class DownloadQueueForm : AgencyBaseForm
    {
        public string SavedFilePath { get; set; }

        public string ArchiveReference
        {
            set
            {
                this.tb_archRef.Text = value;
            }
            get
            {
                return this.tb_archRef.Text;
            }
        }

        public string ArchiveReferenceFT
        {
            set
            {
                this.tb_archRef2.Text = value;
            }
            get
            {
                return this.tb_archRef2.Text;
            }
        }

        public int LanguageId
        {
            get
            {
                int langId;
                return int.TryParse(this.tb_languageId.Text, out langId) ? langId : 1044;
            }
            set
            {
                this.tb_languageId.Text = value.ToString();
            }
        }

        public string ServiceCode
        {
            get
            {
                return this.tb_serviceCode.Text;
            }
            set
            {
                this.tb_serviceCode.Text = value;
            }
        }

        private Functionality.DownloadQueueEndPointFunctionality dqEPFunc { get; set; }

        public ArchivedFormTaskDQBE ArchivedFormTaskBE;

        public DownloadQueueItemBEList DQItemBEList;

        public DownloadQueueItemBE[] DQItems
        {
            get
            {
                return this.DQItemBEList.ToArray();
            }
        }

        public DownloadQueueForm()
        {
            this.InitizializeMyForm();
            this.InitializeComponent();
        }

        public void InitizializeMyForm()
        {
            this.DQItemBEList = new DownloadQueueItemBEList();
            this.ArchivedFormTaskBE = new ArchivedFormTaskDQBE();
            this.SetUpObjectsForPropertyGrid();
            this.dqEPFunc = new Functionality.DownloadQueueEndPointFunctionality();
            this.dqEPFunc.ReturnMessageXml += this.ReturnMessageXmlHandler;
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

        private string PurgeItem()
        {
            return this.dqEPFunc.PurgeDQItem(this.SystemUsername, this.SystemPassword, this.ArchiveReference, this.SelectedEndpointName, this.SelectedCertificate);
        }

        private DownloadQueueItemBEList GetDQItems()
        {
            return this.dqEPFunc.GetDownloadQueueItemBEList(this.SystemUsername, this.SystemPassword, this.ServiceCode, this.SelectedEndpointName, this.SelectedCertificate);
        }

        private ArchivedFormTaskDQBE GetArchivedFormTask()
        {
            return this.dqEPFunc.GetArchivedFormTaskDQBE(this.SystemUsername, this.SystemPassword, this.ArchiveReferenceFT, this.LanguageId, this.SelectedEndpointName, this.SelectedCertificate);
        }

        private void Test()
        {
            this.dqEPFunc.TestDownloadQueue(this.SelectedEndpointName, this.SelectedCertificate);
        }

        private void btn_GetDQList_Click(object sender, EventArgs e)
        {
            try
            {
                this.DQItemBEList = this.GetDQItems();
                this.SetViewedItem(this.DQItems, "Download Queue Items.");
            }
            catch (Exception ex)
            {
                this.SetViewedItem(ex, "Error during GetDownloadQueueItems:");
            }
        }

        private void btn_ShowDQList_Click(object sender, EventArgs e)
        {
            this.SetViewedItem(this.DQItems, "Download Queue Items.");
        }

        private void btn_SaveDQList_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(this.DQItemBEList);
        }

        private void btn_PurgeItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetViewedItem(this.PurgeItem(), "PurgeItem result");
            }
            catch (Exception ex)
            {
                this.SetViewedItem(ex, "Error during PurgeItem");
            }
        }

        private void btn_getArchFormTask_Click(object sender, EventArgs e)
        {
            try
            {
                this.ArchivedFormTaskBE = this.GetArchivedFormTask();
                this.SetViewedItem(this.ArchivedFormTaskBE, "Archived FormTask");
            }
            catch (Exception ex)
            {
                this.SetViewedItem(ex, "Error during GetArchivedFormTask");
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                this.Test();
            }
            catch (Exception ex)
            {
                this.SetViewedItem(ex, "Error during Test");
            }
        }

        private void btn_showArchivedFormTask_Click(object sender, EventArgs e)
        {
            this.SetViewedItem(this.ArchivedFormTaskBE, "Archived FormTask");
        }

        private void btn_saveArchFormTask_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(this.ArchivedFormTaskBE);
        }

        private void btn_GetFormSetPdf_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] pdfBytes = this.GetFormSetPdf();

                this.SavedFilePath = Functionality.IOFunctionality.WriteBytesToFile(pdfBytes);

                if (!string.IsNullOrEmpty(this.SavedFilePath))
                {
                    this.SetViewedItem(this.SavedFilePath, "Downloaded file saved successfully");
                }
                else
                {
                    this.SetViewedItem("Result not saved", "File downloaded, but not saved");
                }
            }
            catch (Exception ex)
            {
                this.SetViewedItem(ex, "Error during GetFormSetPdf");
            }
        }

        private byte[] GetFormSetPdf()
        {
            return this.dqEPFunc.GetFormSetPdf(
                this.SystemUsername,
                this.SystemPassword,
                this.uscGetFormsetPdf.ArchiveReference,
                this.uscGetFormsetPdf.LanguageId,
                this.SelectedEndpointName,
                this.SelectedCertificate);
        }
    }
}
