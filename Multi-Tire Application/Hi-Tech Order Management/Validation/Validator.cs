using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management.Validation
{
    public static class Validator
    {
        public static bool IsValidId(string input, int size)
        {
            if (!(Regex.IsMatch(input, @"^\d{" + size + "}$")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsEmpty(string input)
        {
            if (input == "")
            {
                return true;
            }
            return false;
        }

    }
}
