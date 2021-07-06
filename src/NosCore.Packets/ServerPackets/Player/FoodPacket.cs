using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("food", Scope.InGame)]
    public class FoodPacket : PacketBase
    {
        [PacketIndex(0)]
        public int FoodValue { get; set; }
    }
}
