//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Visibility
{
    [PacketHeader("cl")]
    public class ClPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public long VisualId { get; set; }

        [PacketIndex(1)]
        public bool Camouflage { get; set; }

        [PacketIndex(2)]
        public bool Invisible { get; set; }
    }
}