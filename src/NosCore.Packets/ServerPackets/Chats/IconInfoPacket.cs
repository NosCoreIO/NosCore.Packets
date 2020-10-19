//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("IconInfo")]
    public class IconInfoPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public short IconId { get; set; }
    }
}