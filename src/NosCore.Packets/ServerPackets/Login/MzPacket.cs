//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("mz", Scope.InGame)]
    public class MzPacket : PacketBase
    {
        public MzPacket(string ip)
        {
            Ip = ip;
        }

        [PacketIndex(0)]
        public string Ip { get; set; }

        [PacketIndex(1)]
        public ushort Port { get; set; }

        [PacketIndex(2)]
        public byte CharacterSlot { get; set; }
    }
}