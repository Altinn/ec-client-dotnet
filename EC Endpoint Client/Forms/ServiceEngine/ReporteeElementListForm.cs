using System;
using System.ComponentModel;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.ReporteeElementList;
using EC_Endpoint_Client.Classes.Shipments;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class ReporteeElementListForm : AgencyBaseForm
    {
        private Functionality.EndPoints.ServiceEngine.ReporteeElementListEndPointFunction _relepFunc;
        public DeleteReporteeElementShipment ShipmentDeleteRe { get; set; }
        public ReporteeElemenetListShipmentBase ShipmentGetCorrForAr { get; set; }
        public ReporteeElemenetListShipmentBase ShipmentGcfr { get; set; }
        public GetFormSetShipmentBase ShipmentGetFormSet { get; set; }
        private ReporteeElementBEV2Lis ResultSgcbar { get; set; }
        private ReporteeElementBEV2[] ResultSgcbarArray { get { return ResultSgcbar.ToArray(); } }
        private ReporteeElementBEV2Lis ResultSgcfr { get; set; }
        private ReporteeElementBEV2[] ResultSgcfrArray { get { return ResultSgcfr.ToArray(); } }
        private FormSetElementExternalBEV2List ResultGfs { get; set; }
        private FormSetElementBEV2[] ResultGfsArray { get { return ResultGfs.ToArray(); } }
        public GetReporteeElementListShipment ShipmentGrel { get; set; }
        private ReporteeElementBEV2Lis ResultGrel { get; set; }
        private ReporteeElementBEV2[] ResultGrelArray { get { return ResultGrel.ToArray(); } }
        private FormSetDataBEList ResultFormSetData { get; set; }
        private FormSetDataBE[] ReulstFormSetDataArray { get { return ResultFormSetData.ToArray(); } }
        private BaseReporteeElementIdShipment GetFormSetDataShipment { get; set; }
        public ReporteeElementListForm()
        {
            InitializeComponent();
            _relepFunc = new Functionality.EndPoints.ServiceEngine.ReporteeElementListEndPointFunction();
            _relepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentDeleteRe = new DeleteReporteeElementShipment();
            ShipmentGetCorrForAr = new ReporteeElemenetListShipmentBase();
            ShipmentGetFormSet = new GetFormSetShipmentBase();
            ResultSgcbar = new ReporteeElementBEV2Lis();
            ResultSgcfr = new ReporteeElementBEV2Lis();
            ResultGfs = new FormSetElementExternalBEV2List();
            ShipmentGcfr = new ReporteeElemenetListShipmentBase();
            ShipmentGrel = new GetReporteeElementListShipment();
            ShipmentGrel.ExternalSearch = new ExternalSearchBEV2();
            ResultFormSetData = new FormSetDataBEList();
            GetFormSetDataShipment = new BaseReporteeElementIdShipment();
            AssignAction(ahc_GetFormSetData, _relepFunc.GetFormTaskData, GetFormSetDataShipment, ResultFormSetData, "GetFormSetData");

            SetupObjForPropGrid();
        }
        
        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReporteeElementBEV2Lis), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReporteeElementBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormSetElementExternalBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormSetElementBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ExternalSearchBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormSetDataBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormSetDataBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region Invokes
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                _relepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void DeleteReporteeElement()
        {
            SetBasicShipmentSettings(ShipmentDeleteRe);
            try
            {
                _relepFunc.DeleteReporteeElement(ShipmentDeleteRe);

                SetViewedItem("OK", "DeleteReporteeElement ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from DeleteReporteeElement");
            }
        }

        private void GetCorrespondenceListForArchiveRef()
        {
            SetBasicShipmentSettings(ShipmentGetCorrForAr);
            try
            {
                ResultSgcbar = _relepFunc.GetCorrespondenceListForArchiveRef(ShipmentGetCorrForAr);
                SetViewedItem(ResultSgcbarArray, "Result from GetCorrespondenceListForArchiveRef");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetCorrespondenceListForArchiveRef");
            }
        }

        private void GetCorrespondenceListForReportee()
        {
            SetBasicShipmentSettings(ShipmentGcfr);
            try
            {
                ResultSgcfr = _relepFunc.GetCorrespondenceListForReportee(ShipmentGcfr);
                SetViewedItem(ResultSgcfrArray, "Result from GetCorrespondenceListForReportee");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetCorrespondenceListForReportee");
            }
        }

        private void GetFormSetElements()
        {
            SetBasicShipmentSettings(ShipmentGetFormSet);
            try
            {
                ResultGfs = _relepFunc.GetFormSetElements(ShipmentGetFormSet);
                SetViewedItem(ResultGfsArray, "Result from GetFormSetElements");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetFormSetElements");
            }
        }

        private void GetReporteeElementList()
        {
            SetBasicShipmentSettings(ShipmentGrel);
            try
            {
                ResultGrel = _relepFunc.GetReporteeElementList(ShipmentGrel);
                SetViewedItem(ResultGrelArray, "Result from GetReporteeElementList");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetReporteeElementList");
            }
        }

