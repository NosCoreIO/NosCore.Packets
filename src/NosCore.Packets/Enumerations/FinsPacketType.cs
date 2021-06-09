﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum FinsPacketType : byte
    {
        Accepted = 1,
        Rejected = 2,
        MarriageRequestAccepted = 34,
        MarriageRequestDenied = 69
    }
}