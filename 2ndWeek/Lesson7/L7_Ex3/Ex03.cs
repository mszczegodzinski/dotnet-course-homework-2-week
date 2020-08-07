using System;

namespace L7_Ex3
{
    class Ex03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 3: ");
            Console.WriteLine("Type your number to check if it's positive or negative: ");
            int valueToCheck;
            bool isCorrectInput = Int32.TryParse(Console.ReadLine(), out valueToCheck);

            if (isCorrectInput)
            {
                string result = valueToCheck < 0 ? "negative" : "positive";
                Console.WriteLine($"Number {valueToCheck} is {result}");
            }
            else
            {
                Console.WriteLine("Incorrect input. You have to type a number!");
            }

        }
    }
}
