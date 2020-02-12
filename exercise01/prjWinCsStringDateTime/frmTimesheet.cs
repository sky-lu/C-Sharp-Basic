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
            //MessageBox.Show(myRV.ToString());

            //MessageBox.Show(DateTime.Today.AddDays(10).ToString());
            //MessageBox.Show(DateTime.Now.ToString());
            lblToday.Text = " Today " + DateTime.Today.ToLongDateString();
            

        }

        private void txtTimeOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            txtTimeIn.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            txtTimeOut.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime timeOut, timeIn;
            Int32 sout, mout, hout, sin, min, hin, s, m, h;
            timeIn = Convert.ToDateTime(txtTimeIn.Text);
            timeOut = Convert.ToDateTime(txtTimeOut.Text);
            sout = timeOut.Second;
            mout = timeOut.Minute;
            hout = timeOut.Hour;
            sin = timeIn.Second;
            min = timeIn.Minute;
            hin = timeIn.Hour;

            s = sout - sin;
            m = mout - min;
            h = hout - hin;
            if(s < 0)
            {
                s = s + 60;
                m = m - 1;
            }
            if(m < 0)
            {
                m = m + 60;
                h = h - 1;
            }


            //if(sin > sout)
            //{
            //    mout = mout - 1;//mout -= 1;//mout --;
            //    sout = sout + 60;
            //}
            //s = sout - sin;
            //if(min > mout)
            //{
            //    hout = hout - 1;
            //    mout = mout + 60;
            //}
            //m = mout - min;
            //h = hout - hin;

            lblResult.Text = " Time worked " + h + " hours " + m + " minutes " + s + " seconds ";
            
        }
    }
}
