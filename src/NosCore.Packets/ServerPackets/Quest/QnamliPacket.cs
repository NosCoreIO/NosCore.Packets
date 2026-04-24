//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    /// <summary>
    /// Server-side quest name list entry. Shape observed on the wire:
    /// <c>qnamli &lt;questId&gt; #&lt;localizedRef&gt; &lt;targetId&gt; &lt;value1&gt; &lt;value2&gt; &lt;value3&gt;</c>
    /// e.g. <c>qnamli 9 #guri^518 2308 0 0 0</c>.
    /// </summary>
    [PacketHeader("qnamli", Scope.InGame)]
    public class QnamliPacket : PacketBase
    {
        [PacketIndex(0)]
        public int QuestId { get; set; }

        [PacketIndex(1, RemoveHash = true)]
        public string? Guri { get; set; }

        [PacketIndex(2)]
        public int TargetId { get; set; }

        [PacketIndex(3)]
        public int Value1 { get; set; }

        [PacketIndex(4)]
        public int Value2 { get; set; }

        [PacketIndex(5)]
        public int Value3 { get; set; }
    }
}
