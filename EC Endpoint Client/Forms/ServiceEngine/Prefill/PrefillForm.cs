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
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillEUS;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill;
using EC_Endpoint_Client.PrefillEUS;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Prefill
{
    public partial class PrefillForm : ClientBaseForm
    {
        PrefillEUSEndPointFunction peusepFunc;
        private PrefillDataBE ResultGPD { get; set; }
        public GetPrefillDataShipmentBase ShipmentGPD { get; set; }
        public  GetPrefillDataV2ShipmentExt ShipmentGPDV2 { get; set; }
        private PrefillDataBEv2 ResultGPDV2 { get; set; }

        public PrefillForm()
        {
            InitializeComponent();
            peusepFunc = new Functionality.EndPoints.ServiceEngine.Prefill.PrefillEUSEndPointFunction();
            peusepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            ShipmentGPD = new GetPrefillDataShipmentBase();
            ShipmentGPDV2 = new GetPrefillDataV2ShipmentExt();
            ResultGPD = new PrefillDataBE();
            ResultGPDV2 = new PrefillDataBEv2();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(PrefillDataBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PrefillDataBEv2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(PreFillRequestBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                peusepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        public void GetPrefillDataV1()
        {
            SetBasicShipmentSettings(ShipmentGPD);
            try
            {
                ResultGPD = peusepFunc.GetPrefillData(ShipmentGPD);
                SetViewedItem(ResultGPD, "Result from GetPrefillData");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetPrefillData");
            }
        }

        public void GetPrefillDataV2()
        {
            GetPrefillDataV2Shipment ship = new GetPrefillDataV2Shipment();
            SetBasicShipmentSettings(ship);
            ship.PrefillBEList = new PreFillRequestBEList();
            ship.ExternalServiceCode = ShipmentGPDV2.ExternalServiceCode;
            ship.ExternalServiceEditionCode = ShipmentGPDV2.ExternalServiceEditionCode;
            ship.ReporteeNumber = ShipmentGPDV2.ReporteeNumber;
            if (ShipmentGPDV2.PrefillBEList != null)
            {
                foreach (string s in ShipmentGPDV2.PrefillBEList)
                {
                    ship.PrefillBEList.Add(s);
                }
            }
            try
            {
                ResultGPDV2 = peusepFunc.GetPrefillDataV2(ship);
                SetViewedItem(ResultGPDV2, "Result from GetPrefillDataV2");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetPrefillDataV2");
            }
        }
        #region GPDClick
        private void btn_GPDShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentGPD, "Shipment for GetPrefillData");
        }

        private void btn_GPDLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentGPD = (GetPrefillDataShipmentBase)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentGPD);
        }

        private void btn_GPDShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultGPD, "Result from GetPrefillData");
        }

        private void btn_GPDSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentGPD);
            Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentGPD);
        }

        private void btn_GPDInvoke_Click(object sender, EventArgs e)
        {
            GetPrefillDataV1();
        }

        private void btn_GPDSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultGPD);
        }
#endregion
        #region GPDV2Clicks
        private void btn_GPDV2ShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentGPDV2, "Shipment for GetPrefillDataV2");
        }

        private void btn_GPDV2LoadShip_Click(object sender, EventArgs e)
        {
            GetPrefillDataV2Shipment ship = new GetPrefillDataV2Shipment();
            ship = Functionality.IOFunctionality.GeneralizedLoadFile(ship);
            ShipmentGPDV2 = ListToArray(ship);
            SetViewedItem(ShipmentGPDV2, "Shipment for GetPrefillDataV2");
        }

        private void btn_GPDV2ShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultGPDV2, "Result from GetPrefillDataV2");
        }

        private void btn_GPDV2SaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentGPDV2);
            GetPrefillDataV2Shipment ship = ArrayToList();
            Functionality.IOFunctionality.GeneralizedSaveFile(ship);
        }

        private GetPrefillDataV2Shipment ArrayToList()
        {
            GetPrefillDataV2Shipment ship = new GetPrefillDataV2Shipment();
            ship.ExternalServiceCode = ShipmentGPDV2.ExternalServiceCode;
            ship.ExternalServiceEditionCode = ShipmentGPDV2.ExternalServiceEditionCode;
            ship.ReporteeNumber = ShipmentGPDV2.ReporteeNumber;
            foreach (string s in ShipmentGPDV2.PrefillBEList)
            {
                ship.PrefillBEList.Add(s);
            }
            return ship;
        }

        private GetPrefillDataV2ShipmentExt ListToArray(GetPrefillDataV2Shipment inship)
        {
            GetPrefillDataV2ShipmentExt ship = new GetPrefillDataV2ShipmentExt();
            ship.ExternalServiceCode = inship.ExternalServiceCode;
            ship.ExternalServiceEditionCode = inship.ExternalServiceEditionCode;
            ship.ReporteeNumber = inship.ReporteeNumber;
            ship.PrefillBEList = inship.PrefillBEList.ToArray();
            return ship;
        }

        private void btn_GPDV2Invoke_Click(object sender, EventArgs e)
        {
            GetPrefillDataV2();
        }

        private void btn_GPDV2SaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultGPDV2);
        }
#endregion

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }

    }
}
