using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Npcs
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
