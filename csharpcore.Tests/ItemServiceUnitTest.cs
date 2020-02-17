using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Tests
{
    public class ItemServiceUnitTest
    {
        public virtual ItemService ItemService { get; set; }
        public ItemServiceUnitTest()
        {

            //Arrange 
            ItemService = new ItemService()
            {
                Item = new Item
                {
                    Name = "Foo",
                    SellIn = 10,
                    Quality = 20
                }
            };
        }


        [TestMethod]
        public virtual void DecreaseQualityOneDayForDefaultItem()
        {
            // Act
            ItemService.DecreaseQuality();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 19);
        }
    }
}
