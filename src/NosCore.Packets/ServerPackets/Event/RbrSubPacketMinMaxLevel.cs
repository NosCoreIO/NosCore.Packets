//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Event
{
    public class RbrSubPacketMinMaxLevel : PacketBase
    {
        [PacketIndex(0)]
        public byte MinLevel { get; set; }

        [PacketIndex(1)]
        public byte MaxLevel { get; set; }
    }
}