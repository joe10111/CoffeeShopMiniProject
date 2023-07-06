using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public Order() 
        {
            Items = new List<Item>();
        }

        public void AddItem(Item itemToAdd)
        {
            Items.Add(itemToAdd);
        }

        public double Total()
        {
            double priceTotal = 0;

            foreach (var item in Items)
            {
                priceTotal += item.PriceInDollars();
            }

            return priceTotal;
        }
    }
}
