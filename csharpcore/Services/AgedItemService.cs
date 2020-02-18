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
    }
}
