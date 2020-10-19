﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("title")]
    public class TitlePacket : PacketBase, IWorldPacket
    {
        [PacketListIndex(0, IsOptional = true)]
        public List<TitleSubPacket?>? Data { get; set; }
    }
}