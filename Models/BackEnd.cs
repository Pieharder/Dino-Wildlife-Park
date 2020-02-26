using System;
using System.Collections.Generic;

namespace Jurassic.Models
{
  public class Dino
  {
    public static List<Dino> dinosaursList = new List<Dino>()
    {};
    private string _species;
    private string _color;
    private string _diet;
    private string _name;

    public Dino(string species, string color, string diet, string name)
    {
      _species = species;
      _color = color;
      _diet = diet;
      _name = name;
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
        Console.WriteLine("Dinosaur Added!");
        Dino dinosaurs = new Dino(_type, _color, _diet, _name);
        dinosaursList.Add(dinosaurs);
    }

    public static void ViewDino()
    {
      Console.WriteLine("What dino would you like to view");
      string inputName = Console.ReadLine();
      foreach(Dino data in dinosaursList)
      {
        if (inputName == data._name)
        {
          Console.WriteLine(data._species);
          Console.WriteLine(data._color);
          Console.WriteLine(data._diet);
          Console.WriteLine(data._name);
        }
      }
    }
  }
}