#endregion
        #region clicks
        private void ButtonHandler(object sender, EventArgs e)
        {
            InvokeFunctionByButton((Button)sender);
        }

        private void InvokeFunctionByButton(Button b)
        {
            switch (b.Text)
            {
                case "Test":
                    Test();
                    break;
                case "Show Shipment":
                    ShowShipmentByTabPage();
                    break;
                case "Save Shipment":
                    SaveShipmentByTabPage();
                    break;
                case "Load Shipment":
                    LoadShipmentByTabPage();
                    break;
                case "Invoke Service":
                    InvokeServiceByTabPage();
                    break;
                case "Show Result":
                    ShowResultByTabPage();
                    break;
                case "Save Result":
                    SaveResultByTabPage();
                    break;

            }
        }

        private void ShowShipmentByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "GetCorrListForArch":
                    SetViewedItem(ShipmentGetCorrForAr, "Shipment for GetCorrespondenceListForArchiveRef");
                    break;
                case "GetCorrListForRep":
                    SetViewedItem(ShipmentGcfr, "Shipment for GetCorrespondenceListForReportee");
                    break;
                case "GetFS":
                    SetViewedItem(ShipmentGetFormSet, "Shipment for GetFormSetElements");
                    break;
                case "GetRE":
                    SetViewedItem(ShipmentGrel, "Shipment for GetReporteeElementList");
                    break;
                case "DeleteRE":
                    SetViewedItem(ShipmentDeleteRe, "Shipment for DeleteReporteeElement");
                    break;
            }
        }

        private void SaveShipmentByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "DeleteRE":
                    ClearBasicShipmentsettings(ShipmentDeleteRe);
                    Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentDeleteRe);
                    break;
                case "GetCorrListForArch":
                    ClearBasicShipmentsettings(ShipmentGetCorrForAr);
                    Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentGetCorrForAr);
                    break;
                case "GetCorrListForRep":
                    ClearBasicShipmentsettings(ShipmentGcfr);
                    Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentGcfr);
                    break;
                case "GetFS":
                    ClearBasicShipmentsettings(ShipmentGetFormSet);
                    Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentGetFormSet);
                    break;
                case "GetRE":
                    ClearBasicShipmentsettings(ShipmentGrel);
                    Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentGrel);
                    break;
            }
        }

        private void LoadShipmentByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "DeleteRE":
                    ShipmentDeleteRe = (DeleteReporteeElementShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentDeleteRe);
                    break;
                case "GetCorrListForArch":
                    ShipmentGetCorrForAr = (ReporteeElemenetListShipmentBase)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentGetCorrForAr);
                    break;
                case "GetCorrListForRep":
                    ShipmentGcfr = (ReporteeElemenetListShipmentBase)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentGcfr);
                    break;
                case "GetFS":
                    ShipmentGetFormSet = (GetFormSetShipmentBase)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentGetFormSet);
                    break;
                case "GetRE":
                    ShipmentGrel = (GetReporteeElementListShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentGrel);
                    break;
            }
        }

        private void InvokeServiceByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "GetCorrListForArch":
                    GetCorrespondenceListForArchiveRef();
                    break;
                case "GetCorrListForRep":
                    GetCorrespondenceListForReportee();
                    break;
                case "GetFS":
                    GetFormSetElements();
                    break;
                case "GetRE":
                    GetReporteeElementList();
                    break;
                case "DeleteRE":
                    DeleteReporteeElement();
                    break;
            }
        }

        private void ShowResultByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "GetCorrListForArch":
                    SetViewedItem(ResultSgcbarArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
                case "GetCorrListForRep":
                    SetViewedItem(ResultSgcfrArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
                case "GetFS":
                    SetViewedItem(ResultGfsArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
                case "GetRE":
                    SetViewedItem(ResultGrelArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
            }
        }

        private void SaveResultByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "GetCorrListForArch":
                    Functionality.IoFunctionality.GeneralizedSaveFile(ResultSgcbar);
                    break;
                case "GetCorrListForRep":
                    Functionality.IoFunctionality.GeneralizedSaveFile(ResultSgcfr);
                    break;
                case "GetFS":
                    Functionality.IoFunctionality.GeneralizedSaveFile(ResultGfs);
                    break;
                case "GetRE":
                    Functionality.IoFunctionality.GeneralizedSaveFile(ResultGrel);
                    break;
            }
        }
#endregion
    }
}
