using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.BrokerService;
using EC_Endpoint_Client.BrokerServiceStreamed;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;

namespace EC_Endpoint_Client.Forms.ServiceEngine.BrokerServiceForm
{
    public partial class BrokerServiceForm : ClientBaseForm
    {
        private BrokerServiceEndPointFunction brokerServiceEPFunc;
        private BrokerServiceStreamedEndPointFunction brokerServiceStreanedEPFunc;

        public InitiateBrokerServiceShipment InitiateBrokerServiceShipment;
        public GetAvailableFilesShipment GetAvailableFilesShipment;
        public UploadFileStreamedShipment UploadFileStreamedShipment;
        public DownloadFileStreamedShipment DownloadFileStreamedShipment;

        public string InitiateFileReferenceResult { get; set; }
        public BrokerServiceAvailableFile[] GetAvailableFileListResult { get; set; }
        public UploadFileStreamedResult UploadFileStreamedReceiptResult { get; set; }
        public byte[] DownloadFileStreamedResult { get; set; }
        public string SavedFilePath { get; set; }

        public BrokerServiceForm()
        {
            InitializeComponent();
            brokerServiceEPFunc = new BrokerServiceEndPointFunction();
            brokerServiceEPFunc.ReturnMessageXml += ReturnMessageXmlHandler;

            brokerServiceStreanedEPFunc = new BrokerServiceStreamedEndPointFunction();
            brokerServiceStreanedEPFunc.ReturnMessageXml += ReturnMessageXmlHandler;

            ShipmentTest = new BaseShipment();
            InitiateBrokerServiceShipment = new InitiateBrokerServiceShipment();
            GetAvailableFilesShipment = new GetAvailableFilesShipment();
            UploadFileStreamedShipment = new UploadFileStreamedShipment();
            DownloadFileStreamedShipment = new DownloadFileStreamedShipment();

            UploadFileStreamedReceiptResult = new UploadFileStreamedResult();
            
            SetupObjForPropertyGrid();
        }

