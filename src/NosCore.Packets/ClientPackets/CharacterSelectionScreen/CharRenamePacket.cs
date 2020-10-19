﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("Char_REN", AnonymousAccess = true)]
    public class CharRenamePacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        [Range(0, 3)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        [StringLength(15, MinimumLength = 3)]
        public string? Name { get; set; }
    }
}