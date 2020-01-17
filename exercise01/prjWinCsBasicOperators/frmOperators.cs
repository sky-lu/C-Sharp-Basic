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
    public partial class frmOperators : Form
    {
        public frmOperators()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValue2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text =" The addition of " + val1 + " and " + val2 + " is " + Convert.ToString(val1 + val2) ;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmOperators_Load(object sender, EventArgs e)
        {

        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtValue1.Clear();
            txtValue2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " The multiplication of " + val1 + " and " + val2 + " is " + Convert.ToString(val1 * val2);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " The mode of " + val1 + " and " + val2 + " is " + Convert.ToString(val1 % val2);
        }

        private void btnsubtraction_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " The subtraction of " + val1 + " and " + val2 + " is " + Convert.ToString(val1 - val2);


        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " The division of " + val1 + " and " + val2 + " is " + Convert.ToString(val1 / val2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " Is " + val1 + " equal and greater than " + val2 + " " + Convert.ToString(val1 >= val2);
        }

        private void btngreater_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " Is " + val1 + " greater than " + val2  +" " + Convert.ToString(val1 > val2);
        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " Is " + val1 + " smaller than " + val2 + " " + Convert.ToString(val1 < val2);
        }

        private void btnEqualSmaller_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " Is " + val1 + " equal and smaller than " + val2 + " " + Convert.ToString(val1 <= val2);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " Is " + val1 + " equal to " + val2 + " " + Convert.ToString(val1 == val2);
        }

        private void btnNotEqual_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToInt32(txtValue1.Text);
            Int32 val2 = Convert.ToInt32(txtValue2.Text);

            lblResult.Text = " Is " + val1 + " not equal to " + val2 + " " + Convert.ToString(val1 != val2);
        }
    }
}
