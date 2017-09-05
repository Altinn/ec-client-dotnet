// <copyright file="IntermediaryTester.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace EC_Endpoint_Client.UserControls
{
    using System;
    using System.Windows.Forms;
    #region intermediary
    using EC_Endpoint_Client.IntermediaryInbound;
    using EC_Endpoint_Client.IntermediaryInboundStreamed;
    using EC_Endpoint_Client.Receipt;
    using EC_Endpoint_Client.ReceiptAgency;
    #endregion

    /// <summary>
    /// test test
    /// </summary>
    public partial class IntermediaryTester : UserControl
    {
        /// <summary>
        /// test test
        /// </summary>
        private string soaUser = "SKDEN";

        /// <summary>
        /// test test
        /// </summary>
        private string soaPass = "Altinn1234";

        /// <summary>
        /// test test
        /// </summary>
        private string user = "ectest1";

        /// <summary>
        /// test test
        /// </summary>
        private string pass = "test123";

        /// <summary>
        /// Initializes a new instance of the <see cref="IntermediaryTester"/> class. Test test
        /// </summary>
        public IntermediaryTester()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// test test
        /// </summary>
        /// <param name="sender">test test test test</param>
        /// <param name="e">test a</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            this.TestII();
            this.TestIIStr();
            this.TestReceipt();
            this.TestReceiptAgency();
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestII()
        {
            var client = new IntermediaryInboundExternalECClient("ST01");
            var x = client.SubmitFormTaskEC(this.user, this.pass, new FormTaskShipmentBE());
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestIIStr()
        {
            int a, c = 0;
            string b, d, e, f = string.Empty;
            var client = new IntermediaryInboundExternalECStreamedClient("ST01");
            client.SubmitAttachmentStreamedEC("test", "test", "test", "test", "test", 1, this.pass, this.user, null, out a, out b, out c, out d, out e, out f);
            client.Test();
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestReceipt()
        {
            var client = new ReceiptExternalECClient("ST01");
            var search = new EC_Endpoint_Client.Receipt.ReceiptSearchExternal();
            search.ReceiptId = 10;
            var x = client.GetReceiptEC(this.user, this.pass, search);
            var y = client.GetReceiptListEC(this.user, this.pass, EC_Endpoint_Client.Receipt.ReceiptTypeEnum.Correspondence, DateTime.Parse("2009-01-01"), DateTime.Parse("2020-01-01"));
            var z = client.SaveReceiptEC(this.user, this.pass, new EC_Endpoint_Client.Receipt.ReceiptSaveExternal());
        }

        /// <summary>
        /// test test
        /// </summary>
        private void TestReceiptAgency()
        {
            var client = new ReceiptAgencyExternalECClient("ST01");
            var search = new ReceiptAgency.ReceiptSearchExternal();
            search.ReceiptId = 10;
            var x = client.GetReceiptEC(this.soaUser, this.soaPass, search);
            var y = client.GetReceiptListEC(this.soaUser, this.soaPass, ReceiptAgency.ReceiptTypeEnum.Correspondence, DateTime.Parse("2009-01-01"), DateTime.Parse("2020-01-01"));
            var save = new ReceiptAgency.ReceiptSaveExternal();
            save.ReceiptText = "test";
            save.ReceiptId = 10;
            var z = client.SaveReceiptEC(this.soaUser, this.soaPass, save);
        }
    }
}
