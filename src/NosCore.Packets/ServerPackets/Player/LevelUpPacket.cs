//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("levelup")]
    public class LevelUpPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}