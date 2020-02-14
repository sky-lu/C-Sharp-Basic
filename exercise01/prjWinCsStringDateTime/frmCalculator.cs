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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private Int32 GetValue(TextBox anytxtbox)
        {
            return Convert.ToInt32(anytxtbox.Text);
        }
        private Int32 Add(Int32 value1, Int32 value2)
        {
            return value1 + value2;
        }
        private Int32 Divide(Int32 value1, Int32 value2)
        {
            return value1 / value2;
        }
        private bool isEmpty(TextBox anytxtbox)
        {
            if(anytxtbox.Text.Length == 0)
            {
                return true;
            }
            return false;
        }
        private void Display(Int32 result, Label anylable)
        {
            anylable.Text = " The result is " + result;
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            Int32 val1, val2, result;
            if(!isEmpty(txtValue1) && !isEmpty(txtValue2)) { 
                val1 = GetValue(txtValue1);
                val2 = GetValue(txtValue2);
                if (radAddition.Checked)
                {
                    result = Add(val1, val2);
                }
                else
                {
                    result = Divide(val1, val2);
                }
                Display(result, lblResult);
            }
            else
            {
                MessageBox.Show("Please enter values in txtboxes!");
            }
        }
    }
}
