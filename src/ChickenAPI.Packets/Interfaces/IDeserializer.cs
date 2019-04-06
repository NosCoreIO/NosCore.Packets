using System.Collections.Generic;

namespace ChickenAPI.Packets.Interfaces
{
    public interface IDeserializer
    {
        IPacket Deserialize(string packet, bool includesKeepAliveIdentity);
    }
}
