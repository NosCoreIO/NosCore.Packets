﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qset")]
    public class QsetClientPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public short OriginQuickList { get; set; }

        [PacketIndex(1)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public QsetClientSubPacket? Data { get; set; }
    }
}