//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum ModalPacketType
    {
        Default = 1
    }

    public enum MsgPacketType
    {
        Whisper = 0,
        PrivateChat = 1,
        Shout = 2,
        White = 3,
        FamilyChat = 4
    }
}