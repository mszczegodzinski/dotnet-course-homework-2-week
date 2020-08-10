using System;

namespace L8_Ex06
{
    class Ex06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 6: ");
            int maxRange = 20;
            Console.WriteLine($"Sequence 1/n from range <0,{maxRange}>: ");

            double sequenceSum = 0;
            //display sequence:
            for (int i = 1; i <= maxRange; i++)
            {
                Console.Write($"1/{i} ");
            }
            //calculate sum of sequence:
            for (int i = 1; i <= maxRange; i++)
            {
                sequenceSum += 1 / (double)i;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sequence sum: {sequenceSum}");
        }
    }
}
