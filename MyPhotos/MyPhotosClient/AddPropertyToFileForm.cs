using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosClient
{
    public partial class AddPropertyToFileForm : Form
    {
        PropertyController propertyController = new PropertyController();
        FileController fileController = new FileController();
        FilePropertyController filePropertyController = new FilePropertyController();

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
            allProperties = propertyController.GetAllProperties();
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
            Property selectedProperty = propertyController.GetPropertyByTitle(currentlySelectedItem.Text);
            if (propertyController.ValidateDataType(selectedProperty.Type, propertyValue))
            {
                FileProperty newFileProperty = filePropertyController.CreateFileProperty(workingFile.Id, selectedProperty.Id, propertyValue);
                filePropertyController.AddFilePropertyToFile(newFileProperty);
                parent.UpdateData();
            }
        }
    }
}
