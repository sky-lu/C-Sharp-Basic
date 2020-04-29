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
        clsClient myClient = new clsClient();
        string number, pin;


        private void frmGab_Load(object sender, EventArgs e)
        {
            this.Height = 203;
            //this.FormBorderStyle = FormBorderStyle.None;
            myATM.Fill();

        }

        private void btnReadCard_Click(object sender, EventArgs e)
        {
            number = txtNumber.Text.Trim().ToUpper();
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
            pin = txtPin.Text.Trim().ToLower();
            if (myATM.Clients[number].Pin == pin)
            {
                this.Height = 497;
                myClient.Fill();
                List<clsAccount> myList = myClient.Accounts[number];
                foreach (clsAccount item in myList)
                {
                    lstAccountType.Items.Add(item.Type.ToUpper());
                }
            }
            else
            {
                txtPin.Text = "";
                txtPin.Focus();
                MessageBox.Show("Pin is not correct, try again!");
            }
        }

        private void btnAccountType_Click(object sender, EventArgs e)
        {
            this.Height = 671;
            txtDeposit.Hide();
            txtWithdraw.Hide();
        }

        private void btnTransactionType_Click(object sender, EventArgs e)
        {
            this.Height = 854;
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 203;
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Show();
            txtWithdraw.Hide();
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Show();
            txtDeposit.Hide();
        }

        private void lstAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void frmGab_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawRectangle(Pens.DarkOliveGreen, 0, 0, this.Width - 1, this.Height - 1);
        //}
    }
}
