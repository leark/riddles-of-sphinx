using System;
using RiddlesOfSphinx.Models;

namespace RiddlesOfSphinx
{
  public class Program
  {
    public static void Main(int indexOfPrevQuestion)
    {
      Console.WriteLine("Sphinx appears out of nowhere and asks you this question: ");
      Random rnd = new Random ();
      string[] sphinxRiddles = {"Which is the creature that has one voice, but has four feet in the morning, two feet in the afternoon, and three feet at night?","What goes up but never comes down?"};
      string[] sphinxAnswers = {"human", "age"};
      int rIndex = rnd.Next(sphinxRiddles.Length);
      Console.WriteLine(sphinxRiddles[rIndex]);
      string answer1 = Console.ReadLine();
      string correctAnswer1 = sphinxAnswers[rIndex];

      if (correctAnswer1 == answer1.ToLower()) 
      {
        Console.WriteLine("Sphinx has been defeated. Would you like to face Sphinx again? [y/n]");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "y")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Well played! Game Over.");
        }
      }
      else
      {
        Console.WriteLine("You are eaten by the Sphinx!");
      }
    }
  }
}
