//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    // Follows the character's own c_mode on entering a map while a specialist is worn, with the
    // specialist's morph even when c_mode shows another one.
    [PacketHeader("s_mode", Scope.InGame)]
    public class SModePacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short SpecialistMorph { get; set; }

        [PacketIndex(3)]
        public byte Unknown3 { get; set; }
    }
}
