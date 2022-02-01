//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("taw", Scope.InGame)]
    public class TawPacket : PacketBase
    {
        public TawPacket(string username)
        {
            Username = username;
        }

        [PacketIndex(0)]
        public string Username { get; set; }
    }
}
