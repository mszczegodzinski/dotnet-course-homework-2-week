using System;

namespace L7_Ex7
{
    class Ex07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 7: ");
            Console.WriteLine("Type three numbers: ");
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            bool isFirstNumberCorrect = Int32.TryParse(Console.ReadLine(), out firstNumber);
            bool isSecondNumberCorrect = Int32.TryParse(Console.ReadLine(), out secondNumber);
            bool isThirdNumberCorrect = Int32.TryParse(Console.ReadLine(), out thirdNumber);

            if (isFirstNumberCorrect && isSecondNumberCorrect && isThirdNumberCorrect)
            {
                int theBiggestNumber = firstNumber;
                if (theBiggestNumber < secondNumber)
                {
                    theBiggestNumber = secondNumber;
                }
                if (theBiggestNumber < thirdNumber)
                {
                    theBiggestNumber = thirdNumber;
                }
                Console.WriteLine($"The biggest number from: {firstNumber}, {secondNumber}, {thirdNumber} is {theBiggestNumber}");
            }
            else
            {
                Console.WriteLine("Incorrect inputs type. All three numbers have to be an integer");
            }
        }
    }
}
