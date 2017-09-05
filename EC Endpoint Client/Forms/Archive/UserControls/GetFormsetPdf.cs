using System;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms.Archive.UserControls
{
    public partial class GetFormsetPdf : UserControl
    {
        public event EventHandler InvokeClick;

        public string ArchiveReference {
            get
            {
                return this.txbArchiveReference.Text;
            }
            set
            {
                this.txbArchiveReference.Text = value;
            }
        }

        public int LanguageId
        {
            get
            {
                object selectedValue = this.cobLanguageId.SelectedValue;
                if (selectedValue != null)
                {
                    int langId;
                    return int.TryParse(selectedValue.ToString(), out langId) ? langId : 1044;
                }
                
                return 1044;
            }
            set
            {
                if (this.cobLanguageId.Items.Contains(value))
                {
                    this.cobLanguageId.SelectedItem = value;
                }
            }
        }

        public GetFormsetPdf()
        {
            this.InitializeComponent();
        }

        // ReSharper disable once InconsistentNaming
        private void btnInvoke_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.InvokeClick;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
