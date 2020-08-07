using System;

namespace L7_Ex10
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 10: ");
            int firstSide = 65;
            int secondSide = 40;
            int thirdSide = 55;
            int longestSide = 0;
            int mediumSide = 0;
            int shortestSide = 0;

            //sort sides from the shortest to the longest:
            if (firstSide < secondSide)
            {
                if (secondSide < thirdSide)
                {
                    shortestSide = firstSide;
                    mediumSide = secondSide;
                    longestSide = thirdSide;
                }
            }
            else if (firstSide < thirdSide)
            {
                if (thirdSide < secondSide)
                {
                    shortestSide = firstSide;
                    mediumSide = thirdSide;
                    longestSide = secondSide;
                }
            }
            else
            {
                longestSide = firstSide;
                if (secondSide < thirdSide)
                {
                    shortestSide = secondSide;
                    mediumSide = thirdSide;
                }
            }
            Console.WriteLine($"{shortestSide}, {mediumSide}, {longestSide}");

            //check if it's possible to build a triangle from the given sides:
            if (longestSide < mediumSide + shortestSide)
            {
                Console.WriteLine($"It is possible to build a triangle from the sides: {firstSide}, {secondSide}, {thirdSide}");
            }
            else
            {
                Console.WriteLine($"It is not possible to build a triangle from the sides: {firstSide}, {secondSide}, {thirdSide}");
            }
        }
    }
}
