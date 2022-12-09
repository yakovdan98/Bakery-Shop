using System;


namespace BakeryShop.Models
{
    public abstract class BakeryItem
    {
        public int Count {get; set;}

        public abstract int GetCost();
    }
}