﻿using System;
using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Login
{
    /// <summary>
    /// Thanks to https://github.com/morsisko/NosTale-Auth
    ///  That's how it looks like:
    /// "NoS0577 " + SESSION_GUID + " " + username + " " + INSTALLATION_GUID +
    /// " 003662BF" + char(0xB) + "0.9.3.3103" + " 0 " +
    /// MD5_STR(MD5_FILE("NostaleClientX.exe") + MD5_FILE("NostaleClient.exe"))
    /// 
    /// NoS0577 - The header of the packet, const value
    /// SESSION_GUID - Value generated by this library
    /// USERNAME - Your account username
    /// INSTALLATION_GUID - Id that is generated during installation, for login purpuroses it probably may be random, stored in the windows registry under key name InstallationId in SOFTWARE\\WOW6432Node\\Gameforge4d\\TNTClient\\MainApp
    /// 003662BF - Random value converted to HEX
    /// char(0xB) - Single character with ASCII code 0xB
    /// 0.9.3.3103 - Current version of client, may be obtained from the NostaleClientX.exe file version
    /// 0 - const value
    /// MD5_STR(MD5_FILE("NostaleClientX.exe") + MD5_FILE("NostaleClient.exe")) - MD5 generated from concatenation of MD5 strings of NostaleClientX.exe and NostaleClient.exe
    /// 
    /// </summary>
    [PacketHeader("NoS0577", AnonymousAccess = true)]
    public class NoS0577Packet : PacketBase
    {
        [PacketIndex(0)]
        public string AuthToken { get; set; }

        [PacketIndex(1)]
        public string Username { get; set; }

        [PacketIndex(2)]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Seems to always be 003662BF (random value converted to HEX)
        /// Would be better if we could provide some kind of HEX serialization instead of using string
        /// it may be the update version number
        /// </summary>
        [PacketIndex(3)]
        public string UnknownYet { get; set; }
 
        /// <summary>
        /// May be obtained from the NostaleClientX.exe version
        /// </summary>
        [PacketIndex(4, SpecialSeparator = ".")]
        public ClientVersionSubPacket ClientVersion { get; set; }

        [PacketIndex(5)]
        [Range(0,0)]
        public byte UnknownConstant { get; set; }

        /// <summary>
        /// The MD5 string is a MD5 hashing : MD5_STRING(MD5_FILE(NostaleXClient.exe) + MD5_FILE(NostaleClient.exe))
        /// </summary>
        [PacketIndex(6)]
        public string Md5String { get; set; }
    }
}
