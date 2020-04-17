using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsClassAndCollection
{
    class clsStudent
    {
        
        private String vNumber;
        private String vName;
        private Single vGrade;

        public clsStudent()
        {
            Number = "Not defined";
            Name = "Not defined";
            Grade = -1;
        }
        public clsStudent(String aNumber, String aName, Single aGrade)
        {
            Number = aNumber;
            Name = aName;
            Grade = aGrade;
        }
        
        public string Name { get => vName; set => vName = value; }
        public string Number { get => vNumber; set => vNumber = value; }
        public Single Grade { get => vGrade; set => vGrade = value; }

        public String Display()
        {
            String info;
            info = " Name: " + vName + " \nNumber: " + vNumber + " \nGrade: " + vGrade;
            return info;
        }
    }
}
