//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Map
{  
    [PacketHeader("eff_g", Scope.InGame)]
    public class GroundEffectPacket : PacketBase
    {
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public ushort Effect { get; set; }

        [PacketIndex(2)]
        public string? XYCoordinates { get; set; }

        [PacketIndex(3)]
        public ushort MapX { get; set; }

        [PacketIndex(4)]
        public ushort MapY { get; set; }

        [PacketIndex(5)]
        public bool IsRemoval { get; set; }
    }
}
