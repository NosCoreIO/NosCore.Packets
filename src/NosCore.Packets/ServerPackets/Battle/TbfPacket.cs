using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("tbf", Scope.InGame)]
    public class TbfPacket : PacketBase
    {
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketListIndex(1)]
        public List<TbfSubPacket?>? SubPackets { get; set; }
    }
}
