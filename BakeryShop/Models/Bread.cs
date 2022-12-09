namespace BakeryShop.Models
{
  public class Bread
  {
    // properties, constructors, methods, etc. go here
    public int Count {get; set;}
    public Bread(int Count)
    {
      this.Count = Count;
    }

    public int GetCost() 
    {
      int discount = this.Count / 3;
      int cost = (this.Count * 5) - (discount * 5);
      return cost;
    }
  }
}