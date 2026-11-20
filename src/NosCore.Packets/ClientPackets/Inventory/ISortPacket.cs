using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("isort", Scope.InGame)]
    public class ISortPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType PocketType { get; set; }

        // 1 when the sort question was answered yes.
        [PacketIndex(1, IsOptional = true)]
        public bool? Confirmed { get; set; }
    }
}
