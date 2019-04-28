using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Npcs
{
    [PacketHeader("npc_req")]
    public class RequestNpcPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public long TargetId { get; set; }

        [PacketIndex(2)]
        public long? Data { get; set; }
    }
}
