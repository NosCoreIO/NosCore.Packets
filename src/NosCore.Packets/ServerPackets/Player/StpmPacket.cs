using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("stpm", Scope.InGame)]
    public class StpmPacket : PacketBase
    {
        [PacketIndex(0)] public byte Mastery0 { get; set; }
        [PacketIndex(1)] public byte Mastery1 { get; set; }
        [PacketIndex(2)] public byte Mastery2 { get; set; }
        [PacketIndex(3)] public byte Mastery3 { get; set; }
        [PacketIndex(4)] public byte Mastery4 { get; set; }
        [PacketIndex(5)] public byte Mastery5 { get; set; }
        [PacketIndex(6)] public byte Mastery6 { get; set; }
        [PacketIndex(7)] public byte Mastery7 { get; set; }
        [PacketIndex(8)] public byte Mastery8 { get; set; }
        [PacketIndex(9)] public byte Mastery9 { get; set; }
        [PacketIndex(10)] public byte Mastery10 { get; set; }
        [PacketIndex(11)] public byte Mastery11 { get; set; }
        [PacketIndex(12)] public byte Mastery12 { get; set; }
        [PacketIndex(13)] public byte Mastery13 { get; set; }
        [PacketIndex(14)] public byte Mastery14 { get; set; }
        [PacketIndex(15)] public byte Mastery15 { get; set; }
        [PacketIndex(16)] public byte Mastery16 { get; set; }
        [PacketIndex(17)] public byte Mastery17 { get; set; }
        [PacketIndex(18)] public byte Mastery18 { get; set; }
        [PacketIndex(19)] public byte Mastery19 { get; set; }
    }
}
