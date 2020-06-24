//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Relations
{
    [PacketHeader("blins")]
    public class BlInsPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}