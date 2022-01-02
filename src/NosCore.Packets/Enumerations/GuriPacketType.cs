//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum GuriPacketType
    {
        Shadow = 0,
        Dance = 2,
        Script = 3,
        HPMPBonus = 4,
        DanceAnimationPercent = 5,
        CharacterAnimation = 6,
        FreezeTimer = 8,
        TextInput = 10,
        CancelTarget = 11,
        Unknow4 = 15,
        PerfumAndIdentification = 18,
        AfterSumming = 19,
        AddMountInPearl = 24,
        AddFairyInPearl = 26,
        TattooInfo = 40,
        FlipCamera = 41,
        FriendshipWings = 199,
        PetBasket = 201,
        PartnerBackpack = 202,
        SpPointInitializer = 203,
        UseBoxItem = 300,
        Title = 306,
        CollectItem = 400,
        IceBreaker = 501,
        IceBreakerFrozen = 502,
        StartRbbCountdown = 503,
        TeleportToRbbBase = 504,
        EventInWaiting = 506, 
        RemoveLaurenaMorph = 513,
        Wedding = 603,
        SearchHiddenTimeSpace = 700,
        MapTeleporter = 710,
        TeleportOnOtherMapTp = 711,
        AddFlagToRbbTeam = 720,
        FactionEgg = 750,
        ActVRelic = 1502,
    }
}