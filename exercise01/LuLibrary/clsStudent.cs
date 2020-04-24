using System;
using System.Collections.Generic;
using System.Text;

namespace LuLibrary
{
    public class clsStudent
    {
        private string vName;
        private string vNumber;
        private clsDate vBirthdate;


        public clsStudent(string aNumber, string aName, Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Name = aName;
            Number = aNumber;
            Birthdate = new clsDate(aDay, aMonth, aYear);

        }

        public clsStudent()
        {

            Name = "Not defined";
            Number = "Not defined";
            Birthdate = new clsDate();
        }

        public string Number
        {
            get => vNumber;
            set
            {
                vNumber = value;
            }
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }

        public clsDate Birthdate
        {
            get => vBirthdate;
            set
            {
                vBirthdate = value;
            }
        }

        public string Display()
        {
            return "\nNumber:" + Number + "\nName:" + Name + "\nBirthdate:" + Birthdate.DisplayShort();
         }
    }
}