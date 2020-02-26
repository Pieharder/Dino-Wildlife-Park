using System;
using System.Collections.Generic;
using Jurassic.Models;


namespace Jurassic
{
  public class Program
  {
    public static void Main()
    {
      List<Dino> Dinosaurs = new List<Dino>()
      {};
    


      Dino dinosaur = new Dino();
      dinosaur.AddDino();
      Dinosaurs.Add(dinosaur);
      dinosaur.GetDino();

      Dinosaurs.ForEach(Console.WriteLine);
    }
    
  }
}