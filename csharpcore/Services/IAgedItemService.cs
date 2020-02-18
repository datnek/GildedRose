using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public interface IAgedItemService : IBaseItemService
    {
        void IncreaseQuality();
    }
}
