using ChickenApi.Packet.Attributes;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("Char_NEW_JOB", AnonymousAccess = true)]
    public class CharNewJobPacket : CharNewPacket
    {
        public CharNewJobPacket()
        {
            IsMartialArtist = true;
        }
    }
}