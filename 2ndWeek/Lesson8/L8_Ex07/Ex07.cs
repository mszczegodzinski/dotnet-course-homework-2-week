using System;

namespace L8_Ex07
{
    class Ex07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 7: ");
            Console.WriteLine("Give an integer to build the diamond: ");
            //input number:
            int input;
            bool isInputCorrect = Int32.TryParse(Console.ReadLine(), out input);

            if (isInputCorrect && input > 0)
            {
                int starsCounter = 1;
                Console.WriteLine("Your diamond: ");
                for(int i = 1; i <= input ; i++)
                {
                    if (i-1 <= (double)input / 2)
                    {
                        for (int j = 0; j <= input / 2 - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= starsCounter; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                        if(starsCounter < input)
                        {
                            starsCounter += 2;
                        }
                    }
                    else
                    {
                        for (int j = 1; j < i - input / 2 ; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = starsCounter - 2; j >= 1; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                        starsCounter -= 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input data. You can only pass an integer");
            }
        }
    }
}
