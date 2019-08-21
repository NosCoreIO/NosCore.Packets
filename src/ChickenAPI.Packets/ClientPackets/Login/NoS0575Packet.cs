using System;
using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Login
{
    [PacketHeader("NoS0575", AnonymousAccess = true)]
    public class NoS0575Packet : PacketBase
    {
        [PacketIndex(0)]
        public int SessionId { get; set; }

        [PacketIndex(1)]
        public string Username { get; set; }

        [PacketIndex(2)]
        public string Password { get; set; }

        [PacketIndex(3)]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Seems to always be 00564F36 (random value converted to HEX)
        /// Would be better if we could provide some kind of HEX serialization instead of using string
        /// it may be the update version number
        /// </summary>
        [PacketIndex(3)]
        public string UnknownYet { get; set; }

        [PacketIndex(4)]
        public ClientVersionSubPacket ClientVersion { get; set; }

        [PacketIndex(5)]
        [Range(0, 0)]
        public byte UnknownConstant { get; set; }

        /// <summary>
        /// The MD5 string is a MD5 hashing : MD5_STRING(MD5_FILE(NostaleXClient.exe) + MD5_FILE(NostaleClient.exe))
        /// </summary>
        [PacketIndex(6)]
        public string Md5String { get; set; }
    }
}