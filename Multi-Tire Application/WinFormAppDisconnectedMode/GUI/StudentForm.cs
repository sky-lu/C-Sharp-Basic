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

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dsCollegeDB = new DataSet("CollegeDS");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection connDB = UtilityDB.ConnectDB();
        //    MessageBox.Show(Convert.ToString(connDB.State));
        //}
    }
}
