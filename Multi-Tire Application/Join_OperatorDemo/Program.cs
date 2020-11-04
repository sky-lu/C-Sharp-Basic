using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_OperatorDemo
{
    class Program
    {
        class Department
        {
            public int DepartmentId { get; set; }
            public string Name { get; set; }
        }
        class Employee
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int DepartmentId { get; set; }
        }
        static void Main(string[] args)
        {
            //Create a list of departments
            List<Department> listD = new List<Department>();
            Department dept1 = new Department();
            dept1.DepartmentId = 1;
            dept1.Name = "Marketing";
            listD.Add(dept1);
            Department dept2 = new Department();
            dept2.DepartmentId = 2;
            dept2.Name = "Payroll";
            listD.Add(dept2);
            Department dept3 = new Department();
            dept3.DepartmentId = 3;
            dept3.Name = "Sales";
            listD.Add(dept3);
            Department dept4 = new Department();
            dept4.DepartmentId = 4;
            dept4.Name = "Human Resources";
            listD.Add(dept4);
            // Create list of employees
            List<Employee> listE = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.EmployeeId = 1234;
            emp1.FirstName = "Mary";
            emp1.LastName = "Brown";
            emp1.DepartmentId = 1;
            listE.Add(emp1);
            Employee emp2 = new Employee();
            emp2.EmployeeId = 1235;
            emp2.FirstName = "Mary";
            emp2.LastName = "Green";
            emp2.DepartmentId = 1;
            listE.Add(emp2);
            Employee emp3 = new Employee();
            emp3.EmployeeId = 1236;
            emp3.FirstName = "Maria";
            emp3.LastName = "Nguyen";
            emp3.DepartmentId = 4;
            listE.Add(emp3);

            var list = (from emp in listE
                        join dept in listD on emp.DepartmentId equals dept.DepartmentId
                        select new
                        {
                            EmpFirstName = emp.FirstName,
                            EmpLastName = emp.LastName,
                            DepartName = dept.Name

                        });
            foreach (var e in list)
            {
                Console.WriteLine(e.EmpFirstName + "\t\t" + e.EmpLastName + "\t\t" + e.DepartName);
            }
            Console.ReadKey();
        }
    }
}
