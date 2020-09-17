using Lab1_ConnectedModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ConnectedModel.BLL
{
    class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;


        public Employee()
        {
            employeeId = 0;
            firstName = "";
            lastName = "";
            jobTitle = "";
        }

        public Employee(int employeeId, string firstName, string lastName, string jobTitle)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
        }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public Employee GetEmployee(int eId)
        {
            return EmployeeDB.GetRecord(eId);
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeDB.GetRecordList();
        }

    }
}
