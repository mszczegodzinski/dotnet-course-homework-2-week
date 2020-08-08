using System;

namespace L7_Ex10
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 10: ");
            int firstSide;
            int secondSide;
            int thirdSide;
            Console.WriteLine("Give the first side: ");
            bool isFirstSideCorrect = Int32.TryParse(Console.ReadLine(), out firstSide);
            Console.WriteLine("Give the second side: ");
            bool isSecondSideCorrect = Int32.TryParse(Console.ReadLine(), out secondSide);
            Console.WriteLine("Give the third side: ");
            bool isThirdSideCorrect = Int32.TryParse(Console.ReadLine(), out thirdSide);

            if (isFirstSideCorrect && isSecondSideCorrect && isThirdSideCorrect)
            {
                if (firstSide > 0 && secondSide > 0 && thirdSide > 0)
                {
                    if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
                    {
                        Console.WriteLine($"It is possible to build a triangle from the sides: {firstSide}, {secondSide}, {thirdSide}");
                    }
                    else
                    {
                        Console.WriteLine($"It is not possible to build a triangle from the sides: {firstSide}, {secondSide}, {thirdSide}");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input data. All three sides should be greater than 0");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input data. All three sides should be integers");
            }
        }
    }
}
