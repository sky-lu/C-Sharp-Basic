using Hi_Tech_Order_Management.BLL;
using Hi_Tech_Order_Management.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_Tech_Order_Management.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserId.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            

            string userId = txtUserId.Text.Trim();
            if (Validator.IsEmpty(userId))
            {
                MessageBox.Show("UserId cannot be empty !", "Error");
                txtUserId.Focus();
                return;
            }
            if (!Validator.IsValidId(userId, 4))
            {
                MessageBox.Show("Invalid User Id !", "Error");
                txtUserId.Clear();
                txtPassword.Clear();
                txtUserId.Focus();
                return; 
            }

            User tempUser = new User();
            tempUser = tempUser.GetUser(Convert.ToInt32(userId));
           

            if (tempUser != null)
            {
                
                string password = txtPassword.Text.Trim();
                if (password == "")
                {
                    MessageBox.Show("Please enter the password!", "Error");
                    txtPassword.Focus();
                    return;
                }
                else if (password == tempUser.Password)
                {
                    string jobTitle = tempUser.JobTitle;
                    string display = "Login Successfully !" + "\r\n" + "This user's job title is :" + jobTitle;
                    MessageBox.Show(display, "Login Confirmation");
                    txtUserId.Clear();
                    txtUserId.Focus();
                    txtPassword.Clear();
                    return;
                }
                else
                {
                    txtPassword.Clear();
                    txtPassword.Focus();
                    var result = MessageBox.Show("The password is not correct, try again!", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        txtPassword.Focus();
                        
                    }
                    else
                    {
                        txtUserId.Clear();
                        txtUserId.Focus();
                        return;
                    }
                }
            }
            else
            {
                txtUserId.Clear();
                txtUserId.Focus();
                txtPassword.Clear();
                MessageBox.Show("This user doesn't exist!", "Error");
                return;
            }
        }
    }
}
