//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Families
{
    public class GidxFamilySubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int ServerId { get; set; }

        [PacketIndex(1)]
        public long FamilyId { get; set; }
    }
}
