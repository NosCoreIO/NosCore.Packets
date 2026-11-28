//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Quest
{
    // Ten of them per line; an unused one has every field absent.
    public class QnpcSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short? Unknown0 { get; set; }

        [PacketIndex(1)]
        public short? Unknown1 { get; set; }

        [PacketIndex(2)]
        public short? Unknown2 { get; set; }
    }
}
