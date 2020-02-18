using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public class BackstageItemService : AgedItemService, IBackstageItemService
    {
        #region "UpdateItem"

        /// <summary>
        ///  The UpdateItem method solves the following scenarios
        ///  1- At the end of each day, our system lowers the 
        ///  SellIn for each item
        ///  2- The quality of an article is never negative
        ///  3- Backstage passes, like "Aged Brie", increase 
        ///  in quality when the value direct sales approach
        ///  4-  Quality increases by 2 for 5 - 9 days or less and 3 
        ///  for 0 - 4 days or less Quality drops to 0 after the concert
        /// </summary>
        /// <param name="updateSellin"></param>
        public override void UpdateItem(bool updateSellin = true)
        {
            base.UpdateItem();

            if (Item.SellIn < 10)
            {
                IncreaseQuality();
            }

            if (Item.SellIn < 5)
            {
                this.IncreaseQuality();
            }

            Item.Quality = Item.SellIn < 0 ? 0 : Item.Quality;
        }
        #endregion
    }
}
