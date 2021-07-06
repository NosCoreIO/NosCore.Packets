using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("sreq", Scope.InGame)]
    public class SreqPacket : PacketBase
    {
        public short Argument { get; set; } // TODO : Find it
    }
}
