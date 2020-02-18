using csharpcore.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Tests
{
    [TestClass]
    public class ConjuredItemServiceUnitTest : ItemServiceUnitTest
    {
        public ConjuredItemServiceUnitTest() : base()
        {
            //Arrange 
            ItemService = new ConjuredItemService()
            {
                Item = new Item
                {
                    Name = Constants.CONJURED_ITEM,
                    SellIn = 10,
                    Quality = 20
                }
            };
        }

        [TestMethod]
        public override void UpdateItemOneDayWithNegatifSellIn()
        {
            // Arrange
            ItemService.Item.SellIn = -1;


            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 16);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, -2);
        }

        [TestMethod]
        public override void UpdateItemOneDayWithPositifSellIn()
        {

            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 18);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }
    }
}
