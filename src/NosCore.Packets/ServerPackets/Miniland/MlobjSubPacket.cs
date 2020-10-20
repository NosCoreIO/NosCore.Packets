//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    public class MlobjSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MapX { get; set; }

        [PacketIndex(1)]
        public short MapY { get; set; }

        [PacketIndex(2)]
        public byte Width { get; set; }

        [PacketIndex(3)]
        public byte Height { get; set; }

        [PacketIndex(4)]
        public byte Unknown { get; set; }

        [PacketIndex(5)]
        public int DurabilityPoint { get; set; }

        [PacketIndex(6)]
        public bool Unknown2 { get; set; }

        [PacketIndex(7)]
        public bool IsWarehouse { get; set; }
    }
}