using System;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Login
{
    [PacketHeader("NoS0575", AnonymousAccess = true)]
    public class NoS0575Packet : PacketBase
    {
        [PacketIndex(0)]
        public int Number { get; set; }

        [PacketIndex(1)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public string Password { get; set; }

        [PacketIndex(3)]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Seems to always be 00564F36 (random value converted to HEX)
        /// Would be better if we could provide some kind of HEX serialization instead of using string
        /// </summary>
        [PacketIndex(3)]
        public string UnknownYet { get; set; } = "00564F36";

        [PacketIndex(4, SpecialSeparator = "")]
        public char UnknownProperty { get; set; } = (char)11;

        [PacketIndex(5, SpecialSeparator = ".")]
        public ClientVersionSubPacket ClientVersion { get; set; }

        [PacketIndex(6)]
        public byte UnknownConstant { get; set; } = 0;

        /// <summary>
        /// The MD5 string is a MD5 hashing : MD5_STRING(MD5_FILE(NostaleXClient.exe) + MD5_FILE(NostaleClient.exe))
        /// </summary>
        [PacketIndex(7)]
        public string Md5String { get; set; }
    }
}