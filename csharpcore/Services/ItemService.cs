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
    }
}
