//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.Attributes
{
    /// <summary>
    ///     Refuses the packet while its sender is in any of <see cref="States" />. One attribute
    ///     per reply: a state that answers with its own message gets its own attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class RefusedWhileAttribute : Attribute
    {
        public RefusedWhileAttribute(SenderState states)
        {
            States = states;
        }

        public RefusedWhileAttribute(SenderState states, Game18NConstString message)
        {
            States = states;
            Message = message;
        }

        public SenderState States { get; }

        /// <summary>
        ///     The line the client is sent in a <c>msgi</c> when the packet is refused; none when null.
        /// </summary>
        public Game18NConstString? Message { get; }
    }
}
