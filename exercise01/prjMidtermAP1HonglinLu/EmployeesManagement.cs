using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjMidtermAP1HonglinLu
{
    public partial class EmployeesManagement : Form
    {
        public EmployeesManagement()
        {
            InitializeComponent();
        }

        struct Employee
        {
            public String Number;
            public String Fname;
            public String Lname;
            public String Company;
        }
        Employee[] tabEmplos = new Employee[20];
        Int16 current, nbEmplos;


        private Int16 FileToArray()
        {
            StreamReader myFile = new StreamReader("The text file Employees.txt");
            Int16 i = 0;
            while (myFile.EndOfStream == false)
            {
                String number = myFile.ReadLine();
                String fname = myFile.ReadLine();
                String lname = myFile.ReadLine();
                String company = myFile.ReadLine();
                tabEmplos[i].Number = number;
                tabEmplos[i].Fname = fname;
                tabEmplos[i].Lname = lname;
                tabEmplos[i].Company = company;
                i++;
            }
            myFile.Close();
            return i;
        }
        private bool Exist(String number)
        {
            foreach (Employee em in tabEmplos)
            {
                if (em.Number == number)
                {
                    return true;
                }
            }
            return false;
        }

        private void lstSelectNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 indx = lstSelectNumber.SelectedIndex;
            if (indx != -1)
            {
                txtNumber.Text = tabEmplos[indx].Number;
                txtFname.Text = tabEmplos[indx].Fname;
                txtLname.Text = tabEmplos[indx].Lname;
                txtCompany.Text = tabEmplos[indx].Company;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFname.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this employee?", "Employee Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtNumber.Text = txtFname.Text = txtLname.Text = txtCompany.Text = "";
                lstSelectNumber.Items.Remove(lstSelectNumber.SelectedItem);
            }
            for (Int32 j = lstSelectNumber.SelectedIndex; j <= nbEmplos; j++)
            {
                if (j != -1)
                {
                    tabEmplos[j] = tabEmplos[j + 1];
                }
            }
            nbEmplos--;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32 indx = lstSelectNumber.SelectedIndex;
            if (indx != -1)
            {
                txtFname.Text = txtFname.Text.Substring(0, 1).ToUpper() + txtFname.Text.Substring(1).ToLower();
                txtLname.Text = txtLname.Text.Substring(0, 1).ToUpper() + txtLname.Text.Substring(1).ToLower();
                txtCompany.Text = txtCompany.Text.Substring(0, 1).ToUpper() + txtCompany.Text.Substring(1).ToLower();

                tabEmplos[indx].Fname = txtFname.Text;
                tabEmplos[indx].Lname = txtLname.Text;
                tabEmplos[indx].Company = txtCompany.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Int32 indx = lstSelectNumber.SelectedIndex;
            if (indx != -1)
            {
                txtFname.Text = tabEmplos[indx].Fname;
                txtLname.Text = tabEmplos[indx].Lname;
                txtCompany.Text = tabEmplos[indx].Company;
            }
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String email, Lname, Fname, Company, Number;
            int posD1, posA, posD2, posD3;
            email = txtEmail.Text.Trim();
            if (email.Length == 0)
            {
                MessageBox.Show("Please enter Email !");
                txtEmail.Focus();
                return;
            }
            posD1 = email.IndexOf(".");
            if (posD1 == -1)
            {
                MessageBox.Show("Please enter dot !");
                txtEmail.Focus();
                return;
            }
            Fname = email.Substring(0, posD1).Trim();
            Fname = Fname.Substring(0, 1).ToUpper() + Fname.Substring(1).ToLower();

            if (Fname.Length == 0)
            {
                MessageBox.Show("Please enter Firstname !");
                txtEmail.Focus();
                return;
            }
            posD2 = email.IndexOf(".", posD1+1);
            if (posD2 == -1)
            {
                MessageBox.Show("Please enter another dot !");
                txtEmail.Focus();
                return;
            }
            Lname = email.Substring(posD1 + 1, posD2 - posD1 - 1).Trim();
            Lname = Lname.Substring(0, 1).ToUpper() + Lname.Substring(1).ToLower();
            if (Lname.Length == 0)
            {
                MessageBox.Show("Please enter Lastname !");
                txtEmail.Focus();
                return;
            }
            posA = email.IndexOf("@");
            if (posA == -1)
            {
                MessageBox.Show("Please enter @");
                txtEmail.Focus();
                return;
            }
            Number = email.Substring(posD2 + 1, posA - posD2 - 1).Trim();
            Number = Number.ToUpper();
            if (Number.Length == 0)
            {
                MessageBox.Show("Please enter number !");
                txtEmail.Focus();
                return;
            }
            posD3 = email.IndexOf(".", posA);
            if (posD3 == -1)
            {
                MessageBox.Show("Please enter another dot !");
                txtEmail.Focus();
                return;
            }
            Company = email.Substring(posA + 1, posD3 - posA - 1).Trim();
            Company = Company.Substring(0, 1).ToUpper() + Company.Substring(1).ToLower();
            if (Company.Length == 0)
            {
                MessageBox.Show("Please enter Company !");
                txtEmail.Focus();
                return;
            }


            if (nbEmplos < 20)
            {
                String number = Number;
                if (Exist(number))
                {
                    MessageBox.Show("Student already exist in list !");
                    return;
                }
                else
                {
                    Employee tmp;
                    tmp.Number = Number;
                    tmp.Fname = Fname;
                    tmp.Lname = Lname;
                    tmp.Company = Company;
                    
                    tabEmplos[nbEmplos] = tmp;
                    txtEmail.Text = "";
                    
                    nbEmplos++;
                    lstSelectNumber.Items.Add(Number);
                }

            }

            StreamWriter myFile = new StreamWriter("The text file Employees.txt",true);
            for(Int16 i = 0;i < nbEmplos; i++)
            {
                myFile.WriteLine(tabEmplos[i].Number);
                myFile.WriteLine(tabEmplos[i].Fname);
                myFile.WriteLine(tabEmplos[i].Lname);
                myFile.WriteLine(tabEmplos[i].Company);
            }
            myFile.Close();

        }

        public void EmployeesManagement_Load(object sender, EventArgs e)
        {
            nbEmplos = FileToArray();
            if (nbEmplos != 0)
            {
                for (Int16 indx = 0; indx < nbEmplos; indx++)
                {
                    lstSelectNumber.Items.Add(tabEmplos[indx].Number);
                }

            }
            else
            {
                MessageBox.Show("These is no employee !");
            }

        }
    }
}
