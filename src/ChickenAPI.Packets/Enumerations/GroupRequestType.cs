using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenApi.Packet.Enumerations
{
    public enum GroupRequestType : byte
    {
        Requested = 0,
        Invited = 1,
        Accepted = 3,
        Declined = 4,
        Sharing = 5,
        AcceptedShare = 6,
        DeclinedShare = 7
    }
}
