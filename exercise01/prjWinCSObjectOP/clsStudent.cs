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
        //private Int16 varAge; // we do not need to store the value of the age ,because it is calculated from birthday.
        private clsDate varBirthdate ;

        public clsStudent()
        {
            varNumber = varName = "Not defined";
            varBirthdate = new clsDate();
            varAverage = -1;
        }
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

        public clsDate Birthdate
        {
            get { return varBirthdate; }
            set { varBirthdate = value; }
        }
        public Single Average
        {
            get { return varAverage; }
        }
        public Int16 Age // Read only propertity, without the set
        {
            get { return Convert.ToInt16(DateTime.Today.Year - Birthdate.Year); }
        }


        public void Register(String aNumber, String aName, Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Number = aNumber;
            Name = aName;

            Birthdate = new clsDate(aDay, aMonth, aYear);
            varAverage = 0;
            //Birthdate.Day = aDay;
            //Birthdate.Month = aMonth;
            //Birthdate.Year = aYear;
        }

        public void ToGrade(Single aAverage)
        {
            varAverage = (aAverage >= 0 && aAverage <= 100)? aAverage : varAverage;
            
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
