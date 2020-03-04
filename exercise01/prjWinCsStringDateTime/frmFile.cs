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
            current = 0;
            txtFullName.Text = tabStuds[current].Name;
            datBirthday.Value = tabStuds[current].Birthdate;
            txtAverage.Text = tabStuds[current].Average.ToString();
            lblInfo.Text = " Student 1 " + "on a total of " + nbStud.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtFullName.Text = tabStuds[0].Name;
            datBirthday.Value = tabStuds[0].Birthdate;
            txtAverage.Text = tabStuds[0].Average.ToString();
            lblInfo.Text = " Student 1 " + "on a total of " + nbStud.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txtFullName.Text = tabStuds[nbStud - 1].Name;
            datBirthday.Value = tabStuds[nbStud - 1].Birthdate;
            txtAverage.Text = tabStuds[nbStud - 1].Average.ToString();
            lblInfo.Text = " Student " + (nbStud) + " on a total of " + nbStud.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(current == 0)
            {
                MessageBox.Show("It's already the first student!");
            }
            else
            {
                current = current - 1;
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student " + (current + 1) + " on a total of " + nbStud.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(current == nbStud - 1)
            {
                MessageBox.Show("It's already the last student");
            }
            else
            {
                current = current + 1;
                txtFullName.Text = tabStuds[current].Name;
                datBirthday.Value = tabStuds[current].Birthdate;
                txtAverage.Text = tabStuds[current].Average.ToString();
                lblInfo.Text = " Student " + (current+1) + " on a total of " + nbStud.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
