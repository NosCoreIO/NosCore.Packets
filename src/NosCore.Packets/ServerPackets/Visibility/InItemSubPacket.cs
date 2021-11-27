//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class InItemSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Amount { get; set; }

        [PacketIndex(1)]
        public bool IsQuestRelative { get; set; }

        [PacketIndex(2)]
        public long Owner { get; set; }

        [PacketIndex(3)]
        public byte Unknown { get; set; }
    }
}