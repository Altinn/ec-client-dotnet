using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillEUS;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill;
using EC_Endpoint_Client.Service_References.PrefillEUS;

namespace EC_Endpoint_Client.Forms.ServiceEngine.Prefill
{
    public partial class PrefillForm : BaseForms.ClientBaseForm
    {
        PrefillEusEndPointFunction _peusepFunc;
        private PrefillDataBE ResultGpd { get; set; }
        public GetPrefillDataShipmentBase ShipmentGpd { get; set; }
        public  GetPrefillDataV2ShipmentExt ShipmentGpdv2 { get; set; }
        private PrefillDataBEv2 ResultGpdv2 { get; set; }

        public PrefillForm()
        {
            InitializeComponent();
            _peusepFunc = new PrefillEusEndPointFunction();
            _peusepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentTest = new BaseShipment();
            ShipmentGpd = new GetPrefillDataShipmentBase();
            ShipmentGpdv2 = new GetPrefillDataV2ShipmentExt();
            ResultGpd = new PrefillDataBE();
            ResultGpdv2 = new PrefillDataBEv2();
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
                _peusepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        public void GetPrefillDataV1()
        {
            SetBasicShipmentSettings(ShipmentGpd);
            try
            {
                ResultGpd = _peusepFunc.GetPrefillData(ShipmentGpd);
                SetViewedItem(ResultGpd, "Result from GetPrefillData");
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
            ship.PrefillBeList = new PreFillRequestBEList();
            ship.ExternalServiceCode = ShipmentGpdv2.ExternalServiceCode;
            ship.ExternalServiceEditionCode = ShipmentGpdv2.ExternalServiceEditionCode;
            ship.ReporteeNumber = ShipmentGpdv2.ReporteeNumber;
            if (ShipmentGpdv2.PrefillBeList != null)
            {
                foreach (string s in ShipmentGpdv2.PrefillBeList)
                {
                    ship.PrefillBeList.Add(s);
                }
            }
            try
            {
                ResultGpdv2 = _peusepFunc.GetPrefillDataV2(ship);
                SetViewedItem(ResultGpdv2, "Result from GetPrefillDataV2");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetPrefillDataV2");
            }
        }
        #region GPDClick
        private void btn_GPDShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentGpd, "Shipment for GetPrefillData");
        }

        private void btn_GPDLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentGpd = (GetPrefillDataShipmentBase)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentGpd);
        }

        private void btn_GPDShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultGpd, "Result from GetPrefillData");
        }

        private void btn_GPDSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentGpd);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentGpd);
        }

        private void btn_GPDInvoke_Click(object sender, EventArgs e)
        {
            GetPrefillDataV1();
        }

        private void btn_GPDSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultGpd);
        }
#endregion
        #region GPDV2Clicks
        private void btn_GPDV2ShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentGpdv2, "Shipment for GetPrefillDataV2");
        }

        private void btn_GPDV2LoadShip_Click(object sender, EventArgs e)
        {
            GetPrefillDataV2Shipment ship = new GetPrefillDataV2Shipment();
            ship = Functionality.IoFunctionality.GeneralizedLoadFile(ship);
            ShipmentGpdv2 = ListToArray(ship);
            SetViewedItem(ShipmentGpdv2, "Shipment for GetPrefillDataV2");
        }

        private void btn_GPDV2ShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultGpdv2, "Result from GetPrefillDataV2");
        }

        private void btn_GPDV2SaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentGpdv2);
            GetPrefillDataV2Shipment ship = ArrayToList();
            Functionality.IoFunctionality.GeneralizedSaveFile(ship);
        }

        private GetPrefillDataV2Shipment ArrayToList()
        {
            GetPrefillDataV2Shipment ship = new GetPrefillDataV2Shipment();
            ship.ExternalServiceCode = ShipmentGpdv2.ExternalServiceCode;
            ship.ExternalServiceEditionCode = ShipmentGpdv2.ExternalServiceEditionCode;
            ship.ReporteeNumber = ShipmentGpdv2.ReporteeNumber;
            foreach (string s in ShipmentGpdv2.PrefillBeList)
            {
                ship.PrefillBeList.Add(s);
            }
            return ship;
        }

        private GetPrefillDataV2ShipmentExt ListToArray(GetPrefillDataV2Shipment inship)
        {
            GetPrefillDataV2ShipmentExt ship = new GetPrefillDataV2ShipmentExt();
            ship.ExternalServiceCode = inship.ExternalServiceCode;
            ship.ExternalServiceEditionCode = inship.ExternalServiceEditionCode;
            ship.ReporteeNumber = inship.ReporteeNumber;
            ship.PrefillBeList = inship.PrefillBeList.ToArray();
            return ship;
        }

        private void btn_GPDV2Invoke_Click(object sender, EventArgs e)
        {
            GetPrefillDataV2();
        }

        private void btn_GPDV2SaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultGpdv2);
        }
#endregion

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }

    }
}
