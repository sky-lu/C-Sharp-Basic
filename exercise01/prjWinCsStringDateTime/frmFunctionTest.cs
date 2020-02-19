using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsStringDateTime
{
    public partial class frmFunctionTest : Form
    {
        public frmFunctionTest()
        {
            InitializeComponent();
        }
        
        //private string getLastName (string email)
        //{
        //    string lname;
        //    lname = email.Substring(0, email.IndexOf("."));
        //    return lname.Trim();
        //}
        //private string getFirstName (string email)
        //{
        //    string fname;
        //    fname = email.Substring(email.IndexOf(".") + 1, email.IndexOf("@") - email.IndexOf(".") - 1);
        //    return fname.Trim();
        //}
        //private string getCompany (string email)
        //{
        //    string comp;
        //    int posA = email.IndexOf("@");
        //    int posP2 = email.IndexOf(".", posA);
        //    comp = email.Substring(posA + 1, posP2 - posA - 1);
        //    return comp.Trim();
        //}
        //private string toUpLower(string anyString)
        //{
        //    return anyString.Substring(0, 1).ToUpper() + anyString.Substring(1).ToLower();
        //}
        //private string getGenderTitle()
        //{
        //    return (radMale.Checked) ? "Sir" : "Miss";
        //}
        //private int CalculateAge(Int32 CurrentYear, Int32 YearBorn)
        //{
        //    return CurrentYear - YearBorn;
        //}
        //private decimal GetSalary(string function)
        //{
        //    switch (function)
        //    {
        //        case "Analyst":
        //            return 80000;
        //        case "Programmer":
        //            return 50000;
        //        case "Secretary":
        //            return 30000;
        //    }
        //    return 0;




        }

        //---------------------------------------------------------------------------------------------------------------
        // a function to calculate age
        private Int32 GetAge(DateTime Birth)
        {
            Int32 yb, mb, db , age;
            yb = Birth.Year;
            mb = Birth.Month;
            db = Birth.Day;
            if (DateTime.Today.Month > mb)
            {
                age = DateTime.Today.Year - yb;
            }else if (DateTime.Today.Month < mb)
            {
                age = DateTime.Today.Year - yb - 1;
            }
            else
            {
                if(DateTime.Today.Day >= db)
                {
                    age = DateTime.Today.Year - yb;
                }
                else
                {
                    age = DateTime.Today.Year - yb - 1;
                }
            }

            return age;

        }

        // a function to get salary
        private int GetSalary(string comboitem)
        {
            Int32 salary;
            string pos = comboitem.Trim();
            if( pos == "Programmer")
            {
                salary = 50000;
            }else if( pos == "Analyst")
            {
                salary = 80000;
            }else
            {
                salary = 30000;
            }
            return salary;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            // email validation
            string email, Lname, Fname, Company;
            int posD1, posA, posD2;
            email = txtEmail.Text.Trim();
            if(email.Length == 0)
            {
                MessageBox.Show("Please enter Email !");
                txtEmail.Focus();
                return;
            }
            posD1 = email.IndexOf(".");
            if(posD1 == -1)
            {
                MessageBox.Show("Please enter dot !");
                txtEmail.Focus();
                return;
            }
            Lname = email.Substring(0, posD1).Trim();
            Lname = Lname.Substring(0, 1).ToUpper() + Lname.Substring(1).ToLower();

            if (Lname.Length == 0)
            {
                MessageBox.Show("Please enter Lastname !");
                txtEmail.Focus();
                return;
            }
            posA = email.IndexOf("@");
            if(posA == -1)
            {
                MessageBox.Show("Please enter @");
                txtEmail.Focus();
                return;
            }
            Fname = email.Substring(posD1 + 1, posA - posD1 - 1).Trim();
            Fname = Fname.Substring(0, 1).ToUpper() + Fname.Substring(1).ToLower();
            if(Fname.Length == 0)
            {
                MessageBox.Show("Please enter Firstname !");
                txtEmail.Focus();
                return;
            }
            posD2 = email.IndexOf(".", posA);
            if(posD2 == -1)
            {
                MessageBox.Show("Please enter another dot !");
                txtEmail.Focus();
                return;
            }
            Company = email.Substring(posA + 1, posD2 - posA - 1).Trim();
            if(Company.Length == 0)
            {
                MessageBox.Show("Please enter Company !");
                txtEmail.Focus();
                return;
            }


            // check gender
            if (radMale.Checked)
            {
                lblResult.Text = " Sir " + Fname + " " + Lname + " , " +  "\n" + " At " + Company + " with your age ";
            }
            else
            {
                lblResult.Text = " Madame " + Fname + " " + Lname + " , " + "\n" + " At " + Company + " with your age ";
            }

            // call function GetAge()
            lblResult.Text = lblResult.Text + "(" + GetAge(dtpBirth.Value) + ")" + "\n";

            // display the position and salary
            lblResult.Text += " and position (" + combFunction.SelectedItem.ToString() + "), your salary is ";
            lblResult.Text += GetSalary(combFunction.SelectedItem.ToString());




            //--------------------------------------------------------------------------------------------
            //string email = txtEmail.Text.Trim();
            //string lname = getLastName(email);
            //string fname = getFirstName(email);
            //string comp = getCompany(email);
            //lname = toUpLower(lname);
            //fname = toUpLower(fname);
            //comp = toUpLower(comp);
            //int age = CalculateAge(DateTime.Today.Year, dtpBirth.Value.Year);
            //decimal salary = GetSalary(combFunction.SelectedItem.ToString());
            //string result = getGenderTitle() + fname + " " + lname + ",\n ";
            //result += "At" + comp + ",with your age (" + age + "),\n";
            //result += "And position (" + combFunction.SelectedItem.ToString() + "),\n";
            //result += "Your salary is" + salary + ".\n";
            //lblResult.Text = result;
        }

        private void frmFunctionTest_Load(object sender, EventArgs e)
        {
            //// copy the codes from the website
            //dtpBirth.CustomFormat = " ";
            //dtpBirth.Format = DateTimePickerFormat.Custom;
        }
    }
}
