using System;
using System.Collections.Generic;
using Jurassic.Models;


namespace Jurassic
{
  public class Program
  {
    private string _type;
    private string _color;
    private string _diet;
    private string _name;
    public static void Main()
    {
  // public static Dinosaur newDinosaur = new Dinosaur();
    }
    public static void ChoosePath()
    {
      Console.WriteLine("Would you like to:");
      Console.WriteLine("[View] or [Add]");
      string userChoice = Console.ReadLine();
      if (userChoice == "add")
      {
        AddDino();
      }
      else if (userChoice == "view")
      {

      }
    }
    public static void AddDino()
    {
        Console.WriteLine("Please enter a Dinosaur species");
        string _type = Console.ReadLine();
        Console.WriteLine("Please enter a Dinosaur color");
        string _color = Console.ReadLine();
        Console.WriteLine("Please enter a Dinosaur diet");
        string _diet = Console.ReadLine();
        Console.WriteLine("Please give the dino a name");
        string _name = Console.ReadLine();
        // Console.WriteLine("Dinosaur Added!");
    }

    public static void ViewDino()
    {
      Console.WriteLine("What dino would you like to view");
      Console.ReadLine(dinoGroup)
    }

  }
}