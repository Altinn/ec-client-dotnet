using System;
using System.ComponentModel;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.LookUp;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.LookUp;

namespace EC_Endpoint_Client.Forms.ServiceEngine.LookUpForm
{
    public partial class LookUpForm : ClientBaseForm
    {
        private LookUpEndPointFunction lookUpEndPointFunction;

        public LookUpShipment LookUpShipment;

        public string LookUpResult { get; set; }
        public string SavedFilePath { get; set; }

        public LookUpForm()
        {
            InitializeComponent();
            lookUpEndPointFunction = new LookUpEndPointFunction();
            lookUpEndPointFunction.ReturnMessageXml += ReturnMessageXmlHandler;

            ShipmentTest = new BaseShipment();
            LookUpShipment = new LookUpShipment();
            
            SetupObjForPropertyGrid();
        }

        private void SetupObjForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(LookUpRequest), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region serviceInvocations
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                lookUpEndPointFunction.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }

        private void LookUpInvoke()
        {
            SetBasicShipmentSettings(LookUpShipment);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                LookUpResult = lookUpEndPointFunction.LookUp(LookUpShipment);
                SetViewedItem(LookUpResult, "LookUpResult");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during LookUp");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion
        #region TestClicks
        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }
        #endregion
        #region LookUpClicks
        private void btn_LookUpShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(LookUpShipment, "Shipment for GetAvailableFilesShipment");
        }

        private void btn_LookUpSaveShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(LookUpShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(LookUpShipment);
        }

        private void btn_LookUpLoadShipment_Click(object sender, EventArgs e)
        {
            LookUpShipment = (LookUpShipment)Functionality.IOFunctionality.GeneralizedLoadFile(LookUpShipment);
            SetViewedItem(LookUpShipment, "Shipment for LookUpShipment");
        }

        private void btn_LookUpInvokeService_Click(object sender, EventArgs e)
        {
            LookUpInvoke();
        }

        private void btn_LookUpShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(LookUpResult, "Result from LookUp");
        }

        private void btn_LookUpSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(LookUpResult);
        }
        #endregion
    }
}
