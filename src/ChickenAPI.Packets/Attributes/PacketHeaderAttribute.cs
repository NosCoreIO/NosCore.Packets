using System;

namespace ChickenApi.Packet.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class PacketHeaderAttribute : Attribute
    {
        public PacketHeaderAttribute(string identification)
        {
            Identification = identification;
        }

        public PacketHeaderAttribute(string identification, byte amount)
        {
            Identification = identification;
            Amount = amount;
        }

        /// <summary>
        ///     Unique identification of the Packet
        /// </summary>
        public string Identification { get; set; }

        /// <summary>
        ///     Amount of tcp message to create the Packet
        /// </summary>
        public byte Amount { get; set; }

        public bool AnonymousAccess { get; set; }
    }
}