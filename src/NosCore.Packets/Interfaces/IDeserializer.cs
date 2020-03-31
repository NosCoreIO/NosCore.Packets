namespace NosCore.Packets.Interfaces
{
    public interface IDeserializer
    {
        IPacket Deserialize(string packet);
    }
}