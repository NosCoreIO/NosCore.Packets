using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.Enumerations
{
    public enum QSetType : byte
    {
        Default = 0,
        Set = 1,
        Move = 2,
        Remove = 3,
        Reset = 7
    }
}
