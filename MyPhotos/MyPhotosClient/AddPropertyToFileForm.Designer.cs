namespace MyPhotosClient
{
    partial class AddPropertyToFileForm
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
            this.PropertyValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.AddPropertyButton = new System.Windows.Forms.Button();
            this.CreatePropertyButton = new System.Windows.Forms.Button();
            this.PropertyList = new System.Windows.Forms.ListView();
            this.PropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropertyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PropertyDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.PropertyValueLabel, 0, 1);
            this.MainTableLayout.Controls.Add(this.ValueTextBox, 1, 1);
            this.MainTableLayout.Controls.Add(this.AddPropertyButton, 1, 3);
            this.MainTableLayout.Controls.Add(this.PropertyList, 0, 0);
            this.MainTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.MainTableLayout.Location = new System.Drawing.Point(12, 12);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 4;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.MainTableLayout.Size = new System.Drawing.Size(687, 440);
            this.MainTableLayout.TabIndex = 0;
            // 
            // PropertyValueLabel
            // 
            this.PropertyValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyValueLabel.AutoSize = true;
            this.PropertyValueLabel.Location = new System.Drawing.Point(3, 235);
            this.PropertyValueLabel.Name = "PropertyValueLabel";
            this.PropertyValueLabel.Size = new System.Drawing.Size(337, 13);
            this.PropertyValueLabel.TabIndex = 1;
            this.PropertyValueLabel.Text = "Property Value:";
            this.PropertyValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTextBox.Location = new System.Drawing.Point(346, 231);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(338, 20);
            this.ValueTextBox.TabIndex = 2;
            // 
            // AddPropertyButton
            // 
            this.AddPropertyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddPropertyButton.Location = new System.Drawing.Point(465, 372);
            this.AddPropertyButton.Name = "AddPropertyButton";
            this.AddPropertyButton.Size = new System.Drawing.Size(100, 50);
            this.AddPropertyButton.TabIndex = 3;
            this.AddPropertyButton.Text = "Add Property";
            this.AddPropertyButton.UseVisualStyleBackColor = true;
            this.AddPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // CreatePropertyButton
            // 
            this.CreatePropertyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreatePropertyButton.Location = new System.Drawing.Point(202, 15);
            this.CreatePropertyButton.Name = "CreatePropertyButton";
            this.CreatePropertyButton.Size = new System.Drawing.Size(100, 50);
            this.CreatePropertyButton.TabIndex = 5;
            this.CreatePropertyButton.Text = "Create New Property";
            this.CreatePropertyButton.UseVisualStyleBackColor = true;
            this.CreatePropertyButton.Click += new System.EventHandler(this.CreatePropertyButton_Click);
            // 
            // PropertyList
            // 
            this.PropertyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PropertyName,
            this.PropertyType,
            this.PropertyDescription});
            this.MainTableLayout.SetColumnSpan(this.PropertyList, 2);
            this.PropertyList.Location = new System.Drawing.Point(3, 3);
            this.PropertyList.MultiSelect = false;
            this.PropertyList.Name = "PropertyList";
            this.PropertyList.Size = new System.Drawing.Size(681, 201);
            this.PropertyList.TabIndex = 6;
            this.PropertyList.UseCompatibleStateImageBehavior = false;
            this.PropertyList.View = System.Windows.Forms.View.Details;
            this.PropertyList.SelectedIndexChanged += new System.EventHandler(this.PropertyList_SelectedIndexChanged);
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
            this.PropertyDescription.Width = 389;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(34, 15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 50);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Done";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CreatePropertyButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 357);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 80);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // AddPropertyToFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "AddPropertyToFileForm";
            this.Text = "AddPropertyToFileForm";
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Label PropertyValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Button AddPropertyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreatePropertyButton;
        private System.Windows.Forms.ListView PropertyList;
        private System.Windows.Forms.ColumnHeader PropertyName;
        private System.Windows.Forms.ColumnHeader PropertyType;
        private System.Windows.Forms.ColumnHeader PropertyDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}