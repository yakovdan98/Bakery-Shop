using System;
using BakeryShop.Models;

namespace BakeryShop
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How much bread do you want?");
      int breadCount = int.Parse(Console.ReadLine());
      Bread bread = new Bread(breadCount);

      Console.WriteLine("How many pastries do you want?");
      int pastryCount = int.Parse(Console.ReadLine());
      Pastry pastry = new Pastry(pastryCount);

      Console.WriteLine($"The bread will cost:    {bread.GetCost()}\nThe pastries will cost: {pastry.GetCost()}");
      Console.WriteLine($"The total cost: {bread.GetCost() + pastry.GetCost()}");
    }
  }
}