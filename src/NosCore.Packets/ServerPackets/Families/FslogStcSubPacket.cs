//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    public class FslogStcSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public FamilyWarehouseLogType Type { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public string? CharacterName { get; set; }

        [PacketIndex(2, SpecialSeparator = "|")]
        public short ItemVNum { get; set; }

        [PacketIndex(3, SpecialSeparator = "|")]
        public short Amount { get; set; }

        [PacketIndex(4, SpecialSeparator = "|")]
        public int HoursAgo { get; set; }
    }
}
