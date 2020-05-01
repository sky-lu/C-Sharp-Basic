using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermCT2HonglinLu
{
    public class clsDate
    {
        // declaration of private field that will hold the values of properties
        private Int16 varDay;
        private Int16 varMonth;
        private Int16 varYear;

        // Constructors, event that is triggered when the object is created with the "new" keyword
        //Constructor 1, without parameters
        public clsDate()
        {
            varDay = 1;
            varMonth = 1;
            varYear = 1;
        }

        //Constructor 2, with 1 parameter
        public clsDate(Int16 aDay)
        {
            Day = aDay;
            varMonth = Convert.ToInt16(DateTime.Today.Month);
            varYear = Convert.ToInt16(DateTime.Today.Year);
        }

        //Constructor 3, with 2 parameter
        public clsDate(Int16 aDay, Int16 aMonth)
        {
            Day = aDay;
            Month = aMonth;
            varYear = Convert.ToInt16(DateTime.Today.Year);
        }

        //Constructor 4, with 3 parameter
        public clsDate(Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        //Declaration of public access methods to properties
        public Int16 Day
        {
            get //access for reading
            {
                return varDay;
            }
            set //access for writing
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
            info = info + "  " + Day + " " + tabMonths[Month - 1] + " " + Year;

            return info;
        }

    }
}
