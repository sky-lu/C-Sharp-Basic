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
namespace prjWinCsClassAndCollection
{
    public partial class frmATM : Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        private void frmATM_Load(object sender, EventArgs e)
        {
            this.Height = 289;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Height = 657;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 469;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Height = 841;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Height = 289;
        }
    }
}
