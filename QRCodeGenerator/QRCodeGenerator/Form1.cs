using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {


            QRCoder.QRCodeGenerator QRGen = new QRCoder.QRCodeGenerator();
            var InputData = QRGen.CreateQrCode(txtQRInfo.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var MyQRCode = new QRCoder.QRCode(InputData);
            picbxQRCode.Image = MyQRCode.GetGraphic(50);
        
        }
    }
}
