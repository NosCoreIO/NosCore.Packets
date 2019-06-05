using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Event
{
    public class RbrSubPacketBasicInfo : PacketBase
    {
        [PacketIndex(0)]
        public short TsId { get; set; }

        [PacketIndex(1)]
        public RbrPacketTsType TsType { get; set; }

        [PacketIndex(2)]
        public RbrPacketTsConditionType TsConditionType { get; set; } //Only has meaning with a Miscelaneous TS.
    }
}