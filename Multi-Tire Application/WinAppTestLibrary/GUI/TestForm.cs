using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechLibrary.Business;
using Hi_TechLibrary.Validation;

namespace WinAppTestLibrary.GUI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(1234, "Marie", "Brown", "514111-1111", "mary@yahoo.com");
            string fullName = emp.GetFullName(emp.FirstName, emp.LastName);
            MessageBox.Show(fullName, "Employee");
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string empId = textBoxEmployeeId.Text.Trim();
            if (!Validator.IsValidId(empId, 4))
            {
                MessageBox.Show("Invalid Employee Number", "Error");
                textBoxEmployeeId.Clear();
                textBoxEmployeeId.Focus();
                return;
            }

            string Fname = textBoxFirstName.Text.Trim();
            if ( ! Validator.IsValidName(Fname))
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

            MessageBox.Show("Valid input", "Confirmation");

        }
    }
}
