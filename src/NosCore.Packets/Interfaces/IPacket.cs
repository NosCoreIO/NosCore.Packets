//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

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