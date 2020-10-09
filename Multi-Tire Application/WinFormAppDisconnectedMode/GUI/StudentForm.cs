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



namespace WinFormAppDisconnectedMode.GUI
{
    public partial class StudentForm : Form
    {
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection connDB = UtilityDB.ConnectDB();
        //    MessageBox.Show(Convert.ToString(connDB.State));
        //}
    }
}
