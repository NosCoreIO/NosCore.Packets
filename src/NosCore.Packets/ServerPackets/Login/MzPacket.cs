//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("mz")]
    public class MzPacket : PacketBase
    {
        [PacketIndex(0)]
        public string Ip { get; set; } = null!;

        [PacketIndex(1)]
        public short Port { get; set; }

        [PacketIndex(2)]
        public byte CharacterSlot { get; set; }
    }
}