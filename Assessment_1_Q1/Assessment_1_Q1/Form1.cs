using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_1_Q1
{
    public partial class Form1 : Form
    {
        public DataTable table;
        public Form1()
        {

            InitializeComponent();
            this.dataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain.ReadOnly = true;
            
            table = new DataTable();

            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Surname", typeof(String));
            table.Columns.Add("PhoneNumber", typeof(String));
            table.Columns.Add("Address", typeof(String));

            table.Rows.Add("Parry","Potter","0843436427","56 Parma Lane");
            table.Rows.Add("Barry", "Botter", "123", "567");
            dataGridViewMain.DataSource = table;
            dataGridViewMain.Update();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=0 ;
            try
            {
                index = dataGridViewMain.SelectedRows[0].Index;
            }

            catch {
             
                index = -1;
            
            }

            if (index!=-1)
            {
                txtbxName.Text = dataGridViewMain.SelectedRows[0].Cells["Name"].Value.ToString();
                txtbxSurname.Text = dataGridViewMain.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtbxPhoneNumber.Text = dataGridViewMain.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                txtbxAddress.Text = dataGridViewMain.SelectedRows[0].Cells["Address"].Value.ToString();
            }
           
            else {
                ClearAll();
            }
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContactInfo saveContact = new ContactInfo();
            saveContact.SetName(txtbxName.Text);
            saveContact.SetSurname(txtbxSurname.Text);
            saveContact.SetPhoneNumber(txtbxPhoneNumber.Text);
            saveContact.SetAddress(txtbxAddress.Text);

           

          
            table.Rows.Add(saveContact.getName(), saveContact.getSurname(), saveContact.getPhoneNumber(), saveContact.getStreetAddress());
           
            dataGridViewMain.Update();

           

            MessageBox.Show("Added Successfully");
            ClearAll();
            
        }


        public void ClearAll() {

            txtbxName.Clear();
            txtbxSurname.Clear();
            txtbxPhoneNumber.Clear();
            txtbxAddress.Clear();
            dataGridViewMain.ClearSelection();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCount = dataGridViewMain.SelectedRows.Count;
            while (selectedCount > 0)
            {
                if (!dataGridViewMain.SelectedRows[0].IsNewRow)
                    dataGridViewMain.Rows.RemoveAt(dataGridViewMain.SelectedRows[0].Index);
                selectedCount--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            while (table.Rows.Count > 0)
            {
                dataGridViewMain.Rows.Remove(dataGridViewMain.Rows[0]);
            }
           
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
            int index = dataGridViewMain.SelectedRows[0].Index;

            dataGridViewMain[0,index].Value= txtbxName.Text;
            dataGridViewMain[1, index].Value = txtbxSurname.Text;
            dataGridViewMain[2, index].Value = txtbxPhoneNumber.Text;
            dataGridViewMain[3, index].Value = txtbxAddress.Text;

            ClearAll();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewMain.ClearSelection();
            for (int i=0;i<dataGridViewMain.Rows.Count-1;i++)
            {
                for (int j = 0; j <dataGridViewMain.Columns.Count; j++)
                {
                    if (dataGridViewMain.Rows[i].Cells[j].Value.Equals(txtbxSearch.Text))
                    {
                       // MessageBox.Show("Row:"+i+"Col:"+j);
                        dataGridViewMain.Rows[i].Selected = true;
                    }
                }



            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
