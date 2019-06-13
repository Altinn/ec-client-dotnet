using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;
using EC_Endpoint_Client.Service_References.Receipt;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class ReceiptForm : BaseForms.ClientBaseForm
    {
        #region Fields
        private ReceiptEndPointFunctionality ReFunc { get; set; }
        public ReceiptExternal Receipt { get; set; }
        public ReceiptExternal SaveReceipt { get; set; }
        public Receipt ReceiptV2 { get; set; }
        public Receipt UpdateReceipt { get; set; }
        public ReceiptExternalList ReceiptList { get; set; }
        public ReceiptList ReceiptListV2 { get; set; }
        public ReceiptListSearchExternalShipment ReceiptListSearchShipment { get; set; }
        public ReceiptListV2SearchExternalShipment ReceiptListV2SearchShipment { get; set; }
        public ReceiptSearchExternalShipment ReceiptSearchShipment { get; set; }
        public ReceiptV2SearchExternalShipment ReceiptV2SearchShipment { get; set; }
        public ReceiptSaveExternalShipment ReceiptSaveShipment { get; set; }
        public ReceiptUpdateExternalShipment ReceiptUpdateShipment { get; set; }
        public BaseShipment TestShipment { get; set; }
        private ReceiptExternal[] ReceiptArray => ReceiptList.ToArray();
        private Receipt[] ReceiptV2Array => ReceiptListV2.ToArray();
        #endregion
        public ReceiptForm()
        {
            InitializeComponent();
            Receipt = new ReceiptExternal();
            ReceiptV2 = new Receipt();
            ReceiptList = new ReceiptExternalList();
            ReceiptListV2 = new ReceiptList();
            ReFunc = new ReceiptEndPointFunctionality();
            ReFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SaveReceipt = new ReceiptExternal();
            UpdateReceipt = new Receipt();
            ReceiptSearchShipment = new ReceiptSearchExternalShipment();
            ReceiptV2SearchShipment = new ReceiptV2SearchExternalShipment();
            ReceiptSaveShipment = new ReceiptSaveExternalShipment();
            ReceiptUpdateShipment = new ReceiptUpdateExternalShipment();
            ReceiptListSearchShipment = new ReceiptListSearchExternalShipment();
            ReceiptListV2SearchShipment = new ReceiptListV2SearchExternalShipment();
            SetupObjectsForPropertyGrid();
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Receipt), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptExternalList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptSaveExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region invokes
        private void Test()
        {
            SetBasicShipmentSettings(TestShipment);
            ReFunc.Test(TestShipment);
        }

        private void SaveReceiptInvoke()
        {
            SetBasicShipmentSettings(ReceiptSaveShipment);
            SaveReceipt = ReFunc.SaveReceipt(ReceiptSaveShipment);
        }

        private void UpdateReceiptInvoke()
        {
            SetBasicShipmentSettings(ReceiptUpdateShipment);
            UpdateReceipt = ReFunc.UpdateReceipt(ReceiptUpdateShipment);
        }

        private void GetReceipt()
        {
            SetBasicShipmentSettings(ReceiptSearchShipment);
            Receipt = ReFunc.GetReceipt(ReceiptSearchShipment);
        }

        private void GetReceiptV2()
        {
            SetBasicShipmentSettings(ReceiptV2SearchShipment);
            ReceiptV2 = ReFunc.GetReceiptV2(ReceiptV2SearchShipment);
        }

        private void GetReceiptList()
        {
            SetBasicShipmentSettings(ReceiptListSearchShipment);
            ReceiptList = ReFunc.GetReceiptList(ReceiptListSearchShipment);
        }

        private void GetReceiptListV2()
        {
            SetBasicShipmentSettings(ReceiptListV2SearchShipment);
            ReceiptListV2 = ReFunc.GetReceiptListV2(ReceiptListV2SearchShipment);
        }

        private void ShowGetReceiptShipment()
        {
            SetViewedItem(ReceiptSearchShipment.ReceiptSearch, "Shipment for GetReceipt");
        }

        private void ShowGetReceipt()
        {
            SetViewedItem(Receipt, "Receipt from GetReceipt");
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
        #endregion
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
                if (ex.InnerException != null)
                {
                    SetViewedItem(ex.InnerException, "Error from GetReceipt");
                }
                else
                {
                    SetViewedItem(ex, "Error from GetReceipt");
                }
            }
        }

        private void btn_SaveGetReceipt_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(Receipt);
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

        private void btn_ShowGetReceiptListV2_Click(object sender, EventArgs e)
        {
            ShowReceiptListV2Receipt();
        }

        private void btn_SaveGetReceiptListV2_Click(object sender, EventArgs e)
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
