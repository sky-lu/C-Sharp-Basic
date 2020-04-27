using System;
using System.Collections.Generic;
using System.Text;

namespace ATMLib
{
    public class clsDate
    {
        private Int16 vDay;
        private Int16 vMonth;
        private Int16 vYear;

        public clsDate()
        {
            vDay = 1;
            vMonth = 1;
            vYear = 1;
        }

        public clsDate(Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        public Int16 Day
        {
            get => vDay;
            set
            {
                vDay = (value > 0 && value < 32) ? value : (Int16)DateTime.Today.Day;
            }
        }

        public Int16 Month
        {
            get => vMonth;
            set
            {
                vMonth = (value > 0 && value < 13) ? value : (Int16)DateTime.Today.Month;
            }
        }

        public Int16 Year
        {
            get => vYear;
            set
            {
                vYear = (value > 0) ? value : (Int16)DateTime.Today.Year;
            }
        }

        public string Display()
        {
            return Day + "/" + Month + "/" + Year;
        }

        public void Initialize(Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }
    }
}