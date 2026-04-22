using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("pet_cool2", Scope.InGame)]
    public class PetCool2Packet : PacketBase
    {
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public int Cooldown1 { get; set; }

        [PacketIndex(2)]
        public int Cooldown2 { get; set; }

        [PacketIndex(3)]
        public int Cooldown3 { get; set; }
    }
}
