using System;
using System.Diagnostics;

namespace ClassLibrary1

{
    public class Sort
    {
        public static void BubbleSort(int[] numbers)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length -1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            sw1.Stop();
            Console.WriteLine($"Bubble sort took: {sw1.ElapsedMilliseconds} miliseconds");
        }

    }
}
