using CoffeeShop.Models;

namespace UnitTests
{
    public class CustomerTest
    {
        [Fact]
        public void Test_Customer_Constructor()
        {
            Customer customer = new Customer("Taylor");

            Assert.Equal("Taylor", customer.Name);
            Assert.Empty(customer.Orders);
        }

        [Fact]
        public void Test_Customer_AddOrder()
        {
            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);
            Item item4 = new Item("Caramel Macchiato", 500);
            Item item5 = new Item("Espresso", 250);
            Item item6 = new Item("Cappuccino", 400);
            Order order1 = new Order();
            Order order2 = new Order();

            Customer customer = new Customer("Taylor");
            // A customer is created with a name

            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);
            order2.AddItem(item4);
            order2.AddItem(item5);
            order2.AddItem(item6);

            customer.AddOrder(order1);
            customer.AddOrder(order2);

            Assert.Equal(new List<Order> { order1, order2 }, customer.Orders);
        }

        [Fact]
        public void Test_Customer_TotalSpent()
        {
            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);
            Item item4 = new Item("Caramel Macchiato", 500);
            Item item5 = new Item("Espresso", 250);
            Item item6 = new Item("Cappuccino", 400);
            Order order1 = new Order();
            Order order2 = new Order();

            Customer customer = new Customer("Taylor");
            // A customer is created with a name

            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);
            order2.AddItem(item4);
            order2.AddItem(item5);
            order2.AddItem(item6);

            customer.AddOrder(order1);
            customer.AddOrder(order2);

            Assert.Equal(23.75, customer.TotalSpent());
        }

        [Fact]
        public void Test_Customer_ItemsOrdered()
        {
            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);
            Item item4 = new Item("Caramel Macchiato", 500);
            Item item5 = new Item("Espresso", 250);
            Item item6 = new Item("Cappuccino", 400);

            Order order1 = new Order();
            Order order2 = new Order();

            Customer customer = new Customer("Taylor");
            // A customer is created with a name

            order1.AddItem(item1);
            order1.AddItem(item2);
            order1.AddItem(item3);
            order2.AddItem(item4);
            order2.AddItem(item5);
            order2.AddItem(item6);

            customer.AddOrder(order1);
            customer.AddOrder(order2);

            Assert.Equal(new List<string> { "Latte", "Cappuccino", "Mocha", "Caramel Macchiato", "Espresso" }, customer.ItemsOrdered());
        }
    }
}