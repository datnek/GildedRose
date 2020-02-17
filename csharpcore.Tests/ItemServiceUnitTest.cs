using csharpcore.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Tests
{
    [TestClass]
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

        [TestMethod]
        public virtual void DecreaseQualityOneDayWithQuality0()
        {
            // Arrange
            ItemService.Item.Quality = 0;

            // Act
            ItemService.DecreaseQuality();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 0);
        }


        [TestMethod]
        public virtual void DecreaseSellinOneDay()
        {
            // Act
            ItemService.DecreaseSellin();

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }


        [TestMethod]
        public virtual void UpdateItemOneDayWithNegatifSellIn()
        {
            // Arrange
            ItemService.Item.SellIn = -1;


            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 18);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, -2);
        }


        [TestMethod]
        public virtual void UpdateItemOneDayWithPositifSellIn()
        {

            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 19);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }

        [TestMethod]
        public virtual void UpdateItemOneDayWithQuality0()
        {
            // Arrange
            ItemService.Item.Quality = 0;

            // Act
            ItemService.UpdateItem();

            // Assert 
            Assert.AreEqual(ItemService.Item.Quality, 0);

            // Assert 
            Assert.AreEqual(ItemService.Item.SellIn, 9);
        }

    }
}
