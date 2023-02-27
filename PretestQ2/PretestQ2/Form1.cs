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

namespace PretestQ2
{
    public partial class Form1 : Form
    {
        // public int[] CymbalArr=new int[100];
        List<int> myList = new List<int>();
        public Form1()
        {
            InitializeComponent();
            btnNumOfCymbals.Enabled=false;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            guitar myguitar = new guitar();
            MessageBox.Show(myguitar.Play());
        }

        private void btnNumOfCymbals_Click(object sender, EventArgs e)
        {
            drums myDrums = new drums();
            myDrums.setNumOfCymbals(Convert.ToInt32(txtCymablInput.Text));
            MessageBox.Show("The drums have: "+myDrums.getNumOfCymbals()+" Cymbal/s");
            txtCymablInput.Clear();
            btnNumOfCymbals.Enabled = false;
            myList.Add(myDrums.getNumOfCymbals());
           /*
            for (int i=0;i< CymbalArr.Length;i++) 
            {
                if (CymbalArr[i]==0) 
                {
                    CymbalArr[i] = myDrums.getNumOfCymbals();
                    break;
                }
            }
           /*
            string arrPrint="";
            for (int i = 0; i < CymbalArr.Length; i++)
            {
                arrPrint = arrPrint + CymbalArr[i] + ",";
            }
            MessageBox.Show(arrPrint);
           */
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            sw = File.CreateText("G:\\CymbalsLog.txt");

            for (int i=0;i<myList.Count;i++)
            {
                sw.WriteLine(myList[i]);
            }
            sw.Close();

        }

        private void txtCymablInput_TextChanged(object sender, EventArgs e)
        {

           btnNumOfCymbals.Enabled = true;

        }
    }
}
