// <copyright file="IntermediaryTester.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>

using EC_Endpoint_Client.Service_References.IntermediaryInbound;
using EC_Endpoint_Client.Service_References.IntermediaryInboundStreamed;
using EC_Endpoint_Client.Service_References.Receipt;
using EC_Endpoint_Client.Service_References.ReceiptAgency;
using ReceiptSaveExternal = EC_Endpoint_Client.Service_References.Receipt.ReceiptSaveExternal;
using ReceiptSearchExternal = EC_Endpoint_Client.Service_References.Receipt.ReceiptSearchExternal;
using ReceiptTypeEnum = EC_Endpoint_Client.Service_References.Receipt.ReceiptTypeEnum;

namespace EC_Endpoint_Client.UserControls
{
    using System;
    using System.Windows.Forms;
    #region intermediary

    #endregion

    /// <summary>
    /// test test
    /// </summary>
    public partial class IntermediaryTester : UserControl
    {
        /// <summary>
        /// test test
        /// </summary>
        private string _soaUser = "SKDEN";

        /// <summary>
        /// test test
        /// </summary>
        private string _soaPass = "Altinn1234";

        /// <summary>
        /// test test
        /// </summary>
        private string _user = "ectest1";

        /// <summary>
        /// test test
        /// </summary>
        private string _pass = "test123";

        /// <summary>
        /// Initializes a new instance of the <see cref="IntermediaryTester"/> class. Test test
        /// </summary>
        public IntermediaryTester()
        {
            InitializeComponent();
        }

        /// <summary>
        /// test test
        /// </summary>
        /// <param name="sender">test test test test</param>
        /// <param name="e">test a</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            TestIi();
            TestIiStr();
            TestReceipt();
            TestReceiptAgency();
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestIi()
        {
            var client = new IntermediaryInboundExternalECClient("ST01");
            var x = client.SubmitFormTaskEC(_user, _pass, new FormTaskShipmentBE());
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestIiStr()
        {
            int a, c = 0;
            string b, d, e, f = string.Empty;
            var client = new IntermediaryInboundExternalECStreamedClient("ST01");
            client.SubmitAttachmentStreamedEC("test", "test", "test", "test", "test", 1, _pass, _user, null, out a, out b, out c, out d, out e, out f);
            client.Test();
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestReceipt()
        {
            var client = new ReceiptExternalECClient("ST01");
            var search = new ReceiptSearchExternal();
            search.ReceiptId = 10;
            var x = client.GetReceiptEC(_user, _pass, search);
            var y = client.GetReceiptListEC(_user, _pass, ReceiptTypeEnum.Correspondence, DateTime.Parse("2009-01-01"), DateTime.Parse("2020-01-01"));
            var z = client.SaveReceiptEC(_user, _pass, new ReceiptSaveExternal());
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestReceiptAgency()
        {
            var client = new ReceiptAgencyExternalECClient("ST01");
            var search = new Service_References.ReceiptAgency.ReceiptSearchExternal();
            search.ReceiptId = 10;
            var x = client.GetReceiptEC(_soaUser, _soaPass, search);
            var y = client.GetReceiptListEC(_soaUser, _soaPass, Service_References.ReceiptAgency.ReceiptTypeEnum.Correspondence, DateTime.Parse("2009-01-01"), DateTime.Parse("2020-01-01"));
            var save = new Service_References.ReceiptAgency.ReceiptSaveExternal();
            save.ReceiptText = "test";
            save.ReceiptId = 10;
            var z = client.SaveReceiptEC(_soaUser, _soaPass, save);
        }
    }
}
