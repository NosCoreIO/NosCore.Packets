using NosCore.Packets.Attributes;
using System.Collections.Generic;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("mtlist")]
    public class MultiTargetListPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte TargetsAmount { get; set; }

        [PacketIndex(1)]
        public List<MultiTargetListSubPacket>? Targets { get; set; }

        #endregion
    }
}