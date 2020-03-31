using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.CharacterSelectionScreen
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