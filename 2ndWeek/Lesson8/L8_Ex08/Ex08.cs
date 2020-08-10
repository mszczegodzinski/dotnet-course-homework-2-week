using System;

namespace L8_Ex08
{
    class Ex08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 8:");
            Console.WriteLine("Provide data to reverse: ");
            string rawData = Console.ReadLine();

            Console.WriteLine("");
            for (int i = 0; i < rawData.Length; i++)
            {
                Console.Write(rawData[rawData.Length - i - 1]);
            }
        }
    }
}
