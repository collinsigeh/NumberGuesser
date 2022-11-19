namespace NumberGuesser
{
    internal class Program
    {
        static void Main()
        {
            DisplayAppInfo();
            GreetPlayer();

            while (true)
            {
                // Begin game
                string replay;

                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guessedNumber = 0;

                Console.WriteLine("\nGuess a number between 1 and 10:");

                // Game checks
                while (guessedNumber != correctNumber)
                {
                    //guessedNumber = Int32.Parse(Console.ReadLine());
                    if (!int.TryParse(Console.ReadLine(), out guessedNumber) || guessedNumber < 1 || guessedNumber > 10)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Invalid entry. Try again!");

                        continue;
                    }

                    if (guessedNumber != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number. Try again!");
                        Console.ResetColor();
                    }
                }

                // End game
                PrintColorMessage(ConsoleColor.Yellow, "Your are CORRECT!");

                Console.Write("\nPlay Again? [Y or N]: ");
                replay = Console.ReadLine().ToUpper();

                if (replay == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and displa app info
        static void DisplayAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Collins Igeh";

            string greeting = appName + ": Version" + appVersion + " by " + appAuthor;
            PrintColorMessage(ConsoleColor.Green, greeting);
        }

        // Request player's name and greet player
        static void GreetPlayer()
        {
            string appPlayer = "";

            while (string.IsNullOrEmpty(appPlayer))
            {
                Console.WriteLine("What is your name?");
                appPlayer = Console.ReadLine();
            }

            Console.WriteLine("Hello {0}, let's play a game...", appPlayer);
        }

        // Prints a message to the console with specified colour
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}