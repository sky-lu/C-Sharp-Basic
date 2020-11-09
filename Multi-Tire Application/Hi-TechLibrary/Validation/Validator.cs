using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hi_TechLibrary.Validation
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
    }
}
