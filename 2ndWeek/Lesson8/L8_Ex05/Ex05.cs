using System;

namespace L8_Ex05
{
    class Ex05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 5: ");
            int maxRange = 20;
            Console.WriteLine($"Third power for each number from range <1,{maxRange}>: ");

            for(int i = 1; i <= maxRange; i++)
            {
                Console.Write($"{Math.Pow(i, 3)} ");
            }
        }
    }
}
