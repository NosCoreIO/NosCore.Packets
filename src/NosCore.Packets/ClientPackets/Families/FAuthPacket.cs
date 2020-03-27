﻿using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("fauth")]
    public class FAuthPacket : PacketBase
    {
        [PacketIndex(0)]
        public FamilyAuthority MemberType { get; set; }

        [PacketIndex(1)]
        public byte AuthorityId { get; set; }

        [PacketIndex(2)]
        public byte Value { get; set; }
    }
}