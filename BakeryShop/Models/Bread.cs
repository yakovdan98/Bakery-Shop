namespace BakeryShop.Models
{
  public class Bread : BakeryItem
  {
    // properties, constructors, methods, etc. go here
    
    public Bread(int Count, string Type = "regular")
    {
      this.Count = Count;
      this.Type = Type;
    }

    public override int GetCost() 
    {
      int discount = this.Count / 3;
      int cost = (this.Count * 5) - (discount * 5);
      return cost;
    }
  }
}