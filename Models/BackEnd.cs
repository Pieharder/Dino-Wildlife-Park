using System;
using System.Collections.Generic;

namespace Jurassic.Models
{
  public class Dino
  {
    public static Dictionary<string, Dino> dinoGroup = new Dictionary<string, Dino>();

    public void addDino(string species, string color, string diet, string name)
    {
      dinoGroup[name] = new Dino(species, color, diet);
    }
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
    public string GetSpecies()
    {
      return _species;
    }

    public string GetColor()
    {
      return _color;
    }

    public string GetDiet()
    {
      return _diet;
    }

    public string GetName()
    {
      return _name;
    }
  }
}