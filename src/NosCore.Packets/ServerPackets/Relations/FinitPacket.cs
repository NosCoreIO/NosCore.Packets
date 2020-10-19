﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Relations
{
    [PacketHeader("finit")]
    public class FinitPacket : PacketBase, IWorldPacket
    {
        [PacketListIndex(0, SpecialSeparator = "|")]
        public List<FinitSubPacket?>? SubPackets { get; set; }
    }
}