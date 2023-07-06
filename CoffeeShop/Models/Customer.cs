using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;
using System.Linq;

namespace CoffeeShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(Order orderToAdd)
        {
            Orders.Add(orderToAdd);
        }

        public double TotalSpent()
        {
            double totalSpentOnOrders = 0;

            foreach (Order order in Orders)
            {
                totalSpentOnOrders += order.Total(); // round each level 
            }

            return totalSpentOnOrders;
        }

        public List<String> ItemsOrdered()
        {
            return Orders.SelectMany( o => o.Items).Select(i => i.Name).Distinct().ToList();
        }
    }
}
