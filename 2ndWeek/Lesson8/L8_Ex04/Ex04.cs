using System;

namespace L8_Ex04
{
    class Ex04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 4: ");
            Console.WriteLine("Give an integer to build the piramid: ");
            //input number:
            int input;
            bool isInputCorrect = Int32.TryParse(Console.ReadLine(), out input);

            if (isInputCorrect && input > 0)
            {
                Console.WriteLine("Your pyramid: ");
                int rowNumbers = 0;
                int counter = 1;
                int maxCounter = input;
                int subtrahend = 1;

                while (input > 0) {
                    input -= subtrahend++;
                    rowNumbers++;
                }
                for(int i = 0; i < rowNumbers; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if(counter <= maxCounter)
                        {
                            Console.Write($"{counter++} ");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input data. You can only pass an integer");
            }
        }
    }
}
