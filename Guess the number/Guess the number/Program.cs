using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number , try again..");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "Correct number");


                Console.WriteLine("Play again ? [Y or N]");

                string answer = Console.ReadLine().ToUpper();


                if(answer == "Y")
                {
                    continue;
                }
                else if(answer== "N")
                {
                    return;
                }
                else
                {
                    return;
                }



            }


        }

        static void GetAppInfo()
        {
            string appName = "Guess the number";
            string appVersion = "1.0.0";
            string appAuthor = "Stefan";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

       
        }

        static void GreetUser()
        {
            Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} , Let`s play", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
