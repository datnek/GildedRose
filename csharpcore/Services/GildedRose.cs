using System.Collections.Generic;

namespace csharpcore.Services
{
    public class GildedRose
    {
        #region "Properties"
        private IList<Item> Items { get; set; }
        private readonly IItemService _itemService;
        private readonly IAgedItemService _agedItemService;
        private readonly IBackstageItemService _backstageItemService;
        private readonly IConjuredItemService _conjuredItemService;
        #endregion

        #region "Constructor"
        public GildedRose(IList<Item> items) // this can not be use
        {
            this.Items = items;
        }
        public GildedRose(IItemService itemService,
            IAgedItemService agedItemService,
            IConjuredItemService conjuredItemService,
            IBackstageItemService backstageItemService
            )
        {
            this._itemService = itemService;
            this._agedItemService = agedItemService;
            this._backstageItemService = backstageItemService;
            this._conjuredItemService = conjuredItemService;
        }
        #endregion

        #region "SetItem"
        public void SetItem(IList<Item> items)
        {
            this.Items = items;
        }
        #endregion
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;

                            if (Items[i].Name == "Conjured Mana Cake" && Items[i].Quality > 0)
                            {
                                Items[i].Quality -= 1;
                            }
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                    //here
                                    if (Items[i].Name == "Conjured Mana Cake" && Items[i].Quality > 0)
                                    {
                                        Items[i].Quality -= 1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
