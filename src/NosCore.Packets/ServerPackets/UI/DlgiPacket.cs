﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("dlgi", Scope.InGame)]
    public class DlgiPacket : PacketBase
    {
        [PacketIndex(0)]
        public IPacket? YesPacket { get; set; }

        [PacketIndex(1)]
        public IPacket? NoPacket { get; set; }

        [PacketIndex(2)]
        public Game18NConstString Question { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; }

        [PacketIndex(4)]
        public short ItemVNum { get; set; }
    }
}