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

      // Change text color
      Console.ForegroundColor = ConsoleColor.Green;

      Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);




      Console.ReadLine();  // Pauses the Console to read it...
    }
  }
}
