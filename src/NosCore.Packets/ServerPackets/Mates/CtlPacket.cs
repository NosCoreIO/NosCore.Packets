using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("ctl", Scope.InGame)]
    public class CtlPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public long PetId { get; set; }

        [PacketIndex(2)]
        public byte Action { get; set; }

        [PacketIndex(3)]
        public byte Unknown { get; set; } //TODO to find
    }
}
