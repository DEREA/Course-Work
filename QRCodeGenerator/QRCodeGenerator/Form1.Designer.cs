
namespace QRCodeGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtQRInfo = new System.Windows.Forms.TextBox();
            this.picbxQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(489, 346);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQRInfo
            // 
            this.txtQRInfo.Location = new System.Drawing.Point(354, 349);
            this.txtQRInfo.Name = "txtQRInfo";
            this.txtQRInfo.Size = new System.Drawing.Size(100, 20);
            this.txtQRInfo.TabIndex = 1;
            // 
            // picbxQRCode
            // 
            this.picbxQRCode.Location = new System.Drawing.Point(26, 25);
            this.picbxQRCode.Name = "picbxQRCode";
            this.picbxQRCode.Size = new System.Drawing.Size(428, 303);
            this.picbxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxQRCode.TabIndex = 2;
            this.picbxQRCode.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 405);
            this.Controls.Add(this.picbxQRCode);
            this.Controls.Add(this.txtQRInfo);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtQRInfo;
        private System.Windows.Forms.PictureBox picbxQRCode;
    }
}

