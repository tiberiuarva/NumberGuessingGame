using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var RandomClass = new Random();

            int RandomNumber = RandomClass.Next(1, 100);

            bool win = false;

            do
            {
                try
                {
                    Console.Write("Guess the number between 1 and 100: ");

                    string GuessString = Console.ReadLine();

                    int GuessNumber = int.Parse(GuessString);

                    if (GuessNumber > 100 || GuessNumber < 1)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else if (GuessNumber < RandomNumber)
                    {
                        Console.WriteLine("Number too low! Try again!");
                    }
                    else if (GuessNumber > RandomNumber)
                    {
                        Console.WriteLine("Number too high! Try again!");
                    }
                    else if (RandomNumber == GuessNumber)
                    {
                        Console.WriteLine("You win! The correct number was {0}.", RandomNumber);
                        win = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}. Input a number between 1 and 100!", ex.Message);
                }

                Console.WriteLine();
                
            } while (win == false);

            Console.WriteLine("Thank you for playing! Press any key to exit!");
            Console.ReadKey(true);
        }
    }
}
