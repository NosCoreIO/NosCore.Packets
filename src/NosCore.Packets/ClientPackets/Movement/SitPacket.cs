﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("rest")]
    public class SitPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte Amount { get; set; }

        [PacketListIndex(1, Length = -1)]
        public List<SitSubPacket?>? Users { get; set; }
    }
}