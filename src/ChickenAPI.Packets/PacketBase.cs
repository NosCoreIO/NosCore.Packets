using ChickenAPI.Packets.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ChickenAPI.Packets
{
    public abstract class PacketBase : IPacket
    {
        public string? Header { get; set; }

        public ushort? KeepAliveId { get; set; }

        public ValidationResult? ValidationResult { get; set; }

        public bool IsValid { get; set; } = true;
    }
}
