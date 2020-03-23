using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Correspondence;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence;
using EC_Endpoint_Client.CorrespondenceEC2;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    public partial class CorrespondenceFormEC2 : BaseForms.ClientBaseForm
    {
        private CorrespondenceEndPointFunctionEC2 _cepFunc;
        public CorrespondenceShipmentBase ShipmentAc { get; set; }
        public CorrespondenceShipmentBase ShipmentSaveCorrConf { get; set; }
        private CorrespondenceEC2.Receipt ResultAc { get; set; }
        public GetCorrespondenceShipment ShipmentGetCorr { get; set; }
        private CorrespondenceForEndUserSystemV2 ResultGetCorr { get; set; }
        public CorrespondenceFormEC2()
        {
            InitializeComponent();
            _cepFunc = new CorrespondenceEndPointFunctionEC2();
            _cepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentAc = new CorrespondenceShipmentBase();
            ShipmentGetCorr = new GetCorrespondenceShipment();
            ResultGetCorr = new CorrespondenceForEndUserSystemV2();
            ShipmentSaveCorrConf = new CorrespondenceShipmentBase();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(Receipt.Receipt), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceForEndUserSystemV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                _cepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void ArchiveCorrespondence()
        {
            SetBasicShipmentSettings(ShipmentAc);
            try
            {
                ResultAc = _cepFunc.ArchiveCorrespondence(ShipmentAc);
                SetViewedItem(ResultAc, "Result from ArchiveCorrespondence");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during ArchiveCorrespondence");
            }
        }

        private void GetCorrespondence()
        {
            SetBasicShipmentSettings(ShipmentGetCorr);
            try
            {
                ResultGetCorr = _cepFunc.GetCorrespondence(ShipmentGetCorr);
                SetViewedItem(ShipmentGetCorr, "Result from GetCorrespondence");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetCorrespondence");
            }
        }

        private void SaveCorrespondenceConfirmation()
        {
            SetBasicShipmentSettings(ShipmentSaveCorrConf);
            try
            {
                _cepFunc.SaveCorrespondenceConfirmation(ShipmentSaveCorrConf);
                SetViewedItem("OK", "SaveCorrespondenceConfirmation ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during SaveCorrespondenceConfirmation");
            }
        }
        #region ArchiveCorrespondenceClicks
        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentAc, "Shipment for ArchiveCorrespondence");
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            ArchiveCorrespondence();
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultAc, "Receipt from ArchiveCorrespondence");
        }

        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultAc);
        }
        #endregion
        #region GetCorrespondenceClicks
        private void btn_GCShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentGetCorr, "Shipment for GetCorrespondence");
        }

        private void btn_GCInvoke_Click(object sender, EventArgs e)
        {
            GetCorrespondence();
        }

        private void btn_GCShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultGetCorr, "Correspondence from GetCorrespondence");
        }

        private void btn_GCSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultGetCorr);
        }
#endregion
        #region SaveCorrespondenceConfirmation
        private void btn_SCCShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentSaveCorrConf, "Shipment for SaveCorrespondenceConfirmation");
        }

        private void btn_SCCInvoke_Click(object sender, EventArgs e)
        {
            SaveCorrespondenceConfirmation();
        }
        #endregion

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }

    }
}
