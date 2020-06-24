//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets
{
    public abstract class PacketBase : IPacket
    {
        public string? Header { get; set; }

        public ushort? KeepAliveId { get; set; }

        public ValidationResult? ValidationResult { get; set; }

        public bool IsValid { get; set; } = true;
    }
}