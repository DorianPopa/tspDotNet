using System;
using System.Linq;
using System.Windows.Forms;

namespace MyPhotosClientWCF
{
    public partial class CreatePropertyForm : Form
    {
        MyPhotosClient client = new MyPhotosClient();
        AddPropertyToFileForm ParentForm;

        public CreatePropertyForm(AddPropertyToFileForm parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string type = TypeListBox.CheckedItems[0].ToString();
            if (type == "Text") type = "string";
            else if (type == "Number") type = "int";
            else if (type == "Date, in (dd/mm/yyyy) format") type = "DateTime";

            Property newProperty = client.CreateProperty(TitleTextBox.Text, DescriptionTextBox.Text, type);
            client.AddProperty(newProperty);
            ParentForm.UpdateData();
            this.Close();
        }

        private void TypeListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < TypeListBox.Items.Count; ++ix)
                if (ix != e.Index) TypeListBox.SetItemChecked(ix, false);
        }
    }
}
