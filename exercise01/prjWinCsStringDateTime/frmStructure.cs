using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsStringDateTime
{
    public partial class frmStructure : Form
    {
        public frmStructure()
        {
            InitializeComponent();
        }


        struct Student
        {
            public String Name;
            public Single Grade;
            public String Number;
        }
        Student[] listStuds = new Student[20];
        Int32 i = 0;
        Int32 n = 0;
        private void frmStructure_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i < 20)
            {
                String number = txtNumber.Text.Trim();
                String name = txtName.Text.Trim();
                Single grade = Convert.ToSingle(txtGrade.Text);
                listStuds[i].Number = number;
                listStuds[i].Name = name;
                listStuds[i].Grade = grade;

                lstNumbers.Items.Add(number);
                txtNumber.Text = txtName.Text = txtGrade.Text = "";
                txtNumber.Focus();
                //txtNumber.Clear();
                //txtName.Clear();
                //txtGrade.Clear();
                i = i + 1;
            }
        }

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int j = 0; j < i; j++)
            {
                if(lstNumbers.SelectedItem != null && (lstNumbers.SelectedItem.ToString() == listStuds[j].Number))
                {
                    txtInfoNB.Text = listStuds[j].Number;
                    txtInfoName.Text = listStuds[j].Name;
                    txtInfoGrade.Text = listStuds[j].Grade.ToString();
                    n = j;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtInfoNB.BackColor = txtInfoName.BackColor = txtInfoGrade.BackColor = Color.Yellow;
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtInfoNB.BackColor = txtInfoName.BackColor = txtInfoGrade.BackColor = Color.Gray;
            listStuds[n].Number = txtInfoNB.Text;
            listStuds[n].Name = txtInfoName.Text;
            listStuds[n].Grade = Convert.ToSingle(txtInfoGrade.Text);
            lstNumbers.Items[lstNumbers.SelectedIndex] = txtInfoNB.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Are you sure to delete this student?", "Student Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
                txtInfoNB.Text = txtInfoName.Text = txtInfoGrade.Text = "";
                lstNumbers.Items.Remove(lstNumbers.SelectedItem);
                //listStuds[n].Number = listStuds[n].Name = "";
                
           }
        }
    }
}
