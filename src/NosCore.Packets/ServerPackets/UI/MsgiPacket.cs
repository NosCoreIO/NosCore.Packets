//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("msgi", Scope.InGame)]
    public class MsgiPacket : PacketBase
    {
        [PacketIndex(0)]
        public MessageType Type { get; set; }

        [PacketIndex(1)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(2)]
        public byte ArgumentType { get; set; }
        
        [PacketIndex(3)]
        public object[] Game18NArguments { get; set; } = Array.Empty<object>();
    }
}