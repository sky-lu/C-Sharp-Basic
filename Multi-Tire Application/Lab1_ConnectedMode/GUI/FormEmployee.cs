using Lab1_ConnectedModel.BLL;
using Lab1_ConnectedModel.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_ConnectedModel.GUI
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tempId = txtEmployeeID.Text.Trim();
            if(!Validator.IsValidId(tempId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;
            }
            Employee emp = new Employee();
            emp = emp.GetEmployee(Convert.ToInt32(tempId));
            if (emp != null)
            {
                MessageBox.Show("This EmployeeId already exists!", "Duplicate Employee ID");
                txtEmployeeID.Clear();
                txtEmployeeID.Focus();
                return;
            }
            
           

            string tempFname = txtFirstName.Text.Trim();
            if (!Validator.IsValidName(tempFname))
            {
                MessageBox.Show("Invalid First Name", "Error");
                txtFirstName.Clear();
                txtFirstName.Focus();
                return;
            }

            string tempLname = txtLastName.Text.Trim();
            if (!Validator.IsValidName(tempLname))
            {
                MessageBox.Show("Invalid Last Name", "Error");
                txtLastName.Clear();
                txtLastName.Focus();
                return;
            }

            string tempJob = txtJobTitle.Text.Trim();
            if (Validator.IsEmpty(tempJob))
            {
                MessageBox.Show("Jobtitle cannot be empty", "Error");
                txtJobTitle.Clear();
                return;
            }

            Employee emp1 = new Employee();
            emp1.EmployeeId = Convert.ToInt32(txtEmployeeID.Text);
            emp1.FirstName = txtFirstName.Text.Trim();
            emp1.LastName = txtLastName.Text.Trim();
            emp1.JobTitle = txtJobTitle.Text.Trim();
            emp1.SaveEmployee(emp1);
            txtEmployeeID.Clear();
            txtEmployeeID.Focus();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtJobTitle.Clear();
            MessageBox.Show("Employee info saved successfully", "Confirmation");

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = new List<Employee>();
            listEmp = emp.GetEmployeeList();
            listViewEmployees.Items.Clear();
            if (listEmp != null)
            {
                foreach (Employee anEmp in listEmp)
                {
                    ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                    item.SubItems.Add(anEmp.FirstName);
                    item.SubItems.Add(anEmp.LastName);
                    item.SubItems.Add(anEmp.JobTitle);
                    listViewEmployees.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no employee now!", "Confirmation");
            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBoxSearch.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    labelinfo.Text = "Please enter Employee Id";
                    txtSearch.Clear();
                    txtSearch.Focus();
                    break;
                case 1:
                    labelinfo.Text = "Please enter First Name";
                    txtSearch.Clear();
                    txtSearch.Focus();
                    break;
                case 2:
                    labelinfo.Text = "Please enter Last Name";
                    txtSearch.Clear();
                    txtSearch.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxSearch.SelectedIndex;
            if (indexSelected == 0) { 
                string tempId = txtSearch.Text.Trim();
                if (!Validator.IsValidId(tempId, 4))
                {
                    MessageBox.Show("Invalid Employee Id", "Error");
                    txtSearch.Clear();
                    txtSearch.Focus();
                    return;
                }
                Employee emp = new Employee();
                emp = emp.GetEmployee(Convert.ToInt32(tempId));
                if (emp != null)
                {
                    txtEmployeeID.Text = emp.EmployeeId.ToString();
                    txtFirstName.Text = emp.FirstName;
                    txtLastName.Text = emp.LastName;
                    txtJobTitle.Text = emp.JobTitle;
                    //return;
                }
                else
                {
                    MessageBox.Show("This EmployeeId doesn't exit!", "Confirmation");
                }
            }
            else if (indexSelected == 1 || indexSelected == 2)
            {
                int index = indexSelected;
                string tempName = txtSearch.Text.Trim();
                if (!Validator.IsValidName(tempName))
                {
                    MessageBox.Show("Invalid Name", "Error");
                    txtSearch.Clear();
                    txtSearch.Focus();
                    return;
                }
                Employee emp = new Employee();
                List<Employee> listEmp = new List<Employee>();
                listEmp = emp.GetEmployeeList(index, tempName);
                listViewEmployees.Items.Clear();
                if (listEmp != null)
                {
                    foreach (Employee anEmp in listEmp)
                    {
                        ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                        item.SubItems.Add(anEmp.FirstName);
                        item.SubItems.Add(anEmp.LastName);
                        item.SubItems.Add(anEmp.JobTitle);
                        listViewEmployees.Items.Add(item);
                    }
                    //return;
                }
                if (listEmp.Count == 0)
                {
                    MessageBox.Show("This Name doesn't exist!", "Confirmation");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please select option first!", "Error");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(txtEmployeeID.Text);
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.JobTitle = txtJobTitle.Text;
            emp.UpdateEmployee(emp);
            txtEmployeeID.Clear();
            txtEmployeeID.Focus();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtJobTitle.Clear();
            MessageBox.Show("This Employee has been updated successfully!", "Confirmation");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this employee?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                int temId = Convert.ToInt32(txtEmployeeID.Text);
                Employee emp = new Employee();
                emp.DeleteEmployee(temId);
                txtEmployeeID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtJobTitle.Clear();
                txtSearch.Clear();
                MessageBox.Show("This employee has been deleted!", "Confirmation");
                return;
            }
            else if(result == DialogResult.No)
            {
                txtSearch.Focus();
                return;
            }
        }
    }
}
