using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    /// <summary>
    /// Observed on the wire as <c>fish &lt;type&gt; &lt;100 slots&gt; &lt;count&gt; &lt;extra&gt;</c>
    /// where each slot is a <c>.</c>-separated triplet (<c>&lt;slot&gt;.&lt;unk&gt;.&lt;unk&gt;</c>).
    /// The exact meaning of the slot fields and the trailing extras hasn't been
    /// reverse-engineered; the rest of the line is captured as a single string
    /// so the packet round-trips without crashing.
    /// </summary>
    [PacketHeader("fish", Scope.InGame)]
    public class FishPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public string? Body { get; set; }
    }
}
