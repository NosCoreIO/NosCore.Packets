﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("c_close", Scope.InGame | Scope.InExchange | Scope.OnCharacterScreen)]
    public class CClosePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}