
namespace PreTest
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
            this.btnDistance = new System.Windows.Forms.Button();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblHexa = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRectangleHeight = new System.Windows.Forms.TextBox();
            this.txtRectangleWidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCircleArea = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRectangleArea = new System.Windows.Forms.Label();
            this.lblRectangleConstruction = new System.Windows.Forms.Label();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.lstbxPerimeters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDistance
            // 
            this.btnDistance.Location = new System.Drawing.Point(13, 13);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(133, 23);
            this.btnDistance.TabIndex = 0;
            this.btnDistance.Text = "Determine distance";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(223, 38);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(10, 13);
            this.lblOctal.TabIndex = 1;
            this.lblOctal.Text = "-";
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Location = new System.Drawing.Point(223, 64);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(10, 13);
            this.lblHexa.TabIndex = 2;
            this.lblHexa.Text = "-";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(223, 13);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(10, 13);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "-";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(13, 105);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(133, 23);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Determine area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Distance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hexadecimal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Octal:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(155, 136);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Radius:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rectangle height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rectangle width:";
            // 
            // txtRectangleHeight
            // 
            this.txtRectangleHeight.Location = new System.Drawing.Point(155, 180);
            this.txtRectangleHeight.Name = "txtRectangleHeight";
            this.txtRectangleHeight.Size = new System.Drawing.Size(100, 20);
            this.txtRectangleHeight.TabIndex = 12;
            // 
            // txtRectangleWidth
            // 
            this.txtRectangleWidth.Location = new System.Drawing.Point(155, 217);
            this.txtRectangleWidth.Name = "txtRectangleWidth";
            this.txtRectangleWidth.Size = new System.Drawing.Size(100, 20);
            this.txtRectangleWidth.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Circle Area:";
            // 
            // lblCircleArea
            // 
            this.lblCircleArea.AutoSize = true;
            this.lblCircleArea.Location = new System.Drawing.Point(155, 268);
            this.lblCircleArea.Name = "lblCircleArea";
            this.lblCircleArea.Size = new System.Drawing.Size(10, 13);
            this.lblCircleArea.TabIndex = 15;
            this.lblCircleArea.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rectangle Area:";
            // 
            // lblRectangleArea
            // 
            this.lblRectangleArea.AutoSize = true;
            this.lblRectangleArea.Location = new System.Drawing.Point(155, 303);
            this.lblRectangleArea.Name = "lblRectangleArea";
            this.lblRectangleArea.Size = new System.Drawing.Size(10, 13);
            this.lblRectangleArea.TabIndex = 17;
            this.lblRectangleArea.Text = "-";
            // 
            // lblRectangleConstruction
            // 
            this.lblRectangleConstruction.AutoSize = true;
            this.lblRectangleConstruction.Location = new System.Drawing.Point(152, 347);
            this.lblRectangleConstruction.Name = "lblRectangleConstruction";
            this.lblRectangleConstruction.Size = new System.Drawing.Size(10, 13);
            this.lblRectangleConstruction.TabIndex = 18;
            this.lblRectangleConstruction.Text = "-";
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Location = new System.Drawing.Point(342, 12);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(187, 23);
            this.btnPerimeter.TabIndex = 19;
            this.btnPerimeter.Text = "Determine perimiter/Circumference";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // lstbxPerimeters
            // 
            this.lstbxPerimeters.FormattingEnabled = true;
            this.lstbxPerimeters.Location = new System.Drawing.Point(342, 64);
            this.lstbxPerimeters.Name = "lstbxPerimeters";
            this.lstbxPerimeters.Size = new System.Drawing.Size(187, 173);
            this.lstbxPerimeters.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 541);
            this.Controls.Add(this.lstbxPerimeters);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.lblRectangleConstruction);
            this.Controls.Add(this.lblRectangleArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCircleArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRectangleWidth);
            this.Controls.Add(this.txtRectangleHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblHexa);
            this.Controls.Add(this.lblOctal);
            this.Controls.Add(this.btnDistance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRectangleHeight;
        private System.Windows.Forms.TextBox txtRectangleWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCircleArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRectangleArea;
        private System.Windows.Forms.Label lblRectangleConstruction;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.ListBox lstbxPerimeters;
    }
}

