using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PriceInCents { get; set; }

        public Item(string name, int priceInCents) 
        {
            Name = name;
            PriceInCents = priceInCents;
        }

        public double PriceInDollars()
        {
            return System.Convert.ToDouble(PriceInCents) / 100;
        }
    }
}
