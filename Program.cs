using System;

namespace TDI_Task_03
{
    class Program
    {
        static void Main()
        {
            string password = "password";
            string userInput;

            bool isContinue = true;

            int tryesCounter = 1;

            while (isContinue)
            {
                Console.Write("\nEnter a password: ");
                userInput = Console.ReadLine();

                if (password == userInput)
                {
                    Console.Write("\nSECRET MESSAGE");
                    isContinue = false;
                }
                else if (tryesCounter == 3)
                {
                    isContinue = false;
                }
                else
                {
                    Console.Write("\nUncorrect password, try again");
                    tryesCounter++;
                }
            }
        }
    }
}
