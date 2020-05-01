using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermCT2HonglinLu
{
    class clsStudent
    {
        private String vNumber;
        private String vName;
        private Single vAverage;
        private clsDate vBirthdate;

        public clsStudent()
        {
            vNumber = vName = "Not defined";
            vBirthdate = new clsDate();
            vAverage = -1;
        }
        public clsStudent(String aNumber, String aName, Int16 aDay, Int16 aMonth, Int16 aYear, Single aAverage)
        {
            Number = aNumber;
            Name = aName;
            Birthdate = new clsDate(aDay, aMonth, aYear);
            vAverage = aAverage;
        }
        public String Number
        {
            get { return vNumber; }
            set { vNumber = (value == null) ? "Invalide Number" : value; }
        }
        public String Name
        {
            get { return vName; }
            set { vName = (value == null) ? "Invalide Name" : value; }
        }

        public clsDate Birthdate
        {
            get { return vBirthdate; }
            set { vBirthdate = value; }
        }
        public Single Average
        {
            get { return vAverage; }
        }
        public Int16 Age 
        {
            get { return Convert.ToInt16(DateTime.Today.Year - Birthdate.Year); }
        }


        public void ToGrade(Single aAverage)
        {
            vAverage = (aAverage >= 0 && aAverage <= 100) ? aAverage : vAverage;

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
