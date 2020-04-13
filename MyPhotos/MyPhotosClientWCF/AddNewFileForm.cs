using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotosClientWCF;

namespace MyPhotosClientWCF
{
    public partial class AddNewFileForm : Form
    {
        MyPhotosClient client = new MyPhotosClient();

        private Bitmap currentPictureBitmap;
        private string fileName;
        private string filePath;

        File workingFile = null;
        public bool fileSaved = false;

        private List<Property> currentPropertiesList;
        private MainWindowForm parentReference;

        public AddNewFileForm(File file, MainWindowForm parent)
        {
            parentReference = parent;
            InitializeComponent();

            ImportDataFromFile(file);
        }

        private void ImportDataFromFile(File file)
        {
            fileName = file.Name;
            filePath = file.Path;

            workingFile = file;

            FileNameTextBox.Text = fileName;
            FilePathTextBox.Text = filePath;

            if (currentPictureBitmap != null)
                currentPictureBitmap.Dispose();
            currentPictureBitmap = new Bitmap(filePath);

            PicturePreviewBox.SizeMode = PictureBoxSizeMode.Zoom;
            PicturePreviewBox.Image = currentPictureBitmap;

            UpdateData();

        }

        internal void UpdateData()
        {
            //fileController.AddFile(workingFile);
            //fileSaved = true;
            PropertyList.Items.Clear();
            currentPropertiesList = client.GetPropertiesForFileId(workingFile.Id).ToList();
            foreach (Property p in currentPropertiesList)
            {
                ListViewItem currentPropertyRow = new ListViewItem(p.Title);
                currentPropertyRow.SubItems.Add(p.Type);
                currentPropertyRow.SubItems.Add(p.Description);

                string propertyValue = client.GetValueByFileIdAndPropertyId(workingFile.Id, p.Id);

                currentPropertyRow.SubItems.Add(propertyValue);
                PropertyList.Items.Add(currentPropertyRow);
            }
        }

        private void SubmitFileButton_Click(object sender, EventArgs e)
        {
            if(client.GetFileById(workingFile.Id) == null)
            {
                workingFile.Name = FileNameTextBox.Text;
                client.AddFile(workingFile);
                fileSaved = true;
            }
            parentReference.UpdateData();
            this.Close();
        }

        private void AddNewPropertyButton_Click(object sender, EventArgs e)
        {
            if (fileSaved)
            {
                AddPropertyToFileForm addPropertyForm = new AddPropertyToFileForm(this, workingFile);
                addPropertyForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("File needs to be saved before adding a new property, save file now?", "Save File", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    workingFile.Name = FileNameTextBox.Text;
                    client.AddFile(workingFile);
                    fileSaved = true;
                    AddPropertyToFileForm addPropertyForm = new AddPropertyToFileForm(this, workingFile);
                    addPropertyForm.Show();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
