using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgConCsBasicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Declarations

            Int32 val1, val2, result;
            bool result2;
            //string op;
            //Boolean a;

            Console.WriteLine("\tBASIC OPERATORS");
            Console.WriteLine("\t----------------");

            Console.Write("Enter a value 1: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a value 2: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(val1 + " - " + val2);
            //Console.WriteLine("Enter a operator");
            //op = Console.ReadLine();

            //if (op == "+")
            //{
            //    result = val1 + val2;
            //}
            //else if (op == "-")
            //{
            //    result = val1 - val2;
            //}
            //else if (op == "/")
            //{
            //    result = val1 / val2;
            //}
            //else if (op == "*")
            //{
            //    result = val1 * val2;
            //}
            //else if (op == "%") 
            //{ 
            //    result = val1 % val2;
            //}

            result = val1 + val2;
            Console.WriteLine("Addition of" + val1 + " and " + val2 + "is" + result);
            Console.WriteLine("Addition of" + val1 + " and " + val2 + "is" + (val1 + val2));


            result = val1 - val2;
            Console.WriteLine("Subtraction of" + val1 + " and " + val2 + "is" + result);


            result2 = val1 > val2; 
            Console.WriteLine(" is " + val1 + " greater than " + val2 + " is " + result2);
            result2 = val1 < val2;
            Console.WriteLine(" is " + val1 + " smaller than " + val2 + " is " + result2);



        }
    }
}
