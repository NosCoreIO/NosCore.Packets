//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    // Opens the time-space room map drawn from the rsfn rooms sent before it.
    [PacketHeader("rsfm", Scope.InGame)]
    public class RsfmPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketIndex(1)]
        public RsfmPacketType Type { get; set; }

        // The client only checks that both are positive; traces always carry 4 and 12.
        [PacketIndex(2)]
        public short Unknown1 { get; set; } = 4;

        [PacketIndex(3)]
        public short Unknown2 { get; set; } = 12;
    }
}
