using System.ComponentModel.DataAnnotations;

namespace ChickenAPI.Packets.Interfaces
{
    public interface IPacket
    {
        string? Header { get; set; }
        ushort? KeepAliveId { get; set; }
        ValidationResult? ValidationResult { get; set; }
        bool IsValid { get; set; }
    }
}