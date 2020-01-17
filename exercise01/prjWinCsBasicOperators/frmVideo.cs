using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsBasicOperators
{
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Thanks for using our program!","Closing Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //txtNumber.Text = "Test";
            MessageBox.Show("Do you want to marry me?", "Your choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
