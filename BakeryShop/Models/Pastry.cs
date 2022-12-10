using System;

namespace BakeryShop.Models
{
  public class Pastry : BakeryItem
  {
    // properties, constructors, methods, etc. go here

    public Pastry(int Count, string Type = "regular")
    {
      this.Count = Count;
      this.Type = Type;
    }

    public override int GetCost()
    {


      int cost = 0;
      int tempCount = Count;
      while (tempCount > 0)
      {
        for (int i = 6; i > 0; i--)
        {
          if (tempCount - i >= 0)
          {
            switch (i)
            {
              case 6:
                cost += 10;
                break;
              case 5:
                cost += 9;
                break;
              case 4:
                cost += 7;
                break;
              case 3:
                cost += 5;
                break;
              default:
                cost += (i * 2);
                break;
            }
            tempCount -= i;

            break;
          }
        }
      }
      return cost;
    }
  }
}
