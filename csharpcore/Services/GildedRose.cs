using csharpcore.Utils;
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

        #region "UpdateQuality"

        /// <summary>
        /// This method resolve 
        /// </summary>
        public void UpdateQuality()
        {

            foreach (var item in Items)
            {

                switch (item.Name)
                {
                    case Constants.AGED_ITEM:
                        this._agedItemService.Item = item;
                        _agedItemService.UpdateItem();
                        break;
                    case Constants.BACKSTAGE_ITEM:
                        this._backstageItemService.Item = item;
                        _backstageItemService.UpdateItem();
                        break;
                    case Constants.CONJURED_ITEM:
                        this._conjuredItemService.Item = item;
                        _conjuredItemService.UpdateItem();
                        break;
                    default:
                        this._itemService.Item = item;
                        this._itemService.UpdateItem();
                        break;
                }
            }
        }

        #endregion

        #region "ShowItems"
        /// <summary>
        /// 
        /// </summary>
        public void ShowItems()
        {
            foreach (var item in Items)
            {
                System.Console.WriteLine($"{item.Name}, {item.SellIn}, { item.Quality}");
            }
        }
        #endregion
    }
}
