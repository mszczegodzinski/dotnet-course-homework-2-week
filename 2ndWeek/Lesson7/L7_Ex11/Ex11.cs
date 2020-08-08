using System;

namespace L7_Ex11
{
    class Ex11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leson 7 Exercise 11: ");
            Console.WriteLine("Give a student mark (1-6): ");
            int mark;
            bool isMarkCorrect = Int32.TryParse(Console.ReadLine(), out mark);

            if (isMarkCorrect)
            {
                string translatedMark;
                translatedMark = mark switch
                {
                    1 => "niedostateczny",
                    2 => "dopuszczający",
                    3 => "dostateczny",
                    4 => "dobry",
                    5 => "bardzo dobry",
                    6 => "celujący",
                    _ => "unknown mark"
                };
                Console.WriteLine($"Translated mark {mark} is {translatedMark}");
            }
            else
            {
                Console.WriteLine("Incorrect input data. You have to pass a number between 1 and 6");
            }
        }
    }
}
