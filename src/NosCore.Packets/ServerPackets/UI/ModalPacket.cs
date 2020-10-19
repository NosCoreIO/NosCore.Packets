//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("modal")]
    public class ModalPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; } //TODO: find modal types

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}