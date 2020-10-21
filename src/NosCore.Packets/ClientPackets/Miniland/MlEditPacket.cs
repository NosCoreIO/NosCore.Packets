//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Miniland
{
    [PacketHeader("mledit", Scope.InGame)]
    public class MLEditPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public MinilandState? Parameter { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public string? MinilandInfo { get; set; }
    }
}
