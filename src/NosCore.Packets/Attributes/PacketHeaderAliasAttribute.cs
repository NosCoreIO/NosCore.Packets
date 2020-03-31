using System;

namespace NosCore.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PacketHeaderAliasAttribute : Attribute
    {
        public PacketHeaderAliasAttribute(string identification)
        {
            Identification = identification;
        }

        public string Identification { get; set; }

        /// <summary>
        ///     anything that can be used to filter alias
        /// </summary>
        public string? Flag { get; set; }
    }
}