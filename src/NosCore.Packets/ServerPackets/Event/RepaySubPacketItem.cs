//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Event
{
    public class RepaySubPacketItem : PacketBase
    {
        [PacketIndex(0)]
        public short? ItemId { get; set; }

        [PacketIndex(1)]
        public sbyte Rare { get; set; }

        [PacketIndex(2)]
        public short Amount { get; set; }
    }
}
