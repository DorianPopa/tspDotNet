namespace MyPhotosClientWCF
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddNewFolderButton = new System.Windows.Forms.Button();
            this.AddNewFileButton = new System.Windows.Forms.Button();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.EditFileButton = new System.Windows.Forms.Button();
            this.DeleteFileButton = new System.Windows.Forms.Button();
            this.PropertiesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveFilterButton = new System.Windows.Forms.Button();
            this.AddFilterButton = new System.Windows.Forms.Button();
            this.ActiveFiltersList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.98988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.01012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel1.Controls.Add(this.FileList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.PicturePreview, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PropertiesList, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ActiveFiltersList, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.81424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.18576F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 696);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FileList
            // 
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.tableLayoutPanel1.SetColumnSpan(this.FileList, 2);
            this.FileList.Location = new System.Drawing.Point(710, 131);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(581, 512);
            this.FileList.TabIndex = 3;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 325;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AddNewFolderButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddNewFileButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(875, 649);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 44);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // AddNewFolderButton
            // 
            this.AddNewFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewFolderButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddNewFolderButton.Location = new System.Drawing.Point(3, 3);
            this.AddNewFolderButton.Name = "AddNewFolderButton";
            this.AddNewFolderButton.Size = new System.Drawing.Size(202, 38);
            this.AddNewFolderButton.TabIndex = 5;
            this.AddNewFolderButton.Text = "Add New Folder";
            this.AddNewFolderButton.UseVisualStyleBackColor = false;
            // 
            // AddNewFileButton
            // 
            this.AddNewFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewFileButton.BackColor = System.Drawing.Color.DarkGreen;
            this.AddNewFileButton.Location = new System.Drawing.Point(211, 3);
            this.AddNewFileButton.Name = "AddNewFileButton";
            this.AddNewFileButton.Size = new System.Drawing.Size(202, 38);
            this.AddNewFileButton.TabIndex = 4;
            this.AddNewFileButton.Text = "Add New File";
            this.AddNewFileButton.UseVisualStyleBackColor = false;
            this.AddNewFileButton.Click += new System.EventHandler(this.AddNewFileButton_Click);
            // 
            // PicturePreview
            // 
            this.PicturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePreview.Location = new System.Drawing.Point(3, 131);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(701, 512);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePreview.TabIndex = 7;
            this.PicturePreview.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel4.Controls.Add(this.EditFileButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteFileButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 649);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(701, 44);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // EditFileButton
            // 
            this.EditFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFileButton.Location = new System.Drawing.Point(203, 3);
            this.EditFileButton.Name = "EditFileButton";
            this.EditFileButton.Size = new System.Drawing.Size(495, 38);
            this.EditFileButton.TabIndex = 2;
            this.EditFileButton.Text = "Edit File";
            this.EditFileButton.UseVisualStyleBackColor = true;
            this.EditFileButton.Click += new System.EventHandler(this.EditFileButton_Click);
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFileButton.BackColor = System.Drawing.Color.Maroon;
            this.DeleteFileButton.Location = new System.Drawing.Point(3, 3);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(194, 38);
            this.DeleteFileButton.TabIndex = 1;
            this.DeleteFileButton.Text = "Delete File";
            this.DeleteFileButton.UseVisualStyleBackColor = false;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // PropertiesList
            // 
            this.PropertiesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertiesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.PropertiesList.Location = new System.Drawing.Point(875, 3);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(416, 122);
            this.PropertiesList.TabIndex = 10;
            this.PropertiesList.UseCompatibleStateImageBehavior = false;
            this.PropertiesList.View = System.Windows.Forms.View.Details;
            this.PropertiesList.SelectedIndexChanged += new System.EventHandler(this.PropertiesList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filter";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 278;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RemoveFilterButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.AddFilterButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(710, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(159, 122);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFilterButton.Location = new System.Drawing.Point(3, 65);
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(153, 54);
            this.RemoveFilterButton.TabIndex = 10;
            this.RemoveFilterButton.Text = "Remove Filter";
            this.RemoveFilterButton.UseVisualStyleBackColor = true;
            this.RemoveFilterButton.Click += new System.EventHandler(this.RemoveFilterButton_Click);
            // 
            // AddFilterButton
            // 
            this.AddFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilterButton.Location = new System.Drawing.Point(3, 3);
            this.AddFilterButton.Name = "AddFilterButton";
            this.AddFilterButton.Size = new System.Drawing.Size(153, 56);
            this.AddFilterButton.TabIndex = 9;
            this.AddFilterButton.Text = "Add Filter";
            this.AddFilterButton.UseVisualStyleBackColor = true;
            this.AddFilterButton.Click += new System.EventHandler(this.AddFilterButton_Click);
            // 
            // ActiveFiltersList
            // 
            this.ActiveFiltersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveFiltersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.ActiveFiltersList.Location = new System.Drawing.Point(3, 3);
            this.ActiveFiltersList.Name = "ActiveFiltersList";
            this.ActiveFiltersList.Size = new System.Drawing.Size(701, 122);
            this.ActiveFiltersList.TabIndex = 12;
            this.ActiveFiltersList.UseCompatibleStateImageBehavior = false;
            this.ActiveFiltersList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Active Filters";
            this.columnHeader5.Width = 692;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DeleteFileButton;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddNewFolderButton;
        private System.Windows.Forms.Button AddNewFileButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button EditFileButton;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListView PropertiesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button AddFilterButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button RemoveFilterButton;
        private System.Windows.Forms.ListView ActiveFiltersList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}