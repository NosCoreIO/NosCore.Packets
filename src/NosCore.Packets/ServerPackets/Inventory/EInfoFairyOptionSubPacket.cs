//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // One option of a fairy ("5.15.9"): for a given type, the value grows with the level.
    public class EInfoFairyOptionSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Level { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public int Value { get; set; }
    }
}
