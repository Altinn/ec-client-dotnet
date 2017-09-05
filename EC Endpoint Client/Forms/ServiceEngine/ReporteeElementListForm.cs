using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.ReporteeElementList;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class ReporteeElementListForm : AgencyBaseForm
    {
        private Functionality.EndPoints.ServiceEngine.ReporteeElementListEndPointFunction relepFunc;
        public DeleteReporteeElementShipment ShipmentDeleteRE { get; set; }
        public ReporteeElemenetListShipmentBase ShipmentGetCorrForAR { get; set; }
        public ReporteeElemenetListShipmentBase ShipmentGCFR { get; set; }
        public GetFormSetShipmentBase ShipmentGetFormSet { get; set; }
        private ReporteeElementBEV2Lis ResultSGCBAR { get; set; }
        private ReporteeElementBEV2[] ResultSGCBARArray { get { return ResultSGCBAR.ToArray(); } }
        private ReporteeElementBEV2Lis ResultSGCFR { get; set; }
        private ReporteeElementBEV2[] ResultSGCFRArray { get { return ResultSGCFR.ToArray(); } }
        private FormSetElementExternalBEV2List ResultGFS { get; set; }
        private FormSetElementBEV2[] ResultGFSArray { get { return ResultGFS.ToArray(); } }
        public GetReporteeElementListShipment ShipmentGREL { get; set; }
        private ReporteeElementBEV2Lis ResultGREL { get; set; }
        private ReporteeElementBEV2[] ResultGRELArray { get { return ResultGREL.ToArray(); } }
        public ReporteeElementListForm()
        {
            InitializeComponent();
            relepFunc = new Functionality.EndPoints.ServiceEngine.ReporteeElementListEndPointFunction();
            relepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentDeleteRE = new DeleteReporteeElementShipment();
            ShipmentGetCorrForAR = new ReporteeElemenetListShipmentBase();
            ShipmentGetFormSet = new GetFormSetShipmentBase();
            ResultSGCBAR = new ReporteeElementBEV2Lis();
            ResultSGCFR = new ReporteeElementBEV2Lis();
            ResultGFS = new FormSetElementExternalBEV2List();
            ShipmentGCFR = new ReporteeElemenetListShipmentBase();
            ShipmentGREL = new GetReporteeElementListShipment();
            ShipmentGREL.ExternalSearch = new ExternalSearchBEV2();
            SetupObjForPropGrid();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReporteeElementBEV2Lis), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReporteeElementBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormSetElementExternalBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FormSetElementBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ExternalSearchBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region Invokes
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                relepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void DeleteReporteeElement()
        {
            SetBasicShipmentSettings(ShipmentDeleteRE);
            try
            {
                relepFunc.DeleteReporteeElement(ShipmentDeleteRE);

                SetViewedItem("OK", "DeleteReporteeElement ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from DeleteReporteeElement");
            }
        }

        private void GetCorrespondenceListForArchiveRef()
        {
            SetBasicShipmentSettings(ShipmentGetCorrForAR);
            try
            {
                ResultSGCBAR = relepFunc.GetCorrespondenceListForArchiveRef(ShipmentGetCorrForAR);
                SetViewedItem(ResultSGCBARArray, "Result from GetCorrespondenceListForArchiveRef");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetCorrespondenceListForArchiveRef");
            }
        }

        private void GetCorrespondenceListForReportee()
        {
            SetBasicShipmentSettings(ShipmentGCFR);
            try
            {
                ResultSGCFR = relepFunc.GetCorrespondenceListForReportee(ShipmentGCFR);
                SetViewedItem(ResultSGCFRArray, "Result from GetCorrespondenceListForReportee");
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
                ResultGFS = relepFunc.GetFormSetElements(ShipmentGetFormSet);
                SetViewedItem(ResultGFSArray, "Result from GetFormSetElements");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetFormSetElements");
            }
        }

        private void GetReporteeElementList()
        {
            SetBasicShipmentSettings(ShipmentGREL);
            try
            {
                ResultGREL = relepFunc.GetReporteeElementList(ShipmentGREL);
                SetViewedItem(ResultGRELArray, "Result from GetReporteeElementList");
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
                    SetViewedItem(ShipmentGetCorrForAR, "Shipment for GetCorrespondenceListForArchiveRef");
                    break;
                case "GetCorrListForRep":
                    SetViewedItem(ShipmentGCFR, "Shipment for GetCorrespondenceListForReportee");
                    break;
                case "GetFS":
                    SetViewedItem(ShipmentGetFormSet, "Shipment for GetFormSetElements");
                    break;
                case "GetRE":
                    SetViewedItem(ShipmentGREL, "Shipment for GetReporteeElementList");
                    break;
                case "DeleteRE":
                    SetViewedItem(ShipmentDeleteRE, "Shipment for DeleteReporteeElement");
                    break;
            }
        }

        private void SaveShipmentByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "DeleteRE":
                    ClearBasicShipmentsettings(ShipmentDeleteRE);
                    Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentDeleteRE);
                    break;
                case "GetCorrListForArch":
                    ClearBasicShipmentsettings(ShipmentGetCorrForAR);
                    Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentGetCorrForAR);
                    break;
                case "GetCorrListForRep":
                    ClearBasicShipmentsettings(ShipmentGCFR);
                    Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentGCFR);
                    break;
                case "GetFS":
                    ClearBasicShipmentsettings(ShipmentGetFormSet);
                    Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentGetFormSet);
                    break;
                case "GetRE":
                    ClearBasicShipmentsettings(ShipmentGREL);
                    Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentGREL);
                    break;
            }
        }

        private void LoadShipmentByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "DeleteRE":
                    ShipmentDeleteRE = (DeleteReporteeElementShipment)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentDeleteRE);
                    break;
                case "GetCorrListForArch":
                    ShipmentGetCorrForAR = (ReporteeElemenetListShipmentBase)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentGetCorrForAR);
                    break;
                case "GetCorrListForRep":
                    ShipmentGCFR = (ReporteeElemenetListShipmentBase)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentGCFR);
                    break;
                case "GetFS":
                    ShipmentGetFormSet = (GetFormSetShipmentBase)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentGetFormSet);
                    break;
                case "GetRE":
                    ShipmentGREL = (GetReporteeElementListShipment)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentGREL);
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
                    SetViewedItem(ResultSGCBARArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
                case "GetCorrListForRep":
                    SetViewedItem(ResultSGCFRArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
                case "GetFS":
                    SetViewedItem(ResultGFSArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
                case "GetRE":
                    SetViewedItem(ResultGRELArray, "Result from " + tabControl1.SelectedTab.Text);
                    break;
            }
        }

        private void SaveResultByTabPage()
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "GetCorrListForArch":
                    Functionality.IOFunctionality.GeneralizedSaveFile(ResultSGCBAR);
                    break;
                case "GetCorrListForRep":
                    Functionality.IOFunctionality.GeneralizedSaveFile(ResultSGCFR);
                    break;
                case "GetFS":
                    Functionality.IOFunctionality.GeneralizedSaveFile(ResultGFS);
                    break;
                case "GetRE":
                    Functionality.IOFunctionality.GeneralizedSaveFile(ResultGREL);
                    break;
            }
        }
#endregion
    }
}
