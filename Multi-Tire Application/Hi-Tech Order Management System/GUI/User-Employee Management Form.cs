using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;
using Hi_Tech_Order_Management_System.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hi_Tech_Order_Management_System.GUI
{

    public partial class MIS_ManagerForm : Form
    {
        
        public MIS_ManagerForm()
        {
            InitializeComponent();
        }

        private void MIS_ManagerForm_Load(object sender, EventArgs e)
        {
            List<Job> lstJob = new List<Job>();
            Job aJob = new Job();
            lstJob = aJob.GetJobs();
            comboBoxJob.DataSource = lstJob;
            comboBoxJob.DisplayMember = "JobTitle";
            comboBoxJob.ValueMember = "JobId";
            comboBoxJob.SelectedIndex = -1;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonListAllUsers_Click(object sender, EventArgs e)
        {

            User user = new User();
            List<User> listUser = new List<User>();
            listUser = user.GetUserList();
            listViewUsers.Items.Clear();
            if (listUser != null)
            {
                foreach (User userItem in listUser)
                {
                    ListViewItem item = new ListViewItem(userItem.UserId.ToString());
                    item.SubItems.Add(userItem.Password);
                    item.SubItems.Add(userItem.FirstName);
                    item.SubItems.Add(userItem.LastName);
                    item.SubItems.Add(userItem.JobTitle);
                    item.SubItems.Add(userItem.UserStatus);
                    listViewUsers.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no user now!", "Confirmation");
            }

            
        }

        private void buttonAddE_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmployeeId.Text.Trim();
            if (!Validator.IsValidId(empId, 4))
            {
                MessageBox.Show("Invalid Employee Number", "Error");
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }
            Employee emp = new Employee();
            emp = emp.GetEmployee(Convert.ToInt32(empId));
            if (emp != null)
            {
                MessageBox.Show("This Employee Number already exists!", "Duplicate Employee Number");
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }



            string Fname = textBoxFirstName.Text.Trim();
            if (!Validator.IsValidName(Fname))
            {
                MessageBox.Show("Invalid First Name", "Error");
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }

            string Lname = textBoxLastName.Text.Trim();
            if (!Validator.IsValidName(Lname))
            {
                MessageBox.Show("Invalid Last Name", "Error");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            string phone = maskedTextBoxPhone.Text.Trim();
                        

            string email = textBoxEmail.Text.Trim();
            if (Validator.IsEmpty(email))
            {
                MessageBox.Show("Email cannot be empty", "Error");
                textBoxEmail.Focus();
                return;
            }
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email is not valid, try again !", "Error");
                textBoxEmail.Clear();
                textBoxEmail.Focus();
                return;
            }

            int selectedIndex = comboBoxJob.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select Job for this employee !", "Select Requirement");
                return;
            }


            Employee emp1 = new Employee();
            emp1.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            emp1.FirstName = textBoxFirstName.Text.Trim();
            emp1.LastName = textBoxLastName.Text.Trim();
            emp1.PhoneNumber = maskedTextBoxPhone.Text.Trim();
            emp1.Email = textBoxEmail.Text.Trim();
            emp1.JobId = Convert.ToInt32(comboBoxJob.SelectedValue);
            emp1.SaveEmployee(emp1);
            textBoxEmployeeId.Clear();
            textBoxEmployeeId.Focus();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxPhone.Clear();
            textBoxEmail.Clear();
            comboBoxJob.SelectedIndex = -1;

            MessageBox.Show("Employee info saved successfully", "Confirmation");
        }

        private void buttonExitE_Click(object sender, EventArgs e)
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
