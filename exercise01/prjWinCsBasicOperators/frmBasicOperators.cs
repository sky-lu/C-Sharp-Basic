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
    public partial class frmBasicOperators : Form
    {
        public frmBasicOperators()
        {
            InitializeComponent();
        }

        private void frmBasicOperators_Load(object sender, EventArgs e)
        {
            groupArithmetic.Visible = groupComparison.Visible = false;
        }

        private void chkArithemetics_CheckedChanged(object sender, EventArgs e)
        {
            groupArithmetic.Visible = chkArithemetics.Checked;
        }

        private void chkComparison_CheckedChanged(object sender, EventArgs e)
        {
            groupComparison.Visible = chkComparison.Checked;
        }

        private void rdiAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdiSub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdiMult_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdiDiv_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdiGreat_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdiSmall_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdiEqual_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdiDiff_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            if (rdiAdd.Checked)
            {
                lblResult.Text = "Addition of " + val1 + " and " + val2 + " is " + " " + (val1 + val2);
            }
            if (rdiSub.Checked)
            {
                lblResult.Text = "Subtraction of " + val1 + " and " + val2 + " is " + " " + (val1 - val2);
            }
            if (rdiMult.Checked)
            {
                lblResult.Text = "Multiplication of " + val1 + " and " + val2 + " is " + " " + (val1 * val2);
            }
            if (rdiDiv.Checked)
            {
                lblResult.Text ="Division of " + val1 + " and " + val2 + " is " + " " + (val1 / val2);
            }
          
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);
            if (rdiGreat.Checked)
            {
                lblResult.Text = val1 + " greater than " + val2 + " is " + " " + (val1 > val2);
            }
            if (rdiSmall.Checked)
            {
                lblResult.Text = val1 + " smaller than " + val2 + " is " + " " + (val1 < val2);
            }
            if (rdiEqual.Checked)
            {
                lblResult.Text = val1 + " equal to " + val2 + " is " + " " + (val1 == val2);
            }
            if (rdiDiff.Checked)
            {
                lblResult.Text = val1 + " different to " + val2 + " is " + " " + (val1 != val2);
            }
        }

        
    }
}
