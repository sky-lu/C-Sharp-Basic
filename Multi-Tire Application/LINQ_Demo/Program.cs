using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class Program
    {
        // SQL(Structured Query Language applied to Relational Database)(Tables..)
        //LINQ (Language Intergrated Query)
        // Types of LINQ
        // LINQ to objects
        // LINQ to collections
        // LINQ to SQL
        // LINQ to DataSet
        // LINQ to XML
        // LINQ to Entities // for lab4
        // Syntax of LINQ :
        //Query Syntax
        // 1.specify the source : from which scource
        // 2.Specify the conditions (if necessary)
        // 3. Execute LINQ query (use foreach...)
        // Lamda (method) syntax
        //LINQ Operators
        // - Filtering operators
        // - Join operators
        // - Sorting Operators
        // - Equality operators
        // - Conversions
        // - Aggregations
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
            //Query Syntax
            var oddNumbers = from n in numbers
                             where n % 2 != 0
                             orderby n
                             select n;
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            // Lamda (method) syntax
            var evenNumbers = numbers.Where(n=>n%2 == 0); // =>:Lamda Expression

            //2. Write the code to display the sum of
            int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum = sum + num;
            //}


            //int[] numbers = { 15, 2, 45, 12, 6, 7, 9, 100, 12, 34 };
            // Write the code to display all the distinct numbers in the array
            var distinctNumbers = numbers.Distinct();
            foreach (var n in distinctNumbers)
            {
                Console.WriteLine(n);
            }
            
            Console.WriteLine("The sum is : " + sum);
            Console.WriteLine("The sum is : " + numbers.Sum());
            Console.WriteLine("The sum is : " + numbers.Average());





            Console.ReadKey();
        }
    }
}
