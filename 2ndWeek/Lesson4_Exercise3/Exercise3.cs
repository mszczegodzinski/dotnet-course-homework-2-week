using System;

namespace Lesson4_Exercise3
{
    class Exercise3
    {
        //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 3: ");
            int width = 2;
            int length = 3;

            double rectangleDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

            Console.WriteLine($"For the given: {width} and {length} diagonal is equal to {rectangleDiagonal}");
        }
    }
}
