using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuLibrary;

namespace prjWinCSAppTest4Dll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsCourse myCourse;
        private void Form1_Load(object sender, EventArgs e)
        {
            myCourse = new clsCourse("420AP1AS","Introduction to Programming");
            lblTitle.Text = myCourse.Title;
        }

        private void btnAdd_Click(object sender, EventArgs e) { 
     
            String number = txtNumber.Text.Trim();
            String name = txtName.Text.Trim();
            DateTime bDate = dtBD.Value;
            clsStudent stud = new clsStudent(name, number, Convert.ToInt16(bDate.Day), (Int16)bDate.Month, (Int16)bDate.Year);


          if(myCourse.AddStudent(stud) == false)
            {
                MessageBox.Show("Student already exits in the list", "Adding fail");
            }
            gridStudents.DataSource = myCourse.Students.Values.ToList();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String num = txtNumber.Text;
            clsStudent temp = myCourse.FindStudent(num);
            if(temp != null)
            {
                MessageBox.Show(temp.Display());
            }
            else
            {
                MessageBox.Show("Student doesn't exit in this course", "Student not found");
            }
        }
    }
}
