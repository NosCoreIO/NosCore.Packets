//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Families
{
    public class FrankStcSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Rank { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public string? FamilyName { get; set; }

        [PacketIndex(2, SpecialSeparator = "|")]
        public byte FamilyLevel { get; set; }

        [PacketIndex(3, SpecialSeparator = "|")]
        public long Value { get; set; }
    }
}
