using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Set { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedIndex = 0;
            tbctrlMain.SelectedTab = tabPage2;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            lblLogin.Font = new Font("Arial", 40, FontStyle.Bold);
            tbctrlMain.SelectedIndex = 1;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            tbctrlMain.SelectedIndex = 1;
            Student newStudent = new Student();
            newStudent.setName(txtbxName.Text);
            newStudent.setSurname(txtbxSurname.Text);

            if (cmbCourse.SelectedIndex == 0)
            {//BSC IT
                tbctrlMain.SelectedIndex = 1;
                var newSt = new Student.BSCITStudent();
                newSt.setName(newStudent.getName());
                newSt.setSurname(newStudent.getSurname());
                // lstbxStudentInfo.Items.Insert(newSt.getName);
                lstbxStudentInfo.Items.Add(newSt.getName());
                lstbxStudentInfo.Items.Add(newSt.getSurname());

                lstbxStudentInfo.Items.Add(newSt);

            }
            else if (cmbCourse.SelectedIndex == 1)
            {//MLM
                tbctrlMain.SelectedIndex = 2;
                var newSt = new Student.MLMStudent();

            }
            else if(cmbCourse.SelectedIndex == 2)
            {//BCOM 
                tbctrlMain.SelectedIndex = 3;
                var newSt = new Student.BcomStudent();
            }
        }

        private void lstbxStudentInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Student.BSCITStudent newSt= new Student.BSCITStudent();
            lstbxStudentInfo.Update();//Does not work 
           // tabPage2.setEnabled(true); 
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
