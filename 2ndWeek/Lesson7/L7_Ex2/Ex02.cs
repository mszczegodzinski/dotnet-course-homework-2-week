using System;

namespace L7_Ex2
{
    class Ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 2: ");
            Console.WriteLine("Type your number to check if it's odd or even: ");
            int valueToCheck;
            bool isCorrectInput = Int32.TryParse(Console.ReadLine(), out valueToCheck);

            if (isCorrectInput)
            {
                string result = valueToCheck % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"Number {valueToCheck} is {result}");
            }
            else
            {
                Console.WriteLine("Incorrect input. You have to type a number!");
            }

        }
    }
}
