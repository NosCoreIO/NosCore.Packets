//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Enumerations
{
    public enum GuriPacketType
    {
        Shadow = 0,
        Dance = 2,
        [Obsolete("Use ForcedMove.")]
        Script = 3,
        ForcedMove = 3,
        HPMPBonus = 4,
        // What the client sends back from a TextInput window; Argument repeats the window's.
        TextInputReply = 4,
        DanceAnimationPercent = 5,
        CharacterAnimation = 6,
        FreezeTimer = 8,
        TextInput = 10,
        CancelTarget = 11,
        Unknow4 = 15,
        // A pet that could not pick an item up because the inventory is full.
        MatePickUpRefused = 16,
        PerfumAndIdentification = 18,
        AfterSumming = 19,
        AddMountInPearl = 24,
        CloseMountPearlWindow = 25,
        AddFairyInPearl = 26,
        CloseFairyPearlWindow = 27,
        // An Onyx Dragon appearing beside EntityId; Value and SecondValue are its cell.
        OnyxDragon = 31,
        TattooInfo = 40,
        FlipCamera = 41,
        FriendshipWings = 199,
        PetBasket = 201,
        PartnerBackpack = 202,
        SpPointInitializer = 203,
        ShellIdentification = 204,
        Perfume = 205,
        // The client's confirmation after AddMountInPearl/AddFairyInPearl:
        // `guri 208 0 <pearl slot> <pocket> <item slot>`.
        StoreMountInPearl = 208,
        StoreFairyInPearl = 209,
        UseBoxItem = 300,
        Title = 306,
        CollectItem = 400,
        IceBreaker = 501,
        IceBreakerFrozen = 502,
        [Obsolete("Use RainbowBattleRegistration.")]
        StartRbbCountdown = 503,
        [Obsolete("Use RainbowBattleCapture.")]
        TeleportToRbbBase = 504,
        RainbowBattleRegistration = 503,
        RainbowBattleCapture = 504,
        RainbowBattleUnfreeze = 505,
        EventInWaiting = 506, 
        // Sent with no arguments when the player opens the Instant Combat question from its notification
        // icon; the answer itself is the question's yes packet.
        InstantCombatQuestionOpened = 508,
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