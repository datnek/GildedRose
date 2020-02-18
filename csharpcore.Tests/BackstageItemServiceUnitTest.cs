using csharpcore.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Tests
{
    [TestClass]
    public class BackstageItemServiceUnitTest : AgedItemServiceUnitTest
    {

        public BackstageItemServiceUnitTest() : base()
        {
            // Arrange
            ItemService = new BackstageItemService()
            {
                Item = new Item
                {
                    Name = Constants.BACKSTAGE_ITEM,
                    SellIn = 10,
                    Quality = 20
                }
            };
        }

        [TestMethod]
        public override void UpdateItemOneDayWithPositifSellIn()
        {
            //Arrange 
            ItemService.Item.SellIn = 16;

            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 21);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 15);
        }

        [TestMethod]
        public void UpdateItemOneDayWithSellIn9AndQuality22()
        {
            // Arrange
            ItemService.Item.SellIn = 10;


            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 22);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }

    }
}
