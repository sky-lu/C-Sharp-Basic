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
        public String op;

        public frmCalculator()
        {
            InitializeComponent();
        }

        //This method is called when the number button is clicked to enter a number, 
        //and the entered number is displayed in the lable.
        private void ShowNumbers(int num)
        {
            if(lblResult.Text == "0")
            {
                lblResult.Text = num.ToString();
            }
            else
            {
                lblResult.Text = lblResult.Text + num;
            }
        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(0);
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
            double temp = Convert.ToDouble(lblResult.Text);
            if(temp == 0)
            {
                lblResult.Text = "0";
            }else
            {
                lblResult.Text = (-temp).ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShowNumbers(0);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblResult.Text += ".";
        }
    }
}
