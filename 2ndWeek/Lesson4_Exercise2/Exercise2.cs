using System;

namespace Lesson4_Exercise2
{
    class Exercise2
    {
        //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise2: ");
            char firstLetter = 'a';
            char secondLetter = 'b';
            char thirdLetter = 'c';

            Console.WriteLine($"Letters in normal order: {firstLetter}, {secondLetter}, {thirdLetter}");
            Console.WriteLine($"Letters in reverse order: {thirdLetter}, {secondLetter}, {firstLetter}");
        }
    }
}
