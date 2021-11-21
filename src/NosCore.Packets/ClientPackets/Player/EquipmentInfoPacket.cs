//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("eqinfo", Scope.InGame)]
    public class EquipmentInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } // todo more information

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public short MateSlot { get; set; }

        [PacketIndex(3)]
        public long? ShopOwnerId { get; set; }
    }
}
