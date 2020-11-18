using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.DAL;

namespace Hi_TechLibrary.BLL
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string street;
        private string city;
        private string postalCode;
        private string phone;
        private string email;
        private string fax;
        private string contactName;
        private int creditLimit;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Fax { get => fax; set => fax = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public int CreditLimit { get => creditLimit; set => creditLimit = value; }

        public List<Customer> GetCustomerList()
        {
            return CustomerDB.GetCustomerRecordList();
        }
    }
}
