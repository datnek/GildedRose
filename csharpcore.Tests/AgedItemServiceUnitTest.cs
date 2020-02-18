using csharpcore.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Tests
{
    [TestClass]
    public class AgedItemServiceUnitTest
    {
        public virtual IAgedItemService ItemService { get; set; }
        public AgedItemServiceUnitTest()
        {
            // Arrange
            this.ItemService = new AgedItemService()
            {
                Item = new Item
                {
                    Name = Constants.AGED_ITEM,
                    SellIn = 10,
                    Quality = 20
                }
            };
        }

        [TestMethod]
        public virtual void IncreaseQualityOneDayForQuality50Item()
        {
            // Arrange
            ItemService.Item.Quality = 50;

            // Act
            ItemService.IncreaseQuality();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 50);
        }

        [TestMethod]
        public virtual void IncreaseQualityOneDayForQuality20Item()
        {
            // Act
            ItemService.IncreaseQuality();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 21);
        }

        [TestMethod]
        public virtual void UpdateItemOneDayWithNegatifSellIn()
        {
            // Arrange
            ItemService.Item.SellIn = -1;


            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 22);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, -2);
        }

        [TestMethod]
        public virtual void UpdateItemOneDayWithPositifSellIn()
        {

            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 21);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }

        [TestMethod]
        public void UpdateItemOneDayWithQuality50()
        {
            // Arrange
            ItemService.Item.Quality = 50;

            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 50);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }

    }
}
