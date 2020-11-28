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
        SqlDataAdapter da_c, da_o;
        DataSet dsHiTechDB;
        DataTable dtCustomers, dtOrders;
        SqlCommandBuilder sqlBuilder_c, sqlBuilder_o;
        Customer cust = new Customer();
        public Customer_Management_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCustomerId.Clear();
            textBoxCustomerName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            maskedTextBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxFax.Clear();
            textBoxContactName.Clear();
            textBoxCreditLimit.Clear();

            int indexSelected = comboBoxSearch.SelectedIndex;
            if (indexSelected == 0)
            {
                string customerId = textBoxSearch.Text.Trim();
                if (!Validator.IsValidId(customerId, 4))
                {
                    MessageBox.Show("Invalid Customer Number, try again", "Error");
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    return;
                }
                DataRow dr = dtCustomers.Rows.Find(customerId);
                if (dr != null)
                {
                    textBoxCustomerId.Text = dr["CustomerId"].ToString();
                    textBoxCustomerName.Text = dr["CustomerName"].ToString();
                    textBoxStreet.Text = dr["Street"].ToString();
                    textBoxCity.Text = dr["City"].ToString();
                    textBoxPostalCode.Text = dr["PostalCode"].ToString();
                    maskedTextBoxPhone.Text = dr["Phone"].ToString();
                    textBoxEmail.Text = dr["Email"].ToString();
                    textBoxFax.Text = dr["Fax"].ToString();
                    textBoxContactName.Text = dr["ContactName"].ToString();
                    textBoxCreditLimit.Text = dr["CreditLimit"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Hide();
                Login_Form form_login = new Login_Form();
                form_login.ShowDialog();
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

            da_c = new SqlDataAdapter("SELECT * FROM Customers", UtilityDB.ConnectDB());
            sqlBuilder_c = new SqlCommandBuilder(da_c);
            da_c.Fill(dsHiTechDB.Tables["Customers"]);

            dtOrders = new DataTable("Orders");
            dsHiTechDB.Tables.Add(dtOrders);
            dtOrders.Columns.Add("OrderId", typeof(string));
            dtOrders.Columns.Add("OrderType", typeof(string));
            dtOrders.Columns.Add("OrderDate", typeof(DateTime));
            dtOrders.Columns.Add("RequiredDate", typeof(DateTime));
            dtOrders.Columns.Add("ShippingDate", typeof(DateTime));
            dtOrders.Columns.Add("OrderStatus", typeof(string));
            dtOrders.Columns.Add("CustomerId", typeof(Int32));
            dtOrders.Columns.Add("EployeeId", typeof(Int32));
            dtOrders.PrimaryKey = new DataColumn[] { dtOrders.Columns["OrderId"] };
            DataRelation drCToO = new DataRelation("CToO", dtCustomers.Columns["CustomerId"], dtOrders.Columns["CustomerId"]);
            dsHiTechDB.Relations.Add(drCToO);

            da_o = new SqlDataAdapter("SELECT * FROM Orders", UtilityDB.ConnectDB());
            sqlBuilder_o = new SqlCommandBuilder(da_o);
            da_o.Fill(dsHiTechDB.Tables["Orders"]);


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
            if (!Validator.IsPostalCode(postCode))
            {
                MessageBox.Show("Invalid Postal Code, please try again", "Error");
                textBoxPostalCode.Clear();
                textBoxPostalCode.Focus();
                return;
            }
            
            string phone = maskedTextBoxPhone.Text.Trim();
            //if (!Validator.IsPhone(phone))
            //{
            //    MessageBox.Show("Invalid Phone number, try again!", "Error");
            //    maskedTextBoxPhone.Clear();
            //    maskedTextBoxPhone.Focus();
            //    return;
            //}


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

            DataRow dr = dtCustomers.NewRow();
            dr["CustomerId"] = Convert.ToInt32(textBoxCustomerId.Text.Trim());
            dr["CustomerName"] = textBoxCustomerName.Text.Trim();
            dr["Street"] = textBoxStreet.Text.Trim();
            dr["City"] = textBoxCity.Text.Trim();
            dr["PostalCode"] = textBoxPostalCode.Text.Trim();
            dr["Phone"] = maskedTextBoxPhone.Text.Trim();
            dr["Email"] = textBoxEmail.Text.Trim();
            dr["Fax"] = textBoxFax.Text.Trim();
            dr["ContactName"] = textBoxContactName.Text.Trim();
            dr["CreditLimit"] = Convert.ToInt32(textBoxCreditLimit.Text.Trim());
            dtCustomers.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString(), "Confirmation");
            textBoxCustomerId.Clear();
            textBoxCustomerName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            maskedTextBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxFax.Clear();
            textBoxContactName.Clear();
            textBoxCreditLimit.Clear();

        }

        private void buttonUpdateDB_Click(object sender, EventArgs e)
        {
            da_c.Update(dsHiTechDB.Tables["Customers"]);
            MessageBox.Show("DataBase has been updated successfully", "Confirmation");
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string customerId = textBoxCustomerId.Text.Trim();
            if (!Validator.IsValidId(customerId, 4))
            {
                MessageBox.Show("Invalid Customer Number", "Error");
                textBoxCustomerId.Clear();
                textBoxCustomerId.Focus();
                return;
            }
            DataRow dr = dtCustomers.Rows.Find(Convert.ToInt32(customerId));
            if(dr != null) { 
                dr["CustomerId"] = Convert.ToInt32(textBoxCustomerId.Text.Trim());
                dr["CustomerName"] = textBoxCustomerName.Text.Trim();
                dr["Street"] = textBoxStreet.Text.Trim();
                dr["City"] = textBoxCity.Text.Trim();
                dr["PostalCode"] = textBoxPostalCode.Text.Trim();
                dr["Phone"] = maskedTextBoxPhone.Text.Trim();
                dr["Email"] = textBoxEmail.Text.Trim();
                dr["Fax"] = textBoxFax.Text.Trim();
                dr["ContactName"] = textBoxContactName.Text.Trim();
                dr["CreditLimit"] = Convert.ToInt32(textBoxCreditLimit.Text.Trim());
                MessageBox.Show(dr.RowState.ToString(), "Confirmation");
                textBoxCustomerId.Clear();
                textBoxCustomerName.Clear();
                textBoxStreet.Clear();
                textBoxCity.Clear();
                textBoxPostalCode.Clear();
                maskedTextBoxPhone.Clear();
                textBoxEmail.Clear();
                textBoxFax.Clear();
                textBoxContactName.Clear();
                textBoxCreditLimit.Clear();
            }
            else
            {
                MessageBox.Show("This customer does not exit !", "Error");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());
            DataRow dr = dtCustomers.Rows.Find(customerId);
            var result = MessageBox.Show("Are you sure to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                string expression = $"CustomerId = {customerId}";
                DataRow[] foundRows = dtOrders.Select(expression);
                if (foundRows.Length == 0)
                {  
                    dr.Delete();
                    MessageBox.Show(dr.RowState.ToString(), "Confirmation");
                    textBoxCustomerId.Clear();
                    textBoxCustomerName.Clear();
                    textBoxStreet.Clear();
                    textBoxCity.Clear();
                    textBoxPostalCode.Clear();
                    maskedTextBoxPhone.Clear();
                    textBoxEmail.Clear();
                    textBoxFax.Clear();
                    textBoxContactName.Clear();
                    textBoxCreditLimit.Clear();
                }
                else
                {
                    MessageBox.Show("This customer has related orders, please delete all related orders first!", "Reminder");
                }
            }
        }
    }
}
