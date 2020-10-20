//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Quicklist
{
    public class QsetClientSubPacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public QSetType? Type { get; set; }

        [PacketIndex(1)]
        public short OriginQuickList { get; set; }

        [PacketIndex(2)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? Data { get; set; }
    }
}