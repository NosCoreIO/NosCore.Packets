using System.Collections.Generic;
using System.Linq;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    [PacketHeader("sqst", Scope.InGame)]
    public class SqstPacket : PacketBase
    {
        public const int QuestsPerBlock = 1500;
        private const int QuestsPerChar = 6;
        private const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz{}";

        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public string? Bitmap { get; set; }

        public static byte BlockOf(int questId) => (byte)(questId / QuestsPerBlock);

        // Each character carries six quests; the block's first quest of the six is the top bit.
        public static SqstPacket FromCompletedQuests(byte block, IEnumerable<int> completedQuestIds)
        {
            var flags = new int[QuestsPerBlock / QuestsPerChar];
            foreach (var offset in completedQuestIds.Where(id => id / QuestsPerBlock == block).Select(id => id % QuestsPerBlock))
            {
                var position = offset % QuestsPerChar;
                flags[offset / QuestsPerChar] |= position == 0 ? 0x20 : 1 << (position - 1);
            }

            return new SqstPacket
            {
                Type = block,
                Bitmap = new string(flags.Select(flag => Digits[flag]).ToArray())
            };
        }
    }
}
