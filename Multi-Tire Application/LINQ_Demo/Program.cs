using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class Program
    {
        //LINQ (Language Intergrated Query)
        // Types of LINQ
        // LINQ to objects
        // LINQ to collections
        // LINQ to SQL
        // LINQ to DataSet
        // LINQ to XML
        // LINQ to Entities // for lab4
        // Syntax of LINQ :
        // 1.specify the source : from which scource
        // 2.Specify the conditions (if necessary)
        // 3. Execute LINQ query
        static void Main(string[] args)
        {
            // Eample 1:
            int[] numbers = {15, 2, 45, 12, 6, 7, 9, 100, 12, 34 };

            //1. Write the code to list all the odd numbers
            Console.WriteLine("\n\n");
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("\n\n");
            var oddNumbers = from n in numbers
                             where n % 2 != 0
                             orderby n
                             select n;
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }


            //2. Write the code to display the sum of
            int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum = sum + num;
            //}
            Console.WriteLine("The sum is : " + sum);
            Console.WriteLine("The sum is : " + numbers.Sum());
            Console.WriteLine("The sum is : " + numbers.Average());





            Console.ReadKey();
        }
    }
}
