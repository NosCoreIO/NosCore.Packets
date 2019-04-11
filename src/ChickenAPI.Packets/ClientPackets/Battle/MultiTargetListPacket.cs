using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;
using System.Collections.Generic;

namespace ChickenAPI.Packets.ClientPackets.Battle
{
    [PacketHeader("mtlist")]
    public class MultiTargetListPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte TargetsAmount { get; set; }

        [PacketIndex(1)]
        public List<MultiTargetListSubPacket> Targets { get; set; }

        #endregion
    }
}