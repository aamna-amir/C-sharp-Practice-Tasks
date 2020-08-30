using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[5000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 5001);
            }
            //Sort.BubbleSort(numbers);
            string s1 = System.Configuration.ConfigurationManager.AppSettings["k1"];
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
