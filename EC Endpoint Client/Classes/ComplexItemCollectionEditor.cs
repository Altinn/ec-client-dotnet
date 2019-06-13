using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Classes
{
    public class MyCollectionEditor : CollectionEditor
    {
        public delegate void MyFormClosedEventHandler(object sender,
                                            FormClosedEventArgs e);
        public delegate void MyFormOpenCollection(object sender, FormClosedEventArgs e);
        public static event MyFormClosedEventHandler MyFormClosed;

        public MyCollectionEditor(Type type) : base(type) { }
        protected override CollectionForm CreateCollectionForm()
        {
            CollectionForm collectionForm = base.CreateCollectionForm();
            collectionForm.FormClosed += new FormClosedEventHandler(collection_FormClosed);
            return collectionForm;
        }

        void collection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MyFormClosed != null)
            {
                MyFormClosed(this, e);
            }
        }

        protected override object CreateInstance(Type itemType)
        {
            return base.CreateInstance(itemType);
        }
    }
}
