using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyPhotosClientWCF
{
    public partial class AddPropertyToFileForm : Form
    {
        MyPhotosClient client = new MyPhotosClient();

        AddNewFileForm parent;

        File workingFile = null;

        List<Property> allProperties;
        ListViewItem currentlySelectedItem = null;

        public AddPropertyToFileForm(AddNewFileForm Parent, File file)
        {
            InitializeComponent();
            parent = Parent;
            InitializeData(file);
        }

        private void InitializeData(File file)
        {
            workingFile = file;
            UpdateData();
        }

        internal void UpdateData()
        {
            PropertyList.Items.Clear();
            allProperties = client.GetAllProperties();
            foreach (Property p in allProperties)
            {
                ListViewItem currentPropertyRow = new ListViewItem(p.Title);
                currentPropertyRow.SubItems.Add(p.Type);
                currentPropertyRow.SubItems.Add(p.Description);
                PropertyList.Items.Add(currentPropertyRow);
            }
            currentlySelectedItem = null;
            ValueTextBox.Text = "";
        }

        private void PropertyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PropertyList.SelectedItems.Count > 0)
            {
                currentlySelectedItem = PropertyList.SelectedItems[0];
                PropertyValueLabel.Text = currentlySelectedItem.Text;
            }
        }

        private void CreatePropertyButton_Click(object sender, EventArgs e)
        {
            CreatePropertyForm createPropertyFrom = new CreatePropertyForm(this);
            createPropertyFrom.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            parent.UpdateData();
            this.Close();

        }

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            string propertyValue = ValueTextBox.Text;
            Property selectedProperty = client.GetPropertyByTitle(currentlySelectedItem.Text);
            if (client.ValidateDataType(selectedProperty.Type, propertyValue))
            {
                FileProperty newFileProperty = client.CreateFileProperty(workingFile.Id, selectedProperty.Id, propertyValue);
                client.AddFilePropertyToFile(newFileProperty);
                parent.UpdateData();
            }
        }
    }
}
