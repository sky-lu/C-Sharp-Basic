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

namespace midtermCT2HonglinLu
{
    public partial class frmStudentsManagement : Form
    {
        public frmStudentsManagement()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        List<clsStudent> tabStuds = new List<clsStudent>();
        Int16 current, nbStud;
        String mode = "";
        private void FileToArray()
        {
            StreamReader myFile = new StreamReader("Students.txt");
            while (myFile.EndOfStream == false)
            {
                String number = myFile.ReadLine();
                String name = myFile.ReadLine();
                Int16 day = Convert.ToInt16(myFile.ReadLine());
                Int16 month = Convert.ToInt16(myFile.ReadLine());
                Int16 year = Convert.ToInt16(myFile.ReadLine());
                Single avg = Convert.ToSingle(myFile.ReadLine());
                clsStudent ST1 = new clsStudent(number, name, day, month, year, avg);
                tabStuds.Add(ST1);
                ST1 = null;
            }
            myFile.Close();
        }

        private void Array2txt(Int16 anyIndex)
        {
            txtNumber.Text = tabStuds[anyIndex].Number;
            txtName.Text = tabStuds[anyIndex].Name;
            datBirthday.Value = Convert.ToDateTime(tabStuds[anyIndex].Birthdate.DisplayLong());
            txtAverage.Text = tabStuds[anyIndex].Average.ToString();
            lblAge.Text = tabStuds[current].Age.ToString();
            lblInfo.Text = " Student " + (anyIndex + 1) + " on a total of " + nbStud;
        }

        private void ActivateButtons(Button anyButton)
        {
            if (anyButton == btnCancel || anyButton == btnSave)
            {
                btnSave.Enabled = btnCancel.Enabled = false;
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnFirst.Enabled = btnPrevious.Enabled =
                    btnNext.Enabled = btnLast.Enabled = true;

            }
            else
            {
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnFirst.Enabled = btnPrevious.Enabled =
                    btnNext.Enabled = btnLast.Enabled = false;
                btnSave.Enabled = btnCancel.Enabled = true;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (nbStud > 0)
            {
                current = 0;
                Array2txt(current);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (nbStud > 0)
            {
                current = Convert.ToInt16(nbStud - 1);
                Array2txt(current);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                current--;
                Array2txt(current);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current < nbStud - 1)
            {
                current++;
                Array2txt(current);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActivateButtons(btnCancel);
            Array2txt(current);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActivateButtons(btnAdd);
            mode = "add";
            txtNumber.Clear();
            txtName.Clear();
            txtNumber.Focus();
            datBirthday.ResetText();
            txtAverage.Clear();
            lblAge.Text = "";
            lblInfo.Text = "ADDING MODE";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtName.Focus();
            lblInfo.Text = "EDITNG MODE";
            ActivateButtons(btnEdit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            string name = txtName.Text;
            Int16 day = (Int16)datBirthday.Value.Day;
            Int16 month = (Int16)datBirthday.Value.Month;
            Int16 year = (Int16)datBirthday.Value.Year;
            Single avg = Convert.ToSingle(txtAverage.Text);
            if (mode == "add")
            {
                tabStuds.Add(new clsStudent(number, name, day, month, year, avg));
                current = nbStud;
                nbStud++;
            }
            if (mode == "edit")
            {
                current = current;
                tabStuds.RemoveAt(current);
                tabStuds.Insert(current, new clsStudent(number, name, day, month, year, avg));
            }
            
            mode = "";
            Array2txt(current);
            ActivateButtons(btnSave);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drTemp = MessageBox.Show("Are you sure to delete this student?", "Delete information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drTemp == DialogResult.Yes)
            {
                tabStuds.RemoveAt(current);
                nbStud--;
                Array2txt(current);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentsManagement_Load(object sender, EventArgs e)
        {
            this.FileToArray();
            nbStud = (Int16)tabStuds.Count;
            if (nbStud != 0)
            {
                current = 0;
                txtNumber.Text = tabStuds[current].Number;
                txtName.Text = tabStuds[current].Name;
                datBirthday.Value =Convert.ToDateTime(tabStuds[current].Birthdate.DisplayLong());
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblAge.Text = tabStuds[current].Age.ToString();
                lblInfo.Text = " Student 1 " + "on a total of " + nbStud;
            }
            else
            {
                lblInfo.Text = "These is no student in this class!";
            }
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = true;

        }
    }
}
