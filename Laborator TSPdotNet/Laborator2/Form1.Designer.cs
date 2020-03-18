namespace Laborator2
{
    partial class Form1
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
            this.Equal = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonSubstract = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Number0 = new System.Windows.Forms.Button();
            this.realDot = new System.Windows.Forms.Button();
            this.ButtonNewResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(245, 376);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(155, 73);
            this.Equal.TabIndex = 0;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(326, 256);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(75, 114);
            this.ButtonDivide.TabIndex = 1;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.OpperationButton_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(245, 256);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(75, 114);
            this.ButtonMultiply.TabIndex = 2;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.OpperationButton_Click);
            // 
            // ButtonSubstract
            // 
            this.ButtonSubstract.Location = new System.Drawing.Point(325, 139);
            this.ButtonSubstract.Name = "ButtonSubstract";
            this.ButtonSubstract.Size = new System.Drawing.Size(75, 111);
            this.ButtonSubstract.TabIndex = 3;
            this.ButtonSubstract.Text = "-";
            this.ButtonSubstract.UseVisualStyleBackColor = true;
            this.ButtonSubstract.Click += new System.EventHandler(this.OpperationButton_Click);
            // 
            // Number7
            // 
            this.Number7.Location = new System.Drawing.Point(1, 297);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(75, 73);
            this.Number7.TabIndex = 4;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(1, 218);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(75, 73);
            this.Number4.TabIndex = 5;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(82, 218);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(75, 73);
            this.Number5.TabIndex = 6;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(82, 139);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(75, 73);
            this.Number2.TabIndex = 7;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number9
            // 
            this.Number9.Location = new System.Drawing.Point(163, 297);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(75, 73);
            this.Number9.TabIndex = 8;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(163, 139);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(75, 73);
            this.Number3.TabIndex = 9;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number6
            // 
            this.Number6.Location = new System.Drawing.Point(163, 218);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(75, 73);
            this.Number6.TabIndex = 10;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(1, 139);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(75, 73);
            this.Number1.TabIndex = 11;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Number8
            // 
            this.Number8.Location = new System.Drawing.Point(82, 297);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(75, 73);
            this.Number8.TabIndex = 12;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(244, 139);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 111);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.OpperationButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(2, 23);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(398, 83);
            this.resultTextBox.TabIndex = 14;
            this.resultTextBox.Text = "0";
            // 
            // Number0
            // 
            this.Number0.Location = new System.Drawing.Point(82, 376);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(75, 73);
            this.Number0.TabIndex = 17;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // realDot
            // 
            this.realDot.Location = new System.Drawing.Point(163, 376);
            this.realDot.Name = "realDot";
            this.realDot.Size = new System.Drawing.Size(75, 73);
            this.realDot.TabIndex = 16;
            this.realDot.Text = ".";
            this.realDot.UseVisualStyleBackColor = true;
            this.realDot.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ButtonNewResult
            // 
            this.ButtonNewResult.Location = new System.Drawing.Point(1, 376);
            this.ButtonNewResult.Name = "ButtonNewResult";
            this.ButtonNewResult.Size = new System.Drawing.Size(75, 73);
            this.ButtonNewResult.TabIndex = 15;
            this.ButtonNewResult.Text = "C";
            this.ButtonNewResult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.realDot);
            this.Controls.Add(this.ButtonNewResult);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.ButtonSubstract);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.Equal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPreview = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonSubstract;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button realDot;
        private System.Windows.Forms.Button ButtonNewResult;
    }
}

