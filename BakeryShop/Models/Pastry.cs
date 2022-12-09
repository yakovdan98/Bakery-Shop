namespace BakeryShop.Models
{
  public class Pastry
  {
    // properties, constructors, methods, etc. go here
    public int Count {get; set;}

    public Pastry(int Count)
    {
      this.Count = Count;
    }

    public int GetCost()
    {
      return this.Count * 2;
    }
  }
}
