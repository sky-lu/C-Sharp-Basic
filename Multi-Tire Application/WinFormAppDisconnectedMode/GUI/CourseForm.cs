using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAppDisconnectedMode.BLL;

namespace WinFormAppDisconnectedMode.GUI
{
    public partial class CourseForm : Form
    {
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
    }
}
