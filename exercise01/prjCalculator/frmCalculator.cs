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


        public char opChar;

        public double n1, n2 = 0;

        public bool calcSwitch = false;

        public string calcTempNumber = null;

        public frmCalculator()
        {
            InitializeComponent();
        }

        //This method is called when the number button is clicked to enter a number, 
        //and the entered number is displayed in the lable.
        private void ShowNumbers(char num)
        {

            lblResultDown.Text = calcTempNumber = Convert.ToDouble(calcTempNumber + num).ToString();

            if (calcSwitch == false)
            {
                n1 = Convert.ToDouble(calcTempNumber);
            } else
            {
                n2 = Convert.ToDouble(calcTempNumber);
            }

        }

        private void Compute(Char op)
        {
            // When the first operator comes, it will not excute the switch part.
                switch (opChar)
                {
                    case '+':
                        n1 += n2;
                        break;
                    case '-':
                        n1-= n2;
                        break;

                    case 'x':
                        n1 *= n2;
                        break;

                    case '/':
                        n1 /= n2;
                        break;

                    case '=':
                        lblResultUp.Text = n1.ToString();
                        break;

                    default:
                        break;
                    
                }
           
            
                lblResultDown.Text = n1.ToString();
                lblResultUp.Text += calcTempNumber + op;

                opChar = op;
                calcSwitch = true;
                calcTempNumber = null;
           
            

        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            //When the form load ,the lable shows 0;
            lblResultDown.Text = Convert.ToString(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowNumbers('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowNumbers('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShowNumbers('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowNumbers('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShowNumbers('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShowNumbers('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShowNumbers('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShowNumbers('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShowNumbers('9');
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (calcSwitch == false)
            {

                lblResultUp.Text = (-n1).ToString();
                lblResultDown.Text = (-n1).ToString();
                n1 = -n1;
            }
            else
            {
                lblResultUp.Text += (-n2).ToString();
                lblResultDown.Text = (-n2).ToString();
                n2 = -n2;
            }
            calcTempNumber = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Compute('+');
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            
            if (calcSwitch == false)
            {
                //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
                //format strings (references)

                lblResultUp.Text = $"sqr({n1})";
                n1 = n1 * n1;
                lblResultDown.Text = n1.ToString();
            }
            else
            {
                lblResultUp.Text += $"sqr({n2})";
                n2 = n2 * n2;
                lblResultDown.Text = n2.ToString();
            }
            calcTempNumber = null;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Compute('-');
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Compute('x');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Compute('/');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResultDown.Text = "0";
            lblResultUp.Text = "";

            opChar = '\0';
            calcSwitch = false;
            calcTempNumber = null;
            n1 = n2 = 0;

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
           if(calcTempNumber != null)
            {
                n2 = 0;
                lblResultDown.Text = n2.ToString();
                calcTempNumber = null;
            }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {

            if (calcSwitch == false)
            {

                lblResultUp.Text = $"Cube({n1})";
                n1 = n1 * n1 * n1;
                lblResultDown.Text = n1.ToString();
            }
            else
            {
                lblResultUp.Text += $"Cube({n2})";
                n2 = n2 * n2 * n2;
                lblResultDown.Text = n2.ToString();
            }
            calcTempNumber = null;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (calcSwitch == false)
            {
                lblResultUp.Text = $"1/({n1})";
                if ( n1 != 0) { 
                    n1 = 1 / n1;
                    lblResultDown.Text = n1.ToString();
                }
                else
                {
                    lblResultDown.Text = " Cannot divide ";
                }
            }
            else
            {
                lblResultUp.Text += $"1/({n2})";
                if (n2 != 0) { 
                    n2 = 1 / n2;
                    lblResultDown.Text = n2.ToString();
                }
                else
                {
                    lblResultDown.Text = " Cannot divide ";
                }
            }
            calcTempNumber = null;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (calcSwitch == false)
            {
                lblResultUp.Text = $"√({n1})";
                if (n1 >= 0)
                {
                    n1 = Math.Sqrt(n1);
                    lblResultDown.Text = n1.ToString();
                }
                else
                {
                    lblResultDown.Text = " Invalid input ";
                }
            }
            else
            {
                lblResultUp.Text += $"√({n2})";
                if (n2 >= 0)
                {
                    n2 = Math.Sqrt(n2);
                    lblResultDown.Text = n2.ToString();
                }
                else
                {
                    lblResultDown.Text = " Invalid input ";
                }
            }
            calcTempNumber = null;

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (calcSwitch == false)
            {
                n1 = n2 = 0;
                lblResultDown.Text = lblResultUp.Text = "0";
            }
            else
            {
                switch (opChar)
                {
                    case '+':
                    case '-':
                        n2 = n1 *  n2 * 0.01;
                        break;
                    case 'x':
                    case '/':
                        n2 =  n2 * 0.01;
                        break;
                    default :
                        break;
                }

                lblResultDown.Text = n2.ToString();
                lblResultUp.Text += lblResultDown.Text;
                calcTempNumber = null;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Compute('=');
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShowNumbers('0');
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            ShowNumbers('.');
           
        }
    }
}
