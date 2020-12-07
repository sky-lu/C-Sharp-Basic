using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.Models;
using Hi_TechLibrary.VALIDATION;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Login_Form : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        private static Dictionary<Int32, Int32> loginErrorCount = new Dictionary<Int32, Int32>();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            textBoxUserName.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userId = textBoxUserName.Text.Trim();

            if (!Validator.IsValidId(userId, 3))
            {
                MessageBox.Show("Invalid User Name or Password!", "Error");
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                textBoxUserName.Focus();
                return;
            }

            User tempUser = new User();
            tempUser = dbEntities.Users.Find(Convert.ToInt32(userId));


            if (tempUser != null)
            {
                if (!loginErrorCount.ContainsKey(tempUser.UserId))
                {
                    loginErrorCount.Add(tempUser.UserId, 0);
                }
                if (loginErrorCount[tempUser.UserId] > 1)
                {
                    textBoxUserName.Clear();
                    textBoxUserName.Focus();
                    textBoxPassword.Clear();
                    MessageBox.Show("You've tried 3 times, please contact the administrator!", "Error");
                    return;
                }

                string password = textBoxPassword.Text.Trim();
                if (password == "")
                {
                    MessageBox.Show("Please enter the password!", "Error");
                    textBoxPassword.Focus();
                    //return;
                }
                else if (password == tempUser.Password)
                {
                    this.Hide();
                    if (tempUser.UserId == 331) 
                    {
                        MIS_ManagerForm form_user_employee = new MIS_ManagerForm();
                        form_user_employee.ShowDialog();
                    }else if(tempUser.UserId == 332)
                    {
                        Customer_Management_Form form_customer = new Customer_Management_Form();
                        form_customer.ShowDialog();
                    }else if(tempUser.UserId == 333)
                    {
                        Book_Management_Form form_book = new Book_Management_Form();
                        form_book.ShowDialog();
                    }else if(tempUser.UserId == 334 || tempUser.UserId == 335)
                    {
                        Order_Management_Form form_order = new Order_Management_Form();
                        form_order.ShowDialog();
                    }
                   


                    //return;
                }
                else
                {
                    var result = MessageBox.Show("Invalid user name or password, try again!", "error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    loginErrorCount[tempUser.UserId] += 1;
                    if (result == DialogResult.Yes)
                    {
                        textBoxUserName.Clear();
                        textBoxUserName.Focus();
                        textBoxPassword.Clear();

                    }
                    else
                    {
                        textBoxUserName.Clear();
                        textBoxUserName.Focus();
                        textBoxPassword.Clear();

                        //return;
                    }
                }
            }
            else
            {
                textBoxUserName.Clear();
                textBoxUserName.Focus();
                textBoxPassword.Clear();
                MessageBox.Show("Invalid User name or password!", "Error");
                return;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
