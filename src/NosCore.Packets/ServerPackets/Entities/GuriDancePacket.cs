//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Entities
{
    // Broadcast when an entity starts a filling bar or takes off its specialist.
    [PacketHeader("guri", Scope.InGame, AllowDuplicateHeader = true)]
    public class GuriDancePacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; } = GuriPacketType.Dance;

        [PacketIndex(1)]
        public VisualType VisualType { get; set; }

        [PacketIndex(2)]
        public long VisualId { get; set; }

        [PacketIndex(3)]
        public byte Unknown3 { get; set; }
    }
}
