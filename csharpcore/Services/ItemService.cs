using csharpcore.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    /// <summary>
    /// Manage All basics services
    /// </summary>
    public class ItemService : BaseItemService, IItemService
    {
        #region "DecreaseQuality"
        /// <summary>
        /// The DecreaseQuality method solves the following scenarios
        /// 1- The Quality of an item is never negative
        /// 2- At the end of each day, our system lowers the quality for each item
        /// 3- "Sulfuras", being a legendary item, never has to be  decreases in Quality
        /// </summary>
        public virtual void DecreaseQuality()
            => Item.Quality = Item.Name != Constants.SULFURAGES_ITEM
                                && Item.Quality > 0 ?
                                Item.Quality - 1 : Item.Quality;
        #endregion

        #region "UpdateItem"
        /// <summary>
        /// The UpdateItem method solves the following scenarios
        /// 1.a- At the end of each day, our system lowers the quality for each item
        /// 1.b- At the end of each day, our system lowers the SellIn for each item
        /// 2- Once the sell by date has passed, Quality degrades twice as fast
        /// </summary>
        /// <param name="updateSellIn"></param>
        public override void UpdateItem(bool updateSellIn = true)
        {
            //1.b
            base.UpdateItem(updateSellIn);

            //1.a
            DecreaseQuality();

            //2
            if (Item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
        #endregion
    }
}
