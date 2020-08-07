using System;

namespace L7_Ex9
{
    class Ex09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 9: ");
            Console.WriteLine("Type a temperature: ");
            int temp;
            bool isTempCorrect = Int32.TryParse(Console.ReadLine(), out temp);

            if (isTempCorrect)
            {
                if (temp < 0)
                {
                    Console.WriteLine("cholernie piździ");
                }
                else if (temp < 10)
                {
                    Console.WriteLine("zimno");
                }
                else if (temp < 20)
                {
                    Console.WriteLine("chłodno");
                }
                else if (temp < 30)
                {
                    Console.WriteLine("w sam raz");
                }
                else if (temp < 40)
                {
                    Console.WriteLine("zaczyna być słabo, bo gorąco");
                }
                else
                {
                    Console.WriteLine("a weź, wyprowadzam się na Alaskę");
                }
            }
            else
            {
                Console.WriteLine("Incorrect temperature");
            }
        }
    }
}
