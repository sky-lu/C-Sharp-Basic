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
using WinFormAppDisconnectedMode.DAL;
using WinFormAppDisconnectedMode.BLL;
    


namespace WinFormAppDisconnectedMode.GUI
{
    public partial class StudentForm : Form
    {
        SqlDataAdapter da;
        DataSet dsCollegeDB;
        DataTable dtStudents;
        SqlCommandBuilder sqlBuilder;
        Student aStudent = new Student();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainForm = new MainMenuForm();
            mainForm.ShowDialog();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            dataGridViewStudents.DataSource = stu.ListStudents();


        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonListFromDS_Click(object sender, EventArgs e)
        {
            da.Fill(dsCollegeDB.Tables["Students"]);
            dataGridView1.DataSource = dsCollegeDB.Tables["Students"];
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Create an object of type DataSet and name it as CollegeDB
            dsCollegeDB = new DataSet("CollegeDB");
            // Create a DataTable;name : Students; add it to the DataSet object
            dtStudents = new DataTable("Students");
            dsCollegeDB.Tables.Add(dtStudents);
            //Create columns, add the columns to the DataTable Students
            dtStudents.Columns.Add("StudentId", typeof(Int32));
            dtStudents.Columns.Add("FirstName", typeof(string));
            dtStudents.Columns.Add("LastName", typeof(string));
            dtStudents.Columns.Add("Email", typeof(string));
            dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"] };

            dtStudents.Columns["StudentId"].AutoIncrement = true;
            dtStudents.Columns["StudentId"].AutoIncrementStep = 1;
            dtStudents.Columns["StudentId"].AutoIncrementSeed = 1111111;

            da = new SqlDataAdapter("SELECT * FROM Students", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //search by StudentId
            //Data validation first: Do-it-yourself
            int searchId = Convert.ToInt32(textBoxStuId.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            if (dr != null)
            {
                textBoxFname.Text = dr["FirstName"].ToString();
                textBoxLname.Text = dr["LastName"].ToString();
                textBoxEmail.Text = dr["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Student not found!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            //Data validation first: Do-it-yourself
            // Studentid: valid format
            int searchId = Convert.ToInt32(textBoxStuId.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            dr["StudentId"] = Convert.ToInt32(textBoxStuId.Text.Trim());
            dr["FirstName"] = textBoxFname.Text.Trim();
            dr["LastName"] = textBoxLname.Text.Trim();
            dr["Email"] = textBoxEmail.Text.Trim();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Make sure there is no course registered by this student.

            int searchId = Convert.ToInt32(textBoxStuId.Text.Trim());
            DataRow dr = dtStudents.Rows.Find(searchId);
            dr.Delete();
            MessageBox.Show(dr.RowState.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Input data validation

            // Valid input data
            DataRow dr = dtStudents.NewRow();
            dr["FirstName"] = textBoxFname.Text.Trim();
            dr["LastName"] = textBoxLname.Text.Trim();
            dr["Email"] = textBoxEmail.Text.Trim();
            dtStudents.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
            textBoxFname.Clear();
            textBoxLname.Clear();
            textBoxEmail.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dsCollegeDB.Tables["Students"]);
            MessageBox.Show("Database has been updated successfully.", "Confirmation");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection connDB = UtilityDB.ConnectDB();
        //    MessageBox.Show(Convert.ToString(connDB.State));
        //}
    }
}
