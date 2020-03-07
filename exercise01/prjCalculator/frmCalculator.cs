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

        public bool calcOperatorIsFirst = true;

        public string calcTempNumber, calcExpression = null;

        public double calcPrevious, calcNext, calcResult = 0.0;

        public int calcCount = 0;

        public string[] calcUnits = new string[3];



        public frmCalculator()
        {
            InitializeComponent();
        }

        //This method is called when the number button is clicked to enter a number, 
        //and the entered number is displayed in the lable.
        private void ShowNumbers(int num)
        {
            /*if(calcOperatorIsEmpty != false)
            {
                lblResultDown.Text = num.ToString();
            }
            else
            {

                lblResultDown.Text = Convert.ToDouble(lblResultDown.Text + num).ToString();
                Console.WriteLine(lblResultDown.Text);
            }
            calcTempNumber = lblResultDown.Text;*/
            lblResultDown.Text = Convert.ToDouble(calcTempNumber + num).ToString();
            calcTempNumber = lblResultDown.Text;

        }

        private void Compute(Char op)
        {
            calcExpression += calcTempNumber + op;
            lblResultUp.Text = calcExpression;

            calcPrevious = Convert.ToDouble(calcTempNumber);
            calcUnits[calcCount] = calcTempNumber;

            calcCount++;
            if (calcCount > 2)
            {
                calcCount = 0;
                calcUnits[calcCount] = (Convert.ToDouble(calcUnits[0]) + Convert.ToDouble(calcUnits[2])).ToString();
                //calcUnits[1] = op.ToString();
            }
            
            calcTempNumber = null;

            Console.WriteLine("calcUnit[0]: " + calcUnits[0]);
            Console.WriteLine("calcUnit[1]: " + calcUnits[1]);
            Console.WriteLine("calcUnit[2]: " + calcUnits[2]);

            //compute
            if (calcOperatorIsFirst == false)
            {
                
            }
            calcOperatorIsFirst = false;
            calcCount++;
            //calcCount = calcCount > 2 ? 0 : calcCount;

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
            Double temp = Convert.ToDouble(lblResultDown.Text);
            lblResultUp.Text += " Sqr( " + temp + " )";
            lblResultDown.Text = (temp * temp).ToString();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResultDown.Text = "0";
            lblResultUp.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            lblResultDown.Text = "0";
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            Double temp = Convert.ToDouble(lblResultDown.Text);
            lblResultUp.Text += " Cube( " + temp + " )";
            lblResultDown.Text = (temp * temp * temp).ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            Double temp = Convert.ToDouble(lblResultDown.Text);
            lblResultUp.Text += "1/(" + temp + ")";
            if (temp == 0)
            {
                lblResultDown.Text = "Cannot divide";
               
            }
            else
            {
                lblResultDown.Text = (1 / temp).ToString();
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            Double temp = Convert.ToDouble(lblResultDown.Text);
            lblResultUp.Text += "√(" + temp + ")";
            if (temp < 0)
            {
                lblResultDown.Text = "Invalid input";
            }
            else
            {
                lblResultDown.Text = Math.Sqrt(temp).ToString();
            }

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Double temp = Convert.ToDouble(lblResultDown.Text);
            if(lblResultUp.Text == "")
            {
                lblResultDown.Text = "0";
            }
            else
            {
                lblResultDown.Text = (temp / 100).ToString();
                lblResultUp.Text += lblResultDown.Text;
            }
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
