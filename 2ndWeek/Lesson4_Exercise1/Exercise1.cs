using System;

namespace Lesson4_Exercise1
{
    // Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane które chcesz przetrzymywać to:
    //a.Imię,
    //b.Nazwisko
    //c.Wiek
    //d.Płeć (‘m’ albo ‘k’)
    //e.PESEL
    //f.Numer pracownika (np. 2509324094)
    //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
    class Exercise1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercise1: ");
            string name = "Marek";
            string surname = "Kowalski";
            byte age = 35;
            char gender = 'm';
            ulong pesel = 85010102022;
            uint id = 2509324094;

            Console.WriteLine(
                $"name: {name} \r\n" +
                $"surname:{surname} \r\n" +
                $"age: {age} \r\n" +
                $"gender: {gender} \r\n" +
                $"pesel: {pesel} \r\n" +
                $"id: {id}");

        }
    }
}
