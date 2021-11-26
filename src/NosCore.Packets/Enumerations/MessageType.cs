//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum MessageType : byte
    {
        Default = 0,
        Notification = 1,
        Shout = 2,
        Center = 3,
        Hero = 4,
        DefaultAndNotification
    }
}