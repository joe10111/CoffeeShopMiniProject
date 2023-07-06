using CoffeeShop.Models;

namespace UnitTests
{
    public class ItemTest
    {
        [Fact]
        public void Test_Item_Constructor()
        {
            Item item = new Item("Cappuccino", 400);

            Assert.Equal("Cappuccino", item.Name);
            Assert.Equal(400, item.PriceInCents);
        }

        [Fact]
        public void Test_Item_PriceInDollars()
        {
            Item item = new Item("Cappuccino", 400);

            Assert.Equal(4, item.PriceInDollars());
        }
    }
}