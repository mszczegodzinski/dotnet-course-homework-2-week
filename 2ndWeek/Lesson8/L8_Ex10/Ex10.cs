using System;
using System.Reflection.Emit;

namespace L8_Ex10
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 10:");
            Console.WriteLine("Provide the numbers to calculate the lowest common multiple  ");
            Console.WriteLine("First number: ");
            int firstNumber;
            bool isFirstNumberCorrect = Int32.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Second number: ");
            int secondNumber;
            bool isSecondNumberCorrect = Int32.TryParse(Console.ReadLine(), out secondNumber);


            if (isFirstNumberCorrect && isSecondNumberCorrect && firstNumber > 0 && secondNumber > 0)
            {
                //the lowest common multiple:
                int lcm = 0;

                //set the iteration number. Max range is the lower number:
                int maxRange = firstNumber;
                if(secondNumber < firstNumber)
                {
                    maxRange = secondNumber;
                }

                //calculate the LCM:
                for(int i = 2; i <= maxRange; i++)
                {
                    if(lcm == 0 && firstNumber % i == 0 && secondNumber % i == 0)
                    {
                        lcm = i;
                    }
                }
                Console.WriteLine($"The lowest common multiple for {firstNumber} and {secondNumber} is {lcm}");

            }
            else
            {
                Console.WriteLine("Incorrect input data. You can only pass an integer greater or equal than 0");
            }

        }
    }
}
