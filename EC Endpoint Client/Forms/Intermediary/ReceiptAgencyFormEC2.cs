﻿using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;
using EC_Endpoint_Client.ReceiptAgencyEC2;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class ReceiptAgencyFormEC2 : AgencyBaseForm
    {
        private ReceiptAgencyEndpointFunctionalityEC2 RaeFunc { get; set; }
        public ReceiptExternal ReceiptExt { get; set; }
        public ReceiptAgencyEC2.Receipt ReceiptV2 { get; set; }
        public ReceiptExternal SaveReceipt { get; set; }
        public ReceiptAgencyEC2.Receipt UpdateReceipt { get; set; }
        public ReceiptExternalList ReceiptList { get; set; }
        public ReceiptAgencyEC2.ReceiptList ReceiptListV2 { get; set; }
        public ReceiptListSearchExternalShipmentEC2 ReceiptListSearchShipment { get; set; }
        public ReceiptListV2SearchExternalShipmentEC2 ReceiptListV2SearchShipment { get; set; }
        public ReceiptSearchExternalShipmentEC2 ReceiptSearchShipment { get; set; }
        public ReceiptV2SearchExternalShipmentEC2 ReceiptV2SearchShipment { get; set; }
        public ReceiptSaveExternalShipmentEC2 ReceiptSaveShipment { get; set; }
        public ReceiptUpdateExternalShipmentEC2 ReceiptUpdateShipment { get; set; }
        public BaseShipment TestShipment { get; set; }
        private ReceiptExternal[] ReceiptArray {
            get
            {
                return ReceiptList.ToArray();
            }
        }
        private ReceiptAgencyEC2.Receipt[] ReceiptV2Array
        {
            get
            {
                return ReceiptListV2.ToArray();
            }
        }
        public ReceiptAgencyFormEC2()
        {
            InitializeComponent();
            ReceiptExt = new ReceiptExternal();
            ReceiptV2 = new ReceiptAgencyEC2.Receipt();
            ReceiptList = new ReceiptExternalList();
            ReceiptListV2 = new ReceiptList();
            RaeFunc = new ReceiptAgencyEndpointFunctionalityEC2();
            RaeFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SaveReceipt = new ReceiptExternal();
            UpdateReceipt = new ReceiptAgencyEC2.Receipt();
            SetupObjectsForPropertyGrid();
            ReceiptSearchShipment = new ReceiptSearchExternalShipmentEC2();
            ReceiptV2SearchShipment = new ReceiptV2SearchExternalShipmentEC2();
            ReceiptSaveShipment = new ReceiptSaveExternalShipmentEC2();
            ReceiptUpdateShipment = new ReceiptUpdateExternalShipmentEC2();
            ReceiptListSearchShipment = new ReceiptListSearchExternalShipmentEC2();
            ReceiptListV2SearchShipment = new ReceiptListV2SearchExternalShipmentEC2();
            TestShipment = new BaseShipment();
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptAgencyEC2.Receipt), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptExternalList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptSaveExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(TestShipment);
            RaeFunc.Test(TestShipment);
        }

        private void SaveReceiptInvoke()
        {
            SetBasicShipmentSettings(ReceiptSaveShipment);
            SaveReceipt = RaeFunc.SaveReceipt(ReceiptSaveShipment);
        }

        private void UpdateReceiptInvoke()
        {
            SetBasicShipmentSettings(ReceiptUpdateShipment);
            UpdateReceipt = RaeFunc.UpdateReceipt(ReceiptUpdateShipment);
        }

        private void GetReceipt()
        {
            SetBasicShipmentSettings(ReceiptSearchShipment);
            ReceiptExt = RaeFunc.GetReceipt(ReceiptSearchShipment);
        }

        private void GetReceiptV2()
        {
            SetBasicShipmentSettings(ReceiptV2SearchShipment);
            ReceiptV2 = RaeFunc.GetReceiptV2(ReceiptV2SearchShipment);
        }

        private void GetReceiptList()
        {
            SetBasicShipmentSettings(ReceiptListSearchShipment);
            ReceiptList = RaeFunc.GetReceiptList(ReceiptListSearchShipment);
        }

        private void GetReceiptListV2()
        {
            SetBasicShipmentSettings(ReceiptListV2SearchShipment);
            ReceiptListV2 = RaeFunc.GetReceiptListV2(ReceiptListV2SearchShipment);
        }

        private void ShowGetReceiptShipment()
        {
            SetViewedItem(ReceiptSearchShipment.ReceiptSearch, "Shipment for GetReceipt");
        }

        private void ShowGetReceipt()
        {
            SetViewedItem(ReceiptExt, "Receipt from GetReceipt");
        }

        private void ShowGetReceiptV2Shipment()
        {
            SetViewedItem(ReceiptV2SearchShipment.ReceiptSearch, "Shipment for GetReceiptV2");
        }

        private void ShowGetReceiptV2()
        {
            SetViewedItem(ReceiptV2, "Receipt from GetReceiptV2");
        }

        private void ShowReceiptListShipment()
        {
            SetViewedItem(ReceiptListSearchShipment, "Shipment for GetReceiptList");
        }

        private void ShowReceiptListReceipt()
        {
            SetViewedItem(ReceiptArray, "ReceiptList from GetReceiptList");
        }

        private void ShowReceiptListV2Shipment()
        {
            SetViewedItem(ReceiptListV2SearchShipment, "Shipment for GetReceiptListV2");
        }

        private void ShowReceiptListV2Receipt()
        {
            SetViewedItem(ReceiptV2Array, "ReceiptList from GetReceiptListV2");
        }

        private void ShowSaveReceiptShipment()
        {
            SetViewedItem(ReceiptSaveShipment.ReceiptSave, "Shipment for SaveReceipt");
        }

        private void ShowSaveReceiptReceipt()
        {
            SetViewedItem(SaveReceipt, "Receipt for SaveReceipt");
        }

        private void ShowUpdateReceiptShipment()
        {
            SetViewedItem(ReceiptUpdateShipment.ReceiptSave, "Shipment for UpdateReceipt");
        }

        private void ShowUpdateReceiptReceipt()
        {
            SetViewedItem(UpdateReceipt, "Receipt for UpdateReceipt");
        }
        #region GetReceiptButtons
        private void btn_showGetReceiptShipment_Click(object sender, EventArgs e)
        {
            ShowGetReceiptShipment();
        }

        private void btn_LoadReceiptShipment_Click(object sender, EventArgs e)
        {
            ReceiptSearchShipment.ReceiptSearch = Functionality.IoFunctionality.GeneralizedLoadFile(ReceiptSearchShipment.ReceiptSearch);
        }

        private void btn_ShowGetReceipt_Click(object sender, EventArgs e)
        {
            ShowGetReceipt();
        }

        private void btn_SaveReceiptShipment_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptSearchShipment.ReceiptSearch);
        }

        private void btn_GetReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                GetReceipt();
                ShowGetReceipt();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetReceipt");
            }
        }

        private void btn_SaveGetReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptExt);
        }
        #endregion
        #region GetReceiptV2Buttons
        private void btn_ShowGetReceiptV2Shipment_Click(object sender, EventArgs e)
        {
            ShowGetReceiptV2Shipment();
        }

        private void btn_SaveGetReceiptV2Shipment_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptV2SearchShipment.ReceiptSearch);
        }

        private void btn_LoadGetReceiptV2Shipment_Click(object sender, EventArgs e)
        {
            ReceiptV2SearchShipment.ReceiptSearch = Functionality.IoFunctionality.GeneralizedLoadFile(ReceiptV2SearchShipment.ReceiptSearch);
        }

        private void btn_GetReceiptV2_Click(object sender, EventArgs e)
        {
            try
            {
                GetReceiptV2();
                ShowGetReceiptV2();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetReceiptV2");
            }
        }

        private void btn_ShowGetReceiptV2_Click(object sender, EventArgs e)
        {
            ShowGetReceiptV2();
        }

        private void btn_SaveGetReceiptV2_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptV2);
        }
        #endregion
        #region GetReceiptListButtons
        private void btn_ShowReceiptListShipment_Click(object sender, EventArgs e)
        {
            ShowReceiptListShipment();
        }

        private void btn_SaveReceiptListShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ReceiptListSearchShipment);
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptListSearchShipment);
        }

        private void btn_LoadReceiptListShipment_Click(object sender, EventArgs e)
        {
            ReceiptListSearchShipment = Functionality.IoFunctionality.GeneralizedLoadFile(ReceiptListSearchShipment);
        }

        private void btn_GetReceiptList_Click(object sender, EventArgs e)
        {
            try
            {
                GetReceiptList();
                ShowReceiptListReceipt();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetReceiptList");
            }
        }

        private void btn_ShowReceiptListReceipt_Click(object sender, EventArgs e)
        {
            ShowReceiptListReceipt();
        }

        private void btn_SaveReceiptList_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptList);
        }

        #endregion
        #region GetReceiptListV2Buttons
        private void btn_ShowReceiptListV2Shipment_Click(object sender, EventArgs e)
        {
            ShowReceiptListV2Shipment();
        }

        private void btn_SaveReceiptListV2Shipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ReceiptListV2SearchShipment);
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptListV2SearchShipment);
        }

        private void btn_LoadReceiptListV2Shipment_Click(object sender, EventArgs e)
        {
            ReceiptListV2SearchShipment = Functionality.IoFunctionality.GeneralizedLoadFile(ReceiptListV2SearchShipment);
        }

        private void btn_GetReceiptListV2_Click(object sender, EventArgs e)
        {
            try
            {
                GetReceiptListV2();
                ShowReceiptListV2Receipt();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetReceiptListV2");
            }
        }

        private void btn_ShowReceiptListV2_Click(object sender, EventArgs e)
        {
            ShowReceiptListV2Receipt();
        }

        private void btn_SaveReceiptListV2_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptListV2);
        }
        #endregion
        #region SaveReceiptButtons
        private void btn_ShowSaveReceiptShipment_Click(object sender, EventArgs e)
        {
            ShowSaveReceiptShipment();
        }

        private void btn_SaveSaveReceiptShipment_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptSaveShipment.ReceiptSave);
        }

        private void btn_LoadSaveReceiptShipment_Click(object sender, EventArgs e)
        {
            ReceiptSaveShipment.ReceiptSave = Functionality.IoFunctionality.GeneralizedLoadFile(ReceiptSaveShipment.ReceiptSave);
        }

        private void btn_SaveReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveReceiptInvoke();
                ShowSaveReceiptReceipt();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from SaveReceipt");
            }
        }

        private void btn_ShowSaveReceiptReceipt_Click(object sender, EventArgs e)
        {
            ShowSaveReceiptReceipt();
        }

        private void btn_SaveSaveReceiptReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(SaveReceipt);
        }
        #endregion
        #region UpdateReceiptButtons
        private void btn_ShowUpdateReceiptShipment_Click(object sender, EventArgs e)
        {
            ShowUpdateReceiptShipment();
        }

        private void btn_SaveUpdateReceiptShipment_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ReceiptUpdateShipment.ReceiptSave);
        }

        private void btn_LoadUpdateReceiptShipment_Click(object sender, EventArgs e)
        {
            ReceiptUpdateShipment.ReceiptSave = Functionality.IoFunctionality.GeneralizedLoadFile(ReceiptUpdateShipment.ReceiptSave);
        }

        private void btn_UpdateReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateReceiptInvoke();
                ShowUpdateReceiptReceipt();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from UpdateReceipt");
            }
        }

        private void btn_ShowUpdateReceipt_Click(object sender, EventArgs e)
        {
            ShowUpdateReceiptReceipt();
        }

        private void btn_SaveUpdateReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(UpdateReceipt);
        }
        #endregion
        private void btn_Test_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }
    }
}
