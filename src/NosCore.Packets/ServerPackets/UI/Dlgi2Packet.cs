﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Chats;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("dlgi2", Scope.InGame)]
    public class Dlgi2Packet : PacketBase
    {
        [PacketIndex(0)]
        public IPacket? YesPacket { get; set; }

        [PacketIndex(1)]
        public IPacket? NoPacket { get; set; }

        [PacketIndex(2)]
        public Game18NConstString Question { get; set; }

        [PacketIndex(3)]
        public byte ArgumentType { get; set; }

        [Required]
        [PacketIndex(4)]
        public Game18NArguments Game18NArguments { get; set; } = new(4);
    }
}