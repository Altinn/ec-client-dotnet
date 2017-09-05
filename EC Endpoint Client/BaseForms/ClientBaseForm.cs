using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Configuration;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.ReporteeArchiveStreamed;
using System.ServiceModel;
using EC_Endpoint_Client.Functionality;

namespace EC_Endpoint_Client.Forms
{
    /// <summary>
    /// This is the baseform for the client. It contains the functionality shared by all endpoint forms.
    /// TabPage has to be implemented per endpoint form or it will be un-editable.
    /// </summary>
    public partial class ClientBaseForm : Form
    {
        public X509Certificate2 SelectedCertificate { get; set; }
        public List<string> _endPointConfigurationNameList;
        private string _thumbPrint = string.Empty;
        public string Thumbprint { get { return _thumbPrint; }
            set
            {
                _thumbPrint = value;
                lbl_SelectedCertificate.Text = "Certificate: " + value;
            }
        }
        public int LanguageID { get; set; }
        public string SystemUsername
        {
            get
            {
                return tb_userName.Text;
            }
            set
            {
                tb_userName.Text = value;
            }
        }
        public string SystemPassword
        {
            get
            {
                return tb_password.Text;
            }
            set
            {
                tb_password.Text = value;
            }
        }
        public BaseSoapHolder RequestSoap { get; set; }
        public BaseSoapHolder ReplySoap { get; set; }
        public virtual List<string> EndPointConfigurationNameList
        {
            get { return _endPointConfigurationNameList; }
            set
            {
                _endPointConfigurationNameList = value;
                cb_endPointConfigurationName.DataSource = _endPointConfigurationNameList;
                cb_endPointConfigurationName.SelectedIndex = 0;
            }
        }
        public BaseShipment ShipmentTest { get; set; }
        public string SelectedEndpointName
        {
            get
            {
                if (cb_endPointConfigurationName.SelectedValue != null)
                    return cb_endPointConfigurationName.SelectedValue.ToString();
                else
                    return "";
            }
            set
            {
                if (value == null || value == "")
                { }
                else if (cb_endPointConfigurationName.Items.Contains(value))
                {
                    cb_endPointConfigurationName.SelectedItem = value;
                }
            }
        }
        public virtual void SetUserState(EndPointState state)
        {
            SystemUsername = state.UserName;
            SystemPassword = state.Password;
            SelectedEndpointName = state.SelectedEndPointName;
        }
        public virtual EndPointState GetUserState()
        {
            return new EndPointState() { UserName = SystemUsername, SelectedEndPointName = SelectedEndpointName, Password = SystemPassword };
        }
        public StringWrapper ReturnValueString { get; set; }
        public IntWrapper ReturnValueInt { get; set; }
        public ClientBaseForm()
        {
            InitializeComponent();
            lbl_viewedObject.Text = "";
            _endPointConfigurationNameList = new List<string>();
            pg_objectViewer.PropertySort = PropertySort.NoSort;
            ReturnValueInt = new IntWrapper();
            ReturnValueString = new StringWrapper();
            ShipmentTest = new BaseShipment();
        }

        public ClientBaseForm(string thumb, X509Certificate2 cert)
        {
            Thumbprint = thumb;
            SelectedCertificate = cert;
            _endPointConfigurationNameList = new List<string>();
        }

        public virtual void SetBasicShipmentSettings(BaseShipment shipment)
        {
            shipment.Certificate = SelectedCertificate;
            shipment.EndpointName = SelectedEndpointName;
            shipment.Username = SystemUsername;
            shipment.Password = SystemPassword;
        }

        public virtual void ClearBasicShipmentsettings(BaseShipment shipment)
        {
            shipment.Certificate = null;
            shipment.EndpointName = null;
            shipment.Password = null;
            shipment.Username = null;
        }

        internal virtual void SetViewedItemGeneric<T>(T viewObject, string description)
        {
            if (viewObject != null)
            {
                if (viewObject is int || viewObject.GetType() == typeof(int) || viewObject.GetType() == typeof(Int16))
                {
                    ReturnValueInt.ReturnValue = (int)Convert.ChangeType(viewObject, typeof(int));
                    pg_objectViewer.SelectedObject = ReturnValueInt;
                }
                else if (viewObject is string)
                {
                    ReturnValueString.ReturnValue = viewObject.ToString();
                    pg_objectViewer.SelectedObject = ReturnValueString;
                }
                else if (viewObject is Guid)
                {
                    ReturnValueString.ReturnValue = ((Guid)Convert.ChangeType(viewObject, typeof(Guid))).ToString();
                    pg_objectViewer.SelectedObject = ReturnValueString;
                }
                else
                {
                    if (viewObject.GetType().GetProperty("Detail") != null && viewObject.GetType().GetProperty("Detail").GetValue(viewObject) != null)
                    {
                        pg_objectViewer.SelectedObject = viewObject.GetType().GetProperty("Detail").GetValue(viewObject);
                    }
                    else
                    {
                        pg_objectViewer.SelectedObject = viewObject;
                    }
                }

                lbl_viewedObject.Text = "Viewed object: " + description;
            }
        }

