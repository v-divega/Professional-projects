using DiceRollGame;
var randomNumberGenerator = new RandomNumberGenerator();
int randomNumber = randomNumberGenerator.RandomNumberValue;
Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");
string guessedNumberString = Console.ReadLine();
NumberGuesser.ValidateGuessedNumber(randomNumber, guessedNumberString);

