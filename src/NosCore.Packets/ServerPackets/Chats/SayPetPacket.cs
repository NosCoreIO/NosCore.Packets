﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("say_p", Scope.InGame)]
    public class SayPetPacket : PacketBase
    {
        [PacketIndex(0)]
        public long PetId { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}