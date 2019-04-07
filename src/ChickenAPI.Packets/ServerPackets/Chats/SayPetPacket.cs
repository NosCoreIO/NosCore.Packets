using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("say_p")]
    public class SayPetPacket : IPacket
    {
        [PacketIndex(0)]
        public long PetId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}