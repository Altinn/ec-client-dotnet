using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EC_Endpoint_Client.UserControls
{
    public partial class ReadOnlyPropertyGrid : PropertyGrid
    {
        private bool _readOnly = false;
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                SetObjectAsReadOnly(SelectedObject, _readOnly);
            }
        }

        public ReadOnlyPropertyGrid()
        {
            InitializeComponent();
        }

        protected override void OnSelectedObjectsChanged(EventArgs e)
        {
            SetObjectAsReadOnly(SelectedObject, _readOnly);
            base.OnSelectedObjectsChanged(e);
        }

        private void SetObjectAsReadOnly(object selectedObject, bool isReadOnly)
        {
            if (SelectedObject != null)
            {
                TypeDescriptor.AddAttributes(SelectedObject, new Attribute[] { new ReadOnlyAttribute(_readOnly) });
                Refresh();
            }
        }
    }
}
