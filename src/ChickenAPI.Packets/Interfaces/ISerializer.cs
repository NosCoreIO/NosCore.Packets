using System.Collections.Generic;

namespace ChickenAPI.Packets.Interfaces
{
    public interface ISerializer
    {
        string Serialize(IPacket packet);

        string Serialize(IEnumerable<IPacket> packet);

        void Initialize<T>() where T : IPacket;
    }
}
