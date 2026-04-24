//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Families
{
    public class GexpSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public long Experience { get; set; }
    }
}
