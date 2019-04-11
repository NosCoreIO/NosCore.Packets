using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Movement
{
    [PacketHeader("pulse")]
    public class PulsePacket : PacketBase
    {
        [PacketIndex(0)]
        public int Tick { get; set; }
    }
}