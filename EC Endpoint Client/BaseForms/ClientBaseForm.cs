using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Forms;
using EC_Endpoint_Client.UserControls;
using static EC_Endpoint_Client.Functionality.IoFunctionality;


namespace EC_Endpoint_Client.BaseForms
{
    /// <summary>
    /// This is the baseform for the client. It contains the functionality shared by all endpoint forms.
    /// TabPage has to be implemented per endpoint form or it will be un-editable.
    /// </summary>
    // ReSharper disable once RedundantExtendsListEntry
    public partial class ClientBaseForm : Form
    {
        #region fields
        public X509Certificate2 SelectedCertificate { get; set; }
        public virtual BaseShipment BaseShipment { get; set; }
        private List<string> _endPointConfigurationNameList;
        private string _thumbPrint = string.Empty;
        public string Thumbprint { get { return _thumbPrint; }
            set
            {
                _thumbPrint = value;
                lbl_SelectedCertificate.Text = @"Certificate: " + value;
            }
        }
        public int LanguageId { get; set; }
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
            { return cb_endPointConfigurationName.SelectedValue?.ToString() ?? ""; }
            set
            {
                if (string.IsNullOrEmpty(value))
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
        #endregion
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
        #region functionality
        public virtual void AssignAction<TShipment, TResult>(ActionHolderControl actionHolder, 
            Func<TShipment, TResult> function, TShipment shipment, TResult result, string shipmentDescription) where TShipment : BaseShipment, new() where TResult : new()
        {
            if(result == null)
            {
                result = new TResult();
            }

            if (shipment == null)
            {
                shipment = new TShipment();
            }

            ActionSet set = new ActionSet
            {
                InvokeService   = () => { InvokeService(function, shipment, ref result, shipmentDescription); },
                SaveShipment    = () => { InvokeSaveShipment(shipment); },
                LoadShipment    = () => { InvokeLoadShipment(shipment, shipmentDescription); },
                ShowResult      = () => { SetViewedItem(result, shipmentDescription + " Result"); },
                SaveResult      = () => { InvokeSave(result); },
                ShowShipment    = () => { SetViewedItem(shipment, shipmentDescription + " Shipment"); },
                ActionSetName   = shipmentDescription
            };
            actionHolder.AssignActionSet(set);
        }

        public virtual void AssignAction<TShipment>(ActionHolderControl actionHolder,
            Action<TShipment> function, TShipment shipment, string shipmentDescription) where TShipment : BaseShipment, new()
        {
            if(shipment == null)
            {
                shipment = new TShipment();
            }

            ActionSet set = new ActionSet
            {
                InvokeService = () => { InvokeService(function, shipment, shipmentDescription); },
                SaveShipment = ()  => { InvokeSaveShipment(shipment); },
                LoadShipment = ()  => { InvokeLoadShipment(shipment, shipmentDescription); },
                ShowShipment = ()  => { SetViewedItem(shipment, shipmentDescription + " Shipment"); },
                ActionSetName = shipmentDescription
            };
            actionHolder.AssignActionSet(set);
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
                if (viewObject is int || viewObject is short || viewObject is long)
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
                    if (viewObject.GetType().GetProperty("Detail") != null && viewObject.GetType().GetProperty("Detail")?.GetValue(viewObject) != null)
                    {
                        pg_objectViewer.SelectedObject = viewObject.GetType().GetProperty("Detail")?.GetValue(viewObject);
                    }
                    else
                    {
                        pg_objectViewer.SelectedObject = viewObject;
                    }
                }

                lbl_viewedObject.Text = @"Viewed object: " + description;
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
                if (viewObject.GetType().GetProperty("Detail") != null 
                    && viewObject.GetType().GetProperty("Detail")?.GetValue(viewObject) != null)
                {
                    pg_objectViewer.SelectedObject = viewObject.GetType().GetProperty("Detail")?.GetValue(viewObject);
                }
                else
                {
                    pg_objectViewer.SelectedObject = viewObject;
                }
            }

            lbl_viewedObject.Text = @"Viewed object: " + description;
        }
        public virtual void InvokeService<T>(Action<T> action, T shipment, string functionName) where T : BaseShipment
        {
            SetBasicShipmentSettings(shipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                action(shipment);
                SetViewedItemGeneric("Test OK.", $"Result from {functionName}");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, $"Error during {functionName}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        public virtual void InvokeService<T, T2>(Func<T, T2> function, T shipment, ref T2 resultRef ,string functionName) where T : BaseShipment
        {
            SetBasicShipmentSettings(shipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                resultRef = function(shipment);
                SetViewedItemGeneric(resultRef, $"Result from {functionName}");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, $"Error during {functionName}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        public virtual void InvokeSaveShipment<T>(T saveObj) where T : BaseShipment
        {
            ClearBasicShipmentsettings(saveObj);
            InvokeSave(saveObj);
        }
        public virtual void InvokeLoadShipment<T>(T loadObj, string viewedLabel) where T : BaseShipment
        {
            loadObj = GeneralizedLoadFile(loadObj);
            SetViewedItem(loadObj, viewedLabel);
        }
        public virtual void InvokeSave<T>(T saveObj)
        {
            try
            {
                GeneralizedSaveFile(saveObj);
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
                return GeneralizedLoadFile<T>();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Failed during load file.");
                throw;
            }
        }
        public virtual void GenerateMenu()
        {
        }
        public virtual void ReturnMessageXmlHandler(object sender, EventArgs e)
        {
            var tempSoap = (BaseSoapHolder)sender;
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
        public virtual X509Certificate2 GetCertificateByThumbPrint(string thumbprint)
        {
            var store = new X509Store("My", StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            return store.Certificates.Cast<X509Certificate2>().FirstOrDefault(cert => cert.Thumbprint == thumbprint.ToUpper());
        }
        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCertificateForm();
        }
        private void ShowCertificateForm()
        {
            var csF = SelectedCertificate == null ? new CertificateSelectorForm() : new CertificateSelectorForm(SelectedCertificate);
            
            csF.FormClosing += csF_FormClosing;
            csF.ShowDialog();
        }
        private void csF_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelectedCertificate = ((CertificateSelectorForm)sender).SelectedCertificate;
            if(SelectedCertificate != null)
                Thumbprint = SelectedCertificate.Thumbprint;
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sViewer = new SoapViewer(RequestSoap.XmlDocument);
            sViewer.Show();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralizedSaveFile(RequestSoap.XmlDocument);
        }
        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ReplySoap == null)
            {
                MessageBox.Show(@"No soap message was returned.");
                showToolStripMenuItem1.Enabled = false;
                return;
            }

            var sViewer = new SoapViewer(ReplySoap.XmlDocument);
            sViewer.Show();
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) => GeneralizedSaveFile(ReplySoap?.XmlDocument);
        #endregion
    }
}
