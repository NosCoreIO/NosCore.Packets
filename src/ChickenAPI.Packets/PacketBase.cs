using ChickenAPI.Packets.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ChickenAPI.Packets
{
    public abstract class PacketBase : IPacket
    {
        public string Header { get; set; }

        public ushort? KeepAliveId { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid { get; set; } = true;
    }
}
