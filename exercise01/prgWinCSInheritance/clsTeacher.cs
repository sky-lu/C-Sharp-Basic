using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgWinCSInheritance
{
    class clsTeacher : clsPerson
    {
        private decimal vSalary;

        public clsTeacher()
        {
            Number = Name = Tel = "Not defined";
            Salary = 0;
        }
        //public clsTeacher(string Number, string Name, string Tel, decimal Salary)
        //{
        //    this.Number = Number;
        //    this.Name = Name;
        //    this.Tel = Tel;
        //    this.Salary = Salary;
        //}

        public clsTeacher(string Number, string Name, string Tel, decimal Salary) : base(Number, Name, Tel)
        {
            this.Number = Number;
            this.Name = Name;
            this.Tel = Tel;
            this.Salary = Salary;
        }
        public decimal Salary { get => vSalary; set => vSalary = value; }

        public void Hire(string Number, string Name, string Tel, decimal Salary)
        {
       
            this.Salary = Salary;
        }

        public override string Display()
        {
            //to access the parent class method
            string info = base.Display() + "\nSalary " + Salary;

            return info;
        }
    }
}
