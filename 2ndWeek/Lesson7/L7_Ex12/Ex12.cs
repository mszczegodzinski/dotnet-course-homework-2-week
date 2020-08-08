using System;

namespace L7_Ex12
{
    class Ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leson 7 Exercise 12: ");
            Console.WriteLine("Give the number (1-7) represents the day of the week: ");
            int day;
            bool isDayCorrect = Int32.TryParse(Console.ReadLine(), out day);

            if (isDayCorrect)
            {
                string translatedDay;
                translatedDay = day switch
                {
                    1 => "Monday",
                    2 => "Tuesday",
                    3 => "Wednesday",
                    4 => "Thursday",
                    5 => "Friday",
                    6 => "Saturday",
                    7 => "Sunday",
                    _ => "incorrect day"
                };
                Console.WriteLine($"You chose {translatedDay}");
            }
            else
            {
                Console.WriteLine("Incorrect input data. You have to pass a number between 1 and 7");
            }
        }
    }
}
