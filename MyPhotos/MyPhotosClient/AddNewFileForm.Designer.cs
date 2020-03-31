namespace MyPhotosClient
{
    partial class AddNewFileForm
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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PropertyList = new System.Windows.Forms.ListView();
            this.PropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropertyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropertyDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPropertiesLabel = new System.Windows.Forms.Label();
            this.AddNewPropertyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitFileButton = new System.Windows.Forms.Button();
            this.PicturePreviewBox = new System.Windows.Forms.PictureBox();
            this.MainTableLayout.SuspendLayout();
            this.FileInfoLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayout.Controls.Add(this.FileInfoLayout, 1, 0);
            this.MainTableLayout.Controls.Add(this.CancelButton, 0, 1);
            this.MainTableLayout.Controls.Add(this.SubmitFileButton, 1, 1);
            this.MainTableLayout.Controls.Add(this.PicturePreviewBox, 0, 0);
            this.MainTableLayout.Location = new System.Drawing.Point(12, 12);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 3;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Size = new System.Drawing.Size(1256, 663);
            this.MainTableLayout.TabIndex = 0;
            // 
            // FileInfoLayout
            // 
            this.FileInfoLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileInfoLayout.ColumnCount = 2;
            this.FileInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileInfoLayout.Controls.Add(this.PropertyList, 0, 3);
            this.FileInfoLayout.Controls.Add(this.FilePathTextBox, 1, 1);
            this.FileInfoLayout.Controls.Add(this.FileNameLabel, 0, 0);
            this.FileInfoLayout.Controls.Add(this.FilePathLabel, 0, 1);
            this.FileInfoLayout.Controls.Add(this.FileNameTextBox, 1, 0);
            this.FileInfoLayout.Controls.Add(this.CurrentPropertiesLabel, 0, 2);
            this.FileInfoLayout.Controls.Add(this.AddNewPropertyButton, 0, 4);
            this.FileInfoLayout.Location = new System.Drawing.Point(756, 3);
            this.FileInfoLayout.Name = "FileInfoLayout";
            this.FileInfoLayout.RowCount = 5;
            this.FileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.FileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.FileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.FileInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FileInfoLayout.Size = new System.Drawing.Size(497, 585);
            this.FileInfoLayout.TabIndex = 3;
            // 
            // PropertyList
            // 
            this.PropertyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PropertyName,
            this.PropertyType,
            this.PropertyDescription,
            this.Value});
            this.FileInfoLayout.SetColumnSpan(this.PropertyList, 2);
            this.PropertyList.Location = new System.Drawing.Point(3, 280);
            this.PropertyList.MultiSelect = false;
            this.PropertyList.Name = "PropertyList";
            this.PropertyList.Size = new System.Drawing.Size(491, 256);
            this.PropertyList.TabIndex = 7;
            this.PropertyList.UseCompatibleStateImageBehavior = false;
            this.PropertyList.View = System.Windows.Forms.View.Details;
            // 
            // PropertyName
            // 
            this.PropertyName.Text = "PropertyName";
            this.PropertyName.Width = 106;
            // 
            // PropertyType
            // 
            this.PropertyType.Text = "PropertyType";
            this.PropertyType.Width = 89;
            // 
            // PropertyDescription
            // 
            this.PropertyDescription.Text = "Property Description";
            this.PropertyDescription.Width = 225;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathTextBox.Location = new System.Drawing.Point(251, 150);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(243, 20);
            this.FilePathTextBox.TabIndex = 3;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(3, 47);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(242, 13);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "File Name:";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(3, 154);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(242, 13);
            this.FilePathLabel.TabIndex = 1;
            this.FilePathLabel.Text = "File Path:";
            this.FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTextBox.Location = new System.Drawing.Point(251, 43);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.FileNameTextBox.TabIndex = 0;
            // 
            // CurrentPropertiesLabel
            // 
            this.CurrentPropertiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentPropertiesLabel.AutoSize = true;
            this.FileInfoLayout.SetColumnSpan(this.CurrentPropertiesLabel, 2);
            this.CurrentPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPropertiesLabel.Location = new System.Drawing.Point(3, 235);
            this.CurrentPropertiesLabel.Name = "CurrentPropertiesLabel";
            this.CurrentPropertiesLabel.Size = new System.Drawing.Size(491, 20);
            this.CurrentPropertiesLabel.TabIndex = 4;
            this.CurrentPropertiesLabel.Text = "Current Properties";
            this.CurrentPropertiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNewPropertyButton
            // 
            this.AddNewPropertyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewPropertyButton.Location = new System.Drawing.Point(3, 542);
            this.AddNewPropertyButton.Name = "AddNewPropertyButton";
            this.AddNewPropertyButton.Size = new System.Drawing.Size(242, 40);
            this.AddNewPropertyButton.TabIndex = 6;
            this.AddNewPropertyButton.Text = "Add New Property";
            this.AddNewPropertyButton.UseVisualStyleBackColor = true;
            this.AddNewPropertyButton.Click += new System.EventHandler(this.AddNewPropertyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(3, 594);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 46);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitFileButton
            // 
            this.SubmitFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitFileButton.Location = new System.Drawing.Point(1121, 594);
            this.SubmitFileButton.Name = "SubmitFileButton";
            this.SubmitFileButton.Size = new System.Drawing.Size(132, 46);
            this.SubmitFileButton.TabIndex = 1;
            this.SubmitFileButton.Text = "Submit File";
            this.SubmitFileButton.UseVisualStyleBackColor = true;
            this.SubmitFileButton.Click += new System.EventHandler(this.SubmitFileButton_Click);
            // 
            // PicturePreviewBox
            // 
            this.PicturePreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePreviewBox.Location = new System.Drawing.Point(3, 3);
            this.PicturePreviewBox.Name = "PicturePreviewBox";
            this.PicturePreviewBox.Size = new System.Drawing.Size(747, 585);
            this.PicturePreviewBox.TabIndex = 2;
            this.PicturePreviewBox.TabStop = false;
            // 
            // AddNewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 678);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "AddNewFileForm";
            this.Text = "AddNewFileForm";
            this.MainTableLayout.ResumeLayout(false);
            this.FileInfoLayout.ResumeLayout(false);
            this.FileInfoLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitFileButton;
        private System.Windows.Forms.PictureBox PicturePreviewBox;
        private System.Windows.Forms.TableLayoutPanel FileInfoLayout;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label CurrentPropertiesLabel;
        private System.Windows.Forms.Button AddNewPropertyButton;
        private System.Windows.Forms.ListView PropertyList;
        private System.Windows.Forms.ColumnHeader PropertyName;
        private System.Windows.Forms.ColumnHeader PropertyType;
        private System.Windows.Forms.ColumnHeader PropertyDescription;
        private System.Windows.Forms.ColumnHeader Value;
    }
}