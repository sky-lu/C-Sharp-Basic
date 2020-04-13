using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsEmployee
    {
        private String varNumber;
        private String varName;
        private clsDate varBirthdate;
        private String varType;
        private Single varSalary;

        public String Number
        {
            get { return varNumber; }
        }
        public String Name
        {
            get { return varName; }
        }
        public clsDate Birthdate
        {
            get { return varBirthdate; }
        }
        public String Type
        {
            get { return varType; }
        }
        public Single Salary
        {
            get { if (Type == "Standard") { 
                    varSalary = 40000; 
                  } else if (Type == "Developer")
                {
                    varSalary = 60000;
                }
                else if (Type == "Analyst")
                {
                    varSalary = 80000;
                }
                return varSalary;
            }
        }

        public void Hire(String aNumber, String aName, Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            varNumber = aNumber;
            varName = aName;
            varBirthdate = new clsDate(aDay, aMonth, aYear);
            varType = "Standard";
        }

        public void Promote()
        {
            String type = Type;
            if (type == "Standard")
            {
                varType = "Developer";
            }else if(type == "Developer")
            {
                varType = "Analyst";
            }else if (type == "Analyst")
            {
                varType = "Analyst";
            }
        }
        public void Demote()
        {
            String type = Type;
            if (type == "Standard")
            {
                varType = "Standard";
            }
            else if (type == "Developer")
            {
                varType = "Standard";
            }
            else if (type == "Analyst")
            {
                varType = "Developer";
            }
        }
        public void Fire()
        {
            varType = "None";
            varSalary = 0;
        }

        public String Display()
        {
            String info;
            info = " Number: " + Number + "\n" + " Name: " + Name + "\n" + " Birthdate: " + Birthdate.DisplayShort() + "\n"
                + " Type: " + Type + "\n" + " Salary: " + Salary + " $ ";
            return info;
        }


    }
}
