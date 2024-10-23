using System.Diagnostics;

namespace DiceRollGame
{
    static class NumberGuesser
    {
        static public int ValidateInput (string guessedNumberString)
        {
            bool IsGuessedNumber = int.TryParse(guessedNumberString, out int guessedNumber);
            if (!IsGuessedNumber)
            {
                while (IsGuessedNumber == false)
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine("Enter number");
                    guessedNumberString = Console.ReadLine();
                    IsGuessedNumber = int.TryParse(guessedNumberString, out guessedNumber);
                }
                return guessedNumber;
            }
            else
            {
                return guessedNumber;
            }

        }

        static public void ValidateGuessedNumber(int randomNumber, string guessedNumber)
        {
            int GuessedNumber = ValidateInput(guessedNumber);
            int tries = 0;
            while (tries < 3)
            {
                tries++;
                if (GuessedNumber == randomNumber)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else
                {
                    if (tries < 3)
                    { 
                        Console.WriteLine("Wrong number.");
                        Console.WriteLine("Enter number:");
                        guessedNumber = Console.ReadLine();
                        GuessedNumber = ValidateInput(guessedNumber);
                    }
                    else
                    {
                        Console.WriteLine("Wrong number.");
                        Console.WriteLine("You lose.");
                    }
                }
            }
            
        }

    }
}