using System;

class MealTime
{
  static void AskWhatYouAteFor (string meal)
  {
    Console.WriteLine("What did you eat for " + meal + "?");
  }
  static void Main()
  {
    Console.WriteLine("What did you eat for breakfast?");
    string yourBreakfast = Console.ReadLine();
    Console.WriteLine("You had " + yourBreakfast + " for breakfast.");
    
    Console.WriteLine("What did you eat for lunch?");
    string yourLunch = Console.ReadLine();
    Console.WriteLine("You had " + yourLunch + " for lunch.");

    Console.WriteLine("What did you eat for dinner?");
    string yourDinner = Console.ReadLine();
    Console.WriteLine("You had " + yourDinner + " for dinner.");
  }
}