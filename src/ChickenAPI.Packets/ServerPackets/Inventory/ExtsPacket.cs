using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    [PacketHeader("exts")]
    public class ExtsPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte EquipmentExtension { get; set; }

        [PacketIndex(2)]
        public byte MainExtension { get; set; }

        [PacketIndex(3)]
        public byte EtcExtension { get; set; }
    }
}