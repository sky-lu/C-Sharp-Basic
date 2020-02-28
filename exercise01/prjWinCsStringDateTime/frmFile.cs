using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjWinCsStringDateTime
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        private void frmFile_Load(object sender, EventArgs e)
        {
            StreamWriter myFile = new StreamWriter("Test.txt");

            myFile.Close();
        }
    }
}
