﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Services
{
    public interface IItemService : IBaseItemService
    {
        void DecreaseQuality();
    }
}
