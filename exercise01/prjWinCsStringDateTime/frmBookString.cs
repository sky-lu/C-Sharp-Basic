using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsStringDateTime
{
    public partial class frmBookString : Form
    {
        public frmBookString()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname,firstname,lastname;
            fullname = txtFullname.Text.Trim();
            if(fullname.Length == 0)
            {
                MessageBox.Show("Please enter lastname,firstname");
                txtFullname.Focus();
            }
        }
    }
}
