using System;
using System.Collections.Generic;
using System.Text;

namespace LuLibrary
{
    public class clsStudent
    {
        private string vName;
       
        private clsDate vBirthdate;
        private string vNumber;


        public clsStudent(string aNumber, string aName, short aDay, short aMonth, short aYear)
        {
            throw new System.NotImplementedException();
        }

        public clsStudent()
        {
            throw new System.NotImplementedException();
        }

        public string Number
        {
            get => default;
            set
            {
            }
        }

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public clsDate Birthdate
        {
            get => default;
            set
            {
            }
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }
    }
}