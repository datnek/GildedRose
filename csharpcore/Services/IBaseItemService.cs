using csharpcore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public interface IBaseItemService
    {
        void UpdateItem(bool updateSellIn = true);
        void DecreaseSellin();
        Item Item { get; set; }
    }
}
