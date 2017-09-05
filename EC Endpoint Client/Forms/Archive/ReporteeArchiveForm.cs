using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.ReporteeArchive;

namespace EC_Endpoint_Client.Forms
{
    public partial class ReporteeArchiveForm : ClientBaseForm
    {
        #region variables
        private int _attachmentId;
        public int AttachmentID 
        {
            get
            {
                return _attachmentId;
            }
            set
            {
                if (_attachmentId != value)
                {
                    _attachmentId = value;
                    tb_AttachmentID.Text = value.ToString();
                }
            }
        }
        public ArchivedFormTaskV2 ArchivedFormTask { get; set; }
        public AttachmentBEV2 Attachment { get; set; }
        public ArchivedLookupExternal ArchivedLookup { get; set; }
        private Functionality.ReporteeArchiveEndPointFunctionality repArchFunc { get; set; }
        public ReporteeArchiveShipment GetFTShipment { get; set; }
        public ReporteeArchiveLookupShipment GetLUShipment { get; set; }
        #endregion
        public ReporteeArchiveForm()
        {
            InitializeComponent();
            SetupObjectsForPropertyGrid();
            ArchivedFormTask = new ArchivedFormTaskV2();
            Attachment = new AttachmentBEV2();
            ArchivedLookup = new ArchivedLookupExternal();
            repArchFunc = new Functionality.ReporteeArchiveEndPointFunctionality();
            repArchFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            GetFTShipment = new ReporteeArchiveShipment();
            GetLUShipment = new ReporteeArchiveLookupShipment();
            SetupDataBindings();
        }

        private void ShowFTShipment()
        {
            SetViewedItem(GetFTShipment, "Shipment for GetFormTask");
        }

        private void ShowLUShipment()
        {
            SetViewedItem(GetLUShipment, "Shipment for LookUpFormTask");
        }

        private void SetupDataBindings()
        {
            tb_AttachmentID.DataBindings.Add("Text", this, "AttachmentID");
        }

        public virtual void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskSigningStepBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskSigningStepBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedLookupExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        public void Test()
        {
            try
            {
                repArchFunc.TestReporteeArchive(SelectedEndpointName, SelectedCertificate);
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }

        public void GetArchivedFormTask()
        {
            try
            {
                ArchivedFormTask = repArchFunc.GetReporteeArchiveArchivedFormTaskV2(SystemUsername, SystemPassword, GetFTShipment.ReporteeElementID, GetFTShipment.LanguageID, SelectedEndpointName, SelectedCertificate);
                SetViewedItem(ArchivedFormTask, "Archived FormTask");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetArchivedFormTask");
            }
        }

        public void GetArchivedLookup()
        {
            try
            {
                ArchivedLookup = repArchFunc.GetReporteeArchiveLookUp(SystemUsername, SystemPassword, GetLUShipment.ReporteeElementID, GetLUShipment.LanguageID, SelectedEndpointName, SelectedCertificate);
                SetViewedItem(ArchivedLookup, "ArchivedLookup");
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Error during ArchivedLookup");
            }
            
        }

        public void GetAttachment()
        {
            try
            {
                Attachment = repArchFunc.GetReporteeArchiveAttachment(SystemUsername, SystemPassword, AttachmentID, SelectedEndpointName, SelectedCertificate);
                SetViewedItem(Attachment, "Attachment");
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Error during GetAttachment");
            }
        }

        #region buttoncatch

        private void btn_GetArchivedFormTask_Click(object sender, EventArgs e)
        {
            GetArchivedFormTask();
        }

        private void btn_ViewArchivedFormTask_Click(object sender, EventArgs e)
        {
            SetViewedItem(ArchivedFormTask, "Archived FormTask");
        }

        private void btn_SaveArchivedFormTask_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ArchivedFormTask);
        }

        private void btn_GetArchivedLookUP_Click(object sender, EventArgs e)
        {
            GetArchivedLookup();
        }

        private void btn_ViewArchivedLookUp_Click(object sender, EventArgs e)
        {
            SetViewedItem(ArchivedLookup, "Archived Lookup");
        }

        private void btn_SaveArchivedLookUp_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ArchivedLookup);
        }

        private void btn_getAttachmentData_Click(object sender, EventArgs e)
        {
            GetAttachment();
        }

        private void btn_ViewAttachmentData_Click(object sender, EventArgs e)
        {
            SetViewedItem(Attachment, "Attachment");
        }

        private void btn_SaveAttachmentData_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(Attachment);
        }

        #endregion

        private void btn_ShowFTShipment_Click(object sender, EventArgs e)
        {
            ShowFTShipment();
        }

        private void btn_ShowLUShipment_Click(object sender, EventArgs e)
        {
            ShowLUShipment();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ShowFTShipment();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ShowLUShipment();
        }
    }
}