        private void SetupObjForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(BrokerServiceInitiation), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Manifest), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(File), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Property), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Recipient), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(BrokerServiceSearch), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StreamedPayloadECBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

            TypeDescriptor.AddAttributes(typeof(BrokerServiceAvailableFile), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region serviceInvocations
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                brokerServiceEPFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }

        private void StreamedTest()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                brokerServiceStreanedEPFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Streamed test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Streamed Test");
            }
        }

        private void InitiateBrokerServiceInvoke()
        {
            SetBasicShipmentSettings(InitiateBrokerServiceShipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                InitiateFileReferenceResult = brokerServiceEPFunc.InitiateBrokerService(InitiateBrokerServiceShipment);
                SetViewedItem(InitiateFileReferenceResult, "Initiated Broker Service File Reference");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during InitiateBrokerService");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void GetAvailableFilesInvoke()
        {
            SetBasicShipmentSettings(GetAvailableFilesShipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GetAvailableFileListResult = brokerServiceEPFunc.GetAvailableFiles(GetAvailableFilesShipment);
                SetViewedItem(GetAvailableFileListResult, "List of available files");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetAvailableFiles");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void UploadFileStreamedInvoke()
        {
            SetBasicShipmentSettings(UploadFileStreamedShipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                UploadFileStreamedReceiptResult = brokerServiceStreanedEPFunc.UploadFileStreamed(UploadFileStreamedShipment);
                SetViewedItem(UploadFileStreamedReceiptResult, "ReceiptExternalStreamed");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during UploadFileStreamed");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void DownloadFileStreamedInvoke()
        {
            SetBasicShipmentSettings(DownloadFileStreamedShipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DownloadFileStreamedResult = brokerServiceStreanedEPFunc.DownloadFileStreamed(DownloadFileStreamedShipment);
                Cursor.Current = Cursors.Default;

                SavedFilePath = Functionality.IOFunctionality.WriteBytesToFile(DownloadFileStreamedResult);
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
                SetViewedItem(ex, "Error during DownloadFileStreamed");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void SelectPayloadData(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GetStreamedPayloadFromFile(UploadFileStreamedShipment);
            SetViewedItem(UploadFileStreamedShipment, "Shipment for UploadFileStreamedShipment");
        }
        #endregion
        #region TestClicks
        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void btn_StreamedTestInvoke_Click(object sender, EventArgs e)
        {
            StreamedTest();
        }
        #endregion
        #region InitiateBrokerServiceClicks
        private void btn_InitiateBrokerServiceShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(InitiateBrokerServiceShipment, "Shipment for InitiateBrokerServiceShipment");
        }

        private void btn_InitiateBrokerServiceSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(InitiateBrokerServiceShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(InitiateBrokerServiceShipment);
        }

        private void btn_InitiateBrokerServiceLoadShipment_Click(object sender, EventArgs e)
        {
            InitiateBrokerServiceShipment = (InitiateBrokerServiceShipment)Functionality.IOFunctionality.GeneralizedLoadFile(InitiateBrokerServiceShipment);
            SetViewedItem(InitiateBrokerServiceShipment, "Shipment for InitiateBrokerServiceShipment");
        }

        private void btn_InitiateBrokerServiceInvoke_Click(object sender, EventArgs e)
        {
            InitiateBrokerServiceInvoke();
        }

        private void btn_InitiateBrokerServiceShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(InitiateFileReferenceResult, "Result from InitiateBrokerService");
        }

        private void btn_InitiateBrokerServiceSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(InitiateFileReferenceResult);
        }
        #endregion
        #region GetAvailableFilesClicks
        private void btn_GetAvailableFilesShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(GetAvailableFilesShipment, "Shipment for GetAvailableFilesShipment");
        }

        private void btn_GetAvailableFilesSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(GetAvailableFilesShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(GetAvailableFilesShipment);
        }

        private void btn_GetAvailableFilesLoadShipment_Click(object sender, EventArgs e)
        {
            GetAvailableFilesShipment = (GetAvailableFilesShipment)Functionality.IOFunctionality.GeneralizedLoadFile(GetAvailableFilesShipment);
            SetViewedItem(GetAvailableFilesShipment, "Shipment for GetAvailableFilesShipment");
        }

        private void btn_GetAvailableFilesInvokeService_Click(object sender, EventArgs e)
        {
            GetAvailableFilesInvoke();
        }

        private void btn_GetAvailableFilesShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(GetAvailableFileListResult, "Result from GetAvailableFiles");
        }

        private void btn_GetAvailableFilesSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(GetAvailableFileListResult);
        }
        #endregion
        #region UploadStreamedClicks
        private void btn_UploadFileStreamedShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(UploadFileStreamedShipment, "Shipment for UploadFileStreamedShipment");
        }

        private void btn_UploadFileStreamedSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(UploadFileStreamedShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(UploadFileStreamedShipment);
        }

        private void btn_UploadFileStreamedLoadShipment_Click(object sender, EventArgs e)
        {
            UploadFileStreamedShipment = (UploadFileStreamedShipment)Functionality.IOFunctionality.GeneralizedLoadFile(UploadFileStreamedShipment);
            SetViewedItem(UploadFileStreamedShipment, "Shipment for UploadFileStreamedShipment");
        }

        private void btn_UploadFileStreamedInvokeService_Click(object sender, EventArgs e)
        {
            UploadFileStreamedInvoke();
        }

        private void btn_UploadFileStreamedShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(UploadFileStreamedReceiptResult, "ReceiptExternalStreamed");
        }

        private void btn_UploadFileStreamedSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(UploadFileStreamedReceiptResult);
        }
        #endregion
        #region DownloadStreamedClicks
        private void btn_DownloadFileStreamedShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(DownloadFileStreamedShipment, "Shipment for DownloadFileStreamedShipment");
        }

        private void btn_DownloadFileStreamedSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(DownloadFileStreamedShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(DownloadFileStreamedShipment);
        }

        private void btn_DownloadFileStreamedLoadShipment_Click(object sender, EventArgs e)
        {
            DownloadFileStreamedShipment = (DownloadFileStreamedShipment)Functionality.IOFunctionality.GeneralizedLoadFile(DownloadFileStreamedShipment);
            SetViewedItem(DownloadFileStreamedShipment, "Shipment for DownloadFileStreamedShipment");
        }

        private void btn_DownloadFileStreamedInvokeService_Click(object sender, EventArgs e)
        {
            DownloadFileStreamedInvoke();
        }

        private void btn_DownloadFileStreamedShowResult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SavedFilePath))
            {
                SetViewedItem(SavedFilePath, "Downloaded file saved successfully");
            }
            else
            {
                SetViewedItem("Result not saved", "File downloaded, but not saved");
            }
        }

        private void btn_DownloadFileStreamedSaveResult_Click(object sender, EventArgs e)
        {
            SavedFilePath = Functionality.IOFunctionality.WriteBytesToFile(DownloadFileStreamedResult);
            if (!string.IsNullOrEmpty(SavedFilePath))
            {
                SetViewedItem(SavedFilePath, "Downloaded file saved successfully");
            }
        }
        #endregion

    }
}
