using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("say_p")]
    public class SayPetPacket : PacketBase
    {
        [PacketIndex(0)]
        public long PetId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}