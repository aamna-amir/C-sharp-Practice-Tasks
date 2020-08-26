using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# Sharp program to print Hello and your name in a separate line.
            // Expected Output :
            // Hello: Alexandra Abramov
            /* 
            Console.WriteLine("Hallo:");
            Console.WriteLine("Harry Potter");
            Console.ReadLine(); 
            */

            // 2. Write a C# Sharp program to print the sum of two numbers
            /*
            Console.WriteLine("Sum of 2 + 4 = " + (2+4));
            Console.ReadLine();
            */

            //3.Write a C# Sharp program to print the result of dividing two numbers.
            /*
            Console.WriteLine("20 divided by 4 = " + (20 / 4));
            Console.ReadLine();
            */

            // 4. Write a C# Sharp program to print the result of the specified operations.
            /*
            Test data:
            -1 + 4 * 6
            (35 + 5) % 7
            14 + -4 * 6 / 11
            2 + 15 / 6 * 1 - 7 % 2
            */
            string user = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(user));
            Console.ReadLine();

            //a = Console.ReadLine()
            //Console.WriteLine("Enter second number: ");
            //b = Console.ReadLine()

        }
    }
}
