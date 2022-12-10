using System;
using BakeryShop.Models;

namespace BakeryShop
{
  class Program
  {
    public static void Main(string[] args)
    { 
      Console.WriteLine("Welcome to Pierre's Bakery!\nBread is $5 and is running a buy 1 get one free special\nThe price for Pastries is Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.");
      Console.WriteLine("How much bread do you want?");
      int breadCount = int.Parse(Console.ReadLine());
      Console.WriteLine("What type of bread do you want?");
      string breadType = Console.ReadLine();
      Bread bread = new Bread(breadCount, breadType);

      Console.WriteLine("How many pastries do you want?");
      int pastryCount = int.Parse(Console.ReadLine());
      Console.WriteLine("What type of pastry do you want?");
      string pastryType = Console.ReadLine();
      Pastry pastry = new Pastry(pastryCount, pastryType);

      Console.WriteLine($"The {bread.Type} bread will cost:    {bread.GetCost()}\nThe {pastry.Type} pastries will cost: {pastry.GetCost()}");
      Console.WriteLine($"The total cost: {bread.GetCost() + pastry.GetCost()}");
    }
  }
}