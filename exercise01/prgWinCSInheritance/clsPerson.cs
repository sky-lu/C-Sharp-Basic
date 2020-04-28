using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgWinCSInheritance
{
    //Parent (or Base) class for Teacher and Student
    abstract class clsPerson
    {
        private string vNumber;
        private string vName;
        private string vTel;

        public clsPerson()
        {
            Number = Name = Tel = "Not defined";
        }
        public clsPerson(string Number, string Name, string Tel)
        {
            this.Number = Number;
            this.Name = Name;
            this.Tel = Tel;
        }   

        public string Number { get => vNumber; set => vNumber = value; }
        public string Name { get => vName; set => vName = value; }
        public string Tel { get => vTel; set => vTel = value; }

        // The key word "Virtual" allows the method Display() to be overrided in the
        // subClass
        public virtual string Display()
        {
            string info = "\nNumber: " + Number + " \nName: " + Name + " \nTel:" + Tel;
            return info;
        }

        public override string ToString()
        {
            string info = "\nNumber: " + Number + " \nName: " + Name + " \nTel:" + Tel;
            return info;
        }
    }
}
