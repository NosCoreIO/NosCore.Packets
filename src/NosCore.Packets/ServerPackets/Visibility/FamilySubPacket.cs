//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class FamilySubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long? FamilyId { get; set; }

        [PacketIndex(1)]
        public short? Title { get; set; }
    }
}