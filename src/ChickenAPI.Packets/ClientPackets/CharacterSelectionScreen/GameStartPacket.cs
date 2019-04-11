using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("game_start")]
    public class GameStartPacket : PacketBase
    {
    }
}