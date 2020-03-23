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

namespace prjWinCsStringDateTime
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        struct Student
        {
            public String Name;
            public DateTime Birthdate;
            public Single Average;
        }
        Student[] tabStuds = new Student[50];
        Int16 current, nbStud;
        String mode = "";

        private Int16 FileToArray()
        {
            StreamReader myFile = new StreamReader("College.txt");
            Int16 i = 0;
            while(myFile.EndOfStream == false){
                String name = myFile.ReadLine();
                Int32 day = Convert.ToInt32(myFile.ReadLine());
                Int32 month = Convert.ToInt32(myFile.ReadLine());
                Int32 year = Convert.ToInt32(myFile.ReadLine());
                float avg = Convert.ToSingle(myFile.ReadLine());
                tabStuds[i].Name = name;
                tabStuds[i].Birthdate = new DateTime(year, month, day);
                tabStuds[i].Average = avg;
                i++;
            }
            myFile.Close();
            //MessageBox.Show(i.ToString());
            return i;
        }

        private void Array2txt(Int16 anyIndex)
        {
            txtFullName.Text = tabStuds[anyIndex].Name;
            datBirthday.Value = tabStuds[anyIndex].Birthdate;
            txtAverage.Text = tabStuds[anyIndex].Average.ToString();
            lblInfo.Text = " Student " + (anyIndex + 1) + " on a total of " + nbStud;
        }

        private void ActivateButtons(Button anyButton)
        {
            if(anyButton == btnCancel || anyButton == btnSave)
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
        private void frmFile_Load(object sender, EventArgs e)
        {
            nbStud = FileToArray();
            if(nbStud != 0) { 
                current = 0;
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student 1 " + "on a total of " + nbStud;
            }
            else
            {
                lblInfo.Text = "These is no student in this class!";
            }

            // Activate buttons
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = true;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if(nbStud > 0) { 
                current = 0 ;
                Array2txt(current);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if(nbStud > 0) { 
                current = Convert.ToInt16(nbStud - 1);
                Array2txt(current);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(current > 0)
            {
                current--;
                Array2txt(current);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(current < nbStud - 1)
            {
                current++;
                Array2txt(current);
            }
        }

        private void button5_Click(object sender, EventArgs e)//(Cancel-button)
        {
            //Activates buttons
            //btnAdd.Enabled = true;
            //btnEdit.Enabled = true;
            //btnDelete.Enabled = true;
            //btnSave.Enabled = false;
            //btnCancel.Enabled = false;
            //btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = true;
            ActivateButtons(btnCancel);
            Array2txt(current);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Activates buttons
            //btnAdd.Enabled = false;
            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
            //btnSave.Enabled = true;
            //btnCancel.Enabled = true;
            //btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = false;
            ActivateButtons(btnAdd);
            mode = "add";
            txtFullName.Clear();
            txtFullName.Focus();
            datBirthday.ResetText();
            txtAverage.Clear();
            lblInfo.Text = "ADDING MODE";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtFullName.Focus();
            lblInfo.Text = "EDITNG MODE";

            //btnAdd.Enabled = false;
            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
            //btnSave.Enabled = true;
            //btnCancel.Enabled = true;
            //btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = false;
            ActivateButtons(btnEdit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                if(nbStud < (50 - 1))//nbStud < 50
                {
                    current = nbStud;
                    nbStud++;
                }
            }
            if(mode == "edit")
            {
                current = current;
            }
            tabStuds[current].Name = txtFullName.Text;
            tabStuds[current].Birthdate = datBirthday.Value;
            tabStuds[current].Average = Convert.ToSingle(txtAverage.Text);
            mode = "";
            Array2txt(current);

            //btnAdd.Enabled = true;
            //btnEdit.Enabled = true;
            //btnDelete.Enabled = true;
            //btnSave.Enabled = false;
            //btnCancel.Enabled = false;
            //btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = true;
            ActivateButtons(btnSave);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drTemp = MessageBox.Show("Are you sure to delete this student?", "Delete information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(drTemp == DialogResult.Yes)
            {
                for(Int32 i = current; i < nbStud-1; i++)
                {
                    tabStuds[i].Name = tabStuds[i + 1].Name;
                    tabStuds[i].Birthdate = tabStuds[i + 1].Birthdate;
                    tabStuds[i].Average = tabStuds[i + 1].Average;
                }
                nbStud--;
                if(current == nbStud)
                {
                    txtFullName.Text = tabStuds[current - 1].Name;
                    datBirthday.Value = tabStuds[current - 1].Birthdate;
                    txtAverage.Text = tabStuds[current - 1].Average.ToString();
                    lblInfo.Text = " Student " + current + " on a total of " + nbStud;
                }
                else { 
                    Array2txt(current);
                }
            }
            

        }

        private void datBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 