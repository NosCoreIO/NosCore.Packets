using System.Collections.Generic;

namespace NosCore.Packets.Interfaces
{
    public interface ISerializer
    {
        string Serialize(IPacket packet);

        string Serialize(IEnumerable<IPacket> packet);

        void Initialize<T>() where T : PacketBase;
    }
}
