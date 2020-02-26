using System;
using Jurassic.Models;




public class Program
{
  public static void Main()
  {
    Console.WriteLine("Would you like to:");
    Console.WriteLine("[View] or [Add]");
    string userChoice = Console.ReadLine();
    if (userChoice == "add")
    {
      Dino.AddDino();
      Main();
    }
    else if (userChoice == "view")
    {
      Dino.ViewDino();
      Main();
    }
  }
}