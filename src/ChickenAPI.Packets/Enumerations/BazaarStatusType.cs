using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.Enumerations
{
    public enum BazaarStatusType : byte
    {
        OnSale = 1,
        Solded = 2,
        DelayExpired = 3
    }
}
