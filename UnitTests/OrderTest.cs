using CoffeeShop.Models;

namespace UnitTests
{
    public class OrderTest
    {
        [Fact]
        public void Test_Order_Constructor()
        {
            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);

            Order order = new Order();

            Assert.Empty(order.Items);
        }

        [Fact]
        public void Test_Order_AddItem()
        {
            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);

            Order order = new Order();

            order.AddItem(item1);
            order.AddItem(item2);
            order.AddItem(item3);

            Assert.Equal(new List<Item> { item1, item2, item3}, order.Items);
        }

        [Fact]
        public void Test_Order_Total()
        {
            Item item1 = new Item("Latte", 375);
            Item item2 = new Item("Cappuccino", 400);
            Item item3 = new Item("Mocha", 450);

            Order order = new Order();

            order.AddItem(item1);
            order.AddItem(item2);
            order.AddItem(item3);

            Assert.Equal(12.25, order.Total());
        }
    }
}