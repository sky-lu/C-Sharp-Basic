using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormAppEntityFramework.VALIDATION
{
    class Validator
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

        public static bool IsValidName(string input)
        {
            if (input == "")
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsEmpty(string input)
        {
            if (input == "")
            {
                return true;
            }
            return false;
        }

        public static bool IsValidEmail(string input)
        {
            string reg = "([a-zA-Z0-9_\\.\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9]{2,5})+";

            if (Regex.IsMatch(input, reg))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
