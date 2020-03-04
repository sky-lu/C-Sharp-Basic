using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculator
{
    public partial class frmCalculator : Form
    {

        public double n1, n2, result;
        

        public frmCalculator()
        {
            InitializeComponent();
        }

        //This method is called when the number button is clicked to enter a number, 
        //and the entered number is displayed in the lable.
        private void ShowNumbers(int num)
        {
            if(lblResultDown.Text == "0")
            {
                lblResultDown.Text = num.ToString();
            }
            else
            {
                lblResultDown.Text = lblResultDown.Text + num;
            }
        }

        private void Compute(Char op)
        {
            String up = lblResultUp.Text;
            String down = lblResultDown.Text;
            if(up.IndexOf("+") == -1 && up.IndexOf("-") == -1 && up.IndexOf("*") == -1 && up.IndexOf("/") == -1) { 
                lblResultUp.Text = lblResultDown.Text + op ;
            }
            if(up.IndexOf("+") == up.Length - 1 || up.IndexOf("-") == up.Length - 1 ||
                up.IndexOf("*") == up.Length - 1 || up.IndexOf("/") == up.Length - 1)
            {

            }
        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            //When the form load ,the lable shows 0;
            lblResultDown.Text = Convert.ToString(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowNumbers(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowNumbers(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowNumbers(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowNumbers(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowNumbers(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowNumbers(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowNumbers(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowNumbers(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShowNumbers(9);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // for the button(+/-), if it's 0 ,it does not show sign; if it is positive,then show negative;
            // if it is negative,then show positive. 
            double temp = Convert.ToDouble(lblResultDown.Text);
            if(temp == 0)
            {
                lblResultDown.Text = "0";
            }else
            {
                lblResultDown.Text = (-temp).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Compute('+');
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Compute('-');
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Compute('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Compute('/');
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShowNumbers(0);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // if the lable already has the ".", "." won't show again.
            if (lblResultDown.Text.IndexOf(".") == -1) { 
                lblResultDown.Text += ".";
            }
        }
    }
}
