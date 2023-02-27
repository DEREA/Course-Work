
namespace BarCodeGenerator
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
            this.picbxBarCode = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtbxInputField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxBarCode
            // 
            this.picbxBarCode.Location = new System.Drawing.Point(12, 12);
            this.picbxBarCode.Name = "picbxBarCode";
            this.picbxBarCode.Size = new System.Drawing.Size(435, 316);
            this.picbxBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxBarCode.TabIndex = 0;
            this.picbxBarCode.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(372, 351);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbxInputField
            // 
            this.txtbxInputField.Location = new System.Drawing.Point(250, 353);
            this.txtbxInputField.Name = "txtbxInputField";
            this.txtbxInputField.Size = new System.Drawing.Size(100, 20);
            this.txtbxInputField.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 402);
            this.Controls.Add(this.txtbxInputField);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.picbxBarCode);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbxBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxBarCode;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtbxInputField;
    }
}

