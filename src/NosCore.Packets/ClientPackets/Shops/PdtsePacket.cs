//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("pdtse", Scope.InGame)]
    public class PdtsePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        public byte? Unknown { get; set; }

        [PacketIndex(3)]
        public short? EquipmentSlot { get; set; }

        [PacketIndex(4)]
        public byte Option { get; set; }
    }
}