//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Parcel
{
    [PacketHeader("post", Scope.InGame)]
    public class PostPacket : PacketBase
    {
        [PacketIndex(0)]
        public PostPacketType Type { get; set; }

        [PacketIndex(1)]
        public MailBoxType PostType { get; set; }

        [PacketIndex(2)]
        public short Id { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; }

        [PacketIndex(4)]
        public bool IsOpened { get; set; }

        [PacketIndex(5, IsOptional = true)]
        [PacketPresentWhen(nameof(Type), (byte)5)]
        public PostSubPacket? PostSubPacket { get; set; }

        [PacketIndex(6, IsOptional = true)]
        [PacketPresentWhen(nameof(Type), (byte)1)]
        public string? DateTime { get; set; }

        [PacketIndex(7)]
        public string? SenderName { get; set; }

        [PacketIndex(8)]
        public string? Title { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public string? Message { get; set; }
    }
}