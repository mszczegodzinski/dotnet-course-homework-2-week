using System;
using System.Globalization;

namespace L8_Ex01
{
    class Ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 8 Lesson 1: ");
            int maxRange = 100;
            int primeCounter = 0;
            int num = 0;
            for (int i = 2; i <= maxRange; i++)
            {
                if ((i == 2 || i == 3 || i == 5 || i == 7) || (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0))
                {
                    Console.Write($"{i} ");
                    primeCounter++;
                }

            }
            Console.WriteLine($"In the range from 0 to 100 are {primeCounter} prime number");
        }
    }
}
