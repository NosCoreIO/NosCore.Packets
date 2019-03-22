using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenApi.Packet.Interfaces
{
    public interface ISerializer
    {
        string Serialize(IPacket packet);

        string Serialize(IEnumerable<IPacket> packet);

        void Initialize<T>() where T : IPacket;
    }
}
