using System;

namespace Lesson4_Exercise4
{
    class Exercise4
    {
        // Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
        //a. 10
        //b.Szkoła Dotneta
        //c. 12,5
        //Pamiętaj o użyciu poprawnych typów danych.
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 4: ");
            byte firstNumber = 10;
            string sentence = "Szkoła Dotneta";
            double secondNumber = 12.5;

            Console.WriteLine($"Declarated variables: {firstNumber}, {sentence}, {secondNumber}");
        }
    }
}
