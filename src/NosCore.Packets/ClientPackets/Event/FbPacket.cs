﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Event
{
    [PacketHeader("fb", Scope.InGame)]
    public class FbPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Type { get; set; }
    }
}