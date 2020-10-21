//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_info", Scope.InGame)]
    public class MloInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool IsOwner { get; set; }

        [PacketIndex(1)]
        public short ObjectVNum { get; set; }

        [PacketIndex(2)]
        public byte Slot { get; set; }

        [PacketIndex(3)]
        public long MinilandPoints { get; set; }

        [PacketIndex(4)]
        public bool LawDurability { get; set; }

        [PacketIndex(5)]
        public bool IsFull { get; set; }

        [PacketIndex(6, SpecialSeparator = " ")]
        public MloInfoPacketSubPacket?[]? MinigamePoints { get; set; }
    }
}
