using System;

namespace NosCore.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PacketHeaderAttribute : Attribute
    {
        public PacketHeaderAttribute(string identification)
        {
            Identification = identification;
        }

        /// <summary>
        ///     Unique identification of the Packet
        /// </summary>
        public string Identification { get; set; }

        public bool AnonymousAccess { get; set; }

        public bool BlockedByTrading { get; set; }
    }
}