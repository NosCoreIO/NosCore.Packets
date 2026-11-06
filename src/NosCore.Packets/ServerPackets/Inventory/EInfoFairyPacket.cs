//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a fairy.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoFairyPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.Jewelery;

        [PacketIndex(1)]
        public short ItemVNum { get; set; }

        [PacketIndex(2)]
        public ElementType Element { get; set; }

        [PacketIndex(3)]
        public short ElementRate { get; set; }

        [PacketIndex(4)]
        public int Unknown { get; set; }

        [PacketIndex(5)]
        public int Unknown2 { get; set; }

        [PacketIndex(6)]
        public int Unknown3 { get; set; }

        [PacketIndex(7)]
        public int Unknown4 { get; set; }

        [PacketIndex(8)]
        public bool IsNosmall { get; set; }
    }
}
