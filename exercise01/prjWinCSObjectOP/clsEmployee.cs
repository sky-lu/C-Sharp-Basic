using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsEmployee
    {
        //fields
        private String varNumber;
        private String varName;
        private clsDate varBirthdate;
        private String varType;
        private Decimal varSalary;

        //constructor(if i have to store,the propertity need the field,otherwise,we don't need the private field
        public clsEmployee()
        {
            varNumber = varName = "Not defined";
            varBirthdate = new clsDate();
            varType = "None";
            varSalary = 0;
        }

        public clsEmployee(String aNumber, String aName, Int16 aDay, Int16 aMonth, Int16 aYear, String aType, Decimal aSalary)
        {
            varNumber = aNumber;
            varName = aName;
            varBirthdate = new clsDate(aDay, aMonth, aYear);
            varType = aType;
            varSalary = aSalary;
        }

         //getter and setter(read only,we just need get
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
        public Decimal Salary
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
            varSalary = 40000;
        }

        public bool Promote()
        {
            String type = Type;
            if (type == "Standard")
            {
                varType = "Developer";
                varSalary = 60000;
                return true;
            }else if(type == "Developer")
            {
                varType = "Analyst";
                varSalary = 80000;
                return true;
            }
            return false;
        }
        public bool Demote()
        {
            String type = Type;
            
            if (type == "Developer")
            {
                varType = "Standard";
                varSalary = 40000;
                return true;
            }
            else if (type == "Analyst")
            {
                varType = "Developer";
                varSalary = 60000;
                return true;
            }
            return false;
        }
        public void Fire()
        {
            varType = "None";
            varSalary = 0;
        }

        public String Display()
        {
            String info;
            info = " Number: " + varNumber + "\n" + " Name: " + varName + "\n" + " Birthdate: " + varBirthdate.DisplayShort() + "\n"
                + " Type: " + varType + "\n" + " Salary: " + varSalary + " $ ";
            return info;
        }


    }
}
