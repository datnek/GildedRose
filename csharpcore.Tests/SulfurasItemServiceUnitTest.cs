using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Tests
{
    [TestClass]
    public class SulfurasItemServiceUnitTest
    {
        public virtual ItemService ItemService { get; set; }
        public SulfurasItemServiceUnitTest()
        {

            //Arrange 
            ItemService = new ItemService()
            {
                Item = new Item
                {
                    Name = Constants.SULFURAGES_ITEM,
                    SellIn = 10,
                    Quality = 80
                }
            };
        }

        [TestMethod]
        public virtual void DecreaseQualityOneDay()
        {
            // Act
            ItemService.DecreaseQuality();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 80);
        }

        [TestMethod]
        public virtual void DecreaseSellinOneDay()
        {
            // Act
            ItemService.DecreaseSellin();

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 10);
        }
    }
}
