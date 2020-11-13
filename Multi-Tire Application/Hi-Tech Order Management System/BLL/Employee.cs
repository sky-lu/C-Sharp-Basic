using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;

namespace Hi_Tech_Order_Management_System.BLL
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private int jobId;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public int JobId { get => jobId; set => jobId = value; }

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveEmployeeRecord(emp);
        }

        public Employee GetEmployee(int empId)
        {
            return EmployeeDB.GetEmployeeRecord(empId);
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeDB.GetEmployeeRecordList();
        }

        public List<Employee> GetEmployeeList(string name)
        {
            return EmployeeDB.GetEmployeeRecordList(name);
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateEmployeeRecord(emp);
        }
    }
}
