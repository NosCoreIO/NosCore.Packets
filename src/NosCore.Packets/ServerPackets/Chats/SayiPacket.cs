//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("sayi", Scope.InGame)]
    public class SayiPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        // A line without a sender leaves an empty field after the id.
        [PacketIndex(2, IsOptional = true)]
        [PacketPresentWhen(nameof(VisualId), -1L)]
        public string? ExtraSpace => VisualId == -1 ? string.Empty : null;

        [PacketIndex(3)]
        public SayColorType Type { get; set; }

        [PacketIndex(4)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(5)]
        public byte ArgumentType { get; set; }

        [PacketIndex(6)]
        public Game18NArguments Game18NArguments { get; set; } = new (4);
    }
}