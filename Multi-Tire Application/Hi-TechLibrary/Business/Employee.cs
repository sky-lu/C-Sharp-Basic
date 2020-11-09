using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// create a static class validator
//Add validation methods to this class
//Build the library
//How to use the class Validator in WinAppTestForm

namespace Hi_TechLibrary.Business
{
    public class Employee
    {
        private int employeeId;
        private string firstName;   
        private string lastName;
        private string phoneNumber;
        private string email;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

        // default constructor
        public Employee()
        {
            employeeId = 0;
            firstName = "";
            lastName = "";
            phoneNumber = "";
            email = "";
        }

        //overloaded constructor [parameterized constructor]
        public Employee(int employeeId, string firstName, string lastName, string phoneNumber, string email)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string GetFullName(string fname, string lname)
        {
            return (fname + ',' + lname);
        }
    }
}
