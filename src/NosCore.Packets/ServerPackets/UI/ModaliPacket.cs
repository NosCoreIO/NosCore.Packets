//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("modali", Scope.InGame)]
    public class ModaliPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } //TODO: find modal types

        [PacketIndex(1)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(2)]
        public byte ArgumentType { get; set; }
        
        [PacketIndex(3)]
        public object[] Game18NArguments { get; set; } = Array.Empty<object>();
    }
}