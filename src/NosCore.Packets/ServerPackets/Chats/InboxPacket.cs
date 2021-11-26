﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("inbox", Scope.InGame)]
    public class InboxPacket : PacketBase
    {
        [PacketIndex(0)]
        [Required]
        public IPacket BoxPacket { get; set; } = null!;
    }
}