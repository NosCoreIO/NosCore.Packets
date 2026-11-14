//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Miniland
{
    [PacketHeader("mledit", Scope.InGame)]
    public class MLEditPacket : PacketBase
    {
        [PacketIndex(0)]
        public MinilandEditType Type { get; set; }

        // What follows the kind of change, to the end of the line: the new state, or the introduction with its spaces.
        [PacketIndex(1, IsOptional = true)]
        public string? Value { get; set; }

        public MinilandState? State =>
            Type == MinilandEditType.State && byte.TryParse(Value, out var state) && Enum.IsDefined((MinilandState)state)
                ? (MinilandState)state
                : null;

        public string? Introduction => Type == MinilandEditType.Intro ? Value : null;
    }
}
