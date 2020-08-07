using System;

namespace L7_Ex5
{
    class Ex05
    {
        static void Main(string[] args)
        {
            // representative min age: 21
            // prime minister min age: 21
            // sentor min age: 30
            // president min age: 35 
            Console.WriteLine("Lesson 7 Exercise 5: ");
            Console.WriteLine("Type age to check if you can be a representative, a prime minister, a senator or a president: ");
            int age;
            bool isCorrectInput = Int32.TryParse(Console.ReadLine(), out age);
            string result;

            if (isCorrectInput && age > 0)
            {
                if (age >= 35)
                {
                    result = "become a representative, a prime minister, a senator or a president";
                }
                else if (age >= 30)
                {
                    result = "become a representative, a prime minister or a senator";
                }
                else if (age >= 21)
                {
                    result = "become a representative or a prime minister";
                }
                else
                {
                    result = "not become a representative, a prime minister, a senator or a president";
                }
                Console.WriteLine($"You can {result}");
            }
            else
            {
                Console.WriteLine("Incorrect input value. Type a right age");
            }

        }
    }
}
