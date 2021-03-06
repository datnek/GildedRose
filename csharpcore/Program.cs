﻿using csharpcore.Models;
using csharpcore.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class Program
    {
        #region "GetTestItems"
        private static IList<Item> GetTestItem()
           => new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
           };
        #endregion

        #region "GetServiceCollection"
        private static IServiceCollection GetServiceCollection() =>
          new ServiceCollection()
              .AddSingleton<IItemService, ItemService>()
              .AddSingleton<IConjuredItemService, ConjuredItemService>()
              .AddSingleton<IAgedItemService, AgedItemService>()
              .AddSingleton<IBackstageItemService, BackstageItemService>()
              .AddSingleton<IGildedRoseService, GildedRose>();
        #endregion

        #region "Main function "
        public static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = GetServiceCollection().BuildServiceProvider();

            //Get Gilded Rose Service instance
            var app = serviceProvider.GetService<IGildedRoseService>();

            app.SetItem(GetTestItem());

            Console.WriteLine("OMGHAI!");

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                app.ShowItems();
                Console.WriteLine("");
                app.UpdateQuality();
            }

            serviceProvider.Dispose();
        }
        #endregion
    }
}
