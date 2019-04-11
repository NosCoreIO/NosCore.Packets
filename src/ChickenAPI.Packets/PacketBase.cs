using ChickenAPI.Packets.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets
{
    public abstract class PacketBase : IPacket
    {
        public string Header { get; set; }
        public int? KeepAliveId { get; set; }
    }
}
