//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    // The kind of battle a search window (bsinfo) belongs to; its Cancel button sends it back in bsc.
    public enum BscPacketType : byte
    {
        SheepFarm = 1,
        TalentArena = 2,
        DodgeMeteor = 4,
        ArenaOfMasters = 6,
        RainbowBattle = 7,
        BushiKingDefence = 99
    }
}
