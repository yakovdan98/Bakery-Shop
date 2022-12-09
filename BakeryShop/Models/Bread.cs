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
      return this.Count * 5;
    }
  }
}