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
using WinFormAppDisconnectedMode.DAL;

namespace WinFormAppDisconnectedMode.GUI
{
    public partial class CourseRegistrationForm : Form
    {
        SqlDataAdapter da_s, da_c;
        DataSet dsCollegeDB;
        DataTable dtStudentCourses;
        DataTable dtStudents;
        DataTable dtCourses;
        SqlCommandBuilder sqlBuilder1, sqlBuilder2;
        StudentCourse StuCourse = new StudentCourse();
        public CourseRegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStuInfo_Click(object sender, EventArgs e)
        {
            int StudId = Convert.ToInt32(textBoxStudentID.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(StudId);
            if (dr != null)
            {
                labelStuInfo.Text = "First Name : " + dr["FirstName"].ToString() + "\n" + "Last Name : " + dr["LastName"].ToString() + "\n" 
                                   + "Eamil : " + dr["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Student not found!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCourseInfo_Click(object sender, EventArgs e)
        {
            string courseCode = textBoxCourseCode.Text.Trim();
            DataRow dr = dtCourses.Rows.Find(courseCode);
            if (dr != null)
            {
                labelCourseInfo.Text = "Course Title : " + dr["CourseTitle"].ToString() + "\n\n" +
                                        "Total Hour : " + dr["TotalHour"].ToString();

            }
            else
            {
                MessageBox.Show("Course not found!", "Invalid Course Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void buttonRegister_Click(object sender, EventArgs e)
        //{
            
        //}

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Clear();
            textBoxStudentID.Focus();
            labelStuInfo.Text = "";
            textBoxCourseCode.Clear();
            labelCourseInfo.Text = "";
            maskedTextBoxRegisDate.Clear();
            maskedTextBoxStartDate.Clear();
            maskedTextBoxEndDate.Clear();

        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            DataRow dr = dtStudentCourses.NewRow();
            dr["StudentId"] = Convert.ToInt32(textBoxStudentID.Text.Trim());
            dr["CourseCode"] = textBoxCourseCode.Text.Trim();
            dr["RegistrationDate"] = Convert.ToDateTime(maskedTextBoxRegisDate.Text.Trim());
            dr["StartingDate"] = Convert.ToDateTime(maskedTextBoxStartDate.Text.Trim());
            dr["EndingDate"] = Convert.ToDateTime(maskedTextBoxEndDate.Text.Trim());
            dtStudentCourses.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int studId = Convert.ToInt32(textBoxStudentID.Text.Trim());
            string courseCode = textBoxCourseCode.Text.Trim();
            string expression = $" StudentId = {studId} AND CourseCode = '{courseCode}'";
            DataRow[] dr = dtStudentCourses.Select(expression);
            //MessageBox.Show(dr.Length.ToString(), "confir");
            if (dr != null) { 
                maskedTextBoxRegisDate.Text = dr[0]["RegistrationDate"].ToString();
                maskedTextBoxStartDate.Text = dr[0]["StartingDate"].ToString();
                maskedTextBoxEndDate.Text = dr[0]["EndingDate"].ToString();
            }
            else
            {
                MessageBox.Show("Course Registration not found!", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CourseRegistrationForm_Load(object sender, EventArgs e)
        {
            dsCollegeDB = new DataSet("CollegeDB");
            dtStudentCourses = new DataTable("StudentCourses");
            dtStudents = new DataTable("Students");
            dtCourses = new DataTable("Courses");
            dsCollegeDB.Tables.Add(dtStudentCourses);
            dsCollegeDB.Tables.Add(dtStudents);
            dsCollegeDB.Tables.Add(dtCourses);

            dtStudents.Columns.Add("StudentId", typeof(Int32));
            dtStudents.Columns.Add("FirstName", typeof(string));
            dtStudents.Columns.Add("LastName", typeof(string));
            dtStudents.Columns.Add("Email", typeof(string));
            dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"] };

            dtStudents.Columns["StudentId"].AutoIncrement = true;
            dtStudents.Columns["StudentId"].AutoIncrementStep = 1;
            dtStudents.Columns["StudentId"].AutoIncrementSeed = 1111111;

            dtCourses.Columns.Add("CourseCode", typeof(string));
            dtCourses.Columns.Add("CourseTitle", typeof(string));
            dtCourses.Columns.Add("TotalHour", typeof(Int32));
            dtCourses.PrimaryKey = new DataColumn[] { dtCourses.Columns["CourseCode"] };

            dtStudentCourses.Columns.Add("StudentId", typeof(Int32));
            dtStudentCourses.Columns.Add("CourseCode", typeof(string));
            dtStudentCourses.Columns.Add("RegistrationDate", typeof(DateTime));
            dtStudentCourses.Columns.Add("StartingDate", typeof(DateTime));
            dtStudentCourses.Columns.Add("EndingDate", typeof(DateTime));
            dtStudentCourses.PrimaryKey = new DataColumn[] { dtStudentCourses.Columns["StudentId"], dtStudentCourses.Columns["CourseCode"] };
            
            DataRelation drSToSC = new DataRelation("SToSC", dtStudents.Columns["StudentId"], dtStudentCourses.Columns["StudentId"]);
            DataRelation drCToSC = new DataRelation("CToSC", dtCourses.Columns["CourseCode"], dtStudentCourses.Columns["CourseCode"]);
            dsCollegeDB.Relations.Add(drSToSC);
            dsCollegeDB.Relations.Add(drCToSC);
            
            da_s = new SqlDataAdapter("SELECT * FROM Students", UtilityDB.ConnectDB());
            sqlBuilder1 = new SqlCommandBuilder(da_s);
            da_s.Fill(dsCollegeDB.Tables["Students"]);
            da_c = new SqlDataAdapter("SELECT * FROM Courses", UtilityDB.ConnectDB());
            sqlBuilder2 = new SqlCommandBuilder(da_c);
            da_c.Fill(dsCollegeDB.Tables["Courses"]);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainForm = new MainMenuForm();
            mainForm.ShowDialog();

        }
    }
}