        public virtual void SetViewedItem(object viewObject, string description)
        {
            if (viewObject == null) return;
            if (viewObject is int)
            {
                ReturnValueInt.ReturnValue = (int)viewObject;
                pg_objectViewer.SelectedObject = ReturnValueInt;
            }
            else if (viewObject is string)
            {
                ReturnValueString.ReturnValue = (string)viewObject;
                pg_objectViewer.SelectedObject = ReturnValueString;
            }
            else if (viewObject is Guid)
            {
                ReturnValueString.ReturnValue = ((Guid)viewObject).ToString();
                pg_objectViewer.SelectedObject = ReturnValueString;
            }
            else
            {
                if (viewObject.GetType().GetProperty("Detail") != null && viewObject.GetType().GetProperty("Detail").GetValue(viewObject) != null)
                {
                    pg_objectViewer.SelectedObject = viewObject.GetType().GetProperty("Detail").GetValue(viewObject);
                }
                else
                {
                    pg_objectViewer.SelectedObject = viewObject;
                }
            }

            lbl_viewedObject.Text = "Viewed object: " + description;
        }

        public virtual void InvokeService<T>(Action<T> action, T shipment, string functionName) where T : BaseShipment
        {
            SetBasicShipmentSettings(shipment);
            try
            {
                action(shipment);
                SetViewedItemGeneric("Test OK.", string.Format("Result from {0}", functionName));
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, string.Format("Error during {0}", functionName));
            }
        }

        public virtual void InvokeService<T, T2>(Func<T, T2> function, T shipment, ref T2 resultRef ,string functionName) where T : BaseShipment
        {
            SetBasicShipmentSettings(shipment);
            try
            {
                resultRef = function(shipment);
                SetViewedItemGeneric(resultRef, string.Format("Result from {0}", functionName));
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, string.Format("Error during {0}", functionName));
            }
        }

        public virtual void InvokeSaveShipment<T>(T saveObj) where T : BaseShipment
        {
            ClearBasicShipmentsettings(saveObj);
            InvokeSave(saveObj);
        }

        public virtual void InvokeSave<T>(T saveObj)
        {
            try
            {
                IOFunctionality.GeneralizedSaveFile(saveObj);
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Failed during save file.");
            }
        }

        public virtual T InvokeLoad<T>()
        {
            try
            {
                return IOFunctionality.GeneralizedLoadFile<T>();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Failed during load file.");
                throw;
            }
        }

        SortedSet<string> propertyTypeNames = new SortedSet<string>();

        internal virtual void InvokeAssignTypeDescriptor(Type type)
        {
            foreach (var x in type.GetFields())
            {
                if (x.Name.Contains("ShipmentIC"))
                {
                    int f = 0;
                }

                if (!propertyTypeNames.Contains(x.FieldType.Name))
                {
                    propertyTypeNames.Add(x.FieldType.Name);
                    if (x.FieldType.Name.Contains("SdpStatusDetails"))
                    {
                        int a = 0;
                    }
                }

            /*
                InvokeAssignTypeDescriptor(x.FieldType);
                InvokeTypeDescriptor(x.FieldType); */
            }
        }

        internal void InvokeTypeDescriptor(Type type)
        {
            TypeDescriptor.AddAttributes(type, new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        public virtual void GenerateMenu()
        {
        }

        public void ReturnMessageXmlHandler(object sender, EventArgs e)
        {
            BaseSoapHolder tempSoap = (BaseSoapHolder)sender;
            if (tempSoap.SoapContext == SoapContext.Request)
            {
                RequestSoap = tempSoap;
                ReplySoap = null;

            }
            else
            {
                ReplySoap = tempSoap;             
            }

            soapMessagesToolStripMenuItem.Enabled = true;
            requestToolStripMenuItem.Enabled = RequestSoap != null;
            replyToolStripMenuItem.Enabled = ReplySoap != null;
            showToolStripMenuItem.Enabled = RequestSoap != null;
            showToolStripMenuItem1.Enabled = ReplySoap != null;
            saveToolStripMenuItem.Enabled = RequestSoap != null;
            saveToolStripMenuItem1.Enabled = ReplySoap != null;
        }

        private void GetDefaultCertificate()
        {
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                this.SelectedCertificate = ((SelectorBaseForm)this.Parent).SelectedCertificate;
                this.Thumbprint = ((SelectorBaseForm)this.Parent).Thumbprint;
            }
        }

        public virtual X509Certificate2 GetCertificateByThumbPrint(string thumbprint)
        {
            X509Store store = new X509Store("My", StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in store.Certificates)
            {
                if (cert.Thumbprint == thumbprint.ToUpper())
                    return cert;
            }
            return null;
        }

        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCertificateForm();
        }

        private void ShowCertificateForm()
        {
            CertificateSelectorForm csF = SelectedCertificate == null ? new CertificateSelectorForm() : new CertificateSelectorForm(SelectedCertificate);
            
            csF.FormClosing += csF_FormClosing;
            csF.ShowDialog();
        }

        void csF_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelectedCertificate = ((CertificateSelectorForm)sender).SelectedCertificate;
            if(SelectedCertificate != null)
                Thumbprint = SelectedCertificate.Thumbprint;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoapViewer sViewer = new SoapViewer(RequestSoap.XmlDocument);
            sViewer.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(RequestSoap.XmlDocument);

        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ReplySoap == null)
            {
                MessageBox.Show("No soap message was returned.");
                showToolStripMenuItem1.Enabled = false;
                return;
            }

            SoapViewer sViewer = new SoapViewer(ReplySoap.XmlDocument);
            sViewer.Show();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ReplySoap.XmlDocument);
        }
    }
}
