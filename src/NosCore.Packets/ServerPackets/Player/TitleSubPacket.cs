//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Player
{
    public class TitleSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short TitleId { get; set; }

        [PacketIndex(1)]
        public byte TitleStatus { get; set; }
    }
}