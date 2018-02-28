using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      // Application Variables
      string appName = "Guessing Game";
      string appVersion = "1.0.0";
      string appAuthor = "William A. Mooney";

      // Change Text Color
      Console.ForegroundColor = ConsoleColor.Green;

      // Writeout App Info
      Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

      // Reset Text Color
      Console.ResetColor();

      // Ask Users Name
      Console.WriteLine("What is your name?");

      // Get User Input
      string inputName = Console.ReadLine();

      Console.WriteLine("Hello {0}, let's play a game...", inputName);

      // Create A Random Object
      Random random = new Random();

      // Init Correct Number
      int correctNumber = random.Next(1, 11);

      // Initial Guess Variable
      int guess = 0;

      // Ask User For Number
      Console.WriteLine("Guess a number between 1 and 10");

      // While Guess Is Not Correct
      while (guess != correctNumber)
      {
        // Get User Input
        string input = Console.ReadLine();

        // Make Sure Its A Number
        if (!int.TryParse(input, out guess))
        {
          // Change Text Color
          Console.ForegroundColor = ConsoleColor.Red;

          // Tell User It's Not A Number
          Console.WriteLine("It's not a number, please try again...");

          // Reset Text Color
          Console.ResetColor();

          // Keep Going
          continue;
        }

        // Cast To Int And Put In Guess
        guess = Int32.Parse(input);

        // Match Guess To Correct Number
        if (guess != correctNumber)
        {
          // Change Text Color
          Console.ForegroundColor = ConsoleColor.Red;

          // Tell User It's The Wrong Number
          Console.WriteLine("Wrong number, please try again...");

          // Reset Text Color
          Console.ResetColor();

        }
      }

      // Change Text Color
      Console.ForegroundColor = ConsoleColor.Yellow;

      // Tell User It's The Correct Number
      Console.WriteLine("That is correct, do you want to play again?");

      // Reset Text Color
      Console.ResetColor();


      Console.ReadLine();  // Pauses the Console to read it...
    }
  }
}
