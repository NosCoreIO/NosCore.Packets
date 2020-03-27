using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("glmk")]
    public class CreateFamilyPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? FamilyName { get; set; }
    }
}