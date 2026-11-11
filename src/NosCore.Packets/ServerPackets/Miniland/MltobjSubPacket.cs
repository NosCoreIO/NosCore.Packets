//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    public class MltobjSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short VNum { get; set; }

        // The object's slot in the miniland pocket, as in mlobjlst.
        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public short MapX { get; set; }

        [PacketIndex(3)]
        public short MapY { get; set; }
    }
}
