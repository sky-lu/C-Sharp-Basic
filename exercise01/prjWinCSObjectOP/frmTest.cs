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
            //clsDate RV = new clsDate();
            //RV.Initialize(-18, -10, -1990);
            //MessageBox.Show(RV.DisplayShort());
            //MessageBox.Show(RV.DisplayLong());

            clsStudent ST1 = new clsStudent();
            
            //ST1.Register("ST001", "Marco Polo", 23, 11, 2000);

            //ST1.ToGrade(90);
            //label1.Text = ST1.Display();







            clsDate RV = new clsDate();
            //RV.Initialize(99, -10, -2015);

           // DateTime RV2 = new DateTime();

            
            MessageBox.Show(RV.ToString());

        }
    }
}
