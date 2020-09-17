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
    }
}
