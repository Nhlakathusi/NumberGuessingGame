namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Random random = new Random();

            while (running)
            {
                Console.Clear();

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("\t\tGUESSING GAME");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Settings");
                Console.WriteLine("3. Exit");

                Console.Write("\nSelect option: ");

                int choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

                if (choice == 1)
                {
                    bool playAgain = true;

                    while (playAgain)
                    {
                        Console.Clear();

                        int guessCount = 0;
                        int number = random.Next(1, 11);
                        bool won = false;

                        Console.WriteLine("Guess a number between 1 and 10!");

                        while (guessCount < 3)
                        {
                            Console.Write($"\nGuess #{guessCount + 1}: ");

                            int guess = Convert.ToInt32(Console.ReadLine());

                            guessCount++;

                            if (guess == number)
                            {
                                Console.WriteLine("Correct! You win!");
                                won = true;
                                break;
                            }
                            else if (guess > number)
                            {
                                Console.WriteLine("Too high!");
                            }
                            else
                            {
                                Console.WriteLine("Too low!");
                            }

                            Console.WriteLine(
                                $"Attempts remaining: {3 - guessCount}");
                        }

                        if (won == false)
                        {
                            Console.WriteLine(
                                $"\nGame Over! The number was {number}.");
                        }

                        Console.WriteLine("\n---------------------------------------------------------------------");
                        Console.WriteLine("[1] Play Again");
                        Console.WriteLine("[2] Main Menu");

                        Console.Write("\nSelect option: ");

                        int option = Convert.ToInt32(
                            Console.ReadKey().KeyChar.ToString());

                        if (option == 1)
                        {
                            playAgain = true;
                        }
                        else if (option == 2)
                        {
                            playAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid option!");
                            Console.ReadLine();
                        }
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nSettings coming soon!");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    running = false;
                    Console.WriteLine("\nThanks for playing!");
                }
                else
                {
                    Console.WriteLine("\nInvalid selection!");
                    Console.ReadLine();
                }
            }
        }
    }
}
