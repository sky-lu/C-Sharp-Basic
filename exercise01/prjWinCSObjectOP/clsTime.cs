using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsTime
    {
        // private fields that will store the value of properties
        private Int16 varHour;
        private Int16 varMinute;
        private Int16 varSecond;

        //public properties as function to be able to do validation
        public Int16 Hour
        {
            get { return varHour; }
            set { varHour = value; }
        }
        public Int16 Minute
        {
            get { return varMinute; }
            set { varMinute = value; }
        }
        public Int16 Second
        {
            get { return varSecond; }
            set { varSecond = value; }
        }




        //public methods or functions
        public String ToUniversal()
        {
            String info = Hour + " : " + Minute + " : " + Second;
            return info;
        }

        public String ToStandard()
        {
            //String info;
            //if (Hour < 12)
            //{
            //    info = Hour + " : " + Minute + " : " + Second + " AM ";
            //    return info;
            //}
            //else
            //{
            //    info = (Hour - 12).ToString() + " : " + Minute + " : " + Second + " PM ";
            //    return info;
            //}
            return ((Hour > 12) ? Hour - 12 : Hour).ToString() + ":" + Minute.ToString() + ":" + Second.ToString() + ((Hour > 12) ? " PM" : " AM");
        }
        public void Adjust(Int16 aHour, Int16 aMinute, Int16 aSecond)
        {
            //if (aHour < 24 && aHour >= 0)
            //{
            //    Hour = aHour;
            //}
            //else
            //{
            //    Hour = 1;
            //}
            Hour = (aHour < 24 && aHour >= 0) ? aHour : (Int16)0;
            Minute = (aMinute < 60 && aMinute >= 0) ? aMinute : (Int16)0;
            Second = (aSecond < 60 && aSecond >= 0) ? aSecond : (Int16)0;
        }

    }
}
