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
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Login
{
    [PacketHeader("NoS0575", Scope.OnLoginScreen)]
    public class NoS0575Packet : PacketBase
    {
        [PacketIndex(0)]
        public int SessionId { get; set; }

        [PacketIndex(1)]
        public string? Username { get; set; }

        [PacketIndex(2)]
        public string? Password { get; set; }

        [PacketIndex(3)]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Seems to always be 00564F36 (random value converted to HEX)
        /// Would be better if we could provide some kind of HEX serialization instead of using string
        /// it may be the update version number
        /// </summary>
        [PacketIndex(4)]
        public string? UnknownYet { get; set; }

        [PacketIndex(5, SpecialSeparator = "")]
        public RegionType RegionType { get; set; }

        [PacketIndex(6)]
        public ClientVersionSubPacket? ClientVersion { get; set; }

        [PacketIndex(7)]
        public byte Unknown2 { get; set; }
        /// <summary>
        /// The MD5 string is a MD5 hashing : MD5_STRING(MD5_FILE(NostaleXClient.exe) + MD5_FILE(NostaleClient.exe))
        /// </summary>
        [PacketIndex(8)]
        public string? Md5String { get; set; }
    }
}