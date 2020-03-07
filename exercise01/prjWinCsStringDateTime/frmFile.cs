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
        Int32 current, nbStud;
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
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student 1 " + "on a total of " + nbStud;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if(nbStud > 0) { 
                current = nbStud - 1;
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student " + nbStud + " on a total of " + nbStud;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(current > 0)
            {
                current = current - 1;
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student " + (current + 1) + " on a total of " + nbStud;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(current < nbStud - 1)
            {
                current = current + 1;
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student " + (current+1) + " on a total of " + nbStud;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Activates buttons
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Activates buttons
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = false;

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

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                if(nbStud < (50 - 1))
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

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnFirst.Enabled = btnPrevious.Enabled = btnNext.Enabled = btnLast.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 