namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Collins Igeh";
            string appPlayer = "";

            Random random = new Random();

            int correctNumber = random.Next(1, 11);
            int guessedNumber = 0;

            // App intro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            while (string.IsNullOrEmpty(appPlayer))
            {
                Console.WriteLine("What is your name?");
                appPlayer = Console.ReadLine();
            }

            Console.WriteLine("Hello {0}, let's play a game...", appPlayer);

            // Begin game
            Console.Write("\nGuess a number between 1 and 10: ");

            // Game checks
            while (guessedNumber != correctNumber)
            {
                //guessedNumber = Int32.Parse(Console.ReadLine());
                if(!int.TryParse(Console.ReadLine(), out guessedNumber) || guessedNumber < 1 || guessedNumber > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry. Try again!");
                    Console.ResetColor();

                    continue;
                }

                if(guessedNumber != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number. Try again!");
                    Console.ResetColor();
                }
            }

            // End game
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are CORRECT!");
            Console.ResetColor();
        }
    }
}