using System;

namespace L8_Ex02
{
    class Ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 2: ");
            int maxRange = 1000;
            Console.WriteLine($"All even numbers in range from 0 to {maxRange} are: ");
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
            while (i <= maxRange);

        }
    }
}
