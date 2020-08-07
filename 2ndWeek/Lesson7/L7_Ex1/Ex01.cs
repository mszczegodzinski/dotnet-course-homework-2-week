using System;

namespace L7_Ex1
{
    class Ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 1: ");
            int firstNumber = 5;
            int secondNumber = 5;
            string result = firstNumber == secondNumber ? "są równe" : "nie są równe";

            Console.WriteLine($"{firstNumber} i {secondNumber} {result}");
        }
    }
}
