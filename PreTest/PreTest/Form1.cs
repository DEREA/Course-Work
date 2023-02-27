using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PreTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamWriter sw;
            sw = File.CreateText("G:\\log.txt");
            sw.WriteLine(DateTime.Now.ToString());
            sw.Close();

        }

        private void btnDistance_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            int height1 = rand.Next(0,25);
            int height2 = rand.Next(0, 25);

            int width1 = rand.Next(0, 80);
            int width2 = rand.Next(0, 80);

            double distance;
            double finaldist;
            int intdist;

            if (height1 == height2 && width1 == width2)
            {
                MessageBox.Show("These are at the same coordinates");
            }

            else 
            {

                distance= Math.Sqrt((Math.Pow(width1 - width2, 2) + Math.Pow(height1 - height2, 2)));
                finaldist = Math.Round(distance,0);
                intdist = Convert.ToInt32(finaldist);
                lblDistance.Text = "" + finaldist;
                lblOctal.Text = Convert.ToString(intdist,8);
                lblHexa.Text = string.Format("{0:x}",intdist);

            }



        }

        private void btnArea_Click(object sender, EventArgs e)
        {

            double radius;
            try 
            {
                radius = Convert.ToDouble(txtRadius.Text);
                double circleArea;
                circleArea = (3.14159) * radius * radius;
                lblCircleArea.Text = "" + circleArea;
            }
            


            catch 
            {
                MessageBox.Show("No radius entered");
            }

            double height;
            double width;

            try
            {
                height = Convert.ToDouble(txtRectangleHeight.Text);
                width = Convert.ToDouble(txtRectangleWidth.Text);
                double Rectanglearea = width * height;
                lblRectangleArea.Text = "" + Rectanglearea;
                lblRectangleConstruction.Text = "";
                for (int i=0;i<height;i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        lblRectangleConstruction.Text = lblRectangleConstruction.Text + "*";
                    }
                    lblRectangleConstruction.Text = lblRectangleConstruction.Text +"\n";
                }

            }

            catch 
            {
                MessageBox.Show("Missing height or width value for rectangle area calculation");
            }
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int Swcase = rand.Next(1, 3);

            switch (Swcase) 
            {
                case 1:
                    //circumference
                    double radius = rand.Next(1,10);
                    double circumference = 2 * 3.14159 * radius;
                    lstbxPerimeters.Items.Add(circumference);
                     break;

                case 2:
                    //rectangle perimeter
                    double height = rand.Next(1,10);
                    double width = rand.Next(1, 10);
                    double rectanglePerimeter = width*height ;
                    lstbxPerimeters.Items.Add(rectanglePerimeter);
                    break;

                case 3:
                    //triangle perimeter
                    double side1 = rand.Next(1,10);
                    double side2 = rand.Next(1, 10);
                    double side3 = rand.Next(1, 10);
                    double trianglePerimeter = side1 + side2 + side3;
                    lstbxPerimeters.Items.Add(trianglePerimeter);
                    break;
            
            }

        }
    }
}
