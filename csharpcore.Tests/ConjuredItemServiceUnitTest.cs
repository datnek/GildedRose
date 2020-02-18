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

    }
}
