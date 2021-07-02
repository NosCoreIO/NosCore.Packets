using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("isort", Scope.InGame)]
    public class ISortPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType PocketType { get; set; }
    }
}
