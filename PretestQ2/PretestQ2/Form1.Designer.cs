
namespace PretestQ2
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNumOfCymbals = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.txtCymablInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(51, 28);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNumOfCymbals
            // 
            this.btnNumOfCymbals.Location = new System.Drawing.Point(51, 58);
            this.btnNumOfCymbals.Name = "btnNumOfCymbals";
            this.btnNumOfCymbals.Size = new System.Drawing.Size(75, 23);
            this.btnNumOfCymbals.TabIndex = 1;
            this.btnNumOfCymbals.Text = "Set number of cymbals";
            this.btnNumOfCymbals.UseVisualStyleBackColor = true;
            this.btnNumOfCymbals.Click += new System.EventHandler(this.btnNumOfCymbals_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(51, 88);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFile.TabIndex = 2;
            this.btnWriteFile.Text = "Write to file";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // txtCymablInput
            // 
            this.txtCymablInput.Location = new System.Drawing.Point(133, 60);
            this.txtCymablInput.Name = "txtCymablInput";
            this.txtCymablInput.Size = new System.Drawing.Size(100, 20);
            this.txtCymablInput.TabIndex = 3;
            this.txtCymablInput.TextChanged += new System.EventHandler(this.txtCymablInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 380);
            this.Controls.Add(this.txtCymablInput);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnNumOfCymbals);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNumOfCymbals;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.TextBox txtCymablInput;
    }
}

