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
        clsAccount myAccount = new clsAccount();
        string number, pin;


        private void frmGab_Load(object sender, EventArgs e)
        {
            this.Height = 203;
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            
            myATM.Fill();
            myClient.Fill();

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
            //MessageBox.Show(myAccount.Balance.ToString());
        }

        private void btnTransactionType_Click(object sender, EventArgs e)
        {
            if (radDeposit.Checked)
            {
                Int32 temp = Convert.ToInt32(txtDeposit.Text);
                if (myAccount.Deposit(temp))
                {
                    this.Height = 854;
                    myAccount.Balance += temp;
                    lblAccountInfo.Text = myAccount.Consult();
                    lblAccountInfo.ForeColor = Color.Blue;
                }
                else
                {
                    txtDeposit.Focus();
                    MessageBox.Show("Please enter the amount between 2$ and 20000$");
                }
            }

            if (radWithdraw.Checked)
            {
                Int32 temp = Convert.ToInt32(txtWithdraw.Text);
                Int32 i = myAccount.Withdraw(temp);
                switch (i) {
                    case 1:
                        txtWithdraw.Focus();
                        MessageBox.Show("The amount must be smaller or equal to the balance!");
                        break;
                    case 2:
                        txtWithdraw.Focus();
                        MessageBox.Show("The maximum amount is 500$.");
                        break;
                    case 3:
                        txtWithdraw.Focus();
                        MessageBox.Show("The minimum amount is 20$.");
                        break;
                    case 4:
                        txtWithdraw.Focus();
                        MessageBox.Show("The amount must be a multiple of 20$.");
                        break;
                    case 0:
                        this.Height = 854;
                        myAccount.Balance -= temp;
                        lblAccountInfo.Text = myAccount.Consult();
                        lblAccountInfo.ForeColor = Color.Blue;
                        break;
                    default:
                        break;

                }
            }

            if (radConsult.Checked)
            {
                this.Height = 854;
                lblAccountInfo.Text = myAccount.Consult();
                lblAccountInfo.ForeColor = Color.Blue;


            }
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 203;
            txtNumber.Text = txtPin.Text = lstAccountType.Text = txtDeposit.Text = txtWithdraw.Text = "";
            lstAccountType.Items.Clear();
            radConsult.Checked = radDeposit.Checked = radWithdraw.Checked = false;
            txtNumber.Focus();
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Show();
            txtDeposit.Focus();
            txtWithdraw.Hide();
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Show();
            txtWithdraw.Focus();
            txtDeposit.Hide();
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lstAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            number = txtNumber.Text.Trim().ToUpper();
            List<clsAccount> myAccounts = myClient.Accounts[number];
            foreach (clsAccount item in myAccounts)
            {
                if(lstAccountType.SelectedItem.ToString() == item.Type.ToUpper())
                {
                    myAccount = item;
                }
            }
        }

        //private void frmGab_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.DrawRectangle(Pens.DarkOliveGreen, 0, 0, this.Width - 1, this.Height - 1);
        //}
    }
}
