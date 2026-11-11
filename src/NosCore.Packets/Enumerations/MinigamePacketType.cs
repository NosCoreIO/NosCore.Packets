//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum MinigamePacketType : byte
    {
        Play = 1,
        BroadcastEffect = 2,
        ShowBoxLevels = 3,
        SelectGift = 4,
        ShowManagement = 5,
        Refill = 6,
        ShowGifts = 7,
        OpenGiftBatch = 8,
        UseCoupon = 9
    }
}
