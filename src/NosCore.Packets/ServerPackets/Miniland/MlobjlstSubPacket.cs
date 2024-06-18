﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    public class MlobjlstSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public bool InUse { get; set; }

        [PacketIndex(2,RemoveHeader = true, SpecialSeparator = ".")]
        public MlobjSubPacket? MlObjSubPacket { get; set; }
    }
}