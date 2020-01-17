using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.BrokerService;
using EC_Endpoint_Client.BrokerServiceEC2;
using EC_Endpoint_Client.BrokerServiceEC2Streamed;

namespace EC_Endpoint_Client.Forms.ServiceEngine.BrokerService
{
    public partial class BrokerServiceFormEC2 : BaseForms.ClientBaseForm
    {
        private readonly BrokerServiceEndPointFunctionEC2 _brokerServiceEpFunc;
        private readonly BrokerServiceStreamedEndPointFunctionEC2 _brokerServiceStreanedEpFunc;

        public InitiateBrokerServiceShipmentEC2 InitiateBrokerServiceShipment;
        public GetAvailableFilesShipmentEC2 GetAvailableFilesShipment;
        public UploadFileStreamedShipment UploadFileStreamedShipment;
        public DownloadFileStreamedShipment DownloadFileStreamedShipment;

        public string InitiateFileReferenceResult;
        public BrokerServiceAvailableFile[] GetAvailableFileListResult;
        public UploadFileStreamedResult UploadFileStreamedReceiptResult;
        public byte[] DownloadFileStreamedResult;
        public string SavedFilePath { get; set; }

        public BrokerServiceFormEC2()
        {
            InitializeComponent();
            _brokerServiceEpFunc = new BrokerServiceEndPointFunctionEC2();
            _brokerServiceEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;

            _brokerServiceStreanedEpFunc = new BrokerServiceStreamedEndPointFunctionEC2();
            _brokerServiceStreanedEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;

            ShipmentTest = new BaseShipment();
            InitiateBrokerServiceShipment = new InitiateBrokerServiceShipmentEC2();
            GetAvailableFilesShipment = new GetAvailableFilesShipmentEC2();
            UploadFileStreamedShipment = new UploadFileStreamedShipment();
            DownloadFileStreamedShipment = new DownloadFileStreamedShipment();

            UploadFileStreamedReceiptResult = new UploadFileStreamedResult();
            
            SetupObjForPropertyGrid();
        }

        private static void SetupObjForPropertyGrid()
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
                _brokerServiceEpFunc.Test(ShipmentTest);
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
                _brokerServiceStreanedEpFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Streamed test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Streamed Test");
            }
        }

        private void InitiateBrokerServiceInvoke()
        {
            InvokeService(_brokerServiceEpFunc.InitiateBrokerService, InitiateBrokerServiceShipment, ref InitiateFileReferenceResult, "Broker Service File");
        }

        private void GetAvailableFilesInvoke()
        {
            InvokeService(_brokerServiceEpFunc.GetAvailableFiles, GetAvailableFilesShipment, ref GetAvailableFileListResult, "Get Avilable Files");
        }

        private void UploadFileStreamedInvoke()
        {
            InvokeService(_brokerServiceStreanedEpFunc.UploadFileStreamed, UploadFileStreamedShipment, ref UploadFileStreamedReceiptResult, "ReceiptExternalStreamed");
        }

        private void DownloadFileStreamedInvoke()
        {
            InvokeService(_brokerServiceStreanedEpFunc.DownloadFileStreamed, DownloadFileStreamedShipment, ref DownloadFileStreamedResult, "Downloaded file saved successfully");
            SavedFilePath = Functionality.IoFunctionality.WriteBytesToFile(DownloadFileStreamedResult);
            SetViewedItem(SavedFilePath, "Downloaded file saved successfully");
        }

        private void SelectPayloadData(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GetStreamedPayloadFromFile(UploadFileStreamedShipment);
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
            InvokeSaveShipment(InitiateBrokerServiceShipment);
        }

        private void btn_InitiateBrokerServiceLoadShipment_Click(object sender, EventArgs e)
        {
            InvokeLoadShipment(InitiateBrokerServiceShipment, "Shipment for InitiateBrokerServiceShipment");
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
            Functionality.IoFunctionality.GeneralizedSaveFile(InitiateFileReferenceResult);
        }
        #endregion
        #region GetAvailableFilesClicks
        private void btn_GetAvailableFilesShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(GetAvailableFilesShipment, "Shipment for GetAvailableFilesShipment");
        }

        private void btn_GetAvailableFilesSaveShipment_Click(object sender, EventArgs e)
        {
            InvokeSaveShipment(GetAvailableFilesShipment);
        }

        private void btn_GetAvailableFilesLoadShipment_Click(object sender, EventArgs e)
        {
            InvokeLoadShipment(GetAvailableFilesShipment, "Shipment for GetAvailableFilesShipment");
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
            Functionality.IoFunctionality.GeneralizedSaveFile(GetAvailableFileListResult);
        }
        #endregion
        #region UploadStreamedClicks
        private void btn_UploadFileStreamedShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(UploadFileStreamedShipment, "Shipment for UploadFileStreamedShipment");
        }

        private void btn_UploadFileStreamedSaveShipment_Click(object sender, EventArgs e)
        {
            InvokeSaveShipment(UploadFileStreamedShipment);
        }

        private void btn_UploadFileStreamedLoadShipment_Click(object sender, EventArgs e)
        {
            InvokeLoadShipment(UploadFileStreamedShipment, "Shipment for UploadFileStreamedShipment");
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
            InvokeSave(UploadFileStreamedReceiptResult);
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
            Functionality.IoFunctionality.GeneralizedSaveFile(DownloadFileStreamedShipment);
        }

        private void btn_DownloadFileStreamedLoadShipment_Click(object sender, EventArgs e)
        {
            DownloadFileStreamedShipment = Functionality.IoFunctionality.GeneralizedLoadFile(DownloadFileStreamedShipment);
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
            SavedFilePath = Functionality.IoFunctionality.WriteBytesToFile(DownloadFileStreamedResult);
            if (!string.IsNullOrEmpty(SavedFilePath))
            {
                SetViewedItem(SavedFilePath, "Downloaded file saved successfully");
            }
        }
        #endregion
    }
}
