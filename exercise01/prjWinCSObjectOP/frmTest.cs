using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCSObjectOP
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            //clsTime RV = new clsTime();
            clsDate RV = new clsDate();
            RV.Initialize(-18, -10, -1990);
            MessageBox.Show(RV.DisplayShort());
            MessageBox.Show(RV.DisplayLong());


        }
    }
}
