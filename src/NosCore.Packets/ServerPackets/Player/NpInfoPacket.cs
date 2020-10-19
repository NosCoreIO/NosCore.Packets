//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("npinfo")]
    public class NpInfoPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte Page { get; set; }
    }
}