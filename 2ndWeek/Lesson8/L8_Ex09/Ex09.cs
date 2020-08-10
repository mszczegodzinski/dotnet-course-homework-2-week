using System;

namespace L8_Ex09
{
    class Ex09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 8 Exercise 9:");
            Console.WriteLine("Provide the decimal number to change it to binary number:  ");

            //input number:
            int input;
            bool isInputCorrect = Int32.TryParse(Console.ReadLine(), out input);

            if (isInputCorrect && input > 0)
            {
                int givenNumber = input;
                string binaryNo = "";

                for (int i = 0; input > 0; i++)
                {
                    binaryNo = input % 2 + binaryNo;
                    input /= 2;
                }
                Console.WriteLine($"Binary representation of {givenNumber} is {binaryNo}");
            }
            else
            {
                Console.WriteLine("Incorrect input data. You can only pass an integer greater or equal than 0");
            }

        }
    }
}
