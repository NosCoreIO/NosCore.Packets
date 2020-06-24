//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("pski")]
    public class PSkiPacket : PacketBase
    {
        [PacketIndex(0)]
        public long FirstSkill { get; set; }

        [PacketIndex(1)]
        public long SecondSkill { get; set; }

        [PacketIndex(2)]
        public long ThirdSkill { get; set; }
    }
}