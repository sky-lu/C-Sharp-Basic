using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsStudent
    {

        private String varNumber;
        private String varName;
        private Single varAverage;
        private Int16 varAge;
        public clsDate Birthdate = new clsDate();

        public String Number
        {
            get { return varNumber; }
            set { varNumber = (value == null) ? "Invalide Number" : value; }
        }
        public String Name
        {
            get { return varName; }
            set { varName = (value == null) ? "Invalide Name" : value; }
        }
        public Single Average
        {
            get { return varAverage; }
            set { varAverage = (value >= 0 && value <= 100) ? value : 0; }
        }
        public Int16 Age
        {
            get { return varAge = Convert.ToInt16(DateTime.Today.Year - Birthdate.Year); }
            set { varAge = value; }
        }


        public void Register(String aNumber, String aName, Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Number = aNumber;
            Name = aName;
            Birthdate.Day = aDay;
            Birthdate.Month = aMonth;
            Birthdate.Year = aYear;
        }

        public Single ToGrade(Single aAverage)
        {
            Average = aAverage;
            return Average;
        }

        public String Display()
        {
            String info;
            info = " Number : " + Number + "\n" + " Name : " + Name + "\n" + " Birthdate : " + Birthdate.DisplayShort() + "\n"
                + " Average : " + Average + "/100" + "\n" + " Age : " + Age + " years ";
            return info;
        }
    }
}
