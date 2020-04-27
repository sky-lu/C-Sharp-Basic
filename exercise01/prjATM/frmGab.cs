using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMLib;

namespace prjATM
{
    public partial class frmGab : Form
    {
        public frmGab()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        clsATM myATM = new clsATM();
        private void frmGab_Load(object sender, EventArgs e)
        {
            this.Height = 203;
            //this.FormBorderStyle = FormBorderStyle.None;
            myATM.Fill();

        }

        private void btnReadCard_Click(object sender, EventArgs e)
        {
            
            string number = txtNumber.Text.Trim().ToUpper();
            if (myATM.Clients.ContainsKey(number) == false)
            {
                txtNumber.Text = "";
                txtNumber.Focus();
                MessageBox.Show("The number does not exist, start again!");
            }
            else
            {
                this.Height = 364;
                txtPin.Focus();
                lblValidationInfo.Text = " WELCOME, " + myATM.Clients[number].Name.ToUpper();
                lblValidationInfo.ForeColor = Color.Red;
            }
        }

        private void btnPinValidate_Click(object sender, EventArgs e)
        {
            ;            this.Height = 497;
        }

        private void btnAccountType_Click(object sender, EventArgs e)
        {
            this.Height = 671;
        }

        private void btnTransactionType_Click(object sender, EventArgs e)
        {
            this.Height = 854;
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 203;
        }

        private void frmGab_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DarkOliveGreen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
