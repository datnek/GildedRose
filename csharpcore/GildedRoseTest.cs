using Xunit;
using System.Collections.Generic;
using csharpcore.Models;
using csharpcore.Services;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.NotEqual("fixme", Items[0].Name);
        }
    }
}