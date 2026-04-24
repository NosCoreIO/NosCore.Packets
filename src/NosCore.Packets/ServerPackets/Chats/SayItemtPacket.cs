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
    /// <summary>
    /// Chat bubble advertising a specific item/character, observed on the wire as:
    /// <c>sayitemt 1 &lt;visualId&gt; &lt;oratorSlot&gt; &lt;type&gt; &lt;messageKey&gt; &lt;visualName&gt; &lt;argument&gt; &lt;subPacket...&gt;</c>
    /// where <c>subPacket</c> is one of <c>IconInfo …</c>, <c>e_info …</c>,
    /// <c>slinfo …</c> or <c>pslinfo …</c>. Because only one sub-packet shape
    /// appears per wire line and the dispatch depends on the header token,
    /// the whole tail is captured as a single raw string — consumers that need
    /// structure should deserialise <see cref="SubPacketRaw"/> separately.
    /// </summary>
    [PacketHeader("sayitemt", Scope.InGame)]
    public class SayItemtPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte OratorSlot { get; set; }

        [PacketIndex(3)]
        public byte Type { get; set; }

        [PacketIndex(4)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(5)]
        public string? VisualName { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public string? Argument { get; set; } = "{%s}";

        [PacketIndex(7, IsOptional = true)]
        public string? SubPacketRaw { get; set; }
    }
}
