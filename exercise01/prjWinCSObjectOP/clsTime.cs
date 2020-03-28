using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCSObjectOP
{
    class clsTime
    {
        // Public properties
        public Int16 Hour;
        public Int16 Minute;
        public Int16 Second;




        //public methods or functions
        public String ToUniversal()
        {
            String info = Hour + " : " + Minute + " : " + Second;
            return info;
        }

        public void Adjust(Int16 aHour, Int16 aMinute, Int16 aSecond)
        {
            Hour = aHour;
            Minute = aMinute;
            Second = aSecond;
        }

    }
}
