using System;
using Jurassic;

namespace Jurassic.Models
{
  public class Dino
  {
    private string _type;
    private string _color;
    private string _diet;
    private string _name;

    public void AddDino()
    {
      Console.WriteLine("Add View");
      string addView = Console.ReadLine();
      if (addView == "Add")
      {
        Console.WriteLine("Please enter a Dinosaur species");
        _type = Console.ReadLine();
        Console.WriteLine("Please enter a Dinosaur color");
        _color = Console.ReadLine();
        Console.WriteLine("Please enter a Dinosaur diet");
        _diet = Console.ReadLine();
        Console.WriteLine("Please give the dino a name");
        _name = Console.ReadLine();
        Console.WriteLine("Dinosaur Added!");
      }
      else if (addView == "View")
      {
        Dinosaurs.ForEach(Console.WriteLine);
      }

    }
    public void GetDino()
    {
      Console.WriteLine(_type, _color, _diet, _name);
    }
  }
}