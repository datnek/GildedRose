using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public  class BaseItemService : IBaseItemService
    {
        public Item Item { get; set; }

        #region "DecreaseSellin"
        /// <summary>
        /// /// The DecreaseSellin method solves the following scenarios
        /// 1- At the end of each day, our system lowers the SellIn for each item
        /// 2- "Sulfuras", being a legendary item, never has to be sold 
        /// </summary>
        /// </summary>
        public virtual void DecreaseSellin()
            => Item.SellIn = Item.Name != Constants.SULFURAGES_ITEM ?
                            Item.SellIn - 1 : Item.SellIn;
        #endregion

        public void UpdateItem(bool updateSellIn = true)
        {
            throw new NotImplementedException();
        }
    }
}
