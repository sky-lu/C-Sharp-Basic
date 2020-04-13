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
    public partial class frmEmployee : Form
    {
        clsEmployee Ep1 = new clsEmployee();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            
            String aNumber = txtNumber.Text;
            String aName = txtName.Text;
            Int16 aDay = Convert.ToInt16(dTPBirthdate.Value.Day);
            Int16 aMonth = Convert.ToInt16(dTPBirthdate.Value.Month);
            Int16 aYear = Convert.ToInt16(dTPBirthdate.Value.Year);
            Ep1.Hire(aNumber, aName, aDay, aMonth, aYear);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblInfo.Text = Ep1.Display();
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            Ep1.Promote();
        }

        private void btnDemote_Click(object sender, EventArgs e)
        {
            Ep1.Demote();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            Ep1.Fire();
        }
    }
}
