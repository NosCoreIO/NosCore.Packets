using System;

namespace NosCore.Packets.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Game18NArgumentsAttribute : Attribute
    {
        public Game18NArgumentsAttribute(params Type[] argumentTypes)
        {
            ArgumentTypes = argumentTypes;
        }

        public Type[] ArgumentTypes { get; set; }
    }
}
