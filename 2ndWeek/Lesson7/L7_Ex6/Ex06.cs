using System;

namespace L7_Ex6
{
    class Ex06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 6: ");
            Console.WriteLine("Put your height to check what kind of height type you are: ");
            int height;
            bool isCorrectInput = Int32.TryParse(Console.ReadLine(), out height);
            string result;

            if (isCorrectInput && height > 0)
            {
                if (height >= 190)
                {
                    result = "You are a ledder!";
                }
                else if (height >= 180)
                {
                    result = "You are a tall person";
                }
                else if (height >= 170)
                {
                    result = "You are a mediocrity";
                }
                else if (height >= 160)
                {
                    result = "You are a compact person";
                }
                else
                {
                    result = "You are a tiny person";
                }
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("Incorrect input value. Type a right height");
            }
        }
    }
}
