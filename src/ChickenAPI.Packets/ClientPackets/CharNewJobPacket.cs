using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets
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