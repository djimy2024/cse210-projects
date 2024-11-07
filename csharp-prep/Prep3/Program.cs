using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
       //Console.Write("What is the magic number? ");
       //int magicNumber = int.Parse(Console.ReadLine());
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);

       int guessNumber = 0;
       // Start counting le number of guessing from 0.
       int countGuess = 0;
       // Seek the magicnumber while guessnumber is different than the magicnumber.
       while (guessNumber != magicNumber)
     {
       Console.Write("What is your guess? ");
        guessNumber = int.Parse(Console.ReadLine());
        countGuess++;
       if (guessNumber < magicNumber)
       {
         Console.WriteLine("Higher");
       }
       else if (guessNumber > magicNumber)
       {
        Console.WriteLine("Lower");
       }
       else
       {
        // Display a message for announcing that the player win.
        Console.WriteLine("You guessed it!");
      
        }
     } // Display the magicnumber and the number of guess.
      Console.WriteLine($"You guessed the magic number {magicNumber} in {countGuess} guesses.");
      // Thanks the player.
      Console.WriteLine("Thanks for playing! Goodbye.");
    }
}