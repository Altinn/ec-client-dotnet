using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Receipt;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.Receipt;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class ReceiptForm : ClientBaseForm
    {
        private ReceiptEndPointFunctionality reFunc { get; set; }
        public ReceiptExternal Receipt { get; set; }
        public ReceiptExternal SaveReceipt { get; set; }
        public Receipt.Receipt ReceiptV2 { get; set; }
        public Receipt.Receipt UpdateReceipt { get; set; }
        public ReceiptExternalList ReceiptList { get; set; }
        public ReceiptList ReceiptListV2 { get; set; }
        public ReceiptListSearchExternalShipment receiptListSearchShipment { get; set; }
        public ReceiptListV2SearchExternalShipment receiptListV2SearchShipment { get; set; }
        public ReceiptSearchExternalShipment receiptSearchShipment { get; set; }
        public ReceiptV2SearchExternalShipment receiptV2SearchShipment { get; set; }
        public ReceiptSaveExternalShipment receiptSaveShipment { get; set; }
        public ReceiptUpdateExternalShipment receiptUpdateShipment { get; set; }
        public Classes.BaseShipment testShipment { get; set; }
        private ReceiptExternal[] ReceiptArray
        {
            get
            {
                return ReceiptList.ToArray();
            }
        }
        private Receipt.Receipt[] ReceiptV2Array
        {
            get
            {
                return ReceiptListV2.ToArray();
            }
        }
        public ReceiptForm()
        {
            InitializeComponent();
            Receipt = new ReceiptExternal();
            ReceiptV2 = new Receipt.Receipt();
            ReceiptList = new ReceiptExternalList();
            ReceiptListV2 = new ReceiptList();
            reFunc = new ReceiptEndPointFunctionality();
            reFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SaveReceipt = new ReceiptExternal();
            UpdateReceipt = new Receipt.Receipt();
            receiptSearchShipment = new ReceiptSearchExternalShipment();
            receiptV2SearchShipment = new ReceiptV2SearchExternalShipment();
            receiptSaveShipment = new ReceiptSaveExternalShipment();
            receiptUpdateShipment = new ReceiptUpdateExternalShipment();
            receiptListSearchShipment = new ReceiptListSearchExternalShipment();
            receiptListV2SearchShipment = new ReceiptListV2SearchExternalShipment();
            SetupObjectsForPropertyGrid();
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Receipt.Receipt), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptExternalList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptSaveExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(testShipment);
            reFunc.Test(testShipment);
        }

        private void SaveReceiptInvoke()
        {
            SetBasicShipmentSettings(receiptSaveShipment);
            SaveReceipt = reFunc.SaveReceipt(receiptSaveShipment);
        }

        private void UpdateReceiptInvoke()
        {
            SetBasicShipmentSettings(receiptUpdateShipment);
            UpdateReceipt = reFunc.UpdateReceipt(receiptUpdateShipment);
        }

        private void GetReceipt()
        {
            SetBasicShipmentSettings(receiptSearchShipment);
            Receipt = reFunc.GetReceipt(receiptSearchShipment);
        }

        private void GetReceiptV2()
        {
            SetBasicShipmentSettings(receiptV2SearchShipment);
            ReceiptV2 = reFunc.GetReceiptV2(receiptV2SearchShipment);
        }

        private void GetReceiptList()
        {
            SetBasicShipmentSettings(receiptListSearchShipment);
            ReceiptList = reFunc.GetReceiptList(receiptListSearchShipment);
        }

        private void GetReceiptListV2()
        {
            SetBasicShipmentSettings(receiptListV2SearchShipment);
            ReceiptListV2 = reFunc.GetReceiptListV2(receiptListV2SearchShipment);
        }

        private void ShowGetReceiptShipment()
        {
            SetViewedItem(receiptSearchShipment.ReceiptSearch, "Shipment for GetReceipt");
        }

        private void ShowGetReceipt()
        {
            SetViewedItem(Receipt, "Receipt from GetReceipt");
        }

        private void ShowGetReceiptV2Shipment()
        {
            SetViewedItem(receiptV2SearchShipment.ReceiptSearch, "Shipment for GetReceiptV2");
        }

        private void ShowGetReceiptV2()
        {
            SetViewedItem(ReceiptV2, "Receipt from GetReceiptV2");
        }

        private void ShowReceiptListShipment()
        {
            SetViewedItem(receiptListSearchShipment, "Shipment for GetReceiptList");
        }

        private void ShowReceiptListReceipt()
        {
            SetViewedItem(ReceiptArray, "ReceiptList from GetReceiptList");
        }

        private void ShowReceiptListV2Shipment()
        {
            SetViewedItem(receiptListV2SearchShipment, "Shipment for GetReceiptListV2");
        }

        private void ShowReceiptListV2Receipt()
        {
            SetViewedItem(ReceiptV2Array, "ReceiptList from GetReceiptListV2");
        }

        private void ShowSaveReceiptShipment()
        {
            SetViewedItem(receiptSaveShipment.ReceiptSave, "Shipment for SaveReceipt");
        }

        private void ShowSaveReceiptReceipt()
        {
            SetViewedItem(SaveReceipt, "Receipt for SaveReceipt");
        }

        private void ShowUpdateReceiptShipment()
        {
            SetViewedItem(receiptUpdateShipment.ReceiptSave, "Shipment for UpdateReceipt");
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
            receiptSearchShipment.ReceiptSearch = (ReceiptSearchExternal)Functionality.IOFunctionality.GeneralizedLoadFile(receiptSearchShipment.ReceiptSearch);
        }

        private void btn_ShowGetReceipt_Click(object sender, EventArgs e)
        {
            ShowGetReceipt();
        }

        private void btn_SaveReceiptShipment_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(receiptSearchShipment.ReceiptSearch);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(Receipt);
        }
        #endregion
        #region GetReceiptV2Buttons
        private void btn_ShowGetReceiptV2Shipment_Click(object sender, EventArgs e)
        {
            ShowGetReceiptV2Shipment();
        }

        private void btn_SaveGetReceiptV2Shipment_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(receiptV2SearchShipment.ReceiptSearch);
        }

        private void btn_LoadGetReceiptV2Shipment_Click(object sender, EventArgs e)
        {
            receiptV2SearchShipment.ReceiptSearch = (ReceiptSearchExternal)Functionality.IOFunctionality.GeneralizedLoadFile(receiptV2SearchShipment.ReceiptSearch);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(ReceiptV2);
        }
        #endregion
        #region GetReceiptListButtons
        private void btn_ShowReceiptListShipment_Click(object sender, EventArgs e)
        {
            ShowReceiptListShipment();
        }

        private void btn_SaveReceiptListShipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(receiptListSearchShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(receiptListSearchShipment);
        }

        private void btn_LoadReceiptListShipment_Click(object sender, EventArgs e)
        {
            receiptListSearchShipment = (ReceiptListSearchExternalShipment)Functionality.IOFunctionality.GeneralizedLoadFile(receiptListSearchShipment);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(ReceiptList);
        }

        #endregion
        #region GetReceiptListV2Buttons
        private void btn_ShowReceiptListV2Shipment_Click(object sender, EventArgs e)
        {
            ShowReceiptListV2Shipment();
        }

        private void btn_SaveReceiptListV2Shipment_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(receiptListV2SearchShipment);
            Functionality.IOFunctionality.GeneralizedSaveFile(receiptListV2SearchShipment);
        }

        private void btn_LoadReceiptListV2Shipment_Click(object sender, EventArgs e)
        {
            receiptListV2SearchShipment = (ReceiptListV2SearchExternalShipment)Functionality.IOFunctionality.GeneralizedLoadFile(receiptListV2SearchShipment);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(ReceiptListV2);
        }
        #endregion
        #region SaveReceiptButtons
        private void btn_ShowSaveReceiptShipment_Click(object sender, EventArgs e)
        {
            ShowSaveReceiptShipment();
        }

        private void btn_SaveSaveReceiptShipment_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(receiptSaveShipment.ReceiptSave);
        }

        private void btn_LoadSaveReceiptShipment_Click(object sender, EventArgs e)
        {
            receiptSaveShipment.ReceiptSave = (ReceiptSaveExternal)Functionality.IOFunctionality.GeneralizedLoadFile(receiptSaveShipment.ReceiptSave);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(SaveReceipt);
        }
        #endregion
        #region UpdateReceiptButtons
        private void btn_ShowUpdateReceiptShipment_Click(object sender, EventArgs e)
        {
            ShowUpdateReceiptShipment();
        }

        private void btn_SaveUpdateReceiptShipment_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(receiptUpdateShipment.ReceiptSave);
        }

        private void btn_LoadUpdateReceiptShipment_Click(object sender, EventArgs e)
        {
            receiptUpdateShipment.ReceiptSave = (ReceiptSaveExternal)Functionality.IOFunctionality.GeneralizedLoadFile(receiptUpdateShipment.ReceiptSave);
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
            Functionality.IOFunctionality.GeneralizedSaveFile(UpdateReceipt);
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
