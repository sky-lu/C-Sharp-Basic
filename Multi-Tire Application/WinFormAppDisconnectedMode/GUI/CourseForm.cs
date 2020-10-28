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
    public partial class CourseForm : Form
    {
        SqlDataAdapter da;
        DataSet dsCollegeDB;
        static DataTable dtCourses;
        SqlCommandBuilder sqlBuilder;
        Course aCourse = new Course();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainForm = new MainMenuForm();
            mainForm.ShowDialog();
        }

        private void buttonListCourses_Click(object sender, EventArgs e)
        {
            Course cour = new Course();
            dataGridViewCoursesFromDB.DataSource = cour.ListCourses();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            dsCollegeDB = new DataSet("CollegeDB");
            dtCourses = new DataTable("Courses");
            dsCollegeDB.Tables.Add(dtCourses);

            dtCourses.Columns.Add("CourseCode", typeof(string));
            dtCourses.Columns.Add("CourseTitle", typeof(string));
            dtCourses.Columns.Add("TotalHour", typeof(Int32));
            dtCourses.PrimaryKey = new DataColumn[] { dtCourses.Columns["CourseCode"] };

            da = new SqlDataAdapter("SELECT * FROM Courses", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }

        private void buttonListCoursesFromDS_Click(object sender, EventArgs e)
        {
            da.Fill(dsCollegeDB.Tables["Courses"]);
            dataGridViewFromDS.DataSource = dsCollegeDB.Tables["Courses"];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dtCourses.NewRow();
            dr["CourseCode"] = textBoxCourseCode.Text.Trim();
            dr["CourseTitle"] = textBoxCourseTitle.Text.Trim();
            dr["TotalHour"] = Convert.ToInt32(textBoxTotalHour.Text.Trim());
            dtCourses.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
            textBoxCourseCode.Clear();
            textBoxCourseTitle.Clear();
            textBoxTotalHour.Clear();
            textBoxCourseCode.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchCode = textBoxCourseCode.Text.Trim();
            DataRow dr = dtCourses.Rows.Find(searchCode);
            if (dr != null)
            {
                textBoxCourseCode.Text = dr["CourseCode"].ToString();
                textBoxCourseTitle.Text = dr["CourseTitle"].ToString();
                textBoxTotalHour.Text = dr["TotalHour"].ToString();
                
            }
            else
            {
                MessageBox.Show("Course not found!", "Invalid Course Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string searchCode = textBoxCourseCode.Text.Trim();
            DataRow dr = dtCourses.Rows.Find(searchCode);
            dr["CourseCode"] = textBoxCourseCode.Text.Trim();
            dr["CourseTitle"] = textBoxCourseTitle.Text.Trim();
            dr["TotalHour"] = textBoxTotalHour.Text.Trim();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string searchCode = textBoxCourseCode.Text.Trim();
            DataRow dr = dtCourses.Rows.Find(searchCode);
            dr.Delete();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dsCollegeDB.Tables["Courses"]);
            MessageBox.Show("Database has been updated successfully.", "Confirmation");
        }
    }
}
