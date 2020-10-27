using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo2
{
    // LINQ to Collections
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust;
            List<Customer> listCust = new List<Customer>();
            cust = new Customer();
            cust.CustomerId = 12345;
            cust.FirstName = "Mary";
            cust.LastName = "Brown";
            listCust.Add(cust);
            
            cust = new Customer();
            cust.CustomerId = 12346;
            cust.FirstName = "Helen";
            cust.LastName = "Brown";
            listCust.Add(cust);

            cust = new Customer();
            cust.CustomerId = 12347;
            cust.FirstName = "Tom";
            cust.LastName = "Green";
            listCust.Add(cust);

            var listC = from c in listCust
                        orderby c.FirstName
                        select c;
            foreach (var item in listC)
            {
                Console.WriteLine("\n\n" + item.CustomerId + "\t\t" + item.FirstName + "\t\t" + item.LastName);

            }

            Console.ReadKey();

        }

        class Customer
        {
            public int CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
