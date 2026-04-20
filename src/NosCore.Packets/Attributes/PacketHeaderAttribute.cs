//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PacketHeaderAttribute : Attribute
    {
        public PacketHeaderAttribute(string identification, Scope scopes)
        {
            Identification = identification;
            Scopes = scopes;
        }

        /// <summary>
        ///     Unique identification of the Packet
        /// </summary>
        public string Identification { get; set; }

        public Scope Scopes { get; set; }

        /// <summary>
        ///     Set true when the wire-level header is legitimately shared with another
        ///     packet class that distinguishes itself by a leading discriminator field
        ///     (e.g. e_info subtype 0-5/8 for items vs subtype 10 for NPC/mate in OpenNos).
        ///     Only meaningful for server-only packets — client packets still need a
        ///     1:1 header mapping because the parser looks up the class by header alone.
        /// </summary>
        public bool AllowDuplicateHeader { get; set; }
    }
}