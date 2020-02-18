using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public class ConjuredItemService : ItemService, IConjuredItemService
    {
        #region "UpdateItem"
        /// <summary>
        ///  The UpdateItem method solves the following scenarios
        /// 1- All base scenarios
        /// 2- "Conjured" items degrade in Quality twice as fast as normal items
        /// </summary>
        /// <param name="updateSellIn"></param>
        public override void UpdateItem(bool updateSellIn = true)
        {

            base.UpdateItem(updateSellIn);
            base.UpdateItem(false);
        }
        #endregion
    }
}
