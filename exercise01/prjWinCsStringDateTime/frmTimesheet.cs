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
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            DateTime myRV = new DateTime(1990, 10, 18);
            MessageBox.Show(myRV.ToString());
            
        }
    }
}
