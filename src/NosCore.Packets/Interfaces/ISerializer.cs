//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

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