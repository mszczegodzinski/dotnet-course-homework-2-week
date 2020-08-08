using System;

namespace L7_Ex13
{
    class Ex13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 13: ");
            Console.WriteLine("Give the first number: ");
            double firstNumber;
            bool isFirstNumberCorrect = Double.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Give the second number: ");
            double secondNumber;
            bool isSecondNumberCorrect = Double.TryParse(Console.ReadLine(), out secondNumber);
            Console.WriteLine("Give the number (1-4) which represents the type of action: \r\n" +
                              "1. Addition \r\n"+
                              "2. Subtraction \r\n" +
                              "3. Multiplaying \r\n" +
                              "4. Division \r\n");
            int typeOfAction;
            bool isTypeOfActionCorrect = Int32.TryParse(Console.ReadLine(), out typeOfAction);
            if(isFirstNumberCorrect && isSecondNumberCorrect && isTypeOfActionCorrect)
            {
                double result;
                switch (typeOfAction)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                        break;
                    case 4:
                        if(secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                        } 
                        else
                        {
                            Console.WriteLine("You damn, don't divide by 0!");
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect type action!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input data. You can only pass numbers");
            }

        }
    }
}
