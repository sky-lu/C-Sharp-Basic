using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAppDisconnectedMode.BLL;

namespace WinFormAppDisconnectedMode.GUI
{
    public partial class CourseRegistrationForm : Form
    {
        SqlDataAdapter da;
        DataSet dsCollegeDB;
        DataTable dtStudentCourses;
        SqlCommandBuilder sqlBuilder;
        StudentCourse StuCourse = new StudentCourse();
        public CourseRegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CourseRegistrationForm_Load(object sender, EventArgs e)
        {
            dsCollegeDB = new DataSet("CollegeDB");
            dtStudentCourses = new DataTable("StudentCourses");
            dsCollegeDB.Tables.Add(dtStudentCourses);

            dtStudentCourses.Columns.Add("StudentId", typeof(Int32));
            //dtStudents.Columns.Add("StudentId", typeof(Int32));
            //dtStudents.Columns.Add("FirstName", typeof(string));
            //dtStudents.Columns.Add("LastName", typeof(string));
            //dtStudents.Columns.Add("Email", typeof(string));
            //dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"] };

            //dtStudents.Columns["StudentId"].AutoIncrement = true;
            //dtStudents.Columns["StudentId"].AutoIncrementStep = 1;
            //dtStudents.Columns["StudentId"].AutoIncrementSeed = 1111111;

            //da = new SqlDataAdapter("SELECT * FROM Students", UtilityDB.ConnectDB());
            //sqlBuilder = new SqlCommandBuilder(da);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainForm = new MainMenuForm();
            mainForm.ShowDialog();

        }
    }
}
