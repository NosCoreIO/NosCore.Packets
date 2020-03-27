using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.Interfaces
{
    public interface IPacket
    {
        string? Header { get; set; }
        ushort? KeepAliveId { get; set; }
        ValidationResult? ValidationResult { get; set; }
        bool IsValid { get; set; }
    }
}