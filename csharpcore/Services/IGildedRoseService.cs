using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public interface IGildedRoseService
    {
        void UpdateQuality();
        void SetItem(IList<Item> items);
        void ShowItems();
    }
}
