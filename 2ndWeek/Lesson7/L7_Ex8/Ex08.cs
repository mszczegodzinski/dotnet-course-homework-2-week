using System;

namespace L7_Ex8
{
    class Ex08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 7 Exercise 8: ");
            int math = 80;
            int physics = 71;
            int chemistry = 0;
            Console.WriteLine(
                "Student's results: \r\n" +
                $"Math: {math} \r\n" +
                $"Physics: {physics} \r\n" +
                $"Chemistry: {chemistry} \r\n");
            if (math > 70 || physics > 45 || chemistry > 45)
            {
                Console.WriteLine("Studnent may enroll");
            }
            else if (math + physics + chemistry > 180)
            {
                Console.WriteLine("Studnent may enroll");
            }
            else if (math > 150)
            {
                Console.WriteLine("Studnent may enroll");
            }
            else
            {
                Console.WriteLine("Studnent may not enroll :(");
            }
        }
    }
}
