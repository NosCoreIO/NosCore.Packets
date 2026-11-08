//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Attributes
{
    /// <summary>
    ///     The shortest time a client leaves between two packets of this type. One arriving sooner
    ///     is dropped.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MinimumIntervalAttribute : Attribute
    {
        public int Milliseconds { get; set; }

        public TimeSpan Interval => TimeSpan.FromMilliseconds(Milliseconds);
    }
}
