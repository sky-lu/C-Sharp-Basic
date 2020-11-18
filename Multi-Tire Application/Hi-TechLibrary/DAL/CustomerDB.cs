using Hi_TechLibrary.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_TechLibrary.DAL
{
    public class CustomerDB
    {
        public static List<Customer> GetCustomerRecordList()
        {
            List<Customer> listCustomer = new List<Customer>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("Select * From Customers", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Customer cust;
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    cust = new Customer();
                    cust.CustomerId = Convert.ToInt32(sqlReader["CustomerId"]);
                    cust.CustomerName = sqlReader["CustomerName"].ToString();
                    cust.Street = sqlReader["Street"].ToString();
                    cust.City = sqlReader["City"].ToString();
                    cust.PostalCode = sqlReader["PostalCode"].ToString();
                    cust.Phone = sqlReader["Phone"].ToString();
                    cust.Email = sqlReader["Email"].ToString();
                    cust.Fax = sqlReader["Fax"].ToString();
                    cust.ContactName = sqlReader["ContactName"].ToString();
                    cust.CreditLimit = Convert.ToInt32(sqlReader["CreditLimit"]);
                    listCustomer.Add(cust);
                }
            }
            else
            {
                listCustomer = null;
            }
            return listCustomer;
        }
    }
}
