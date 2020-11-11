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
            //if (Validator.IsEmpty(phone))
            //{
            //    MessageBox.Show("Phone Number cannot be empty", "Error");
            //    maskedTextBoxPhone.Focus();
            //    return;
            //}
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
            int empId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());
            Employee emp = new Employee();
            emp = dbEntities.Employees.Find(empId);

            if (emp != null)
            {
                var result = MessageBox.Show("Are you sure to delete this employee?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    var lstPrjAssignment = from prjAssignment in dbEntities.ProjectAssignments.Where(x => x.EmployeeId == empId)
                                           select prjAssignment;
                    if (lstPrjAssignment.Count() == 0) 
                    { 
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
                        MessageBox.Show("Please delete all assignments releted to this employee first.", "Requirements");

                    }
                }
                
            }
            else
            {
                MessageBox.Show("Employee not found", "error");
                return;
            }
        }

        private void buttonExitP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonListP_Click(object sender, EventArgs e)
        {
            listViewProject.Items.Clear();
            var listPrj = from prj in dbEntities.Projects
                          select prj;
            if (listPrj != null)
            {
                foreach (var prj in listPrj)
                {
                    ListViewItem item = new ListViewItem(prj.ProjectCode);
                    item.SubItems.Add(prj.ProjectTitle);
                    listViewProject.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no project now!", "Confirmation");
            }
        }

        private void buttonSaveP_Click(object sender, EventArgs e)
        {
            string prjCode = textBoxProjectCode.Text.Trim();
            if (Validator.IsEmpty(prjCode))
            {
                MessageBox.Show("Please enter the project code !", "Empty Error");
                textBoxProjectCode.Focus();
                return;
            }
            Project prj = new Project();
            prj = dbEntities.Projects.Find(prjCode);
            if (prj != null)
            {
                MessageBox.Show("This Project Code already exists!", "Duplicate Project Code");
                textBoxProjectCode.Clear();
                textBoxProjectCode.Focus();
                return;
            }


            string prjTitle = textBoxProjectTitle.Text.Trim();
            if (Validator.IsEmpty(prjTitle))
            {
                MessageBox.Show("Please enter the project title !", "Empty Error");
                textBoxProjectTitle.Focus();
                return;
            }

            Project prj1 = new Project();
            prj1.ProjectCode = textBoxProjectCode.Text.Trim();
            prj1.ProjectTitle = textBoxProjectTitle.Text.Trim();
            dbEntities.Projects.Add(prj1);
            dbEntities.SaveChanges();
            textBoxProjectCode.Clear();
            textBoxProjectCode.Focus();
            textBoxProjectTitle.Clear();

            MessageBox.Show("The project has been saved successfully !", "Confirmation");

        }

        private void buttonUpdateP_Click(object sender, EventArgs e)
        {
            string prjCode = textBoxProjectCode.Text.Trim();
            Project prj = new Project();
            prj = dbEntities.Projects.Find(prjCode);
            if (prj != null)
            {
                prj.ProjectCode = textBoxProjectCode.Text.Trim();
                prj.ProjectTitle = textBoxProjectTitle.Text.Trim();
                dbEntities.SaveChanges();
                MessageBox.Show("Project has been updated successfully", "Confirmation");
            }
            else
            {
                MessageBox.Show("Project not found", "error");
                return;
            }
        }

        private void buttonDeleteP_Click(object sender, EventArgs e)
        {
            string prjCode = textBoxProjectCode.Text.Trim();
            Project prj = new Project();
            prj = dbEntities.Projects.Find(prjCode);

            if (prj != null)
            {
                var result = MessageBox.Show("Are you sure to delete this project?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var lstPrjAssignment = from prjAssignment in dbEntities.ProjectAssignments.Where(x => x.ProjectCode == prjCode)
                                           select prjAssignment;
                    if (lstPrjAssignment.Count() == 0)
                    { 
                        dbEntities.Projects.Remove(prj);
                        dbEntities.SaveChanges();
                        textBoxProjectCode.Clear();
                        textBoxProjectTitle.Clear();

                        MessageBox.Show("Project has been deleted successfully!", "Confirmation");
                    }
                    else
                    {
                        MessageBox.Show("Please delete all assignments relatted to this project first.", "Requirement");
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Project not found", "error");
                return;
            }
        }

        private void buttonSearchP_Click(object sender, EventArgs e)
        {
            textBoxProjectCode.Clear();
            textBoxProjectTitle.Clear();
            int indexSelected = comboBoxSearchP.SelectedIndex;
            if (indexSelected == 0)
            {
                string prjCode = textBoxSearchP.Text.Trim();
                if ( Validator.IsEmpty(prjCode))
                {
                    MessageBox.Show("Please enter the search information", "Empty Error");
                    textBoxSearchP.Focus();
                    return;
                }
                Project prj = new Project();
                prj = dbEntities.Projects.Find(prjCode);
                if (prj != null)
                {
                    textBoxProjectCode.Text = prj.ProjectCode;
                    textBoxProjectTitle.Text = prj.ProjectTitle;
                    textBoxSearchP.Clear();
                    comboBoxSearchP.SelectedIndex = -1;
                    return;
                }
                else
                {
                    MessageBox.Show("This Project Code doesn't exit!", "Confirmation");
                }

            }
        }

        private void buttonExitAssignProject_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeProjectForm_Load(object sender, EventArgs e)
        {
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
            if (comboBoxEmployee.SelectedIndex != -1) { 
                int searchId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
                Employee emp = new Employee();

                emp = dbEntities.Employees.Where(x => x.EmployeeId == searchId).FirstOrDefault();
                labelEmpInfo.Text = emp.FirstName + "\n" + emp.LastName + "\n" + emp.PhoneNumber + "\n" + emp.Email + "\n";
        
            }
        }
        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProject.SelectedIndex != -1) 
            { 
                string code = comboBoxProject.SelectedItem.ToString();
                Project prj = new Project();
                prj = dbEntities.Projects.Where(x => x.ProjectCode == code).FirstOrDefault();
                labelProjInfo.Text = prj.ProjectTitle;
            }
        }

        private void buttonListAssignedProject_Click(object sender, EventArgs e)
        {
            listViewAssignProject.Items.Clear();
            var listPrjAssignment = from prjAssignment in dbEntities.ProjectAssignments
                          select prjAssignment;
            if (listPrjAssignment != null)
            {
                foreach (var prjAssignment in listPrjAssignment)
                {
                    ListViewItem item = new ListViewItem(prjAssignment.EmployeeId.ToString());
                    item.SubItems.Add(prjAssignment.ProjectCode);
                    item.SubItems.Add(prjAssignment.StartingDate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(prjAssignment.EndingDate.ToString("yyyy-MM-dd"));
                    listViewAssignProject.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There is no project assignment now!", "Confirmation");
            }
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
            string prjCode = comboBoxProject.SelectedItem.ToString();
            ProjectAssignment prjAssignment = new ProjectAssignment();
            prjAssignment = dbEntities.ProjectAssignments.Where(x => x.EmployeeId == empId && x.ProjectCode == prjCode).FirstOrDefault();
            if (prjAssignment != null)
            {
                MessageBox.Show("This Project has been assigned, select another project !", "Assignment Notification");
                comboBoxEmployee.SelectedIndex = -1;
                labelEmpInfo.Text = "";
                comboBoxProject.SelectedIndex = -1;
                labelProjInfo.Text = "";
                maskedTextBoxStartDate.Clear();
                maskedTextBoxEndDate.Clear();
                return;
            }
            
            ProjectAssignment prjAssignment1 = new ProjectAssignment();

            prjAssignment1.EmployeeId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
            prjAssignment1.ProjectCode = comboBoxProject.SelectedItem.ToString();
            prjAssignment1.StartingDate = Convert.ToDateTime(maskedTextBoxStartDate.Text);
            prjAssignment1.EndingDate = Convert.ToDateTime(maskedTextBoxEndDate.Text);
            dbEntities.ProjectAssignments.Add(prjAssignment1);
            dbEntities.SaveChanges();
            comboBoxEmployee.SelectedIndex = -1;
            labelEmpInfo.Text = "";
            comboBoxProject.SelectedIndex = -1;
            labelProjInfo.Text = "";
            maskedTextBoxStartDate.Clear();
            maskedTextBoxEndDate.Clear();
            MessageBox.Show("This project is assigned successfully !", "Confirmation");
            
        }

        private void buttonSearchAssginment_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.SelectedIndex != -1 && comboBoxProject.SelectedIndex == -1)
            {
                listViewAssignProject.Items.Clear();
                int empId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
                var lstPrjAssignment = from prjAssignment in dbEntities.ProjectAssignments.Where(x => x.EmployeeId == empId)
                                       select prjAssignment;
                if (lstPrjAssignment.Count() == 0)
                {
                    MessageBox.Show("This employee does not have any project assignment now.", "Confirmation");
                    return;
                }

                if (lstPrjAssignment != null)
                {
                    foreach (var prjAssignment in lstPrjAssignment)
                    {
                        ListViewItem item = new ListViewItem(prjAssignment.EmployeeId.ToString());
                        item.SubItems.Add(prjAssignment.ProjectCode);
                        item.SubItems.Add(prjAssignment.StartingDate.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(prjAssignment.EndingDate.ToString("yyyy-MM-dd"));
                        listViewAssignProject.Items.Add(item);
                    }
                }
                
                                       
                return;
            }
            if(comboBoxEmployee.SelectedIndex == -1 && comboBoxProject.SelectedIndex != -1)
            {
                listViewAssignProject.Items.Clear();
                string prjCode = comboBoxProject.SelectedItem.ToString();
                var lstPrjAssignment = from prjAssignment in dbEntities.ProjectAssignments.Where(x => x.ProjectCode == prjCode)
                                       select prjAssignment;
                if (lstPrjAssignment.Count() == 0)
                {
                    MessageBox.Show("This project has not been assigned to any employee.", "Confirmation");
                    return;
                }

                if (lstPrjAssignment != null)
                {
                    foreach (var prjAssignment in lstPrjAssignment)
                    {
                        ListViewItem item = new ListViewItem(prjAssignment.EmployeeId.ToString());
                        item.SubItems.Add(prjAssignment.ProjectCode);
                        item.SubItems.Add(prjAssignment.StartingDate.ToString("yyyy-MM-dd"));
                        item.SubItems.Add(prjAssignment.EndingDate.ToString("yyyy-MM-dd"));
                        listViewAssignProject.Items.Add(item);
                    }
                }
                return;
            }
            if(comboBoxEmployee.SelectedIndex != -1 && comboBoxProject.SelectedIndex != -1)
            {
                int empId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
                string prjCode = comboBoxProject.SelectedItem.ToString();
                ProjectAssignment prjAssignment = new ProjectAssignment();
                prjAssignment = dbEntities.ProjectAssignments.Where(x => x.EmployeeId == empId && x.ProjectCode == prjCode).FirstOrDefault();
                if (prjAssignment != null)
                {
                    maskedTextBoxStartDate.Text = prjAssignment.StartingDate.ToString("MM-dd-yyyy");
                    maskedTextBoxEndDate.Text = prjAssignment.EndingDate.ToString("MM-dd-yyyy");
                }
                else
                {
                    MessageBox.Show("This project has not been assigned to this employee !", "Error");
                }
                return;
            }

        }

        private void buttonDeleteAssignmment_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
            string prjCode = comboBoxProject.SelectedItem.ToString();
            ProjectAssignment prjAssignment = new ProjectAssignment();
            prjAssignment = dbEntities.ProjectAssignments.Where(x => x.EmployeeId == empId && x.ProjectCode == prjCode).FirstOrDefault();
            if (prjAssignment != null)
            {
                var result = MessageBox.Show("Are you sure to delete this assignment?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) { 
                    dbEntities.ProjectAssignments.Remove(prjAssignment);
                    dbEntities.SaveChanges();
                    comboBoxEmployee.SelectedIndex = -1;
                    labelEmpInfo.Text = "";
                    comboBoxProject.SelectedIndex = -1;
                    labelProjInfo.Text = "";
                    maskedTextBoxStartDate.Clear();
                    maskedTextBoxEndDate.Clear();
                    MessageBox.Show("This project assignment has been deleted successfully!", "Confirmation");
                }
            }
            else
            {
                MessageBox.Show("This project has not been assigned to this employee !", "Error");
            }
        }

        private void buttonUpdateAssignment_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
            string prjCode = comboBoxProject.SelectedItem.ToString();
            ProjectAssignment prjAssignment = new ProjectAssignment();
            prjAssignment = dbEntities.ProjectAssignments.Where(x => x.EmployeeId == empId && x.ProjectCode == prjCode).FirstOrDefault();
            if (prjAssignment != null)
            {
                prjAssignment.EmployeeId = Convert.ToInt32(comboBoxEmployee.SelectedItem);
                prjAssignment.ProjectCode = comboBoxProject.SelectedItem.ToString();
                prjAssignment.StartingDate = Convert.ToDateTime(maskedTextBoxStartDate.Text);
                prjAssignment.EndingDate = Convert.ToDateTime(maskedTextBoxEndDate.Text);
                dbEntities.SaveChanges();
                comboBoxEmployee.SelectedIndex = -1;
                labelEmpInfo.Text = "";
                comboBoxProject.SelectedIndex = -1;
                labelProjInfo.Text = "";
                maskedTextBoxStartDate.Clear();
                maskedTextBoxEndDate.Clear();
                MessageBox.Show("This project Assignment has been updated !", "Confirmation");
            }
            else
            {
                MessageBox.Show("This project has not been assigned to this employee !", "Error");
            }
        }
    }
}


