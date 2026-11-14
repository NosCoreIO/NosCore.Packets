//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // One faction's side of the fc HUD. The four raid flags name the Act 4 raid that is open.
    public class FcSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Percentage { get; set; }

        [PacketIndex(1)]
        public Act4WarMode Mode { get; set; }

        [PacketIndex(2)]
        public short SecondsLeft { get; set; }

        [PacketIndex(3)]
        public short TotalSeconds { get; set; }

        [PacketIndex(4)]
        public bool IsMorcos { get; set; }

        [PacketIndex(5)]
        public bool IsHatus { get; set; }

        [PacketIndex(6)]
        public bool IsCalvina { get; set; }

        [PacketIndex(7)]
        public bool IsBerios { get; set; }

        [PacketIndex(8)]
        public byte Unknown { get; set; }
    }
}
