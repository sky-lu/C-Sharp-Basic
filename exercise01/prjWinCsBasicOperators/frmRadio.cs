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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddition_CheckedChanged(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            Result.Text = " The addition of " + val1 + " and " + val2 + " is" + " " + (val1 + val2);
        }

        private void btnSubstraction_CheckedChanged(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            Result.Text = " The substraction of " + val1 + " and " + val2 + " is" + " " + (val1 - val2);
        }

        private void btnDivision_CheckedChanged(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            Result.Text = " The division of " + val1 + " and " + val2 + " is" + " " + (val1 / val2);
        }

        private void btnMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            Result.Text = " The multiplication of " + val1 + " and " + val2 + " is" + " " + (val1 * val2);
        }
    }
}
