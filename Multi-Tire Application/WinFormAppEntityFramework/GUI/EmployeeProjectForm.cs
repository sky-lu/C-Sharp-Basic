using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAppEntityFramework.VALIDATION;

namespace WinFormAppEntityFramework.GUI
{
    public partial class EmployeeProjectForm : Form
    {
        EmployeeProjectDBEntities dbEntities = new EmployeeProjectDBEntities();
        public EmployeeProjectForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewEmployee.Items.Clear();
            var listEmp = from emp in dbEntities.Employees
                          select emp;
            if (listEmp != null)
            {
                foreach (var emp in listEmp)
                {
                    ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.PhoneNumber);
                    item.SubItems.Add(emp.Email);
                    listViewEmployee.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no employee now!", "Confirmation");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmployeeId.Text.Trim();
            if (!Validator.IsValidId(empId, 4))
            {
                MessageBox.Show("Invalid Employee ID", "Error");
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(Convert.ToInt32(empId));
            if (emp != null)
            {
                MessageBox.Show("This Employee Number already exists!", "Duplicate Employee Number");
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }



            string empFname = textBoxFirstName.Text.Trim();
            if (!Validator.IsValidName(empFname))
            {
                MessageBox.Show("Invalid First Name", "Error");
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;
            }

            string empLname = textBoxLastName.Text.Trim();
            if (!Validator.IsValidName(empLname))
            {
                MessageBox.Show("Invalid Last Name", "Error");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            string phone = maskedTextBoxPhone.Text.Trim();
            if (Validator.IsEmpty(phone))
            {
                MessageBox.Show("Phone Number cannot be empty", "Error");
                maskedTextBoxPhone.Focus();
                return;
            }
            //if (!Validator.IsValidId(phone, 10))
            //{
            //    MessageBox.Show("Invalid Phone Number", "Error");
            //    maskedTextBoxPhone.Clear();
            //    maskedTextBoxPhone.Focus();
            //    return;
            //}

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


            Employee emp1 = new Employee();
            emp1.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            emp1.FirstName = textBoxFirstName.Text.Trim();
            emp1.LastName = textBoxLastName.Text.Trim();
            emp1.PhoneNumber = maskedTextBoxPhone.Text.Trim();
            emp1.Email = textBoxEmail.Text.Trim();
            dbEntities.Employees.Add(emp1);
            dbEntities.SaveChanges();

            textBoxEmployeeId.Clear();
            textBoxEmployeeId.Focus();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxPhone.Clear();
            textBoxEmail.Clear();
            MessageBox.Show("Employee has been saved successfully", "Employee Saved");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxEmployeeId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxPhone.Clear();
            textBoxEmail.Clear();
            int indexSelected = comboBoxSearch.SelectedIndex;
            if (indexSelected == 0)
            {
                string empId = textBoxSearch.Text.Trim();
                if (!Validator.IsValidId(empId, 4))
                {
                    MessageBox.Show("Invalid Student Number", "Error");
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    return;
                }
                Employee emp = new Employee();
                emp = dbEntities.Employees.Find(Convert.ToInt32(empId));
                if (emp != null)
                {
                    textBoxEmployeeId.Text = emp.EmployeeId.ToString();
                    textBoxFirstName.Text = emp.FirstName;
                    textBoxLastName.Text = emp.LastName;
                    maskedTextBoxPhone.Text = emp.PhoneNumber;
                    textBoxEmail.Text = emp.Email;
                    return;
                }
                else
                {
                    MessageBox.Show("This Employee Number doesn't exit!", "Confirmation");
                }

            }
            if (indexSelected == 1)
            {
                string Lname = textBoxSearch.Text.Trim();
                if (!Validator.IsValidName(Lname))
                {
                    MessageBox.Show("Invalid Name", "Error");
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    return;
                }

                var listEmp = from emp in dbEntities.Employees
                              where emp.LastName == Lname
                              select emp;

                listViewEmployee.Items.Clear();
                if (listEmp != null)
                {
                    foreach (var emp in listEmp)
                    {
                        ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                        item.SubItems.Add(emp.FirstName);
                        item.SubItems.Add(emp.LastName);
                        item.SubItems.Add(emp.PhoneNumber);
                        item.SubItems.Add(emp.Email);
                        listViewEmployee.Items.Add(item);
                    }
                    //return;
                }
                if (listEmp.Count() == 0)
                {
                    MessageBox.Show("This Name doesn't exist!", "Confirmation");
                    return;
                }
                return;

            }
            else
            {
                MessageBox.Show("Please select option first!", "Error");
                return;
            }



        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmployeeId.Text.Trim();
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(Convert.ToInt32(empId));
            if (emp != null)
            {
                emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
                emp.FirstName = textBoxFirstName.Text.Trim();
                emp.LastName = textBoxLastName.Text.Trim();
                emp.PhoneNumber = maskedTextBoxPhone.Text.Trim();
                emp.Email = textBoxEmail.Text.Trim();
                dbEntities.SaveChanges();
                MessageBox.Show("Employee has been updated successfully", "Confirmation");
            }
            else
            {
                MessageBox.Show("Employee not found", "error");
                return;
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string empId = textBoxEmployeeId.Text.Trim();
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(Convert.ToInt32(empId));

            if (emp != null)
            {
                var result = MessageBox.Show("Are you sure to delete this employee?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) { 
                    dbEntities.Employees.Remove(emp);
                    dbEntities.SaveChanges();
                    textBoxEmployeeId.Clear();
                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxEmail.Clear();
                    maskedTextBoxPhone.Clear();

                    MessageBox.Show("Employee deleted successfully!", "Confirmation");
                }
                else 
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Employee not found", "error");
                return;
            }
        }
    }
}


