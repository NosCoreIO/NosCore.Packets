using System;

namespace ChickenAPI.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
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
    }
}