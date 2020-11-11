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

    public partial class TestForm2 : Form
    {
        EmployeeProjectDBEntities dbEntities = new EmployeeProjectDBEntities();

        public TestForm2()
        {
            InitializeComponent();
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {
            // LINQ to Entities
            var listEmp = from emp in dbEntities.Employees
                          select emp;
            foreach (Employee emp in listEmp)
            {
                comboBoxEmployee.Items.Add(emp.EmployeeId);
            }
            var listProj = (from proj in dbEntities.Projects
                           select proj).ToList<Project>();
            foreach (Project proj in listProj)
            {
                comboBoxProject.Items.Add(proj.ProjectCode);
            }
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
            Employee emp = new Employee();
            //LINQ To Entities

            emp = dbEntities.Employees.Where(x => x.EmployeeId == searchId).FirstOrDefault();
            labelEmpInfo.Text = emp.EmployeeId.ToString() + "," + emp.FirstName + "," + emp.LastName;
        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = comboBoxProject.SelectedItem.ToString();
            Project prj = new Project();
            prj = dbEntities.Projects.Where(x => x.ProjectCode == code).FirstOrDefault();
            labelProjInfo.Text = prj.ProjectCode + "," + prj.ProjectTitle;
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {

        }
    }
}
