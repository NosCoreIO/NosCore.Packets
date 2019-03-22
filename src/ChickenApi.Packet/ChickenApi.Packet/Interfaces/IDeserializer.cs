using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenApi.Packet.Interfaces
{
    public interface IDeserializer
    {
        IPacket Deserialize(string packet);

        IEnumerable<IPacket> DeserializePackets(string packets);
    }
}
