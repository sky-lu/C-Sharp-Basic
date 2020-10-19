using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormAppDisconnectedMode.GUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm stuForm = new StudentForm();
            this.Hide();
            stuForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void courseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm couForm = new CourseForm();
            this.Hide();
            couForm.ShowDialog();
        }
    }
}
