using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgWinCSInheritance
{
    class clsStudent : clsPerson
    {
        private float vAverage;
        public clsStudent()
        {
            Number = Name = Tel = "Not defined";
            Average = 0;
        }
        //public clsTeacher(string Number, string Name, string Tel, decimal Salary)
        //{
        //    this.Number = Number;
        //    this.Name = Name;
        //    this.Tel = Tel;
        //    this.Salary = Salary;
        //}

        public clsStudent(string Number, string Name, string Tel, float Average) : base(Number, Name, Tel)
        {
            this.Number = Number;
            this.Name = Name;
            this.Tel = Tel;
            this.Average = Average;
        }
        public float Average { get => vAverage; set => vAverage = value; }

        public void Register(string Number, string Name, string Tel, float Average)
        {
            this.Number = Number;
            this.Name = Name;
            this.Tel = Tel;
            this.Average = Average;
        }

        public bool ToGrade(float Grade)
        {
            if(Grade < 0 || Grade > 100)
            {
                return false;
            }
            else
            {
                vAverage = Grade;
                return true;
            }
        }

        public override string Display()
        {
            //to access the parent class method
            string info = base.Display() + "\nAverage " + Average;

            return info;
        }
    }
}
