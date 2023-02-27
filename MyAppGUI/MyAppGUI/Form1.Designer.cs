namespace MyAppGUI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.tbctrlMain = new System.Windows.Forms.TabControl();
            this.tbpgLogin = new System.Windows.Forms.TabPage();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstbxStudentInfo = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbctrlMain.SuspendLayout();
            this.tbpgLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(126, 78);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 20);
            this.txtbxName.TabIndex = 0;
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Location = new System.Drawing.Point(126, 115);
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtbxSurname.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(39, 122);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(126, 217);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "BSC IT Student",
            "MLM Student",
            "Bcom Student"});
            this.cmbCourse.Location = new System.Drawing.Point(126, 154);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 5;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(39, 162);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course:";
            this.lblCourse.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbctrlMain
            // 
            this.tbctrlMain.Controls.Add(this.tbpgLogin);
            this.tbctrlMain.Controls.Add(this.tabPage2);
            this.tbctrlMain.Controls.Add(this.tabPage3);
            this.tbctrlMain.Controls.Add(this.tabPage4);
            this.tbctrlMain.Location = new System.Drawing.Point(13, 13);
            this.tbctrlMain.Name = "tbctrlMain";
            this.tbctrlMain.SelectedIndex = 0;
            this.tbctrlMain.Size = new System.Drawing.Size(320, 302);
            this.tbctrlMain.TabIndex = 7;
            // 
            // tbpgLogin
            // 
            this.tbpgLogin.Controls.Add(this.lblLogin);
            this.tbpgLogin.Controls.Add(this.cmbCourse);
            this.tbpgLogin.Controls.Add(this.lblCourse);
            this.tbpgLogin.Controls.Add(this.txtbxName);
            this.tbpgLogin.Controls.Add(this.txtbxSurname);
            this.tbpgLogin.Controls.Add(this.btnAccept);
            this.tbpgLogin.Controls.Add(this.lblName);
            this.tbpgLogin.Controls.Add(this.lblSurname);
            this.tbpgLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbpgLogin.Location = new System.Drawing.Point(4, 22);
            this.tbpgLogin.Name = "tbpgLogin";
            this.tbpgLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgLogin.Size = new System.Drawing.Size(312, 276);
            this.tbpgLogin.TabIndex = 0;
            this.tbpgLogin.Text = "HOME PAGE";
            this.tbpgLogin.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(41, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login:";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstbxStudentInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BSC_IT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstbxStudentInfo
            // 
            this.lstbxStudentInfo.FormattingEnabled = true;
            this.lstbxStudentInfo.Location = new System.Drawing.Point(3, 45);
            this.lstbxStudentInfo.Name = "lstbxStudentInfo";
            this.lstbxStudentInfo.Size = new System.Drawing.Size(198, 225);
            this.lstbxStudentInfo.TabIndex = 0;
            this.lstbxStudentInfo.SelectedIndexChanged += new System.EventHandler(this.lstbxStudentInfo_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(312, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MLM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(312, 276);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BCOM";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 325);
            this.Controls.Add(this.tbctrlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbctrlMain.ResumeLayout(false);
            this.tbpgLogin.ResumeLayout(false);
            this.tbpgLogin.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.TabPage tbpgLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstbxStudentInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

