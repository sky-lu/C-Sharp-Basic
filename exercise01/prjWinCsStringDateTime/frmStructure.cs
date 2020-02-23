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
        private void frmStructure_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (i < 20) { 
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
            //txtNumber.Text = lstNumbers.SelectedItem.ToString();

        }
    }
}
