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
    }
}