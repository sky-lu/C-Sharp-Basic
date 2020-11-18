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
using Hi_TechLibrary.BLL;
using Hi_TechLibrary.DAL;
using Hi_TechLibrary.VALIDATION;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Customer_Management_Form : Form
    {
        SqlDataAdapter da;
        DataSet dsHiTechDB;
        DataTable dtCustomers;
        SqlCommandBuilder sqlBuilder;
        Customer cust = new Customer();
        public Customer_Management_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
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

        private void Customer_Management_Form_Load(object sender, EventArgs e)
        {
            dsHiTechDB = new DataSet("HiTechDB");
            dtCustomers = new DataTable("Customers");
            dsHiTechDB.Tables.Add(dtCustomers);
            
            dtCustomers.Columns.Add("CustomerId", typeof(Int32));
            dtCustomers.Columns.Add("CustomerName", typeof(string));
            dtCustomers.Columns.Add("Street", typeof(string));
            dtCustomers.Columns.Add("City", typeof(string));
            dtCustomers.Columns.Add("PostalCode", typeof(string));
            dtCustomers.Columns.Add("Phone", typeof(string));
            dtCustomers.Columns.Add("Email", typeof(string));
            dtCustomers.Columns.Add("Fax", typeof(string));
            dtCustomers.Columns.Add("ContactName", typeof(string));
            dtCustomers.Columns.Add("CreditLimit", typeof(Int32));

            dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };

            da = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            sqlBuilder = new SqlCommandBuilder(da);
        }

        private void buttonListFromDB_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            List<Customer> listCustomer = new List<Customer>();
            listCustomer = cust.GetCustomerList();
            if (listCustomer != null)
            {
                dataGridViewListFromDB.DataSource = listCustomer;
            }
            else
            {
                MessageBox.Show("There is no customer now !", "Confirmation");
            }
        }

        private void buttonListFromDS_Click(object sender, EventArgs e)
        {
            da.Fill(dsHiTechDB.Tables["Customers"]);
            dataGridViewListFromDS.DataSource = dsHiTechDB.Tables["Customers"];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string custId = textBoxCustomerId.Text.Trim();
            if (!Validator.IsValidId(custId, 4))
            {
                MessageBox.Show("Invalid Customer Number", "Error");
                textBoxCustomerId.Clear();
                textBoxCustomerId.Focus();
                return;
            }
                        
            if (dtCustomers.Rows.Contains(custId))
            {
                MessageBox.Show("This Customer Number already exists!", "Duplicate Customer Number");
                textBoxCustomerId.Clear();
                textBoxCustomerId.Focus();
                return;
            }



            string CustName = textBoxCustomerName.Text.Trim();
            if (!Validator.IsValidName(CustName))
            {
                MessageBox.Show("Invalid Customer Name", "Error");
                textBoxCustomerName.Clear();
                textBoxCustomerName.Focus();
                return;
            }

            string street = textBoxStreet.Text.Trim();
            if (Validator.IsEmpty(street))
            {
                MessageBox.Show("Please enter Street Name", "Empty Error");
                textBoxStreet.Clear();
                textBoxStreet.Focus();
                return;
            }

            string city = textBoxCity.Text.Trim();
            if (!Validator.IsValidName(city))
            {
                MessageBox.Show("Invalid City Name", "Empty Error");
                textBoxCity.Clear();
                textBoxCity.Focus();
                return;
            }

            string postCode = textBoxPostalCode.Text.Trim();
            if (Validator.IsEmpty(postCode))
            {
                MessageBox.Show("Postal Code cannot be empty", "Error");
                textBoxPostalCode.Focus();
                return;
            }
            
            string phone = maskedTextBoxPhone.Text.Trim();


            string email = textBoxEmail.Text.Trim();
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Email is not valid, try again !", "Error");
                textBoxEmail.Clear();
                textBoxEmail.Focus();
                return;
            }

            string fax = textBoxFax.Text.Trim();
            if (!Validator.IsNumber(fax))
            {
                MessageBox.Show("Fax is not valid, try again !", "Error");
                textBoxFax.Clear();
                textBoxFax.Focus();
                return;
            }


            string ContName = textBoxContactName.Text.Trim();
            if (!Validator.IsValidName(ContName))
            {
                MessageBox.Show("Invalid Contact Name", "Error");
                textBoxContactName.Clear();
                textBoxContactName.Focus();
                return;
            }

            string credit = textBoxCreditLimit.Text.Trim();
            if (!Validator.IsNumber(credit))
            {
                MessageBox.Show("Credit Limit is not valid, try again !", "Error");
                textBoxCreditLimit.Clear();
                textBoxCreditLimit.Focus();
                return;
            }

        }

        private void buttonUpdateDB_Click(object sender, EventArgs e)
        {
            da.Update(dsHiTechDB.Tables["Customers"]);
            MessageBox.Show("DataBase has been updated successfully", "Confirmation");
        }
    }
}
