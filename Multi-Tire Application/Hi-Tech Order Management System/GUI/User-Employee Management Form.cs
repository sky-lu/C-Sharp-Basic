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

        private void buttonListE_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            List<Employee> listEmp = new List<Employee>();
            listEmp = Emp.GetEmployeeList();
            listViewEmployee.Items.Clear();
            if (listEmp != null)
            {
                foreach (Employee emp in listEmp)
                {
                    Job aJob = new Job();
                    ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.PhoneNumber);
                    item.SubItems.Add(emp.Email);
                    item.SubItems.Add(aJob.GetJobTitle(emp.JobId));
                    listViewEmployee.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no Employee now!", "Confirmation");
            }
        }

        private void buttonUpadateE_Click(object sender, EventArgs e)
        {
            //For this part , validation also needed.
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.PhoneNumber = maskedTextBoxPhone.Text.Trim();
            emp.Email = textBoxEmail.Text.Trim();
            emp.JobId = Convert.ToInt32(comboBoxJob.SelectedValue);
            emp.UpdateEmployee(emp);
            textBoxEmployeeId.Clear();
            textBoxEmployeeId.Focus();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            maskedTextBoxPhone.Clear();
            comboBoxJob.SelectedIndex = -1;
            MessageBox.Show("This Employee has been updated successfully!", "Confirmation");
        }

        private void buttonSearchE_Click(object sender, EventArgs e)
        {
            Job aJob = new Job();
            int indexSelected = comboBoxSearchE.SelectedIndex;
            if (indexSelected == 0)
            {
                string empId = textBoxSearchE.Text.Trim();
                if (!Validator.IsValidId(empId, 4))
                {
                    MessageBox.Show("Invalid Employee Id", "Error");
                    textBoxSearchE.Clear();
                    textBoxSearchE.Focus();
                    return;
                }
                Employee emp = new Employee();
                emp = emp.GetEmployee(Convert.ToInt32(empId));
                if (emp != null)
                {
                    
                    textBoxEmployeeId.Text = emp.EmployeeId.ToString();
                    textBoxFirstName.Text = emp.FirstName;
                    textBoxLastName.Text = emp.LastName;
                    maskedTextBoxPhone.Text = emp.PhoneNumber;
                    textBoxEmail.Text = emp.Email;
                    listViewEmployee.Items.Clear();
                    comboBoxJob.SelectedIndex = comboBoxJob.FindStringExact(aJob.GetJobTitle(emp.JobId));
                     
                   
                }
                else
                {
                    MessageBox.Show("This EmployeeId doesn't exit!", "Confirmation");
                }
            }
            else if (indexSelected == 1)
            {
                int index = indexSelected;
                string empName = textBoxSearchE.Text.Trim();
                if (!Validator.IsValidName(empName))
                {
                    MessageBox.Show("Invalid Last Name", "Error");
                    textBoxSearchE.Clear();
                    textBoxSearchE.Focus();
                    return;
                }
                Employee emp = new Employee();
                List<Employee> listEmp = new List<Employee>();
                listEmp = emp.GetEmployeeList(empName);
                listViewEmployee.Items.Clear();
                textBoxEmployeeId.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                maskedTextBoxPhone.Clear();
                textBoxEmail.Clear();
                comboBoxJob.SelectedIndex = -1;
                if (listEmp != null)
                {
                    foreach (Employee anEmp in listEmp)
                    {
                        ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                        item.SubItems.Add(anEmp.FirstName);
                        item.SubItems.Add(anEmp.LastName);
                        item.SubItems.Add(anEmp.PhoneNumber);
                        item.SubItems.Add(anEmp.Email);
                        item.SubItems.Add(aJob.GetJobTitle(anEmp.JobId));
                        listViewEmployee.Items.Add(item);
                    }
                    //return;
                }
                if (listEmp.Count == 0)
                {
                    MessageBox.Show("This Name doesn't exit!", "Confirmation");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select option first!", "Error");
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddU_Click(object sender, EventArgs e)
        {

        }
    }
}
