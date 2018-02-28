using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      // Display's App Info
      GetAppInfo();

      // Ask for Users Name and Get Info
      GreetUser();  

      while (true)
      {

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
            // Print Error Message
            PrintColorMessage(ConsoleColor.Red, "That is not a number, please try again...");

            // Keep Going
            continue;
          }

          // Cast To Int And Put In Guess
          guess = Int32.Parse(input);

          // Match Guess To Correct Number
          if (guess != correctNumber)
          {
            // Print Error Message
            PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again...");

          }
        }

        // Print Success Message
        PrintColorMessage(ConsoleColor.Yellow, "That is correct!!!");

        // Play Again?
        Console.WriteLine("Do you want to play again? [Y or N]");

        // Get Answer
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
          continue;
        }
        else
        {
          return;
        }

      }
      
    }

    static void GetAppInfo()
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
    }

    // Get and display user info
    static void GreetUser()
    {
      // Ask Users Name
      Console.WriteLine("What is your name?");

      // Get User Input
      string inputName = Console.ReadLine();

      Console.WriteLine("Hello {0}, let's play a game...", inputName);
    }

    // Print Color Message
    static void PrintColorMessage(ConsoleColor color, string message)
    {
      // Change Text Color
      Console.ForegroundColor = color;

      // Tell User It's Not A Number
      Console.WriteLine(message);

      // Reset Text Color
      Console.ResetColor();
    }

  }
}
