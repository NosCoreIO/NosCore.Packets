﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("sayitemt")]
    public class SayItemtPacket : PacketBase, IWorldPacket
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

        [PacketIndex(4)]
        public string? VisualName { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public string? Argument { get; set; } = "{%s}";

        [PacketIndex(4, IsOptional = true, RemoveHash = true)]
        public IconInfoPacket? IconInfo { get; set; }

        [PacketIndex(5, IsOptional = true, RemoveHash = true)]
        public EInfoPacket? EquipmentInfo { get; set; }

        [PacketIndex(6, IsOptional = true, RemoveHash = true)]
        public SlInfoPacket? SlInfo { get; set; }

    }
}