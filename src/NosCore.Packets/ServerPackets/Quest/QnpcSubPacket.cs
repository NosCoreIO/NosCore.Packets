//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Quest
{
    // Ten of them per line; an unused one is -1|-1|-1.
    public class QnpcSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Unknown0 { get; set; } = -1;

        [PacketIndex(1)]
        public short Unknown1 { get; set; } = -1;

        [PacketIndex(2)]
        public short Unknown2 { get; set; } = -1;
    }
}
