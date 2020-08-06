using System;

namespace Lesson4_Exercise5
{
    class Exercise5
    {
        //Napisz program w którym poprosisz użytkownika o jego dane personalne tj.Imię, nazwisko, numer telefonu, adres email, wzrost, waga(np. 85,7), itp(postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 5: ");
            Console.WriteLine("type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("type your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("type your phone number (9 digits): ");
            int phoneNumber;
            Int32.TryParse(Console.ReadLine(), out phoneNumber);
            Console.WriteLine("type your age: ");
            int age = 0;
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Type your weight (floating number separated by , not .): ");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine(
                $"Your data: \r\n" +
                $"name: {name} \r\n" +
                $"surname: {surname} \r\n" +
                $"phoneNumber: {phoneNumber} \r\n" +
                $"age: {age} \r\n" +
                $"weight: {weight}");
        }
    }
}
