using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.Models;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Book_Management_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public Book_Management_Form()
        {
            InitializeComponent();
        }

        private void Book_Management_Form_Load(object sender, EventArgs e)
        {
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
