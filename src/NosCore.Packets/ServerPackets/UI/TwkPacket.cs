using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("twk", Scope.InGame)]
    public class TwkPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)] 
        [Required]
        public string AccountName { get; set; } = null!;

        [PacketIndex(3)]
        [Required]
        public string Salt { get; set; } = "shtmxpdlfeoqkr";

        [PacketIndex(4)]
        public RegionType ServerLanguage { get; set; }

        [PacketIndex(5)]
        public RegionType ClientLanguage { get; set; }
    }
}
