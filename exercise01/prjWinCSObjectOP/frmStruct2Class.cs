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
    public partial class frmStruct2Class : Form
    {
        public frmStruct2Class()
        {
            InitializeComponent();
        }
        struct Time
        {
            public Int16 Hour;
            public Int16 Minute;
            public Int16 Second;

        }
        Time current;

        private Time Adjust(Int16 aHour,Int16 aMinute,Int16 aSecond)
        {
            Time tmp;
            tmp.Hour = aHour;
            tmp.Minute = aMinute;
            tmp.Second = aSecond;
            return tmp;
        }

        private String DisplayUniversal(Time anyTime)
        {
            String info = anyTime.Hour + " : " + anyTime.Minute + " : " + anyTime.Second;
            return info;
        }
        private String DisplayStandard(Time anyTime)
        {
            String info;
            if (anyTime.Hour < 12)
            {
                info = anyTime.Hour + " : " + anyTime.Minute + " : " + anyTime.Second  + " AM ";
                return info;
            }
            else
            {
                info = (anyTime.Hour - 12 ).ToString() + " : " + anyTime.Minute + " : " + anyTime.Second + " PM ";
                return info;
            }

            
        }
        private void frmStruct2Class_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Int16 hr = Convert.ToInt16(txtHour.Text);
            Int16 mn = Convert.ToInt16(txtMinute.Text);
            Int16 sc = Convert.ToInt16(txtSecond.Text);
            current = Adjust(hr, mn, sc);
            MessageBox.Show("Appointment created with success!");
        }

        private void btnDUniversal_Click(object sender, EventArgs e)
        {
            lblUniversal.Text = DisplayUniversal(current);
        }

        private void btnDStandard_Click(object sender, EventArgs e)
        {
            lblStandard.Text = DisplayStandard(current);
        }
    }
}
