//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.CharacterSelectionScreen
{
    [PacketHeader("scene")]
    public class ScenePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte SceneId { get; set; }
    }
}