﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos;

namespace MyPhotosClient
{
    public partial class MainWindowForm : Form
    {
        PropertyController propertyController = new PropertyController();
        FileController fileController = new FileController();
        FilePropertyController filePropertyController = new FilePropertyController();

        MyPhotos.File[] fileList;
        MyPhotos.Property[] propertyList;

        private OpenFileDialog openFileDialog;
        private MyPhotos.File workingFile = null;
        private MyPhotos.Property selectedProperty = null;
        private int selectedPropertyIndexInList = 0;
        List<Property> activeFilters = new List<Property>();

        Image previewImage;

        public MainWindowForm()
        {
            InitializeComponent();
            UpdateData();
        }

        internal void UpdateData()
        {
            FileList.Items.Clear();
            fileList = fileController.GetAllNonDeletedFiles().ToArray();
            fileList = fileList.OrderBy(e => e.CreatedAt).ToArray();

            fileList = FilterDataByActiveFilters(fileList.ToList()).ToArray();

            foreach(MyPhotos.File f in fileList)
            {
                if(f.Deleted == false)
                {
                    ListViewItem currentFileRow = new ListViewItem(f.Name);
                    currentFileRow.SubItems.Add(f.Path);
                    FileList.Items.Add(currentFileRow);
                }
            }
            PropertiesList.Items.Clear();
            propertyList = propertyController.GetAllProperties().ToArray();
            propertyList = propertyList.OrderBy(p => p.Id.ToString()).ToArray();

            foreach(MyPhotos.Property p in propertyList)
            {
                ListViewItem currentFilterRow = new ListViewItem(p.Title);
                currentFilterRow.SubItems.Add(p.Description);
                PropertiesList.Items.Add(currentFilterRow);
            }
        }

        private List<MyPhotos.File> FilterDataByActiveFilters(List<MyPhotos.File> fileList)
        {
            if (activeFilters.Count == 0)
                return fileList;
            List<MyPhotos.File> fileList2 = new List<MyPhotos.File>();
            foreach (MyPhotos.File f in fileList)
            {
                List<Property> fileProperties = filePropertyController.GetPropertiesForFileId(f.Id);
                foreach (Property p in activeFilters)
                {
                    Property foundProperty = fileProperties.Find(pr => pr.Id == p.Id);
                    if (foundProperty != null)
                        fileList2.Add(f);
                }
            }
            return fileList2;
        }

        private void AddNewFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog.FileName);
                    string fileData = sr.ReadToEnd();
                    MyPhotos.File workingFile = fileController.CreateNewFile(openFileDialog.FileName, openFileDialog.SafeFileName);
                    AddNewFileForm newFileForm = new AddNewFileForm(workingFile, this);
                    newFileForm.Show();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileList.SelectedItems.Count > 0)
            {
                workingFile = fileList[FileList.SelectedItems[0].Index];
                previewImage = new Bitmap(workingFile.Path);
                if (previewImage != null)
                    PicturePreview.Image = previewImage;
            }
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            bool result = fileController.DeleteFile(workingFile.Id);
            PicturePreview.Image = null;
            UpdateData();
        }

        private void EditFileButton_Click(object sender, EventArgs e)
        {
            AddNewFileForm editFileForm = new AddNewFileForm(workingFile, this);
            editFileForm.fileSaved = true;
            editFileForm.Show();
        }

        private void AddFilterButton_Click(object sender, EventArgs e)
        {
            if (activeFilters.Find(p => p.Id == selectedProperty.Id) == null)
            {
                if(PropertiesList.SelectedItems.Count > 0)
                {
                    ListViewItem currentFilter = new ListViewItem(selectedProperty.Title);
                    ActiveFiltersList.Items.Add(currentFilter);
                    activeFilters.Add(selectedProperty);
                    PropertiesList.SelectedItems[0].ForeColor = Color.Green;
                    UpdateData();
                }
            }
        }

        private void RemoveFilterButton_Click(object sender, EventArgs e)
        {
            if (activeFilters.Find(p => p.Id == selectedProperty.Id) != null)
            {
                if(PropertiesList.SelectedItems.Count > 0)
                {
                    
                    activeFilters.Remove(selectedProperty);
                    PropertiesList.SelectedItems[0].ForeColor = Control.DefaultForeColor;
                    UpdateData();

                    foreach (ListViewItem filter in ActiveFiltersList.Items)
                    {
                        if (filter.Text == selectedProperty.Title)
                            ActiveFiltersList.Items.Remove(filter);
                    }
                }
            }
        }

        private void PropertiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PropertiesList.SelectedItems.Count > 0)
            {
                selectedPropertyIndexInList = PropertiesList.SelectedItems[0].Index;
                selectedProperty = propertyList[selectedPropertyIndexInList];
            }
        }
    }
}
