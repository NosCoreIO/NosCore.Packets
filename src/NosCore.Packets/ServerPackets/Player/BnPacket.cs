//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("bn")]
    public class BnPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte BnNumber { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}