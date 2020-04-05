using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsDate
    {
        // declaration of private field that will hold the values of properties
        private Int16 varDay;
        private Int16 varMonth;
        private Int16 varYear;

        public Int16 Day
        {
            get
            {
                return varDay;
            }
            set
            {
                varDay = (value > 0 && value < 32) ? value : (Int16)DateTime.Today.Day;
            }
        }
        public Int16 Month
        {
            get
            {
                return varMonth;
            }
            set
            {
                varMonth = (value > 0 && value < 13) ? value : (Int16)DateTime.Today.Month;
            }
        }
        public Int16 Year
        {
            get
            {
                return varYear;
            }
            set
            {
                varYear = (value > 0) ? value : (Int16)DateTime.Today.Year;
            }
        }

        public void Initialize(Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        public String DisplayShort()
        {
            return Day + "/" + Month + "/" + Year;
        }

        public String DisplayLong()
        {
            String info;
            String[] tabDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satarday" };
            DateTime tmp = new DateTime(Year, Month, Day);
            info = tabDays[(Int32)tmp.DayOfWeek];

            String[] tabMonths = {"January", "February", "March", "April", "May", "June", "July", "August","September",
            "October", "November", "December"};
            info = info + "  " +  Day + " " + tabMonths[(Int32)tmp.Month - 1] + " " + Year;
            
            return info;
        }
    }

    
}
