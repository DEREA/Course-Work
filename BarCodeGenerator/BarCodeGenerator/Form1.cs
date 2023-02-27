using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string barCode = txtbxInputField.Text;
            try
            {

                Zen.Barcode.Code128BarcodeDraw bc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picbxBarCode.Image = bc.Draw(barCode, 60);

            }
            catch (Exception)
            {
            
            }


        }
    }
}
