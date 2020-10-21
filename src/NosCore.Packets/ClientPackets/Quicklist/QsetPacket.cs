//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Quicklist
{
    [PacketHeader("qset", Scope.InGame | Scope.InTrade)]
    public class QsetPacket : PacketBase
    {
        [PacketIndex(0)]
        public QSetType Type { get; set; }

        [PacketIndex(1)]
        public short OriginQuickList { get; set; }

        [PacketIndex(2)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(3)]
        public short? FirstData { get; set; }

        [PacketIndex(4)]
        public short? SecondData { get; set; }
    }
}