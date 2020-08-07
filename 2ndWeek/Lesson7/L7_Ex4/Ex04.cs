using System;

namespace L7_Ex4
{
    class Ex04
    {
        //1. If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
        //2. If the year is evenly divisible by 100, go to step 3. Otherwise, go to step 4.
        //3. If the year is evenly divisible by 400, go to step 4. Otherwise, go to step 5.
        //4. The year is a leap year(it has 366 days).
        //5. The year is not a leap year(it has 365 days).
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 4: ");
            Console.WriteLine("Type year to check if it's leap year or not: ");
            int year;
            bool isCorrectInput = Int32.TryParse(Console.ReadLine(), out year);
            string result;

            if (isCorrectInput && year >= 0)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            result = "a leap year";
                        }
                        else
                        {
                            result = "not a leap year";
                        }
                    }
                    else
                    {
                        result = "a leap year";
                    }
                }
                else
                {
                    result = "not a leap year";
                }

                Console.WriteLine($"Year {year} is {result}");
            }
            else
            {
                Console.WriteLine("Incorrect input. Type a right year");
            }

        }
    }
}
