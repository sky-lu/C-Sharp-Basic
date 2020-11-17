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
            List<Employee> lstEmp = new List<Employee>();
            Employee emp = new Employee();
            lstEmp = emp.GetEmployeeList();
            foreach (Employee Emp in lstEmp)
            {
                comboBoxEmployeeId.Items.Add(Emp.EmployeeId);
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonListAllUsers_Click(object sender, EventArgs e)
        {

            
            
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
            User auser = new User();
            auser.UserId = Convert.ToInt32(textBoxUserId.Text.Trim());
            auser.Password = textBoxPassword.Text.Trim();
            auser.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.SelectedItem);
            auser.UpdateUser(auser);
            textBoxUserId.Clear();
            textBoxUserId.Focus();
            textBoxPassword.Clear();
            comboBoxEmployeeId.SelectedIndex = -1;
            
            MessageBox.Show("This User has been updated successfully!", "Confirmation");
        }

        private void buttonAddU_Click(object sender, EventArgs e)
        {
            string userId = textBoxUserId.Text.Trim();
            if (!Validator.IsValidId(userId, 3))
            {
                MessageBox.Show("Invalid User Number", "Error");
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }
            User auser = new User();
            auser = auser.GetUser(Convert.ToInt32(userId));
            if (auser != null)
            {
                MessageBox.Show("This User Number already exists!", "Duplicate User Number");
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                return;
            }


            string passWord = textBoxPassword.Text.Trim();
            if (Validator.IsEmpty(passWord))
            {
                MessageBox.Show("Password cannot be empty", "Error");
                textBoxPassword.Focus();
                return;
            }
            

            int selectedIndex = comboBoxEmployeeId.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select EmployeeId for this user !", "Select Requirement");
                return;
            }


            User user1 = new User();
            user1.UserId = Convert.ToInt32(textBoxUserId.Text.Trim());
            user1.Password = textBoxPassword.Text.Trim();
            user1.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.SelectedItem);
            user1.SaveUser(user1);
            textBoxUserId.Clear();
            textBoxPassword.Clear();
            labelUserInfo.Text = "";
            comboBoxEmployeeId.SelectedIndex = -1;

            MessageBox.Show("User info saved successfully", "Confirmation");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExitU_Click(object sender, EventArgs e)
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

        private void comboBoxEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBoxEmployeeId.SelectedIndex;
            if (indexSelected != -1)
            {
                Job aJob = new Job();
                Employee emp = new Employee();
                int empId = Convert.ToInt32(comboBoxEmployeeId.SelectedItem);
                emp = emp.GetEmployee(empId);
                labelUserInfo.Text = "First Name:" + emp.FirstName + "\n" + "Last Name :" + emp.LastName + "\n"
                                     + "Phone NUmber :" + emp.PhoneNumber + "\n" + "Email :" + emp.Email + "\n"
                                     + "Job Title :" + aJob.GetJobTitle(emp.JobId);
            }
            else
            {
                labelUserInfo.Text = "";
            }
        }

        private void comboBoxSearchU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonListAllUsers_Click_1(object sender, EventArgs e)
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
                    item.SubItems.Add(userItem.EmployeeId.ToString());
                    listViewUsers.Items.Add(item);
                }
            }
            if (listUser.Count == 0)
            {
                MessageBox.Show("There is no user now!", "Confirmation");
            }

        }

        private void buttonSearchU_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxSearchU.SelectedIndex;
            if (indexSelected == 0)
            {
                string userId = textBoxSearchU.Text.Trim();
                if (!Validator.IsValidId(userId, 3))
                {
                    MessageBox.Show("Invalid User Id", "Error");
                    textBoxSearchU.Clear();
                    textBoxSearchU.Focus();
                    return;
                }
                User auser = new User();
                auser = auser.GetUser((Convert.ToInt32(userId)));
                if (auser != null)
                {

                    textBoxUserId.Text = auser.UserId.ToString();
                    textBoxPassword.Text = auser.Password;
                    comboBoxEmployeeId.SelectedIndex = comboBoxEmployeeId.FindStringExact(auser.EmployeeId.ToString());
                    listViewUsers.Items.Clear();

                }
                else
                {
                    textBoxSearchU.Clear();
                    textBoxSearchU.Focus();
                    MessageBox.Show("This UserId doesn't exit!", "Confirmation");
                }
            }
        }

        private void buttonDeleteU_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int userId = Convert.ToInt32(textBoxUserId.Text.Trim());
                User auser = new User();
                auser.DeleteUser(userId);
                textBoxUserId.Clear();
                textBoxPassword.Clear();
                comboBoxEmployeeId.SelectedIndex = -1;
                MessageBox.Show("This user has been deleted!", "Confirmation");
                return;
            }
            
        }

        private void buttonDeleteE_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this employee?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int empId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
                Employee emp = new Employee();
                User auser = new User();
                 auser = auser.GetUserByEmpId(empId);
                if (auser == null)
                {
                    emp.DeleteEmployee(empId);
                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    maskedTextBoxPhone.Clear();
                    textBoxEmail.Clear();
                    comboBoxJob.SelectedIndex = -1;
                    MessageBox.Show("This employee has been deleted!", "Confirmation");

                }
                else
                {
                    MessageBox.Show("Please delete the user record related to this employee first", "Delete Error");
                }
                
            }
            
        }
    }
}
