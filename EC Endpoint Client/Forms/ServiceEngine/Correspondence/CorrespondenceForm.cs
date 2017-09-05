using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Correspondence;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.Correspondence;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    public partial class CorrespondenceForm : ClientBaseForm
    {
        private CorrespondenceEndPointFunction cepFunc;
        public CorrespondenceShipmentBase ShipmentAC { get; set; }
        public CorrespondenceShipmentBase ShipmentSaveCorrConf { get; set; }
        private EC_Endpoint_Client.Correspondence.Receipt ResultAC { get; set; }
        public GetCorrespondenceShipment ShipmentGetCorr { get; set; }
        private EC_Endpoint_Client.Correspondence.CorrespondenceForEndUserSystemV2 ResultGetCorr { get; set; }
        public CorrespondenceForm()
        {
            InitializeComponent();
            cepFunc = new CorrespondenceEndPointFunction();
            cepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentAC = new CorrespondenceShipmentBase();
            ShipmentGetCorr = new GetCorrespondenceShipment();
            ResultGetCorr = new CorrespondenceForEndUserSystemV2();
            ShipmentSaveCorrConf = new CorrespondenceShipmentBase();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(EC_Endpoint_Client.Correspondence.Receipt), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CorrespondenceForEndUserSystemV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                cepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void ArchiveCorrespondence()
        {
            SetBasicShipmentSettings(ShipmentAC);
            try
            {
                ResultAC = cepFunc.ArchiveCorrespondence(ShipmentAC);
                SetViewedItem(ResultAC, "Result from ArchiveCorrespondence");
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
                ResultGetCorr = cepFunc.GetCorrespondence(ShipmentGetCorr);
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
                cepFunc.SaveCorrespondenceConfirmation(ShipmentSaveCorrConf);
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
            SetViewedItem(ShipmentAC, "Shipment for ArchiveCorrespondence");
        }

        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            ArchiveCorrespondence();
        }

        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultAC, "Receipt from ArchiveCorrespondence");
        }

        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultAC);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultGetCorr);
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
