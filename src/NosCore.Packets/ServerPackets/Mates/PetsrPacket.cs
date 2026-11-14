using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("petsr", Scope.InGame)]
    public class PetsrPacket : PacketBase
    {
        // The slot of the pet's skill bar that is ready again; -1 for all of them.
        [PacketIndex(0)]
        public short Slot { get; set; }
    }
}
