
using System.Collections.Generic;
using csharpcore.Services;
using csharpcore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests.Reporters;
using System.Text;
using System;
using System.IO;
using ApprovalTests;
using Moq;

namespace csharpcore.Tests
{

    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class GildedRoseUnitTest
    {

        public virtual IGildedRoseService GildedRoseService { get; set; }

        public GildedRoseUnitTest()
        {
            GildedRoseService = new GildedRose(new Mock<IItemService>().Object,
                                    new Mock<IAgedItemService>().Object,
                                    new Mock<IConjuredItemService>().Object,
                                    new Mock<IBackstageItemService>().Object
                                    );
        }

        [TestMethod]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRoseService.SetItem(Items);
            GildedRoseService.UpdateQuality();
            Assert.AreNotEqual("fixme", Items[0].Name);
        }

        [TestMethod]
        public void ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}