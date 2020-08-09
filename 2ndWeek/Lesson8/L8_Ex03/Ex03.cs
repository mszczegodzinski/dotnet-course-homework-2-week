using System;

namespace L8_Ex03
{
    class Ex03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 3: ");
            Console.WriteLine("Give the fibonacci number: ");
            //fibonacci number:
            int fn;
            bool isNumberCorrect = Int32.TryParse(Console.ReadLine(), out fn);

            if(isNumberCorrect)
            {
                Console.Write("Fibonacci sequence: ");
                if (fn > 1)
                {
                    int fni;
                    int fni_1 = 1;
                    int fni_2 = 0;
                    Console.Write("0 1 ");
                    for (int i = 2; i <= fn; i++)
                    {
                            fni = fni_1 + fni_2;
                            Console.Write($"{fni} ");
                            fni_2 = fni_1;
                            fni_1 = fni;
                    }
                    
                }
                else if (fn == 1)
                {
                    for (int i = 0; i <= fn; i++)
                    {
                        Console.Write($"{i} ");
                    }

                }
                else
                {
                    Console.Write("0");
                }

            }
            else
            {
                Console.WriteLine("Incorrect input data. You can pass only an integer");
            }
        }
    }
}
