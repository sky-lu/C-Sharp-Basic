using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppEntityFramework.GUI
{
    public partial class EFTestForm : Form
    {
        EmployeeProjectDBEntities dbEntities = new EmployeeProjectDBEntities();
        public EFTestForm()
        {
            InitializeComponent();
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            // LINQ To Entities
            var listEmp = from emp in dbEntities.Employees
                          select emp;
            string display = "";
            foreach (var emp in listEmp)
            {
                display += emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName + "," + 
                           emp.PhoneNumber + "," + emp.Email + "\n";
            }
            MessageBox.Show(display, "List of Employees");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Data Validation
            //Check Duplicate EmployeeId
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(1414);
            if(emp != null)
            {
                MessageBox.Show("EmployeeId already exists!", "Duplicate EmployeeId");
                return;
            }
            emp.EmployeeId = 1414;          
            emp.FirstName = "Maria";
            emp.LastName = "Nguyen";
            emp.PhoneNumber = "514-111-1111";
            emp.Email = "mariaNguyen@yahoo.ca";
            dbEntities.Employees.Add(emp);
            dbEntities.SaveChanges();// Save to the database
            MessageBox.Show("Employee saved successfully", "Confirmation");


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(1414);
            if (emp != null)
            {
                emp.EmployeeId = 1414;
                emp.FirstName = "Maria";
                emp.LastName = "Brown";
                emp.PhoneNumber = "514-111-1111";
                emp.Email = "mariaBrown@yahoo.ca";
                dbEntities.SaveChanges();
                MessageBox.Show("Employee updated successfully", "Confirmation");
            }
            else
            {
                MessageBox.Show("Employee not found", "error");
                return;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(1414);
           //emp = dbEntities.Employees.Where(emp1 => emp1.EmployeeId == 1414).FirstOrDefault();
            if (emp != null)
            {
                dbEntities.Employees.Remove(emp);
                dbEntities.SaveChanges();//delete this employee from the database
                MessageBox.Show("Employee deleted successfully!", "Confirmation");
            }
            else
            {
                MessageBox.Show("Employee not found", "error");
                return;
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
