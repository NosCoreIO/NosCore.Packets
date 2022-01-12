//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("sayi2", Scope.InGame)]
    public class Sayi2Packet : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public SayColorType Type { get; set; }

        [PacketIndex(3)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(4)]
        public byte ArgumentType { get; set; }

        [PacketIndex(5)]
        public Game18NArguments Game18NArguments { get; set; } = new(1);
    }
}
