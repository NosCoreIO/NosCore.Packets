//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    /// <summary>
    /// Server-side timespace progression packet, observed as e.g.
    /// <c>rsfi 3 3 0 1 0 1</c>. Mirrors the client-side
    /// <see cref="NosCore.Packets.ClientPackets.Player.RsfiPacket"/>.
    /// </summary>
    [PacketHeader("rsfi", Scope.InGame)]
    public class RsfiPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Act { get; set; }

        [PacketIndex(1)]
        public byte ActPart { get; set; }

        [PacketIndex(2)]
        public byte Unknown1 { get; set; }

        [PacketIndex(3)]
        public byte Unknown2 { get; set; }

        [PacketIndex(4)]
        public byte Ts { get; set; }

        [PacketIndex(5)]
        public byte TsMax { get; set; }
    }
}
