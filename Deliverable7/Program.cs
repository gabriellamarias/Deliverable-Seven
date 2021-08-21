using System;

namespace Deliverable7
{
    class Program
    {
        static void Continue()
        {
            string userInputContinue = "";
            bool userContinue = true;

            Console.Write("Would you like to continue (y/n)? ");
            userInputContinue = Console.ReadLine().ToLower();

            if (userInputContinue == "y")
            {
                userContinue = true;
            }
            else
            {
                Console.WriteLine("Goodbye!");
                System.Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            //int[] userNumbers = new int[5];

            //while (true)
            //{
            //    int userNumbersAdd = 0;

            //    for (int i = 0; i < userNumbers.Length; i++)
            //    {
            //        Console.Write("Enter a number: ");
            //        int userInput = int.Parse(Console.ReadLine());
            //        userNumbers[i] = userInput;
            //    }

            //    for (int i = 0; i < userNumbers.Length; i++)
            //    {
            //        userNumbersAdd += userNumbers[i];
            //    }

            //    Console.WriteLine($"{userNumbers[0]} + {userNumbers[1]} + {userNumbers[2]} + {userNumbers[3]} + {userNumbers[4]} = {userNumbersAdd} ");

            //    Continue();
            //}

            //END OF EXERCISE 37

            double[] userNumbers = new double[5];

            while (true)
            {
                double userNumbersAdd = 0;
                double userNumbersAverage = 0;

                for (int i = 0; i < userNumbers.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    double userInput = double.Parse(Console.ReadLine());
                    userNumbers[i] = userInput;
                }

                for (int i = 0; i < userNumbers.Length; i++)
                {
                    userNumbersAdd += userNumbers[i];
                }

                userNumbersAverage = userNumbersAdd / 5;

                Console.WriteLine($"({userNumbers[0]} + {userNumbers[1]} + {userNumbers[2]} + {userNumbers[3]} + {userNumbers[4]} = {userNumbersAdd}) /5 = {userNumbersAverage} ");

                Continue();
            }
        }
    }
}
