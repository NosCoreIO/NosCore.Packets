using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    // Shows the mini pet the entity wears, or takes it away. A trace line names the same item as the last
    // slot of the eq line that follows it.
    [PacketHeader("minipet", Scope.InGame)]
    public class MinipetPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short? MiniPetVNum { get; set; }
    }
}
