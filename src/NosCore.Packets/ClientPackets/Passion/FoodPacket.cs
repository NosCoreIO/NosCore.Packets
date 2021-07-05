using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Passion
{
    [PacketHeader("food", Scope.InGame)]
    public class FoodPacket : PacketBase
    {
        [PacketIndex(0)]
        public int FoodValue { get; set; }
    }
}
