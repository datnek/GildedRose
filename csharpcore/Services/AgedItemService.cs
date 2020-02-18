using csharpcore.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public class AgedItemService : BaseItemService, IAgedItemService
    {
        #region "IncreaseQuality"
        /// <summary>
        /// 1- The Quality of an item is never more than 50
        /// 2- "Aged Brie" actually increases in Quality the older it gets
        /// </summary>
        public virtual void IncreaseQuality()
            => Item.Quality = Item.Quality < 50 ?
                                 ++Item.Quality : Item.Quality;
        #endregion


        #region "UpdateItem"
        /// <summary>
        /// The UpdateItem method solves the following scenarios
        /// 1- At the end of each day, our system lowers the SellIn for each item
        /// 2- "Aged Brie" actually increases in Quality the older it gets
        /// 3- Once the sell by date has passed, Quality older twice as fast
        /// </summary>
        /// <param name="updateSellIn"></param>
        public override void UpdateItem(bool updateSellIn = true)
        {
            //1
            base.UpdateItem();

            //2
            this.IncreaseQuality();

            //3
            if (Item.SellIn < 0 && Item.Name != Constants.BACKSTAGE_ITEM)
            {
                this.IncreaseQuality();
            }
        }
        #endregion
    }
}
