//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.Enumerations
{
    public enum Game18NConstString : short
    {
        // <summary>
        // *
        // <summary>
        Undefined = 0,
        // <summary>
        // Hooray!!!
        // <summary>
        Hooray = 1,
        // <summary>
        // I don't have enough Gold.
        // <summary>
        DoNotHaveEnoughGold = 2,
        // <summary>
        // You are mine now!
        // <summary>
        YouAreMine = 3,
        // <summary>
        // You have already acquired this land.
        // <summary>
        LandAlreadyAquired = 4,
        // <summary>
        // Your Miniland has been changed.
        // <summary>
        MinilandChanged = 5,
        // <summary>
        // You cannot change the Miniland because another player is inside.
        // <summary>
        CanNotChangeMinilandVisitor = 6,
        // <summary>
        // You already have this structure.
        // <summary>
        YouAlreadyHaveThisMinilandObject = 7,
        // <summary>
        // You cannot learn that yet.
        // <summary>
        YouCanNotLearnThat = 8,
        // <summary>
        // You have already learnt this skill.
        // <summary>
        YouAlreadyKnowThisSkill = 9,
        // <summary>
        // You don't have enough Gold.
        // <summary>
        NotEnoughGold = 10,
        // <summary>
        // You've already learned a higher level.
        // <summary>
        YouAlreadyKnowABetterSkill = 11,
        // <summary>
        // You don't have enough CP to learn this.
        // <summary>
        NotEnoughCp = 12,
        // <summary>
        // You have to learn the associated base skill.
        // <summary>
        YouNeedBaseSkill = 13,
        // <summary>
        // The remaining items are insufficient.
        // <summary>
        RemainingItemInsuficiant = 14,
        // <summary>
        // That item has already been sold.
        // <summary>
        ItemAlreadySold = 15,
        // <summary>
        // : Purchase <
        // <summary>
        Purchase = 16,
        // <summary>
        // : Pieces >
        // <summary>
        Piece = 17,
        // <summary>
        // Skill has disappeared.
        // <summary>
        SkillDisapeared = 18,
        // <summary>
        // The item has been given.
        // <summary>
        ItemGiven = 19,
        // <summary>
        // You don't have enough Koaren treasure. Find 5 more.
        // <summary>
        NotEnoughKoarenTreasure = 20,
        // <summary>
        // You don't have the Koaren Symbol. Contact the admin.
        // <summary>
        YouDontHaveTheKoarenSymbol = 21,
        // <summary>
        // You have lost the %s effect.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        LostSideEffect = 22,
        // <summary>
        // The side effects of %s have started.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SideEffectStarted = 23,
        // <summary>
        // No effect because of immunity.
        // <summary>
        ImmunitizedAgainstEffect = 24,
        // <summary>
        // Buff lifted: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        BuffLifted = 25,
        // <summary>
        // You are under the effect of %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UnderEffect = 26,
        // <summary>
        // Training is only possible in the Miniland.
        // <summary>
        TrainingOnlyMiniland = 27,
        // <summary>
        // You cannot hear the opponent's cry.
        // <summary>
        CanNotHearOpponentCry = 28,
        // <summary>
        // Huh!!
        // <summary>
        Huh = 29,
        // <summary>
        // Uurk!!!
        // <summary>
        Uurk = 30,
        // <summary>
        // Hic!
        // <summary>
        Hic = 31,
        // <summary>
        // Ah!!
        // <summary>
        Ah = 32,
        // <summary>
        // Hehe...
        // <summary>
        Hehe = 33,
        // <summary>
        // Trade cancelled
        // <summary>
        TradeCancelled = 34,
        // <summary>
        // Adventurer
        // <summary>
        Adventurer = 35,
        // <summary>
        // Swordsman
        // <summary>
        Swordsman = 36,
        // <summary>
        // Archer
        // <summary>
        Archer = 37,
        // <summary>
        // Mage
        // <summary>
        Mage = 38,
        // <summary>
        // Martial Artist
        // <summary>
        MartialArtist = 39,
        // <summary>
        // Knight
        // <summary>
        Knight = 40,
        // <summary>
        // Ranger
        // <summary>
        Ranger = 41,
        // <summary>
        // Assassin
        // <summary>
        Assassin = 42,
        // <summary>
        // Mage
        // <summary>
        Mage2 = 43,
        // <summary>
        // Priest
        // <summary>
        Priest = 44,
        // <summary>
        // You cannot change job at this level.
        // <summary>
        CanNotChangeJobAtThisLevel = 45,
        // <summary>
        // Job transfer requires job level 20 and combat level 15.
        // <summary>
        CanNotChangeJobAtThisJobLevel = 46,
        // <summary>
        // Disband your party before transferring.
        // <summary>
        DisbandYourParty = 47,
        // <summary>
        // Remove your equipment.
        // <summary>
        RemoveEquipment = 48,
        // <summary>
        // Congratulations. Transfer complete.
        // <summary>
        ClassChanged = 49,
        // <summary>
        // I don't have enough Seeds of Power.
        // <summary>
        NotEnoughPowerSeed = 50,
        // <summary>
        // Will be revived in 10 seconds during battle.
        // <summary>
        ReviveInTenSeconds = 51,
        // <summary>
        // Dead: [
        // <summary>
        Dead = 52,
        // <summary>
        // You can be revived %d more times.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        YouCanBeRevivedMoreTime = 53,
        // <summary>
        // Your magic items have expired.
        // <summary>
        MagicItemExpired = 54,
        // <summary>
        // The fairy has full energy.
        // <summary>
        FairyEnergyFull = 55,
        // <summary>
        // The fairy has gained energy.
        // <summary>
        FairyHasGotEnergy = 56,
        // <summary>
        // Pingy feels OK.
        // <summary>
        PingyFeelsOK = 57,
        // <summary>
        // The fairy feels OK.
        // <summary>
        FairyFeelsOK = 58,
        // <summary>
        // Pingy feels good.
        // <summary>
        PingyFeelsGood = 59,
        // <summary>
        // The fairy feels good.
        // <summary>
        FairyFeelsGood = 60,
        // <summary>
        // Pingy feels very good.
        // <summary>
        PingyFeelsVeryGood = 61,
        // <summary>
        // The fairy feels very good.
        // <summary>
        FairyFeelsVeryGood = 62,
        // <summary>
        // Pingy has eaten your food.
        // <summary>
        PingyEatenFood1 = 63,
        // <summary>
        // Pingy has eaten your food.
        // <summary>
        PingyEatenFood2 = 64,
        // <summary>
        // The fairy has eaten your food.
        // <summary>
        FairyEatenFood1 = 65,
        // <summary>
        // The fairy has eaten your food.
        // <summary>
        FairyEatenFood2 = 66,
        // <summary>
        // Pingy feels bad because he is hungry.
        // <summary>
        PingyIsHungry = 67,
        // <summary>
        // Your fairy feels ill because it is hungry.
        // <summary>
        FairyIsHungry = 68,
        // <summary>
        // Difficulty (h+/vh+/h+hp/vh+hp):
        // <summary>
        Difficulty = 69,
        // <summary>
        // You are now invisible.
        // <summary>
        YouAreInvisible = 70,
        // <summary>
        // You are now visible.
        // <summary>
        YouAreVisible = 71,
        // <summary>
        // Connection lost.
        // <summary>
        ConnectionLost1 = 72,
        // <summary>
        // You are logging out.
        // <summary>
        LoggedOut = 73,
        // <summary>
        // Connection lost.
        // <summary>
        ConnectionLost2 = 74,
        // <summary>
        // Your friend is offline.
        // <summary>
        YourFriendIsOffline = 75,
        // <summary>
        // Current punishment for '%s': %d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        CurrentPunishment = 76,
        // <summary>
        // Current '%s' remaining time (mins.): %d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        CurrentRemainingTime = 77,
        // <summary>
        // %s has been punished for %d minutes.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        HasBeenPunished = 78,
        // <summary>
        // %s now has %d criminal records.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        HasCriminalRecord = 79,
        // <summary>
        // Unknown person.
        // <summary>
        UnknownCharacter = 80,
        // <summary>
        // Current experience rate: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CurrentExperienceRate = 81,
        // <summary>
        // Current Time Circle Damage Rate: %d%%<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CurrentTimeCircleDamageRate = 82,
        // <summary>
        // Time remaining:
        // <summary>
        TimeRemaining = 83,
        // <summary>
        // Currently off
        // <summary>
        CurrentlyOff = 84,
        // <summary>
        // Instant Combat feature will be turned off.
        // <summary>
        InstantCombatOff = 85,
        // <summary>
        // Instant Combat feature will be turned on.
        // <summary>
        InstantCombatOn = 86,
        // <summary>
        // Icebreaker feature will be turned off.
        // <summary>
        IceBreakerOff = 87,
        // <summary>
        // Icebreaker feature will be turned on.
        // <summary>
        IceBreakerOn = 88,
        // <summary>
        // Type in between 0 to 4
        // <summary>
        TypeBetweenZeroAndFour = 89,
        // <summary>
        // Administrator
        // <summary>
        Administrator = 90,
        // <summary>
        // I need 5 Seeds of Power.
        // <summary>
        NeedFivePowerSeed = 91,
        // <summary>
        // Do you want to enter the first room?
        // <summary>
        WantEnterFirstRoom = 92,
        // <summary>
        // Cannot move before mission start.
        // <summary>
        CannotMoveBeforeStart = 93,
        // <summary>
        // You will be able to move shortly
        // <summary>
        WillMoveShortly = 94,
        // <summary>
        // The gate is locked!
        // <summary>
        GateLocked = 95,
        // <summary>
        // You still have an incomplete mission.
        // <summary>
        HaveIncompleteMission = 96,
        // <summary>
        // Please wait.
        // <summary>
        PleaseWait = 97,
        // <summary>
        // You can enter after the waiting time.
        // <summary>
        WaitBeforeEnter = 98,
        // <summary>
        // Do you want to join your party members?
        // <summary>
        WantJoinParty = 99,
        // <summary>
        // *** Unavailable: Level %d or higher ***<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        UnavailableForHigherLevel = 100,
        // <summary>
        // *** Lacking Pieces of Reality ***
        // <summary>
        LackingPieceOfReality = 101,
        // <summary>
        // *** Complete the previous Hero Mission first ***
        // <summary>
        IncompletePrevHeroMission = 102,
        // <summary>
        // [General Reward Item with 50 points or more] =>
        // <summary>
        GeneralRewardItem = 103,
        // <summary>
        // [Reward Item with 80 points or more for each difficulty] =>
        // <summary>
        RewardItem = 104,
        // <summary>
        // [No. of Seeds of Power required]:
        // <summary>
        SeedsRequiredNum = 105,
        // <summary>
        // You are not qualified yet.
        // <summary>
        NotQualifiedYet = 106,
        // <summary>
        // You need to break the seal to take on the extra challenging difficulty level!
        // <summary>
        YouNeedToBreakTheSeal = 107,
        // <summary>
        // Oh! I need %d Seeds of Power for the mission.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        SeedsOfPowerNeededForMission = 108,
        // <summary>
        // You cannot enter a mission which has already started.
        // <summary>
        MissionAlreadyStarted = 109,
        // <summary>
        // This mission has already finished.
        // <summary>
        MissionAlreadyFinished = 110,
        // <summary>
        // No player selected.
        // <summary>
        NoPlayerSelected = 111,
        // <summary>
        // You don't have permission to pick that up.
        // <summary>
        UnableToPickUp = 112,
        // <summary>
        // Your inventory is full!
        // <summary>
        FullInventory = 113,
        // <summary>
        // You cannot drop this item.
        // <summary>
        CantDropItem = 114,
        // <summary>
        // You don't have enough Gold.
        // <summary>
        NotEnoughGold5 = 115,
        // <summary>
        // Your inventory is full!
        // <summary>
        FullInventory2 = 116,
        // <summary>
        // Trade successful
        // <summary>
        TradeSuccessfull = 117,
        // <summary>
        // You cannot learn a skill while casting.
        // <summary>
        CanNotLearnSkillWhileCasting = 118,
        // <summary>
        // To learn a new skill, all cooldowns must have reset.
        // <summary>
        CanNotLearnSkillOnCooldown = 119,
        // <summary>
        // You already have a plus skill. Do you want to overwrite it?
        // <summary>
        AlreadyHavePlusSkill = 120,
        // <summary>
        // You've learned a new skill.
        // <summary>
        SkillLearned = 121,
        // <summary>
        // You don't have enough Gold.
        // <summary>
        NotEnoughGold2 = 122,
        // <summary>
        // Please check your inventory.
        // <summary>
        CheckYourInventory = 123,
        // <summary>
        // You cannot sell this item.
        // <summary>
        ItemCanNotBeSold = 124,
        // <summary>
        // Shops can only be opened on general fields.
        // <summary>
        ShopIsNotAllowedInPrivate = 125,
        // <summary>
        // You cannot open a shop here.
        // <summary>
        ShopIsNotAllowedHere = 126,
        // <summary>
        // Please use the commercial map to open a shop.
        // <summary>
        UseCommercialMapToShop = 127,
        // <summary>
        // You have two or more identical items!
        // <summary>
        TwoOrMoreIdenticalItems = 128,
        // <summary>
        // Private Shop
        // <summary>
        PrivateShop = 129,
        // <summary>
        // You have items that cannot be sold in your shop!
        // <summary>
        ContainsItemsNotForSell = 130,
        // <summary>
        // You have opened a shop.
        // <summary>
        ShopOpened = 131,
        // <summary>
        // Your character does not fulfil the requirements needed to wear this item.
        // <summary>
        CanNotWearThat = 132,
        // <summary>
        // You cannot find the item.
        // <summary>
        CanNotFindItem = 133,
        // <summary>
        // Your partner is disarmed.
        // <summary>
        PartnerDisadmed = 134,
        // <summary>
        // You have already assigned a point of return. Overwrite?
        // <summary>
        OverwriteReturnPoint = 135,
        // <summary>
        // Select an item to change.
        // <summary>
        SelectItemToChange = 136,
        // <summary>
        // Contains unnecessary items for upgrade.
        // <summary>
        UnnecessaryItemsUpgrade = 137,
        // <summary>
        // Item was changed
        // <summary>
        ItemWasChanged = 138,
        // <summary>
        // Total number of combinations has exceeded 6.
        // <summary>
        CombinationNumExceeded = 139,
        // <summary>
        // You don't have enough Gold to pay the reward!
        // <summary>
        NotEnoughGoldForReward = 140,
        // <summary>
        // You don't have enough Dona River Sand.
        // <summary>
        NotEnoughSand = 141,
        // <summary>
        // Combination successful!
        // <summary>
        CombinationSuccessful = 142,
        // <summary>
        // Combination failed.
        // <summary>
        CombinationFailed = 143,
        // <summary>
        // Items have disappeared because the combination failed.
        // <summary>
        CombinationItemsDisappeared = 144,
        // <summary>
        // You don't have enough Cella Powder.
        // <summary>
        NotEnoughCella = 145,
        // <summary>
        // The item has disappeared because gamble failed!
        // <summary>
        GambleItemDisappeared = 146,
        // <summary>
        // Gamble successful! Rarity level: %d <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        GambleSuccessful = 147,
        // <summary>
        // You need five Cellons from the previous level.
        // <summary>
        NeedFiveCellonsFromPreviousLevel = 148,
        // <summary>
        // This item has a fixed level.
        // <summary>
        ItemFixedLevel = 149,
        // <summary>
        // Cannot be upgraded any more.
        // <summary>
        CanNotUpgraded = 150,
        // <summary>
        // You don't have enough Soul Gems.
        // <summary>
        NotEnoughSoulGems = 151,
        // <summary>
        // Upgrade to next level failed.
        // <summary>
        UpgradeFailed = 152,
        // <summary>
        // Fixed level
        // <summary>
        FixedLevel = 153,
        // <summary>
        // Upgrade to next level successful.
        // <summary>
        UpgradeSuccessful = 154,
        // <summary>
        // The item's maximum strength has been reached.
        // <summary>
        ItemReachedMaxStrength = 155,
        // <summary>
        // All slots are full.
        // <summary>
        AllSlotsFull = 156,
        // <summary>
        // The data seems to be incorrect.
        // <summary>
        IncorrectData = 157,
        // <summary>
        // You don't have enough ingredients.
        // <summary>
        NotEnoughIngredients = 158,
        // <summary>
        // An error occurred while creating materials.
        // <summary>
        ErrorCreatingMaterials = 159,
        // <summary>
        // Cannot find %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CannotFind = 160,
        // <summary>
        // Trade is only possible on general maps.
        // <summary>
        TradeUnallowedMap = 161,
        // <summary>
        // What? You want to trade with yourself?!
        // <summary>
        WantTradeYourself = 162,
        // <summary>
        // Cannot trade with shop owners.
        // <summary>
        CanNotTradeShopOwners = 163,
        // <summary>
        // Cannot trade during combat.
        // <summary>
        CanNotTradeDuringCombat = 164,
        // <summary>
        // Cannot trade with someone in combat.
        // <summary>
        CanNotTradeSomeoneInCombat = 165,
        // <summary>
        // %s is trading with someone else.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TradingWithSomeoneElse = 166,
        // <summary>
        // %s is blocking trades.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        BlockingTrades = 167,
        // <summary>
        // You are already trading.
        // <summary>
        AlreadyTrading = 168,
        // <summary>
        // Accept trade from %s %s?<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        WantAcceptTrade = 169,
        // <summary>
        // You have invited %s to trade.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        YouInvitedToTrade = 170,
        // <summary>
        // %s is trading with someone else.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TradingWithSomeoneElse2 = 171,
        // <summary>
        // Your partner has not confirmed the item yet.
        // <summary>
        PartnerNotConfirmedItems = 172,
        // <summary>
        // You don't have enough space for the trade.
        // <summary>
        NotEnoughSpaceForTrade = 173,
        // <summary>
        // One or more items cannot be traded.
        // <summary>
        ItemsCanNotTraded = 174,
        // <summary>
        // Please try again.
        // <summary>
        PleaseTryAgain = 175,
        // <summary>
        // Waiting for confirmation.
        // <summary>
        TradeWaitingConfirm = 176,
        // <summary>
        // %s - cancelled the trade.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CancelledTrade = 177,
        // <summary>
        // Trade cancelled
        // <summary>
        TradeCancelled2 = 178,
        // <summary>
        // Check the price and try again.
        // <summary>
        TradeCheckPrice = 179,
        // <summary>
        // One or more items are overlapping. Please try again.
        // <summary>
        ItemsOverlapping = 180,
        // <summary>
        // You cannot use that during combat.
        // <summary>
        CanNotUseInCombat = 181,
        // <summary>
        // The Miniland is locked.
        // <summary>
        MinilandLocked = 182,
        // <summary>
        // The Miniland is full and you cannot enter it.
        // <summary>
        MinilandFull = 183,
        // <summary>
        // Time's up. You will be teleported to the village.
        // <summary>
        TimeUpTeleportToVillage = 184,
        // <summary>
        // Upgrades are only available for weapons and armour.
        // <summary>
        OnlyWeaponArmorCanBeUpgraded = 185,
        // <summary>
        // You must pay 350 Gold. Do you want to proceed?
        // <summary>
        AskPayThreeFifty = 186,
        // <summary>
        // You need Cellons to add options. Cellons can be obtained by refining Gillion Stones.
        // <summary>
        CellonRequiredToAddOptions = 187,
        // <summary>
        // Gambling can always fail.
        // <summary>
        GamblingCanAlwaysFail = 188,
        // <summary>
        // This village is the designated place of revival.
        // <summary>
        RevivalPlaceChanged = 189,
        // <summary>
        // You need three members in your party.
        // <summary>
        ThreeMemberInGroupRequired = 190,
        // <summary>
        // Enter a family name.
        // <summary>
        EnterFamilyName = 191,
        // <summary>
        // The maximum capacity of 50 has been reached.
        // <summary>
        FamilyReachedMaxCapacity = 192,
        // <summary>
        // Cannot enter in the middle of an Instant Combat.
        // <summary>
        InstantCombatAlreadyStarted = 193,
        // <summary>
        // You don't have enough Gold to enter.
        // <summary>
        NotEnoughGoldToEnter = 194,
        // <summary>
        // The mission starts as soon as you enter the map.
        // <summary>
        MissionStartWhenYouEnterTheMap = 195,
        // <summary>
        // Could not execute the energy field.
        // <summary>
        CouldNotExecuteEnergyField = 196,
        // <summary>
        // Oh! I have to complete another mission with a different difficulty first!!
        // <summary>
        AnotherMissionToCompleteBefore = 197,
        // <summary>
        // Cannot enter now. Mission already in progress.
        // <summary>
        CanNotEnterMissionInProgress = 198,
        // <summary>
        // You cannot use the Time Circle whilst in a party.
        // <summary>
        CanNotUseTimeCircleInGroup = 199,
        // <summary>
        // Time Circle will be available in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TimeCircleWillBeAvailableShortly = 200,
        // <summary>
        // You cannot join because you do not meet the minimum level requirements.
        // <summary>
        CanNotJoinWithThisLevel = 201,
        // <summary>
        // Can only enter a private room with the correct password.
        // <summary>
        PrivateRoomNeedPassword = 202,
        // <summary>
        // The room is already full.
        // <summary>
        RoomAlreadyFull = 203,
        // <summary>
        // You cannot enter because the battle is about to end.
        // <summary>
        CanNotEnterBattleEnd = 204,
        // <summary>
        // Take a seat when you are ready.
        // <summary>
        TakeSeatWhenReady = 205,
        // <summary>
        // [Notice] %s has entered.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeoneEntered = 206,
        // <summary>
        // This battle no longer exists. Click refresh.
        // <summary>
        BatleNotExistsRefresh = 207,
        // <summary>
        // The battle starts when everyone is ready.
        // <summary>
        BattleStartsEveryoneReady = 208,
        // <summary>
        // Battle options have been changed.
        // <summary>
        BattleOptionsChanged = 209,
        // <summary>
        // You cannot start the battle.
        // <summary>
        CanNotStartBattle = 210,
        // <summary>
        // Setup failed.
        // <summary>
        SetupFailed = 211,
        // <summary>
        // The Time Circle cannot be used whilst in a party.
        // <summary>
        TimeCircleCanNotBeUsedInGroup = 212,
        // <summary>
        // Creation failed. Please try again.
        // <summary>
        CreationFailed = 213,
        // <summary>
        // Cannot enter Miniland from here.
        // <summary>
        CanNotEnterMinilandFromHere = 214,
        // <summary>
        // You cannot enter Mini-Land while your private shop is open.
        // <summary>
        CannotMinilandInShop = 215,
        // <summary>
        // Cannot find opposite number.
        // <summary>
        CannotFindOppositeNumber = 216,
        // <summary>
        // The Miniland is private.
        // <summary>
        MinilandIsPrivate = 217,
        // <summary>
        // The Miniland is empty.
        // <summary>
        MinilandIsEmpty = 218,
        // <summary>
        // Helper has become unkind!!
        // <summary>
        HelperIsUnkind = 219,
        // <summary>
        // Helper has become kind again.
        // <summary>
        HelperKindAgain = 220,
        // <summary>
        // <I am serving a penalty.>
        // <summary>
        IAmUnderPenalty = 221,
        // <summary>
        // Punishment remaining: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PunishmentRemaining = 222,
        // <summary>
        // You are not playing.
        // <summary>
        YouAreNotPlaying = 223,
        // <summary>
        // This person does not want to receive whispers.
        // <summary>
        ThisPersonRefuseWhisper = 224,
        // <summary>
        // %s is not playing.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsNotPlaying = 225,
        // <summary>
        // Cannot form a party while in a battle.
        // <summary>
        NoGroupInBattle = 226,
        // <summary>
        // Already in the requested party.
        // <summary>
        AlreadyInGroup = 227,
        // <summary>
        // Already in another party.
        // <summary>
        AlreadyInAnotherGroup = 228,
        // <summary>
        // Your party is already full.
        // <summary>
        YourGroupIsFull = 229,
        // <summary>
        // The party is already full.
        // <summary>
        GroupIsFull = 230,
        // <summary>
        // You cannot join the party. Enable the party option.
        // <summary>
        GroupBlocked = 231,
        // <summary>
        // This person's party option is blocked.
        // <summary>
        TargetGroupBlocked = 232,
        // <summary>
        // %s has invited you to join their party.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GroupInvite = 233,
        // <summary>
        // %s has been invited to join.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        YouInvitedToGroup = 234,
        // <summary>
        // Not found.
        // <summary>
        NotFound = 235,
        // <summary>
        // Already in the requested party.
        // <summary>
        AlreadyInGroup2 = 236,
        // <summary>
        // %s rejected your invitation.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GroupInviteRejected = 237,
        // <summary>
        // You are blocked.
        // <summary>
        YouAreBlocked = 238,
        // <summary>
        // Registered.
        // <summary>
        Registered = 239,
        // <summary>
        // Cannot list any more.
        // <summary>
        CannotListAnymore = 240,
        // <summary>
        // %s is in combat.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsInCombat = 241,
        // <summary>
        // %s has blocked being chosen as a friend.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HAsFriendRequestBlocked = 242,
        // <summary>
        // Become friends with %s?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskBecomeFriend = 243,
        // <summary>
        // Deleted.
        // <summary>
        Deleted = 244,
        // <summary>
        // You already have this attribute.
        // <summary>
        AlreadyHaveAttribute = 245,
        // <summary>
        // Name is too long.
        // <summary>
        NameTooLong = 246,
        // <summary>
        // Give your companion a name.
        // <summary>
        GiveCompanionName = 247,
        // <summary>
        // New name has been assigned to your teammate.
        // <summary>
        NewNameAssignedToCompanion = 248,
        // <summary>
        // Can be only built in Miniland.
        // <summary>
        CanOnlyBuildInMiniland = 249,
        // <summary>
        // Can only be removed in Miniland.
        // <summary>
        CanOnlyRemoveInMiniland = 250,
        // <summary>
        // You can only use the structure in the Miniland.
        // <summary>
        CanOnlyUseStructureInMiniland = 251,
        // <summary>
        // You can only charge the structure in Miniland.
        // <summary>
        CanOnlyRechargeInMiniland = 252,
        // <summary>
        // Please try again.
        // <summary>
        TryAgain = 253,
        // <summary>
        // You need 200,000 Gold to create a family.
        // <summary>
        NeedMoneyForFamily = 254,
        // <summary>
        // Name is too short or too long.
        // <summary>
        FamilyNameTooShortOrTooLong = 255,
        // <summary>
        // You need three members in your party. %d <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NeedThreeMember = 256,
        // <summary>
        // One or more members of your party already have a family.
        // <summary>
        OneMemberAlreadyHaveAFamily = 257,
        // <summary>
        // One or more members of your party have not completed Act 1-1.
        // <summary>
        OneMemberHaveNotCompletedActOnePartOne = 258,
        // <summary>
        // One or more members in your party must change their character class.
        // <summary>
        OneOrMoreMemberHaveToChangeClass = 259,
        // <summary>
        // %s cannot found a family yet.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CannotFoundFamily = 260,
        // <summary>
        // That family name already exists.
        // <summary>
        FamilyAlreadyExist = 261,
        // <summary>
        // Congratulations! The '%s' Family has been created!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamilyCreated = 262,
        // <summary>
        // Family creation failed.
        // <summary>
        FamilyCreationFailed = 263,
        // <summary>
        // This family is not registered.
        // <summary>
        FamilyNotRegistered = 264,
        // <summary>
        // Only the family head can disband a family.
        // <summary>
        OnlyHeadCanDisbandFamily = 265,
        // <summary>
        // Disbanding a family is only possible in the channel where the family was created.
        // <summary>
        DisbandingFamilyOnlyOnCreationChannel = 266,
        // <summary>
        // Are you sure you want to disband your family?
        // <summary>
        AreYouSureToDisbandFamily = 267,
        // <summary>
        // Family disbanded.
        // <summary>
        FamilyDisbanded = 268,
        // <summary>
        // Failed to disband family. Please try again.
        // <summary>
        FailedToDisbandFamily = 269,
        // <summary>
        // You are not authorised to accept a family.
        // <summary>
        NotAuthorizedToAcceptFamily = 270,
        // <summary>
        // You cannot lead your family in the current channel.
        // <summary>
        CanNotLeadFamilyInThisChannel = 271,
        // <summary>
        // The player is already a member of another family.
        // <summary>
        PlayerAlreadyInAnotherFamily = 272,
        // <summary>
        // The player is blocking the families option.
        // <summary>
        PlayerFamilyBlocked = 273,
        // <summary>
        // Player cannot join a family yet.
        // <summary>
        PlayerCanNotJoinFamilyYet = 274,
        // <summary>
        // Do you want to become a member of %s's family?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskMemberFamily = 275,
        // <summary>
        // %s has joined your family.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        JoinedFamily = 276,
        // <summary>
        // You can no longer accept.
        // <summary>
        YouCanNoLongerAccept = 277,
        // <summary>
        // The player does not want to join your family.
        // <summary>
        PlayerRefusedFamilyInvite = 278,
        // <summary>
        // Familydeputy
        // <summary>
        Familydeputy2 = 279,
        // <summary>
        // You cannot find %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CanNotFind = 280,
        // <summary>
        // %s is completely authorised.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsCompletlyAuthorized = 281,
        // <summary>
        // A new family deputy has been appointed.
        // <summary>
        NewFamilyDeputyAppointed = 282,
        // <summary>
        // You cannot appoint any more family deputies!
        // <summary>
        CanNotAppointMoreDeputy = 283,
        // <summary>
        // Familykeeper
        // <summary>
        Familykeeper2 = 284,
        // <summary>
        // Appointment
        // <summary>
        Appointment = 285,
        // <summary>
        // A new family keeper has been appointed.
        // <summary>
        NewFamilyKeeperAppointed = 286,
        // <summary>
        // You cannot have any more family keepers.
        // <summary>
        MaxFamilyKeeper = 287,
        // <summary>
        // Dismiss
        // <summary>
        Dismiss = 288,
        // <summary>
        // Dismissed
        // <summary>
        Dismissed1 = 289,
        // <summary>
        // You cannot dismiss so many family members at once.
        // <summary>
        CanNotDismissedSoMuchFamillyMembers = 290,
        // <summary>
        // The player cannot be dismissed.
        // <summary>
        PlayerCanNotBeDismissed = 291,
        // <summary>
        // Familyhead
        // <summary>
        Familyhead2 = 292,
        // <summary>
        // Your authority as a family deputy has been passed on.
        // <summary>
        FamilyDeputyAuthorityPassedOn = 293,
        // <summary>
        // Only a family deputy can become a family head.
        // <summary>
        OnlyFamilyDeputyCanBecomeHEad = 294,
        // <summary>
        // Familyleave
        // <summary>
        Familyleave = 295,
        // <summary>
        // The family head can not leave the family.
        // <summary>
        FamilyHeadCanNotLeave = 296,
        // <summary>
        // Do you really want to leave your family? (You cannot join a new family for one day.)
        // <summary>
        LeaveFamilyQuestion = 297,
        // <summary>
        // Familyinvite
        // <summary>
        Familyinvite = 298,
        // <summary>
        // Familydismiss
        // <summary>
        Familydismiss = 299,
        // <summary>
        // You cannot dismiss family deputies or family heads.
        // <summary>
        CanNotDismissedDeputy = 300,
        // <summary>
        // Dismissed
        // <summary>
        Dismissed2 = 301,
        // <summary>
        // Familyshout
        // <summary>
        Familyshout = 302,
        // <summary>
        // Today
        // <summary>
        Today = 303,
        // <summary>
        // You left the family.
        // <summary>
        LeftFamily = 304,
        // <summary>
        // Cannot find information.
        // <summary>
        CanNotFindInformation = 305,
        // <summary>
        // Invite
        // <summary>
        Invite = 306,
        // <summary>
        // Invitations are only possible in Miniland.
        // <summary>
        InvitationOnlyPossibleInMiniland = 307,
        // <summary>
        // You do not have enough Seeds of Power. You need 1 Seed of Power to invite someone.
        // <summary>
        NotEnoughSeedToInvite = 308,
        // <summary>
        // The player is not logged in.
        // <summary>
        PlayerIsNotLoggedIn = 309,
        // <summary>
        // The player cannot be invited.
        // <summary>
        PlayerCanNotBeInvited = 310,
        // <summary>
        // Cannot invite because the Miniland is locked.
        // <summary>
        CanNotInviteInLockedMiniland = 311,
        // <summary>
        // %s has invited you to their Miniland. Accept?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HasInvitedToMiniland = 312,
        // <summary>
        // Miniland is full. You cannot invite any more.
        // <summary>
        CanNotInviteInFullMiniland = 313,
        // <summary>
        // Exchange
        // <summary>
        Exchange = 314,
        // <summary>
        // Block
        // <summary>
        Block2 = 315,
        // <summary>
        // Accept
        // <summary>
        Accept = 316,
        // <summary>
        // You will block trades from now on.
        // <summary>
        TradeBlocked = 317,
        // <summary>
        // You will accept trades from now on.
        // <summary>
        TradeAllowed = 318,
        // <summary>
        // Friend
        // <summary>
        Friend = 319,
        // <summary>
        // You will block friends from now on.
        // <summary>
        FriendBlocked = 320,
        // <summary>
        // You will accept friends from now on.
        // <summary>
        FriendAllowed = 321,
        // <summary>
        // Family
        // <summary>
        Family = 322,
        // <summary>
        // You will block families from now on.
        // <summary>
        FamilyBlocked = 323,
        // <summary>
        // You will accept families from now on.
        // <summary>
        FamilyAllowed = 324,
        // <summary>
        // Whisper
        // <summary>
        Whisper = 325,
        // <summary>
        // You will block whispers from now on.
        // <summary>
        WhisperBlocked = 326,
        // <summary>
        // You will accept whispers from now on.
        // <summary>
        WhisperAllowed = 327,
        // <summary>
        // Party
        // <summary>
        Party = 328,
        // <summary>
        // You will block parties from now on.
        // <summary>
        GroupRequestBlocked = 329,
        // <summary>
        // You will accept parties from now on.
        // <summary>
        GroupRequestAllowed = 330,
        // <summary>
        // Pet
        // <summary>
        Pet = 331,
        // <summary>
        // Pet will return to Miniland after it dies.
        // <summary>
        PetWillReturnMinilandAfterDeath = 332,
        // <summary>
        // Pet can be revived with Seed of Power if it dies.
        // <summary>
        PetWillReviveAfterDeath = 333,
        // <summary>
        // Partner
        // <summary>
        Partner = 334,
        // <summary>
        // Partner will return to Miniland after it dies.
        // <summary>
        PartnerWillReturnMinilandAfterDeath = 335,
        // <summary>
        // Partner can be revived with Seed of Power if it dies.
        // <summary>
        PartnerWillReviveAfterDeath = 336,
        // <summary>
        // [History]
        // <summary>
        History = 337,
        // <summary>
        // Welcome
        // <summary>
        Welcome = 338,
        // <summary>
        // Damage was reflected.
        // <summary>
        DamageReflected = 339,
        // <summary>
        // Use of skill was interrupted!
        // <summary>
        SkillInterrupted = 340,
        // <summary>
        // No weapon to use.
        // <summary>
        NoWeapon = 341,
        // <summary>
        // Insufficient ammo. Buy more in an equipment shop.
        // <summary>
        NoAmmo = 342,
        // <summary>
        // Punishment time is over.
        // <summary>
        PunishmentOver = 343,
        // <summary>
        // Enter the Time-Space Stone to the north of the village.
        // <summary>
        EnterTimespaceNorthOfVillage = 344,
        // <summary>
        // %d hours have passed.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        HoursHavePassed = 345,
        // <summary>
        // %d hours have passed. Please have a break.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        HoursHavePassedTakeABreak = 346,
        // <summary>
        // Thank you for participating.
        // <summary>
        ThanksForParticipating = 347,
        // <summary>
        // The server will be disconnected in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ServerWillBeDisonnected = 348,
        // <summary>
        // Returning to village because you died during a Quick Mission.
        // <summary>
        ReturningToVillageDiedDuringQuickMission = 349,
        // <summary>
        // You have left the Miniland because the owner closed it.
        // <summary>
        KickOwnerClosedTheMiniland = 350,
        // <summary>
        // The battle has ended because everyone left.
        // <summary>
        BattleEndedBecauseEverybodyLeft = 351,
        // <summary>
        // Battle is over.
        // <summary>
        BattleOver = 352,
        // <summary>
        // Failed. Contains an invalid character.
        // <summary>
        InvalidCharacter = 353,
        // <summary>
        // The maximum capacity has been reached.
        // <summary>
        MaximumCapacityReached = 354,
        // <summary>
        // Enter at least 4 letters.
        // <summary>
        NameTooShort = 355,
        // <summary>
        // Do not use any special characters such as '|' in your character name.
        // <summary>
        NoSpecialCharacterName = 356,
        // <summary>
        // Do not use any special characters such as ' in your character name.
        // <summary>
        NoSpecialCharacterName2 = 357,
        // <summary>
        // The name contains an invalid word or character.
        // <summary>
        NameIsInvalid = 358,
        // <summary>
        // Incorrect password
        // <summary>
        IncorrectPassword = 359,
        // <summary>
        // Invalid ID (case sensitive)
        // <summary>
        InvalidIDCaseSensitive = 360,
        // <summary>
        // In %d minute(s)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        InMinutes = 361,
        // <summary>
        // In %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        InSeconds = 362,
        // <summary>
        // %d~%d Icebreaker will start for all levels.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(long), typeof(long))]
        IceBreakerWillStartForLevels = 363,
        // <summary>
        // Icebreaker has started.
        // <summary>
        IcebreakerStarted = 364,
        // <summary>
        // Do you want to join Icebreaker? You must pay %d Gold<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AskJoinIcebreaker = 365,
        // <summary>
        // Gold
        // <summary>
        Gold1 = 366,
        // <summary>
        // You will return to the starting position in 10 seconds.
        // <summary>
        ReturnToStartingPosition = 367,
        // <summary>
        // Icebreaker time has elapsed.
        // <summary>
        IcebreakerTimeElapsed = 368,
        // <summary>
        // Everyone in Icebreaker has left!
        // <summary>
        EveryoneHasLeftIcebreaker = 369,
        // <summary>
        // Everybody is frozen and cannot continue Icebreaker.
        // <summary>
        EverybodyIsFrozen = 370,
        // <summary>
        // Icebreaker is over.
        // <summary>
        IceBreakerOver = 371,
        // <summary>
        // PvP will be available shortly...
        // <summary>
        PvpWillBeAvailable = 372,
        // <summary>
        // Icebreaker will end in 30 seconds.
        // <summary>
        IcebreakerWillEndInThirtySeconds = 373,
        // <summary>
        // Begin attack!
        // <summary>
        BeginAttack = 374,
        // <summary>
        // You earned reputation and a reward: %d Gold<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        EarnedReputationAndReward = 375,
        // <summary>
        // Gold
        // <summary>
        Gold2 = 376,
        // <summary>
        // an Instant Combat for all levels will start. %s <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        InstantCombatWillStart = 377,
        // <summary>
        // An Instant Combat has started.
        // <summary>
        InstantCombatStarted = 378,
        // <summary>
        // Do you want to join the Instant Combat?
        // <summary>
        JoinInstantCombatQuestion = 379,
        // <summary>
        // You will return to the starting position in 10 seconds.
        // <summary>
        ReturnToStartingPositionTenSeconds = 380,
        // <summary>
        // Instant Combat time has elapsed.
        // <summary>
        InstantCombatElapsed = 381,
        // <summary>
        // Everyone in the Instant Combat has died!
        // <summary>
        InstantCombatLost = 382,
        // <summary>
        // You have won the Instant Combat! Congratulations!
        // <summary>
        InstantCombatSuccess = 383,
        // <summary>
        // A horde of monsters is slowly approaching...
        // <summary>
        MonstersAreApproaching = 384,
        // <summary>
        // Instant Combat will end in 30 seconds.
        // <summary>
        InstantCombatThirtySecondsRemaining = 385,
        // <summary>
        // Instant Combat is over.
        // <summary>
        InstantCombatOver = 386,
        // <summary>
        // Woah! Monsters have appeared!
        // <summary>
        MonsterHaveAppeared = 387,
        // <summary>
        // The server will be disconnected in %d minutes.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ServerWillDisconnectShortly = 388,
        // <summary>
        // You don't have enough Gold to withdraw.
        // <summary>
        NotEnoughGoldToWithdraw = 389,
        // <summary>
        // You don't have enough Gold to deposit.
        // <summary>
        NotEnoughGoldToDeposit = 390,
        // <summary>
        // Someone is using the safe.
        // <summary>
        SomeoneIsUsingTheSafe = 391,
        // <summary>
        // You are not qualified to use the warehouse.
        // <summary>
        NotQualifiedForWarehouse = 392,
        // <summary>
        // Someone is using the warehouse.
        // <summary>
        SomeoneUsingTheWarehouse = 393,
        // <summary>
        // You don't have enough Seeds of Power.
        // <summary>
        NotEnoughSeedOfPower = 394,
        // <summary>
        // You have used %dx %s.<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        YouHaveUsed = 395,
        // <summary>
        // Ammo reloaded.
        // <summary>
        AmmoReloaded = 396,
        // <summary>
        // You have not chosen a point of return.
        // <summary>
        NoReturnPoint = 397,
        // <summary>
        // Your partner is upset.
        // <summary>
        PartnerUpset = 398,
        // <summary>
        // Do I look like your pet?!
        // <summary>
        DoILookLikeYourPet = 399,
        // <summary>
        // Your pet has eaten everything.
        // <summary>
        PetEatenEverything = 400,
        // <summary>
        // What are you going to do with these people?
        // <summary>
        WhatAreYouGoingToDoWithThesePeople = 401,
        // <summary>
        // You cannot release your NosMate while it is accompanying you.
        // <summary>
        CanNotReleasePetInYourTeam = 402,
        // <summary>
        // You can only collect pets in Miniland.
        // <summary>
        CanOnlyCollectPetInMiniland = 403,
        // <summary>
        // I'm full.
        // <summary>
        IAmFull = 404,
        // <summary>
        // Eat something while resting.
        // <summary>
        EatSomethingWhileResting = 405,
        // <summary>
        // I'm feeling sick...
        // <summary>
        FeelingSick = 406,
        // <summary>
        // A door has opened somewhere.
        // <summary>
        DoorOpenedSomewhere = 407,
        // <summary>
        // The lever has been pulled.
        // <summary>
        LeverHasBeenPulled = 408,
        // <summary>
        // The object has been moved.
        // <summary>
        ObjectHasBeenMoved = 409,
        // <summary>
        // Oops!! That's a fake potion from a Mimic.
        // <summary>
        FakePotionUsed = 410,
        // <summary>
        // That won't move any more!
        // <summary>
        ThatWontMoveAnymore = 411,
        // <summary>
        // The box is empty.
        // <summary>
        BoxIsEmpty = 412,
        // <summary>
        // You have received an item -
        // <summary>
        ItemReceived = 413,
        // <summary>
        // Your inventory is full!
        // <summary>
        FullInventory3 = 414,
        // <summary>
        // You have produced an item -
        // <summary>
        ItemProduced = 415,
        // <summary>
        // You need at least two empty slots.
        // <summary>
        NeedTwoEmptySpot = 416,
        // <summary>
        // You have no more Gillion Stones.
        // <summary>
        NotEnoughGillion = 417,
        // <summary>
        // You have acquired a special item:
        // <summary>
        SpecialItemAcquired = 418,
        // <summary>
        // You have acquired Cella Powder: Amount %d <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CellaPowderItemAcquired = 419,
        // <summary>
        // Installation is only possible in lock mode.
        // <summary>
        InstallationOnlyLockMode = 420,
        // <summary>
        // This structure is already built.
        // <summary>
        StructureAlreadyBuild = 421,
        // <summary>
        // You must build a house first.
        // <summary>
        MustBuildHouseFirst = 422,
        // <summary>
        // You must build a vacation house first.
        // <summary>
        MustBuildVacationHouseFirst = 423,
        // <summary>
        // You can only remove the structure in lock mode.
        // <summary>
        RemoveOnlyLockMode = 424,
        // <summary>
        // Miniland is now public.
        // <summary>
        MinilandPublic = 425,
        // <summary>
        // Miniland is now private.
        // <summary>
        MinilandPrivate = 426,
        // <summary>
        // You cannot enter because the Miniland is locked.
        // <summary>
        CanNotEnterLockedMiniland = 427,
        // <summary>
        // Miniland is now locked.
        // <summary>
        MinilandLocked2 = 428,
        // <summary>
        // Structure unavailable.
        // <summary>
        StructureUnavailable = 429,
        // <summary>
        // Only open to owner.
        // <summary>
        OnlyOpenedToOwner = 430,
        // <summary>
        // You don't have enough points.
        // <summary>
        NotEnoughPoints = 431,
        // <summary>
        // No energy in the structure.
        // <summary>
        NoEnergyStructure = 432,
        // <summary>
        // Energy is full.
        // <summary>
        EnergyFull = 433,
        // <summary>
        // Structure is charged.
        // <summary>
        StructureCharged = 434,
        // <summary>
        // Item was created.
        // <summary>
        ItemCreated = 435,
        // <summary>
        // There is not enough energy to operate the structure.
        // <summary>
        NotEnoughStructureEnergy = 436,
        // <summary>
        // Introduce Miniland using up to 50 characters.
        // <summary>
        MinilandIntroduction = 437,
        // <summary>
        // Your introductory message has been updated.
        // <summary>
        MinilandIntroductionUpdated = 438,
        // <summary>
        // Total visitors: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TotalVisitors = 439,
        // <summary>
        // Today's visitors: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TodayVisitors = 440,
        // <summary>
        // You've already set up a signpost. Time remaining: %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AlreadyASignPost = 441,
        // <summary>
        // You already have a better land.
        // <summary>
        AlreadyBetterLand = 442,
        // <summary>
        // You already have the same land.
        // <summary>
        AlreadySameLand = 443,
        // <summary>
        // You don't have enough Gold.
        // <summary>
        NotEnoughGold4 = 444,
        // <summary>
        // You have acquired new land.
        // <summary>
        AcquiredNewLand = 445,
        // <summary>
        // You don't own any land yet.
        // <summary>
        DoNotOwnLand = 446,
        // <summary>
        // You cannot accept any more companions.
        // <summary>
        MaxCompanion = 447,
        // <summary>
        // You cannot acquire any more pets.
        // <summary>
        MaxPets = 448,
        // <summary>
        // Your Guardian Angel has protected your pet.
        // <summary>
        GuardianProtectPet = 449,
        // <summary>
        // NosMate dead. It will be revived in 3 minutes.
        // <summary>
        NosmateDeadThreeMinutes = 450,
        // <summary>
        // You used 5 Seeds of Power.
        // <summary>
        FivePowerSeedUsed = 451,
        // <summary>
        // NosMate dead: It has returned to your Miniland because you don't have any Seeds of Power.
        // <summary>
        NosMateDeadNoMorePowerSeed = 452,
        // <summary>
        // NosMate dead: It has returned to your Miniland.
        // <summary>
        NosMateDeadMiniland = 453,
        // <summary>
        // Your level is lower than mine.
        // <summary>
        LevelLowerThanPet = 454,
        // <summary>
        // Already in your party.
        // <summary>
        AlreadyInYourParty = 455,
        // <summary>
        // Congratulations! You have a further member to your party: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeoneJoinGroup = 456,
        // <summary>
        // Monsters cannot be captured.
        // <summary>
        CanNotCaptureMonster1 = 457,
        // <summary>
        // Are you trying to steal?
        // <summary>
        TryingToSteal = 458,
        // <summary>
        // Monsters cannot be captured.
        // <summary>
        CanNotCaptureMonster2 = 459,
        // <summary>
        // You can only capture animals of a lower level than you.
        // <summary>
        CaptureToHighLevel = 460,
        // <summary>
        // You can only capture animals whose HP is 50% or lower.
        // <summary>
        CaptureTooMuchLife = 461,
        // <summary>
        // You cannot capture any more.
        // <summary>
        CaptureLimitReached = 462,
        // <summary>
        // Capture failed.
        // <summary>
        CaptureFailed = 463,
        // <summary>
        // Capture successful.
        // <summary>
        CaptureSuccessful = 464,
        // <summary>
        // Oops! Your attack level has fallen!
        // <summary>
        AttackHasFallen = 465,
        // <summary>
        // Attack level drops:
        // <summary>
        AttackLevelDrops = 466,
        // <summary>
        // Oops! Your defence level has fallen!
        // <summary>
        DefenceHasFallen = 467,
        // <summary>
        // Defence level drops:
        // <summary>
        DefenceLevelDrops = 468,
        // <summary>
        // Your pet couldn't learn anything.
        // <summary>
        PetCouldNotLearnAnything = 469,
        // <summary>
        // The name of your gold-eating pet is:
        // <summary>
        NameOfGoldEatingPetIs = 470,
        // <summary>
        // Your pet smiled while attacking. It appears to have learned something!
        // <summary>
        PetLearnedAbility = 471,
        // <summary>
        // %s ...'s attack level increased:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PetAttackLevelIncreased = 472,
        // <summary>
        // Your pet smiled during the attack. It seems to weather it!
        // <summary>
        PetWeatherIt = 473,
        // <summary>
        // %s ...'s defence level increased:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PetDefenceLevelIncreased = 474,
        // <summary>
        // The partner cannot use this equipment.
        // <summary>
        PartnerCanNotUseThatEquipment = 475,
        // <summary>
        // Level doesn't match.
        // <summary>
        LevelDoesNotMatch = 476,
        // <summary>
        // Joined a party.
        // <summary>
        JoinedParty = 477,
        // <summary>
        // Party disbanded.
        // <summary>
        PartyDisbanded = 478,
        // <summary>
        // Find a key!
        // <summary>
        FindKey = 479,
        // <summary>
        // Pull the lever.
        // <summary>
        PullLever = 480,
        // <summary>
        // Defeat all the enemies!
        // <summary>
        DefeatAllEnemies = 481,
        // <summary>
        // Protect your companions and attack the enemies.
        // <summary>
        ProtectCompanion = 482,
        // <summary>
        // Eliminate all the monsters.
        // <summary>
        EliminateAllMonsters = 483,
        // <summary>
        // Escape to the exit.
        // <summary>
        EscapeToTheExit = 484,
        // <summary>
        // Killed:
        // <summary>
        Killed = 485,
        // <summary>
        // Captured:
        // <summary>
        Captured = 486,
        // <summary>
        // Talk: %d times<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Talk = 487,
        // <summary>
        // Operation: %d times<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Operation = 488,
        // <summary>
        // If you die more than %d times.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        IfMoreThanDeath = 489,
        // <summary>
        // Protected NPCs:
        // <summary>
        ProtectedNpc = 490,
        // <summary>
        // Time's up.
        // <summary>
        TimeIsUp = 491,
        // <summary>
        // Difficulty %s:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Difficulty2 = 492,
        // <summary>
        // [Conditions of Success]
        // <summary>
        SuccessConditions = 493,
        // <summary>
        // [Conditions of Failure]
        // <summary>
        FailureConditions = 494,
        // <summary>
        // [General Reward]
        // <summary>
        GeneralReward = 495,
        // <summary>
        // You have successfully completed the Quick Mission.
        // <summary>
        QuickMissionComplete = 496,
        // <summary>
        // You failed the Quick Mission.
        // <summary>
        QuickMissionFailed = 497,
        // <summary>
        // Eliminate all monsters -> [Successful]
        // <summary>
        EliminateAllMonstersSuccessful = 498,
        // <summary>
        // Remaining
        // <summary>
        Remaining = 499,
        // <summary>
        // Monster attack -> [Successful]
        // <summary>
        MonsterAttackSuccessful = 500,
        // <summary>
        // Capture mission -> [Successful]
        // <summary>
        CaptureMissionSuccessful = 501,
        // <summary>
        // Remaining conversations: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RemainingConversations = 502,
        // <summary>
        // Talking mission -> [Successful]
        // <summary>
        TalkingMissionSuccessful = 503,
        // <summary>
        // Remaining operations: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RemainingOperations = 504,
        // <summary>
        // Operation mission -> [Successful]
        // <summary>
        OperationMissionSuccessful = 505,
        // <summary>
        // -> [In Progress]
        // <summary>
        InProgress = 506,
        // <summary>
        // [Mission in Progress]
        // <summary>
        MissionInProgress = 507,
        // <summary>
        // [Reward]
        // <summary>
        Reward = 508,
        // <summary>
        // New mission goal!
        // <summary>
        NewGoal = 509,
        // <summary>
        // Your level has increased.
        // <summary>
        LevelIncreased = 510,
        // <summary>
        // You have reached the level required for a job transfer.
        // <summary>
        LevelForClassChangeReached = 511,
        // <summary>
        // You can only achieve a higher job level with a specialist.
        // <summary>
        YouCanOnlyAchieveHigherJobLevelWithSpecialist = 512,
        // <summary>
        // You have reached the highest job level!
        // <summary>
        MaxJobLevelReached = 513,
        // <summary>
        // Your job level has increased.
        // <summary>
        JobLevelIncreased = 514,
        // <summary>
        // Because you did not land the first blow, you only receive a fraction of the experience points.
        // <summary>
        NotFirstAttaquantExperienceReduced = 515,
        // <summary>
        // No! If you have the same level as your partner, they will look down on you.
        // <summary>
        TooLowLevelToUpPartner = 516,
        // <summary>
        // Your pet cannot currently level up or it would no longer respect you!
        // <summary>
        TooLowLevelToUpPet = 517,
        // <summary>
        // A bonus enlivens you with new energy.
        // <summary>
        BonusEnlievenWithNewEnergy = 518,
        // <summary>
        // To level up, the bar must be completely filled.
        // <summary>
        BarMustBeFilledToLevelUp = 519,
        // <summary>
        // Your pet's loyalty has fallen to 0!
        // <summary>
        PetLoyaltyIsEmpty = 520,
        // <summary>
        // Feed your pet or go to your Miniland.
        // <summary>
        FeedPetOrGoToMiniland = 521,
        // <summary>
        // The Cellon has disappeared because you failed to add options.
        // <summary>
        CellonDisapearedFailedUpgrade = 522,
        // <summary>
        // Options added.
        // <summary>
        OptionAdded = 523,
        // <summary>
        // The Cellon's level is higher than that of the accessory.
        // <summary>
        CellonLevelHigherThanAccessory = 524,
        // <summary>
        // (Party) [%s], Priority: <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GroupPriority = 525,
        // <summary>
        // ], Priority:
        // <summary>
        Priority = 526,
        // <summary>
        // The skill cannot be deleted.
        // <summary>
        SkillCanNotBeDelleted = 527,
        // <summary>
        // You can delete it after consuming.
        // <summary>
        CanDeleteAfterConsuming = 528,
        // <summary>
        // Cannot be deleted if it is linked to a plus skill.
        // <summary>
        CannotDeleteIfLinkedToSkill = 529,
        // <summary>
        // You cannot use this skill here.
        // <summary>
        CannotSkillHere = 530,
        // <summary>
        // You don't have enough MP to cast the spell.
        // <summary>
        NotEnoughMpForSpell = 531,
        // <summary>
        // You are missing an item for the skill: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        MissingItemForSkill = 532,
        // <summary>
        // Battle Result#13#10------------------------#13#10
        // <summary>
        BattleResult = 533,
        // <summary>
        // [Notice] %s has left.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        NoticeHasLeft = 534,
        // <summary>
        // Receive a coupon: get a higher score and obtain a bonus item!
        // <summary>
        ReceivedCoupon = 535,
        // <summary>
        // Coupon is only awarded once.
        // <summary>
        CouponOnlyAwardedOnce = 536,
        // <summary>
        // A door has opened.
        // <summary>
        ADoorHasOpened = 537,
        // <summary>
        // The door is locked.
        // <summary>
        DoorIsLocked = 538,
        // <summary>
        // Could not create the field.
        // <summary>
        CouldNotCreateField = 539,
        // <summary>
        // Normal
        // <summary>
        Normal = 540,
        // <summary>
        // Difficult
        // <summary>
        Difficult = 541,
        // <summary>
        // Special
        // <summary>
        Special = 542,
        // <summary>
        // Completed in special mode for the first time.
        // <summary>
        FirstSpecialModeCompleted = 543,
        // <summary>
        // This item belongs to the current party.
        // <summary>
        ItemBelongsToGroup = 544,
        // <summary>
        // Gambling is not possible for this item.
        // <summary>
        CanNotGambleThat = 545,
        // <summary>
        // The item survived thanks to the protection spell.
        // <summary>
        ItemSurvivedWithProtection = 546,
        // <summary>
        // The rarity level was increased by the Amulet for Rare Rising.
        // <summary>
        RarityLevelIncreased = 547,
        // <summary>
        // %s is not frozen.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsNotFrozen = 548,
        // <summary>
        // You aren't authorised to invite anybody!
        // <summary>
        YouAreNotAuthorizedToInvite = 549,
        // <summary>
        // You are not authorised to change the family keeper.
        // <summary>
        YouAreNotAuthorizedToChangeKeeper = 550,
        // <summary>
        // Notice
        // <summary>
        Notice = 551,
        // <summary>
        // You aren't authorised to change the notice.
        // <summary>
        NotAuthorizedToChangeNoticed = 552,
        // <summary>
        // You are not authorised to change the family shout.
        // <summary>
        NotAuthorizedToChangeFamilyShout = 553,
        // <summary>
        // Authority
        // <summary>
        Authority = 554,
        // <summary>
        // Not authorised.
        // <summary>
        NotAuthorized = 555,
        // <summary>
        // Title
        // <summary>
        Title = 556,
        // <summary>
        // Gender
        // <summary>
        Gender = 557,
        // <summary>
        // If the family head changes their gender, all relationships will be reset.
        // <summary>
        RelashionshipAreResetedWhenHeadChangeGender = 558,
        // <summary>
        // In turn
        // <summary>
        InTurn = 559,
        // <summary>
        // You cannot change party mode because you are not the party master.
        // <summary>
        CanNotChangeGroupMode = 560,
        // <summary>
        // Party item looting has been changed to 'Share as group'.
        // <summary>
        ShareAsGroupChanged = 561,
        // <summary>
        // Party item looting has been changed to 'Loot in turn'.
        // <summary>
        LootInTurnChanged = 562,
        // <summary>
        // The Family Head has been changed.
        // <summary>
        FamilyHeadChanged = 563,
        // <summary>
        // %s is frozen.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsFrozen = 564,
        // <summary>
        // %s is out!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsOut = 565,
        // <summary>
        // Remaining punishment: %d minutes<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RemainingPunishment = 566,
        // <summary>
        // %d parcels have arrived.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ParcelHaveArrived = 567,
        // <summary>
        // Mission will continue here. No penalty for level 10 or lower.
        // <summary>
        MissionContinueLessThanLevel10 = 568,
        // <summary>
        // Mission will be continued here. You will receive half your HP and MP.
        // <summary>
        MissionContinueHalfHpMp = 569,
        // <summary>
        // Continue here? It's free up to and including level 20.
        // <summary>
        ContinueHereFree = 570,
        // <summary>
        // Continue here? You'll need 10 Seeds of Power.
        // <summary>
        ContinueHereTenSeeds = 571,
        // <summary>
        // Continue here? You'll need 2 Seeds of Power.
        // <summary>
        ContinueHereTwoSeeds = 572,
        // <summary>
        // No event period.
        // <summary>
        NoEventPeriod = 573,
        // <summary>
        // Not the subject of the current event.
        // <summary>
        NotSubjectCurrentEvent = 574,
        // <summary>
        // Already recommended.
        // <summary>
        AlreadyRecommended = 575,
        // <summary>
        // Enter correct character name.
        // <summary>
        EnterCorrectName = 576,
        // <summary>
        // Change family authority:
        // <summary>
        ChangeFamilyAuthority = 577,
        // <summary>
        // Authority to change family keeper.
        // <summary>
        AuthorityToChangeKeeper = 578,
        // <summary>
        // Authority to invite players.
        // <summary>
        AuthorityToInvite = 579,
        // <summary>
        // Authority to use Level 1 Warehouse.
        // <summary>
        AuthorityToUseLevelOneWarehouse = 580,
        // <summary>
        // Authority to use Level 2 Warehouse.
        // <summary>
        AuthorityToUseLevelTwoWarehouse = 581,
        // <summary>
        // Authority to use a safe.
        // <summary>
        AuthorityToUseSafe = 582,
        // <summary>
        // Authority to change notice.
        // <summary>
        AuthorityToChangeNotice = 583,
        // <summary>
        // Authority to change family shout
        // <summary>
        AuthorityToChangeFamilyShout = 584,
        // <summary>
        // Deprivation
        // <summary>
        Deprivation = 585,
        // <summary>
        // Allowance
        // <summary>
        Allowance = 586,
        // <summary>
        // The family head has given you a title.
        // <summary>
        FamilyHeadGiveTitle = 587,
        // <summary>
        // Signposts can only be set up in NosVille.
        // <summary>
        SignPostOnlyNosville = 588,
        // <summary>
        // Parcel sent successfully.
        // <summary>
        ParcelSentSuccessfully = 589,
        // <summary>
        // Parcel arrived.
        // <summary>
        ParcelArrived = 590,
        // <summary>
        // Parcel can't be sent because the character's postbox is full.
        // <summary>
        ParcelNotSentBecauseBoxFull = 591,
        // <summary>
        // Parcel cannot be sent now. Try again later.
        // <summary>
        ParcelNotSent = 592,
        // <summary>
        // Some parcels were not dispatched. Try again later.
        // <summary>
        ParcelNotDispatched = 593,
        // <summary>
        // Parcel was sent successfully. Recipient is away.
        // <summary>
        ParcelSentSuccessfully2 = 594,
        // <summary>
        // %s's [Miniland]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UserMiniland = 595,
        // <summary>
        // You are the party master.
        // <summary>
        YouAreGroupLeader = 596,
        // <summary>
        // Party looting: Share as group
        // <summary>
        LootShareInGroup = 597,
        // <summary>
        // Party looting: Loot in turn
        // <summary>
        LootInTurn = 598,
        // <summary>
        // You are now the party master.
        // <summary>
        YouAreNowGroupLeader = 599,
        // <summary>
        // Could not receive reward. Inventory is full.
        // <summary>
        NoRewardInventoryFull = 600,
        // <summary>
        // Make sure you have a free slot in your inventory and try again.
        // <summary>
        EnsureFreeSlot = 601,
        // <summary>
        // Cannot be continued as a party.
        // <summary>
        CanNotContinueInGroup = 602,
        // <summary>
        // Can only be continued as a full party.
        // <summary>
        CanNotContinueWithoutFullGroup = 603,
        // <summary>
        // You can only enter together if your party members are nearby.
        // <summary>
        GroupMemberHaveToBeNearby = 604,
        // <summary>
        // %d Gold is required to challenge a record. Do you want to try it?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        GoldRequiredToChallengeRecord = 605,
        // <summary>
        // Do you want to transform into a specialist?
        // <summary>
        AskTransformSpecialist = 606,
        // <summary>
        // Amulet of Reinforcing was used for fixed levels.
        // <summary>
        AmuletReinforcingUsedFixedLevels = 607,
        // <summary>
        // Hidden Time-Space Stone hasn't been found.
        // <summary>
        HiddenTimeSpaceStoneNotFound = 608,
        // <summary>
        // Your dowsing data has been reset because your exploration was completed by entering the map.
        // <summary>
        DowsingDataResetExplorationCompleted = 609,
        // <summary>
        // You must be on a Time-Space mission to chat in a Time-Space.
        // <summary>
        YouMustBeInTimeSpaceToTimeSpaceChat = 610,
        // <summary>
        // Mission has disappeared and Accompany is not possible.
        // <summary>
        MissionDisappearedAccompanyImpossible = 611,
        // <summary>
        // The mission has already started so you cannot join anymore.
        // <summary>
        MissionAlreadyStarted2 = 612,
        // <summary>
        // %s declined to be accompanied.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        DeclinedAccompanied = 613,
        // <summary>
        // A party with completed dowsing exploration cannot accept others with different results.
        // <summary>
        CompletedDowsingExplorationCannotAcceptOthers = 614,
        // <summary>
        // Party cannot consist of characters who had already completed the exploration.
        // <summary>
        PartyCannotConsistCharactersAlreadyCompleted = 615,
        // <summary>
        // Your dowsing data has been reset.
        // <summary>
        DowsingDataReset = 616,
        // <summary>
        // Time required: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TimeRequired = 617,
        // <summary>
        // No quest for your level.
        // <summary>
        NoQuestForYourLevel = 618,
        // <summary>
        // Hidden Time-Space Stone has already been created.
        // <summary>
        HiddenTimeSpaceStoneCreated = 619,
        // <summary>
        // You have to find the location by using a Dowsing Rod.
        // <summary>
        FindLocationDowsingRod = 620,
        // <summary>
        // - has created a Time-Space Stone.
        // <summary>
        HasCreatedTimeSpaceStone = 621,
        // <summary>
        // Time-Space Stone created in another map.
        // <summary>
        TimeSpaceStoneCreatedAnotherMap = 622,
        // <summary>
        // The Hidden Time-Space Stone has been created.
        // <summary>
        TimeSpaceStoneCreated = 623,
        // <summary>
        // Incorrect place to create Time-Space Stone.
        // <summary>
        TimeSpaceStoneIncorrectPlace = 624,
        // <summary>
        // Dowsing Rod can only be used on an ordinary map.
        // <summary>
        DowsingRodOnlyOrdinaryMap = 625,
        // <summary>
        // Accompany
        // <summary>
        Accompany = 626,
        // <summary>
        // Cannot request to accompany once a mission has started.
        // <summary>
        CannotRequestAccompanyStartedMission = 627,
        // <summary>
        // You have to complete it by yourself.
        // <summary>
        CompleteByYourself = 628,
        // <summary>
        // The others are too far away to help you.
        // <summary>
        OtherTooFarAway = 629,
        // <summary>
        // From current location
        // <summary>
        FromCurrentLocation = 630,
        // <summary>
        // You cannot have any more party members.
        // <summary>
        GroupFull = 631,
        // <summary>
        // Will you accept the request from %s to accompany them?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AcceptRequestAccompany = 632,
        // <summary>
        // Company was requested.
        // <summary>
        CompanyRequested = 633,
        // <summary>
        // Insufficient bolts. Buy some in the equipment shop.
        // <summary>
        NotEnoughBolts = 634,
        // <summary>
        // Insufficient arrows. Buy some in the equipment shop.
        // <summary>
        NotEnoughArrows = 635,
        // <summary>
        // This is not an event period.
        // <summary>
        NotEventPeriod = 636,
        // <summary>
        // Player already belongs to another party.
        // <summary>
        PlayerAlreadyGroup = 637,
        // <summary>
        // Bolts reloaded.
        // <summary>
        BoltsReloaded = 638,
        // <summary>
        // Arrows reloaded.
        // <summary>
        ArrowsReloaded = 639,
        // <summary>
        // This item cannot be used in PvP mode.
        // <summary>
        CanNotUseInPvp = 640,
        // <summary>
        // Dowsing info from the previous map was deleted.
        // <summary>
        DowsingInfoFromPreviousMapDeleted = 641,
        // <summary>
        // The Hidden Time-Space Stone cannot be created on this map.
        // <summary>
        HiddenTimeSpaceStoneNotOnThisMap = 642,
        // <summary>
        // You have discovered an energy field.
        // <summary>
        DiscoveredEnergyField = 643,
        // <summary>
        // %s- has discovered an energy field.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UserHasDiscoveredEnergyField = 644,
        // <summary>
        // %s- has discovered an energy field on another map.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UserHasDiscoveredEnergyFieldOtherMap = 645,
        // <summary>
        // Cannot receive any signal because it's too far away.
        // <summary>
        SignalTooFarAway = 646,
        // <summary>
        // [Hidden Time-Space] of %s <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HiddenTimeSpaceOf = 647,
        // <summary>
        // [Parcel] %d of %s received. Sender:<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        ParcelReceivedFromSender = 648,
        // <summary>
        // Your postbox is full so you cannot receive any more parcels. Please empty it.
        // <summary>
        PostboxFull = 649,
        // <summary>
        // Capture successful! (Quest)
        // <summary>
        CaptureSuccessfulQuest = 650,
        // <summary>
        // Quest reward [%d Gold]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        QuestRewardGold = 651,
        // <summary>
        // Quest reward [Experience points]
        // <summary>
        QuestRewardExperience = 652,
        // <summary>
        // Quest reward [Job experience points]
        // <summary>
        QuestRewardJobExperience = 653,
        // <summary>
        // Quest reward [%s x %d]<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        QuestRewardItem = 654,
        // <summary>
        // Quest reward [Reputation %d]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        QuestRewardReputation = 655,
        // <summary>
        // No quest reward
        // <summary>
        NoQuestReward = 656,
        // <summary>
        // You cannot accept any more quests.
        // <summary>
        TooManyQuests = 657,
        // <summary>
        // This quest does not exist.
        // <summary>
        QuestDoesNotExist = 658,
        // <summary>
        // You've already accepted this quest.
        // <summary>
        AlreadyAccepedQuest = 659,
        // <summary>
        // Quest received from a party member.
        // <summary>
        QuestReceivedFromPartyMember = 660,
        // <summary>
        // Quest cancelled.
        // <summary>
        QuestCancelled = 661,
        // <summary>
        // Quest complete!
        // <summary>
        QuestComplete = 662,
        // <summary>
        // Move further ahead and try to explore.
        // <summary>
        MoveFurtherAheadAndExplore = 663,
        // <summary>
        // [%s] hunting:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Hunting = 664,
        // <summary>
        // [%s] collecting:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Collecting = 665,
        // <summary>
        // %s collected:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Collected = 666,
        // <summary>
        // %s delivered to:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Delivered = 667,
        // <summary>
        // [%s] captured:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Captured2 = 668,
        // <summary>
        // [%s] currently captured:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CurrentlyCaptured = 669,
        // <summary>
        // [%d Level ] Time-Space Stone complete<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TimeSpaceCompleted = 670,
        // <summary>
        // [%s] produced:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Produced = 671,
        // <summary>
        // [Increases the kills] :
        // <summary>
        IncreasesKills = 672,
        // <summary>
        // [Increases reputation] :
        // <summary>
        IncreasesReputation = 673,
        // <summary>
        // [Increases score] :
        // <summary>
        IncreasesScore = 674,
        // <summary>
        // There is no quest for your current level.
        // <summary>
        NoQuestLevel = 675,
        // <summary>
        // Reward may be limited in observer mode.
        // <summary>
        RewardLimitedObserverMode = 676,
        // <summary>
        // Reward for mission completion [%d Gold]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RewardForCompletion = 677,
        // <summary>
        // %d%% of points reduced because of level penalty.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PointsReducedLevelPenalty = 678,
        // <summary>
        // The enemies are getting reinforcements!
        // <summary>
        EnemiesReinforcements = 679,
        // <summary>
        // South
        // <summary>
        South = 680,
        // <summary>
        // North
        // <summary>
        North = 681,
        // <summary>
        // East
        // <summary>
        East = 682,
        // <summary>
        // West
        // <summary>
        West = 683,
        // <summary>
        // South East
        // <summary>
        SouthEast = 684,
        // <summary>
        // North East
        // <summary>
        NorthEast = 685,
        // <summary>
        // South West
        // <summary>
        SouthWest = 686,
        // <summary>
        // North West
        // <summary>
        NorthWest = 687,
        // <summary>
        // [Piece] %d of %s<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        PieceOfItem = 688,
        // <summary>
        // Equipment
        // <summary>
        Equipment = 689,
        // <summary>
        // Main
        // <summary>
        Main = 690,
        // <summary>
        // Others
        // <summary>
        Others = 691,
        // <summary>
        // Structure
        // <summary>
        Structure = 692,
        // <summary>
        // Transformation is not possible when you transform into a Specialist.
        // <summary>
        TransformationImpossibleWhenTransformingIntoSpecialist = 693,
        // <summary>
        // Defeating adventurers of level 20 or lower does not count.
        // <summary>
        DefeatingAdventurerLevelTwentyDoesNotCount = 694,
        // <summary>
        // Defeating adventurers of level 10 or lower does not count.
        // <summary>
        DefeatingAdventurerLevelTenDoesNotCount = 695,
        // <summary>
        // Reputation increased: +%d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReputationIncreased = 696,
        // <summary>
        // Dignity increased: +%d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        DignityIncreased = 697,
        // <summary>
        // Dignity reduced: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        DignityReduced = 698,
        // <summary>
        // Dignity is at maximum.
        // <summary>
        DignityMaximum = 699,
        // <summary>
        // Dignity is at minimum.
        // <summary>
        DignityMinimum = 700,
        // <summary>
        // You cannot bring any NosMates because your dignity is too low.
        // <summary>
        DignityTooLawForNosmate = 701,
        // <summary>
        // Dignity has been increased.
        // <summary>
        DignityIncreases = 702,
        // <summary>
        // A problem with the price!
        // <summary>
        ProblemWithPrice = 703,
        // <summary>
        // Some items cannot be traded.
        // <summary>
        SomeItemsCannotBeTraded = 704,
        // <summary>
        // Specialist Cards cannot be traded during the transformation.
        // <summary>
        SpecialistCardsCannotBeTradedWhileTransformed = 705,
        // <summary>
        // Adventurers cannot wear Specialist Cards.
        // <summary>
        AdventurerCannotWearSpecialist = 706,
        // <summary>
        // Cannot be worn it because the job is different.
        // <summary>
        CanNotBeWornDifferentClass = 707,
        // <summary>
        // Cannot be worn because job level is too low.
        // <summary>
        CanNotBeWornLowJobLevel = 708,
        // <summary>
        // Cannot be worn because reputation level is too low.
        // <summary>
        CanNotBeWornReputationLow = 709,
        // <summary>
        // Removing the Specialist Card costs 1,000 SP. Continue?
        // <summary>
        RemovingSpecialistCardCostsOneThousandSpecialistPointQuestion = 710,
        // <summary>
        // Not in correct status to use this item.
        // <summary>
        StatusIncorrectToUseItem = 711,
        // <summary>
        // Only available on general maps.
        // <summary>
        OnlyAvailableOnGeneralMap = 712,
        // <summary>
        // Adventurers cannot receive Specialist Cards.
        // <summary>
        AdventurerCannotReceiveSpecialist = 713,
        // <summary>
        // This quest does not match the level.
        // <summary>
        QuestDoesNotMatchLevel = 714,
        // <summary>
        // The mission starts as soon as you enter the first room.
        // <summary>
        MissionStartWhenEnterFirstRoom = 715,
        // <summary>
        // %d Gold is required to enter. Continue?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        GoldRequiredToEnterQuestion = 716,
        // <summary>
        // Player is not qualified to complete here.
        // <summary>
        PlayerNotQualifiedToEnterHere = 717,
        // <summary>
        // No Specialist Card equipped.
        // <summary>
        NoSpecialistCardEquipped = 718,
        // <summary>
        // Put on Name Tag.
        // <summary>
        PutNameTag = 719,
        // <summary>
        // Accessory already worn.
        // <summary>
        AccessoryAlreadyWorn = 720,
        // <summary>
        // Raw materials missing.
        // <summary>
        RawMaterialsMissing = 721,
        // <summary>
        // Event item received.
        // <summary>
        EventItemReceived = 722,
        // <summary>
        // Hiding will be cancelled after attacking.
        // <summary>
        HidingCancelAfterAttacking = 723,
        // <summary>
        // Hiding will be cancelled after being attacked.
        // <summary>
        HidingCancelAfterBeingAttacked = 724,
        // <summary>
        // PvP is now available.
        // <summary>
        PvpAvailable = 725,
        // <summary>
        // Continue here? %d Gold will be required.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ContinueGoldRequired = 726,
        // <summary>
        // Cannot be used because it exceeds the capacity.
        // <summary>
        CannotBeUsedExceedsCapacity = 727,
        // <summary>
        // Basic specialist points increased by %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        BasicSpecialistPointsIncreased = 728,
        // <summary>
        // You have 0 specialist points. Transformation cancelled.
        // <summary>
        ZeroPointsTransformationCancelled = 729,
        // <summary>
        // Transformation side effects are gone.
        // <summary>
        TransformationSideEffectGone = 730,
        // <summary>
        // Cannot form group because your dignity level is too low.
        // <summary>
        DignityTooLowForGroup = 731,
        // <summary>
        // You can ot capture because your dignity level is low.
        // <summary>
        DignityTooLowToCapture = 732,
        // <summary>
        // Pet trained.
        // <summary>
        PetTrained = 733,
        // <summary>
        // The pet feels gloomy and rejects the food.
        // <summary>
        ThePetRejectedFood = 734,
        // <summary>
        // Pet force fed.
        // <summary>
        PetForceFed = 735,
        // <summary>
        // The pet is happy with the food.
        // <summary>
        PetHappyWithFood = 736,
        // <summary>
        // Played with the pet.
        // <summary>
        PlayedWithPet = 737,
        // <summary>
        // Mood
        // <summary>
        Mood = 738,
        // <summary>
        // Health
        // <summary>
        Health = 739,
        // <summary>
        // Exercise
        // <summary>
        Exercise = 740,
        // <summary>
        // Patience
        // <summary>
        Patience = 741,
        // <summary>
        // Spirit
        // <summary>
        Spirit = 742,
        // <summary>
        // Judging
        // <summary>
        Judging = 743,
        // <summary>
        // Satisfaction
        // <summary>
        Satisfaction = 744,
        // <summary>
        // Disease
        // <summary>
        Disease = 745,
        // <summary>
        // Point
        // <summary>
        Point = 746,
        // <summary>
        // increases: +%d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Increases = 747,
        // <summary>
        // decreases: -%d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Decreases = 748,
        // <summary>
        // Already completing same quest type.
        // <summary>
        AlreadyCompletingSameQuestType = 749,
        // <summary>
        // Adventurers cannot receive Specialist Cards.
        // <summary>
        AdventurersCannotReceiveSpecialistCards = 750,
        // <summary>
        // Received Specialist Card.
        // <summary>
        ReceivedSpecialistCard = 751,
        // <summary>
        // Your specialist has reached the highest level.
        // <summary>
        SpecialistMaxLevelReached = 752,
        // <summary>
        // Specialist level increased.
        // <summary>
        SpecialistLevelIncreased = 753,
        // <summary>
        // Duration of transformation side effects: %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        DurationOfSideEffect = 754,
        // <summary>
        // Not enough points. Cannot remove Specialist Card.
        // <summary>
        NotEnoughPointsToRemoveSpecialist = 755,
        // <summary>
        // No specialist points.
        // <summary>
        NoSpecialistPoints = 756,
        // <summary>
        // Cannot transform because of bad effect.
        // <summary>
        CanNotTransformBadEffect = 757,
        // <summary>
        // Cannot transform. Job level is insufficient.
        // <summary>
        CanNotTransformJobLevel = 758,
        // <summary>
        // Cannot transform. Reputation level is insufficient.
        // <summary>
        CanNotTransformReputation = 759,
        // <summary>
        // Adventurers cannot transform into specialists.
        // <summary>
        CanNotTransformAdventurer = 760,
        // <summary>
        // This specialist doesn't match your job.
        // <summary>
        CanNotTransformBadClass = 761,
        // <summary>
        // Cannot transform because of transformation side effects: %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CantTrasformWithSideEffect = 762,
        // <summary>
        // Can be transformed once the cooldown of all skills is complete.
        // <summary>
        CanTransformWithCooldownComplete = 763,
        // <summary>
        // Cannot transform while using skill.
        // <summary>
        CantTransfromWhileUsingSkill = 764,
        // <summary>
        // Cannot cancel transformation while using skill.
        // <summary>
        CantCancelWhileUsingSkill = 765,
        // <summary>
        // Cannot reverse transformation because of bad effect.
        // <summary>
        CantReverseWithBadEffect = 766,
        // <summary>
        // Reinforcements have arrived!
        // <summary>
        ReinforcementsArrived = 767,
        // <summary>
        // %s has reached the maximum level.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ReachedMaxLeve = 768,
        // <summary>
        // %s has levelled up.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HasLevelledUp = 769,
        // <summary>
        // %s feels normal again.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FeelNormal = 770,
        // <summary>
        // %s feels good again.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FeelGoodAgain = 771,
        // <summary>
        // %s feels better.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FeelBetter = 772,
        // <summary>
        // %s rummages through your food.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RummagesFood = 773,
        // <summary>
        // Hungry %s feels bad.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Hungry = 774,
        // <summary>
        // Cannot remove Specialist Card during transformation side effects: %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CantRemoveSpecialistWithSideEffect = 775,
        // <summary>
        // You cannot remove the Specialist Card because of a bad effect.
        // <summary>
        CantRemoveSpecialistWithBadEffect = 776,
        // <summary>
        // Teammate died: [%s]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TeammateDied = 777,
        // <summary>
        // Item %s has expired and disappeared.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ItemDisappeared = 778,
        // <summary>
        // Team member cannot enter Time-Space Stone.
        // <summary>
        PartyCantEnterTimeSpace = 779,
        // <summary>
        // Teammate cannot open the shop.
        // <summary>
        TeammateCanNotOpenShop = 780,
        // <summary>
        // Self-introduction registered.
        // <summary>
        SelfIntroductionRegistered = 781,
        // <summary>
        // Medal's usable period has been changed.
        // <summary>
        MedalUsablePeriodChanged = 782,
        // <summary>
        // No Wings of Friendship.
        // <summary>
        NoFriendshipWings = 783,
        // <summary>
        // Can only move on general fields.
        // <summary>
        CanOnlyMoveOnGeneralField = 784,
        // <summary>
        // Cannot move because friend is not on a general field.
        // <summary>
        CanNotMoveBecauseFriendNotOnGeneralField = 785,
        // <summary>
        // You cannot put Specialist Cards in the Card Holder while the transformation is in progress.
        // <summary>
        CanNotPutSpecialistInHolderWhileTransforming = 786,
        // <summary>
        // You have placed the Specialist Card in the Card Holder.
        // <summary>
        SpecialistInTheHolder = 787,
        // <summary>
        // Your partner is now in the bead.
        // <summary>
        PartnerIsNowInBead = 788,
        // <summary>
        // Pet is now in the bead.
        // <summary>
        PetIsNowInBead = 789,
        // <summary>
        // The Specialist Card has been removed from the Card Holder.
        // <summary>
        SpecialistOutOfHolder = 790,
        // <summary>
        // Partner is coming out of the bead.
        // <summary>
        PartnerOutOfBead = 791,
        // <summary>
        // Pet is coming out of the bead.
        // <summary>
        PetOutOfBead = 792,
        // <summary>
        // Can start with at least 5 teammates.
        // <summary>
        NeedFiveTeammates = 793,
        // <summary>
        // Left %s team because you were not at the map starting point.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        NotAtTheStartPoint = 794,
        // <summary>
        // Failed because the team leader left.
        // <summary>
        LeaderLeftTeam1 = 795,
        // <summary>
        // %s has left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerLeftTeam1 = 796,
        // <summary>
        // Cannot form a party as a team member.
        // <summary>
        CantPartyAsTeamMember = 797,
        // <summary>
        // The player is a member of a raid team.
        // <summary>
        PlayerIsRaidMember = 798,
        // <summary>
        // Currently purchasing. Wait.
        // <summary>
        Purchasing = 799,
        // <summary>
        // This item cannot be sold.
        // <summary>
        CannotBeSold = 800,
        // <summary>
        // %s has logged in.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerLoggedIn = 801,
        // <summary>
        // Current NosDollars: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NosdolarAmount = 802,
        // <summary>
        // Thanks for your purchase in the NosMall.#13#10The following package is ready for collection
        // <summary>
        ThanksPurchaseInNosmall = 803,
        // <summary>
        // Purchase failed: Check NosDollar balance.
        // <summary>
        PurchaseFailedCheckBalance = 804,
        // <summary>
        // Purchase failed: Try again later.
        // <summary>
        PurchaseFailed = 805,
        // <summary>
        // Send the gift to %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SendGift = 806,
        // <summary>
        // Gift has been delivered.
        // <summary>
        GiftDelivered = 807,
        // <summary>
        // %s' is currently resting.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CurrentlyResting = 808,
        // <summary>
        // Cannot find '%s'.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CantFind = 809,
        // <summary>
        // Cannot find the player.
        // <summary>
        CanNotFindPlayer = 810,
        // <summary>
        // NosMall is currently undergoing maintenance. Please contact the admin.
        // <summary>
        NosMallMaintenance = 811,
        // <summary>
        // A bug report requires the name and number of the item.
        // <summary>
        BugReportInfo = 812,
        // <summary>
        // Note has been sent.
        // <summary>
        NoteSent = 813,
        // <summary>
        // Note has been deleted.
        // <summary>
        NoteDeleted = 814,
        // <summary>
        // Note option changed to 'Open to All'.
        // <summary>
        NoteOptionOpenToAll = 815,
        // <summary>
        // Note option changed to 'Open to Friends only'.
        // <summary>
        NoteOptionOpenToFriendsOnly = 816,
        // <summary>
        // Note option changed to 'Closed to All'.
        // <summary>
        NoteOptionClosedToAll = 817,
        // <summary>
        // Structures being used cannot be sent.
        // <summary>
        StructuresBeingUsed = 818,
        // <summary>
        // That item does not exist.
        // <summary>
        ItemDoesNotExist = 819,
        // <summary>
        // Parcel does not contain any items.
        // <summary>
        ParcelEmpty = 820,
        // <summary>
        // Number of teammates (%d/15)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TeammatesNumber = 821,
        // <summary>
        // Do you want to join %s's team?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskJoinToTeam = 822,
        // <summary>
        // Joined %s's team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        JoinedToTeam = 823,
        // <summary>
        // %s has joined the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerJoinedToTeam = 824,
        // <summary>
        // You cannot leave your own team.
        // <summary>
        CantLeaveYourTeam = 825,
        // <summary>
        // Do you want to leave %s's team?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskLeaveTeam = 826,
        // <summary>
        // %s has left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerHasLeftTeam = 827,
        // <summary>
        // Do you want to kick %s from the team?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskKickPlayerFromTeam = 828,
        // <summary>
        // %s kicked from the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerKickedFromTeam = 829,
        // <summary>
        // You were kicked from %s's team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        YouKickedFromTeam = 830,
        // <summary>
        // Disband team?
        // <summary>
        DisbandTeam = 831,
        // <summary>
        // %s's team was disbanded.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UserTeamDisbanded = 832,
        // <summary>
        // No self-introduction message.
        // <summary>
        NoIntroMessage = 833,
        // <summary>
        // %d new note(s) have arrived.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NewNoteArrived = 834,
        // <summary>
        // %d new parcels have arrived.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NewParcelArrived = 835,
        // <summary>
        // Postbox for parcels is full. Check your postbox and collect Time-Space Stone and Quest rewards. Remaining parcels %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ParcelIsFull = 836,
        // <summary>
        // Left the team because you died.
        // <summary>
        DiedAndLeftTeam = 837,
        // <summary>
        // Failed because the team leader died.
        // <summary>
        TeamLeaderDied = 838,
        // <summary>
        // %s has left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TeamPlayerDied = 839,
        // <summary>
        // You are already using this medal. Do you want to extend it?
        // <summary>
        AskExtendMedal = 840,
        // <summary>
        // Medal of Erenia effect activated.
        // <summary>
        EreniaMedalActivated = 841,
        // <summary>
        // You are already using this medal. Would you like to extend the duration of the effect?
        // <summary>
        ExtendMedal = 842,
        // <summary>
        // Adventurer's Medal effect activated.
        // <summary>
        AdventurerMedalActivated = 843,
        // <summary>
        // Already Raid Leader.
        // <summary>
        AlreadyRaidLeader = 844,
        // <summary>
        // Already member of the team.
        // <summary>
        AlreadyTeamMember = 845,
        // <summary>
        // Cannot form a team as a party member.
        // <summary>
        LeavePartyToFormTeam = 846,
        // <summary>
        // You are now the Raid Leader. Invite members.
        // <summary>
        YouAreRaidLeader = 847,
        // <summary>
        // You cannot put Specialist Cards in the Card Holder while the transformation is in progress.
        // <summary>
        CantPutSpecialistInHolderWhileTransformed = 848,
        // <summary>
        // Do you want to put the Specialist Card in the Card Holder?
        // <summary>
        AskPutSpecialistInHolder = 849,
        // <summary>
        // Do you want to remove the Specialist Card?
        // <summary>
        AskRemoveSpecialist = 850,
        // <summary>
        // Only possible in Miniland.
        // <summary>
        MinilandOnly = 851,
        // <summary>
        // Cannot put NosMate in the bead.
        // <summary>
        CanNotPutNosmateInBead = 852,
        // <summary>
        // Put the pet in the bead?
        // <summary>
        AskPutNosmateInBead = 853,
        // <summary>
        // Remove the pet from the bead?
        // <summary>
        AskRemovePetFromBead = 854,
        // <summary>
        // You can put the partner in the bead after disarming it.
        // <summary>
        DisarmPetToBeadHim = 855,
        // <summary>
        // Put the partner in the bead?
        // <summary>
        AskPutPartnerToBead = 856,
        // <summary>
        // Remove the partner from the bead?
        // <summary>
        AskRemovePartnerFromBead = 857,
        // <summary>
        // Medal of Erenia expired. Effect deactivated.
        // <summary>
        MedalEreniaExpired = 858,
        // <summary>
        // Adventurer's Medal expired. Effect deactivated.
        // <summary>
        AdventurerMedalExpired = 859,
        // <summary>
        // Cannot set up NosMates whose level is higher than the player's.
        // <summary>
        CantSetNosmateWithHigherLevel = 860,
        // <summary>
        // Leader %s has left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        LeaderLeftTeam2 = 861,
        // <summary>
        // %s has left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerLeftTeam2 = 862,
        // <summary>
        // Note's recipient is not your friend.
        // <summary>
        NoteRecipientNotYourFriend = 863,
        // <summary>
        // The player is rejecting notes.
        // <summary>
        PlayerRejectingNote = 864,
        // <summary>
        // Cannot delete notes which are being sent.
        // <summary>
        NoteBeingSentCantDelete = 865,
        // <summary>
        // New note has arrived.
        // <summary>
        NewNoteArrived2 = 866,
        // <summary>
        // Remaining time of %s is %d minutes.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        RemainingTimeMinutes = 867,
        // <summary>
        // Remaining time of %s is %d hours.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        RemainingTimeHours = 868,
        // <summary>
        // Remaining time of %s is %d days.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        RemainingTimeDays = 869,
        // <summary>
        // Item is already on Wish List.
        // <summary>
        ItemIsOnWishList = 870,
        // <summary>
        // You can have up to 10 items on your Wish List.
        // <summary>
        MaxTenItemsOnWishList = 871,
        // <summary>
        // You cannot receive quest rewards. Not enough space in your inventory and postbox.
        // <summary>
        NoSpaceForQuestReward = 872,
        // <summary>
        // Adventure successful!!!
        // <summary>
        AdventureSuccessful = 873,
        // <summary>
        // A new parcel has arrived.
        // <summary>
        NewParcelArrived2 = 874,
        // <summary>
        // This character name is already in use.#13#10Please choose a different one.
        // <summary>
        CharacterNameAlreadyTaken = 875,
        // <summary>
        // Failed to create character name. Please try again.
        // <summary>
        InvalidCreateCharacterName = 876,
        // <summary>
        // Failed to change character name. Please try again.
        // <summary>
        InvalidUpdateCharacterName = 877,
        // <summary>
        // Trade failed because shop owner has too much money.
        // <summary>
        TradeFailedMaxMoney = 878,
        // <summary>
        // Could not be sold because you have too much Gold.
        // <summary>
        CantSoldMaxGold = 879,
        // <summary>
        // Will be revived in 10 seconds.
        // <summary>
        ReviveSoon = 880,
        // <summary>
        // A team must first be created for the raid.
        // <summary>
        CreateTeamFirst = 881,
        // <summary>
        // Team leader must lead the raid.
        // <summary>
        LeaderMustLeadRaid = 882,
        // <summary>
        // The raid does not match the seal.
        // <summary>
        RaidDoNotMatchSeal = 883,
        // <summary>
        // Do you want to create the raid map?
        // <summary>
        AskCreateRaidMap = 884,
        // <summary>
        // Raid members cannot trade.
        // <summary>
        RaidMembersCannotTrade = 885,
        // <summary>
        // You cannot trade with a raid member.
        // <summary>
        CantTradeRaidMember = 886,
        // <summary>
        // Check your current values.
        // <summary>
        CheckValues = 887,
        // <summary>
        // Received %s item.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ReceivedItem = 888,
        // <summary>
        // Can only be used on general maps.
        // <summary>
        OnlyUseOnGeneralMap = 889,
        // <summary>
        // Already member of another team.
        // <summary>
        AlreadyMemberOfAnotherTeam = 890,
        // <summary>
        // Cannot accept party members as team members.
        // <summary>
        PartyMembersNotAllowedToBeTeamMembers = 891,
        // <summary>
        // Cannot join the team as a party member.
        // <summary>
        LeavePartyToJoinTeam = 892,
        // <summary>
        // You cannot receive the treasure chest because your level is higher than the required level for this raid.
        // <summary>
        LevelTooHighToReceiveTreasureChest = 893,
        // <summary>
        // %s joined as a helper, because their level is higher than the raid's recommended level.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerXJoinedAsHelperBecauseOfHighLevel = 894,
        // <summary>
        // Helpers are not included in lives or rewards.
        // <summary>
        HelpersNotAllowedToReceiveRewards = 895,
        // <summary>
        // The team is full.
        // <summary>
        TeamIsFull = 896,
        // <summary>
        // The team was disbanded.
        // <summary>
        TeamDisbanded = 897,
        // <summary>
        // Do you want to send %d parcels to %s?<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        AskSendParcel = 898,
        // <summary>
        // Died during Icebreaker and returned to the village.
        // <summary>
        DiedOnIcebreakerReturned = 899,
        // <summary>
        // Open the treasure chest?
        // <summary>
        OpenChestQuestion = 900,
        // <summary>
        // Received raid box.
        // <summary>
        RaidBoxReceived = 901,
        // <summary>
        // This Time-Space Stone does not exist.
        // <summary>
        TimespaceDoesNotExist = 902,
        // <summary>
        // Cannot capture in this area.
        // <summary>
        CanNotCaptureHere = 903,
        // <summary>
        // Time's up!
        // <summary>
        TimesUp = 904,
        // <summary>
        // [%s's team] has successfully completed the %s raid.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        TeamCompletedRaid = 905,
        // <summary>
        // has successfully completed the %s raid.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CompletedRaid = 906,
        // <summary>
        // Can be used later.
        // <summary>
        CanBeUsedLater = 907,
        // <summary>
        // Already highest level.
        // <summary>
        AlreadyHighestLevel = 908,
        // <summary>
        // Cannot be done because of low level.
        // <summary>
        TooLowLevel = 909,
        // <summary>
        // Cannot be done because of high level.
        // <summary>
        TooHighLevel = 910,
        // <summary>
        // Cannot be done because of low act.
        // <summary>
        TooLowAct = 911,
        // <summary>
        // You quest progress is insufficient to enter.
        // <summary>
        QuestProgessInsufficientToProceed = 912,
        // <summary>
        // Some Time-Space Stones have not been completed.
        // <summary>
        SomeTimeSpaceStonesNotDone = 913,
        // <summary>
        // Mission failed %d times and can be attempted in Loser Mode.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        LoserModeAvailable = 914,
        // <summary>
        // (Familyhead)
        // <summary>
        Familyhead = 915,
        // <summary>
        // (Familydeputy)
        // <summary>
        Familydeputy = 916,
        // <summary>
        // (Familykeeper)
        // <summary>
        Familykeeper = 917,
        // <summary>
        // (Member)
        // <summary>
        Member = 918,
        // <summary>
        // Woahh!!!! Woahhh!!!!
        // <summary>
        WoahhWoahhh = 919,
        // <summary>
        // Grrrrrrrrrrr...
        // <summary>
        Grrrrrrrrrrr = 920,
        // <summary>
        // Kwak!! Kweak!!
        // <summary>
        KwakKweak = 921,
        // <summary>
        // Booo...Booo...
        // <summary>
        BoooBooo = 922,
        // <summary>
        // Keee!!! Keeee!!!!
        // <summary>
        KeeeKeeee = 923,
        // <summary>
        // Open shop away from the portal.
        // <summary>
        OpenShopAwayPortal = 924,
        // <summary>
        // Items being traded cannot be worn.
        // <summary>
        CanNotWearItemInTrade = 925,
        // <summary>
        // Team members cannot use the Time Circle.
        // <summary>
        TeamMembersCanNotUseTimeCircle = 926,
        // <summary>
        // You broke the record score.
        // <summary>
        BrokeRecordScore = 927,
        // <summary>
        // Enter fewer than 120 characters.
        // <summary>
        EnterFewerCharacter = 928,
        // <summary>
        // <Total> [
        // <summary>
        Total = 929,
        // <summary>
        // Cannot join the party because Secret Partner is in a party.
        // <summary>
        CannotJoinPartyBecauseSecretPartnerInside = 930,
        // <summary>
        // Secret Partner is not online.
        // <summary>
        SecretPartnerOffline = 931,
        // <summary>
        // Use the Time-Space Stone after meeting your Secret Partner.
        // <summary>
        UseTimeSpaceAfterMeetingPartner = 932,
        // <summary>
        // You are not qualified to enter the Secret Partner Time-Space Stone.
        // <summary>
        NotAbleToEnterSecretPartnerTimeSpace = 933,
        // <summary>
        // Team members cannot use Arena.
        // <summary>
        TeamMembersCantUseArena = 934,
        // <summary>
        // In a party with your Secret Partner, all experience points will be increased by 10%%.
        // <summary>
        InAPartyWithParnerTenPercentExperience = 935,
        // <summary>
        // Cannot have Secret Partners because %s rejected it.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CannotHavePartner = 936,
        // <summary>
        // Already registered as a friend.
        // <summary>
        RegisteredAsFriend = 937,
        // <summary>
        // You cannot make any more friends because you have already reached the maximum 50 friends.
        // <summary>
        MaxFriendReachedAdd = 938,
        // <summary>
        // You cannot be a friend any more. You already have 50 friends.
        // <summary>
        MaxFriendReached = 939,
        // <summary>
        // %s currently has %d/2 Secret Partners.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        TwoSecretPartner = 940,
        // <summary>
        // %s has Secret Partners already.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HasSecretParnerAlready = 941,
        // <summary>
        // %s already has 2 Secret Partners.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AlreadyTwoSecretPartner = 942,
        // <summary>
        // Friend is not online
        // <summary>
        FriendOffline = 943,
        // <summary>
        // Congratulations! You become a Secret Partner of %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        BecomedSecretPartner = 944,
        // <summary>
        // To cancel 'Secret Partner', type the command ' cancel Secret Partner'. You can only cancel it before completing the first Time-Space Mission.
        // <summary>
        CancelSecretPartnerHelp = 945,
        // <summary>
        // In a party with your Secret Partner, all experience points will be increased by 10%%.
        // <summary>
        InPartyWithSecretPartner = 946,
        // <summary>
        // Do you want to be %s's Secret Partner?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskSecretPartner = 947,
        // <summary>
        // To cancel Secret Partners, type the command 'cancel secret partner'.
        // <summary>
        CancelSecretPartnerHelp2 = 948,
        // <summary>
        // Only new Secret Partners can be cancelled.
        // <summary>
        OnlySecretPartnersCancelable = 949,
        // <summary>
        // Secret Partner was cancelled: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SecretPartnerCancelled = 950,
        // <summary>
        // %s is not a Secret Partner any more.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        NotSecretPartnerAnymore = 951,
        // <summary>
        // Secret Partner
        // <summary>
        SecretPartner = 952,
        // <summary>
        // Cancel
        // <summary>
        Cancel = 953,
        // <summary>
        // Only new players with Secret Partners can use it.
        // <summary>
        NeedSecretPartnerToUse = 954,
        // <summary>
        // Cannot cancel Secret Partner because mission was completed.
        // <summary>
        CannotCancelSecretPartner = 955,
        // <summary>
        // Cancel Secret Partnership with %s?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CancelSecretPartnership = 956,
        // <summary>
        // Received event item %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ReceivedEventItem = 957,
        // <summary>
        // Adventurer's Medal effect persists.
        // <summary>
        AdventurerMedalEffectPersists = 958,
        // <summary>
        // Medal of Erenia effect persists.
        // <summary>
        MedalEreniaPersists = 959,
        // <summary>
        // Specialist Medal effect persists.
        // <summary>
        SpecialistMedalPersists = 960,
        // <summary>
        // %s can have a Secret Partner among the existing players.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CanHaveSecretPartnerAmmongPlayers = 961,
        // <summary>
        // %s already has a Secret Partner.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AlreadyHasSecretPartner = 962,
        // <summary>
        // %s can have %d Secret Partners from new players.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        CanHaveSecretPartnerFromNewPlayers = 963,
        // <summary>
        // %s has 2 Secret Partners.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HasTwoSecretPartner = 964,
        // <summary>
        // %s is online<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        IsOnline = 965,
        // <summary>
        // Do you want to start the Secret Partner Time-Space Stone? This will be entry number %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        StartSecretPartnerTimeSpaceStone = 966,
        // <summary>
        // Specialist Medal effect begins.
        // <summary>
        SpecialistMedal = 967,
        // <summary>
        // The mask doesn't match the partner.
        // <summary>
        MaskDoesNotMatchPartner = 968,
        // <summary>
        // You're already wearing the same skin.
        // <summary>
        AlreadyWearingSameMask = 969,
        // <summary>
        // Put partner in the bead? This will cause your partner's mask to disappear.
        // <summary>
        AskPartnerInBead = 970,
        // <summary>
        // Cannot create private Time-Space after forming a party.
        // <summary>
        NoPrivateTimespaceInParty = 971,
        // <summary>
        // Quest doesn't match Hidden Time-Space!
        // <summary>
        QuestDoesNotMatchHiddenTimeSpace = 972,
        // <summary>
        // Following item is required: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FollowingItemRequired = 973,
        // <summary>
        // It just doesn't work! Try again in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        DoesNotWorkRetryInSeconds = 974,
        // <summary>
        // You have received this item - %s x %d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        ReceivedThisItem = 975,
        // <summary>
        // Attempt failed!
        // <summary>
        AttemptFailed = 976,
        // <summary>
        // You cannot join Icebreaker once it has started!
        // <summary>
        CanNotJoinStartedIceBreaker = 977,
        // <summary>
        // MouseTrap deactivated
        // <summary>
        MouseTrapDeactivated = 978,
        // <summary>
        // MouseTrap activated
        // <summary>
        MouseTrapActivated = 979,
        // <summary>
        // Already completing a main quest.
        // <summary>
        AlreadyAMainQuest = 980,
        // <summary>
        // [%s] collected from Time-Space Stone:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CollectedFromTimeSpace = 981,
        // <summary>
        // The items to be delivered are insufficient.
        // <summary>
        InsufficientItemsToDelivery = 982,
        // <summary>
        // Talked to %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TalkedTo = 983,
        // <summary>
        // You're not wearing this item.
        // <summary>
        YouAreNotWearingItem = 984,
        // <summary>
        // Gold given to %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GoldGivenTo = 985,
        // <summary>
        // Learned Beginner Course for Physical Strength.
        // <summary>
        LearnedBeginnerCoursePhysicalStrength = 986,
        // <summary>
        // Learned Beginner Speed Course.
        // <summary>
        LearnedBeginnerSpeedCourse = 987,
        // <summary>
        // Learned Beginner Intelligence Development.
        // <summary>
        LearnedBeginnerIntelligenceDevelopment = 988,
        // <summary>
        // Learned Beginner HP Recovery.
        // <summary>
        LearnedBeginnerHPRecovery = 989,
        // <summary>
        // You've learned the basic skills!
        // <summary>
        BasicSkillsLearned = 990,
        // <summary>
        // Learned Strong Hit skill.
        // <summary>
        LearnedStrongHitSkill = 991,
        // <summary>
        // Received Adventurer's Uniform.
        // <summary>
        ReceivedAdventurerUniform = 992,
        // <summary>
        // Teleport now?
        // <summary>
        TeleportNow = 993,
        // <summary>
        // Received +1 Wooden Sword.
        // <summary>
        ReceivedWoodenSword = 994,
        // <summary>
        // Learned Strengthen Swing skill.
        // <summary>
        LearnedStrengthenSwingSkill = 995,
        // <summary>
        // Received Adventurer's Shoes of combination 3.
        // <summary>
        CombinationThreeAdventuerShoesReceived = 996,
        // <summary>
        // Received Delicious Lunch.
        // <summary>
        ReceivedDeliciousLunch = 997,
        // <summary>
        // Click the button at the bottom to search for new quests!
        // <summary>
        ClickButtonToSearachNewQuests = 998,
        // <summary>
        // You cannot abandon the main quest once started. Start anyway?
        // <summary>
        CannotAbandonMainQuest = 999,
        // <summary>
        // Quest already completed?
        // <summary>
        AskQuestAlreadyCompleted = 1000,
        // <summary>
        // Pyjama
        // <summary>
        Pyjama = 1001,
        // <summary>
        // Warrior
        // <summary>
        Warrior = 1002,
        // <summary>
        // Ninja
        // <summary>
        Ninja = 1003,
        // <summary>
        // Ranger
        // <summary>
        Ranger2 = 1004,
        // <summary>
        // Assassin
        // <summary>
        Assassin2 = 1005,
        // <summary>
        // Red Magician
        // <summary>
        RedMagician = 1006,
        // <summary>
        // Holy Mage
        // <summary>
        HolyMage = 1007,
        // <summary>
        // All party members
        // <summary>
        AllPartyMembers = 1008,
        // <summary>
        // Parcel sent.
        // <summary>
        ParcelSent = 1009,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1010 = 1010,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1011 = 1011,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1012 = 1012,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1013 = 1013,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1014 = 1014,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1015 = 1015,
        // <summary>
        // The player you want to give the Valentine's Day Gift to is not online.
        // <summary>
        ValentineIsNotOnline = 1016,
        // <summary>
        // %s- rejected the Valentine's Day gift.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerRejectedValentine = 1017,
        // <summary>
        // %s- has accepted the Valentine's Day gift.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerAcceptedValentine = 1018,
        // <summary>
        // %s's Valentine's Day Gift does not exist.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ValentineGiftNotExist = 1019,
        // <summary>
        // You can only declare your love to the other gender.
        // <summary>
        NowCanDeclareLove = 1020,
        // <summary>
        // Do you want to accept %s's Valentine's Day Gift?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskAcceptValentine = 1021,
        // <summary>
        // %s has been asked to accept the gift.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskedToAcceptGift = 1022,
        // <summary>
        // Sniff!
        // <summary>
        Sniff = 1023,
        // <summary>
        // Sob! Snivel!
        // <summary>
        SobSnivel = 1024,
        // <summary>
        // Sob! Boohoohoo! Snivel!
        // <summary>
        SobBoohoohooSnivel = 1025,
        // <summary>
        // Try to give the Valentine's Day Gift to someone of the opposite gender.
        // <summary>
        ValentineDayGiftIsForOtherGender = 1026,
        // <summary>
        // %s effect activated<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        EffectActivated = 1027,
        // <summary>
        // Parcel received >> %s x %d <NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        ParcelReceived = 1028,
        // <summary>
        // Contains an invalid character. Choose another name.
        // <summary>
        InvalidCharacterInName = 1029,
        // <summary>
        // %s' : Cannot be purchased in the NosMall.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CantPurchasedFromNosmall = 1030,
        // <summary>
        // Error during purchase. Please contact the admin.
        // <summary>
        ErrorDuringPurchase = 1031,
        // <summary>
        // Can only be used if the target's HP is less than 20%.
        // <summary>
        CanBeUsedIfHpLessTwentyPercent = 1032,
        // <summary>
        // Cannot be tried with this monster any more.
        // <summary>
        CannotBeTriedWithThisMonsterAnymore = 1033,
        // <summary>
        // Missed. Cannot try on the same target again once failed.
        // <summary>
        CantTryOnSameTarget = 1034,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1035 = 1035,
        // <summary>
        // The server is undergoing maintenance.#13#10Please try again later.#13#10
        // <summary>
        ServerMaintenance = 1036,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1037 = 1037,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1038 = 1038,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1039 = 1039,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1040 = 1040,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1041 = 1041,
        // <summary>
        // The player you want to give the White Day Gift Box to is currently offline.
        // <summary>
        WhiteDayGiftBoxRecipientOffline = 1042,
        // <summary>
        // %s has rejected your gift.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RejectedGift = 1043,
        // <summary>
        // %s has accepted your gift.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AcceptedGift = 1044,
        // <summary>
        // %s's White Day Gift Box does not exist.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        WhiteDayGiftBoxDoesNotExist = 1045,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1046 = 1046,
        // <summary>
        // Do you wish to accept %s's White Day Gift Box?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskAcceptWhiteDayGiftBox = 1047,
        // <summary>
        // Cannot be raised any more with food.
        // <summary>
        CannotRaiseMoreWithFood = 1048,
        // <summary>
        // Your pet likes it a lot.
        // <summary>
        YourPetLikeItALot = 1049,
        // <summary>
        // Cannot be raised any more with medicine.
        // <summary>
        CannotRaiseMoreWithMedicine = 1050,
        // <summary>
        // Boosts the body's power!
        // <summary>
        BoostPower = 1051,
        // <summary>
        // Characters below level 10 cannot enter Mini-Land.
        // <summary>
        MiniLandFromTenLevel = 1052,
        // <summary>
        // This colour is already being used.
        // <summary>
        ColourUsed = 1053,
        // <summary>
        // This wax is already being used.
        // <summary>
        WaxUsed = 1054,
        // <summary>
        // Time-Space 1-4 and onwards will be launched in the Open Beta.
        // <summary>
        TimeSpaceOneToFourOnlyInBeta = 1055,
        // <summary>
        // A family can only be created in Channel 1.
        // <summary>
        CreateFamilyOnFirstChannel = 1056,
        // <summary>
        // The upgrade to the next level has failed. Items up to level 3 are protected.
        // <summary>
        UpgradeFailedUnderLevelThree = 1057,
        // <summary>
        // You have to complete a Main Quest first.
        // <summary>
        CompleteMainQuestFirst = 1058,
        // <summary>
        // In maintenance. Scheduled maintenance times can be found on the NosTale website.
        // <summary>
        InMaintenance = 1059,
        // <summary>
        // Version mismatch. Please install the new client.
        // <summary>
        VersionMismatch = 1060,
        // <summary>
        // This account is already in use.
        // <summary>
        AccountIsInUse = 1061,
        // <summary>
        // This is not a test account.
        // <summary>
        NotTestAccount = 1062,
        // <summary>
        // Connecting
        // <summary>
        Connecting = 1063,
        // <summary>
        // Playing is not allowed.
        // <summary>
        PlayingNotAllowed = 1064,
        // <summary>
        // Check username and password
        // <summary>
        CheckUsernameAndPassword = 1065,
        // <summary>
        // An error occurred while connecting. Please try again.
        // <summary>
        ErrorWithConnecting = 1066,
        // <summary>
        // Protection Scroll used
        // <summary>
        ProtectionScrollUsed = 1067,
        // <summary>
        // Gamble failed. The item survived thanks to the protection scroll.
        // <summary>
        GambleFailedButSurvived = 1068,
        // <summary>
        // Upgrade to next level failed. Item was protected by Protection Scroll.
        // <summary>
        UpgradeFailedButProtected = 1069,
        // <summary>
        // You cannot use the bank services while you have a private shop open.
        // <summary>
        NoBankInShop = 1070,
        // <summary>
        // You cannot use the bank services while trading.
        // <summary>
        NoBankExchange = 1071,
        // <summary>
        // You don't have enough Gold.
        // <summary>
        NotEnoughGold3 = 1072,
        // <summary>
        // You cannot deposit any more.
        // <summary>
        CanNotDepositAnymore = 1073,
        // <summary>
        // Insufficient funds.
        // <summary>
        NotEnoughFounds = 1074,
        // <summary>
        // You have exceeded the amount of Gold you may carry.
        // <summary>
        MaxGoldReached = 1075,
        // <summary>
        // Can only be used for fixed level weapons and equipment.
        // <summary>
        UseOnlyOnFixEquipment = 1076,
        // <summary>
        // This equipment level can be changed.
        // <summary>
        CanModifyEquipmentLevel = 1077,
        // <summary>
        // The level can be modified.
        // <summary>
        CanModifyLevel = 1078,
        // <summary>
        // The rarity level remains unchanged thanks to the protection scroll.
        // <summary>
        RarityUnchangedProtectionScroll = 1079,
        // <summary>
        // Send the message to '%s' in channel %d.<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        SendMessageToCharacterInChannel = 1080,
        // <summary>
        // <Channel: %d><NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Channel = 1081,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1082 = 1082,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1083 = 1083,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1084 = 1084,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1085 = 1085,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1086 = 1086,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1087 = 1087,
        // <summary>
        // You cannot hear the speaker from now on.
        // <summary>
        SpeakerDisabled = 1088,
        // <summary>
        // You can hear the speaker from now on.
        // <summary>
        SpeakerEnabled = 1089,
        // <summary>
        // Can only be separated from the partner in Miniland.
        // <summary>
        PartnerKickOnlyMiniland = 1090,
        // <summary>
        // You cannot separate from your partner when they are accompanying you.
        // <summary>
        CannotSeparateFromPartnerInTeam = 1091,
        // <summary>
        // Chicken
        // <summary>
        Chicken = 1092,
        // <summary>
        // Jajamaru
        // <summary>
        Jajamaru = 1093,
        // <summary>
        // '^' cannot be used in name
        // <summary>
        CaretCantBeUsed = 1094,
        // <summary>
        // Cannot be used on the normal map.
        // <summary>
        CantUseOnNormalMap = 1095,
        // <summary>
        // There is already a family member with the same name.
        // <summary>
        FamilyMemberWithSameName = 1096,
        // <summary>
        // You cannot accept characters who have opened a private shop.
        // <summary>
        CannotAcceptCharacterWhileShop = 1097,
        // <summary>
        // You cannot be a member while opening a private shop.
        // <summary>
        CannotBeMemberWhileShop = 1098,
        // <summary>
        // To delete the skill, all skill cooldowns must have reset.
        // <summary>
        SkillResetToDelete = 1099,
        // <summary>
        // The quests will come soon.
        // <summary>
        QuestSoon = 1100,
        // <summary>
        // The pet is becoming smart.
        // <summary>
        PetSmart = 1101,
        // <summary>
        // The pet can collect items from now on.
        // <summary>
        PetCollectItems = 1102,
        // <summary>
        // [Score] :
        // <summary>
        Score = 1103,
        // <summary>
        // Turn off the Rainbow Battle function.
        // <summary>
        TurnOffRainbowBattle = 1104,
        // <summary>
        // Turn on the Rainbow Battle function.
        // <summary>
        TurnOnRainbowBattle = 1105,
        // <summary>
        // Already conquered
        // <summary>
        AlreadyConquered = 1106,
        // <summary>
        // %s conquered points: %d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        ConqueredPoints = 1107,
        // <summary>
        // Leader %s has left the raid team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        LeaderLeftTeam = 1108,
        // <summary>
        // The battle is over! You won because the opponent's leader left.
        // <summary>
        OpponentLeaderLeft = 1109,
        // <summary>
        // You receive %d specialist points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReceiveSpecialistPoints = 1110,
        // <summary>
        // %s left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerLeftTeam = 1111,
        // <summary>
        // The Rainbow Battle function is currently off.
        // <summary>
        RainbowBattleOff = 1112,
        // <summary>
        // You are already member of another team.
        // <summary>
        AlreadyMemberAnotherTeam = 1113,
        // <summary>
        // You cannot accept players from another group.
        // <summary>
        CannotAcceptOtherGroupPlayers = 1114,
        // <summary>
        // Would you like to join %s's team?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CharacterWantToJoin = 1115,
        // <summary>
        // You have joined %s's team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        YouJoinedTeam = 1116,
        // <summary>
        // %s joined the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        JoinedTeam = 1117,
        // <summary>
        // Team is full
        // <summary>
        TeamFull = 1118,
        // <summary>
        // You cannot leave your team.
        // <summary>
        CanNotLeaveTeam = 1119,
        // <summary>
        // Would you like to leave %s's team?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskLeaveTeamRainbowBattle = 1120,
        // <summary>
        // %s has left the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CharacterHasLeft = 1121,
        // <summary>
        // Would you like to kick %s from the team?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskKickCharacter = 1122,
        // <summary>
        // %s has been kicked from the team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CharacterHasBeenKickedFromTeam = 1123,
        // <summary>
        // You have been kicked from %s's team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        KickedFromLeaderTeam = 1124,
        // <summary>
        // Would you like to disband your team?
        // <summary>
        AskDisbandTeam = 1125,
        // <summary>
        // Your team has been disbanded.
        // <summary>
        YourTeamDisbanded = 1126,
        // <summary>
        // %s's team has been disbanded.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PersonTeamDisbanded = 1127,
        // <summary>
        // Only the Rainbow Battle team leader can Request & Cancel.
        // <summary>
        OnlyRainbowTeamLeader = 1128,
        // <summary>
        // You cannot send a request now because the Rainbow Battle is currently in progress.
        // <summary>
        NoRequestWhileRainbowBattle = 1129,
        // <summary>
        // You cannot request now. Wrong time.
        // <summary>
        WrongTimeToRequest = 1130,
        // <summary>
        // You have already requested.
        // <summary>
        AlreadyRequested = 1131,
        // <summary>
        // Your team must have 10-15 members to join the Rainbow Battle.
        // <summary>
        TenMinimumForRainbowBattle = 1132,
        // <summary>
        // You have signed up for the Rainbow Battle.
        // <summary>
        SignedToRainbowBattle = 1133,
        // <summary>
        // You cannot request any more.
        // <summary>
        CannotRequestAnymore = 1134,
        // <summary>
        // You cannot cancel now.
        // <summary>
        CannotCancelNow = 1135,
        // <summary>
        // You have cancelled your request.
        // <summary>
        CancelledRequest = 1136,
        // <summary>
        // There is no team to cancel.
        // <summary>
        NoTeamToCancel = 1137,
        // <summary>
        // Ice effect for %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        IceEffect = 1138,
        // <summary>
        // Draw
        // <summary>
        Draw = 1139,
        // <summary>
        // The battle is over! The red team has won!
        // <summary>
        RedTeamWon = 1140,
        // <summary>
        // The battle is over! The blue team has won!
        // <summary>
        BlueTeamWon = 1141,
        // <summary>
        // You will be teleported to the starting position after %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TeleportToStartPoint = 1142,
        // <summary>
        // The battle will start in %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        BattleStartInSeconds = 1143,
        // <summary>
        // The battle starts NOW!
        // <summary>
        BattleStarted = 1144,
        // <summary>
        // The Rainbow Battle has finished.
        // <summary>
        RainbowBattleFinished = 1145,
        // <summary>
        // The battle ends in %d minutes<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        BattleEndInMinutes = 1146,
        // <summary>
        // You can sign up for the Rainbow Battle now! %d <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RainbowRegisterStarted = 1147,
        // <summary>
        // The Rainbow Battle will start in %d minute(s)!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RainbowBattleStartInMinutes = 1148,
        // <summary>
        // Your request was automatically cancelled because your team has been disbanded.
        // <summary>
        RequestCancelledTeamDisbanded = 1149,
        // <summary>
        // You cannot join since the leader is not in your family.
        // <summary>
        LeaderNotInFamilly = 1150,
        // <summary>
        // The request has been automatically cancelled since your team has fewer than 10 members.
        // <summary>
        TooFewRaidMember = 1151,
        // <summary>
        // You are in the Blue Team.
        // <summary>
        YouAreBlueTeam = 1152,
        // <summary>
        // You have won an undeserved victory as there is no team to fight.
        // <summary>
        UndeservedVictory = 1153,
        // <summary>
        // Rainbow Crystal(s) held � the red team has earned %d points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RedEarnedPoints = 1154,
        // <summary>
        // Rainbow Crystal(s) held � the blue team has earned %d points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        BlueEarnedPoints = 1155,
        // <summary>
        // You cannot be the member of two raid teams at the same time.
        // <summary>
        AlreadyInRaid = 1156,
        // <summary>
        // This item is for Family/Team Leaders only.
        // <summary>
        ItemForLeader = 1157,
        // <summary>
        // You cannot create a raid team when you are in a group.
        // <summary>
        CannotCreateRaidWhileInGroup = 1158,
        // <summary>
        // You already have a raid team in the family.
        // <summary>
        AlreadyRaidInFamilly = 1159,
        // <summary>
        // You are now the leader of a raid team. Recruit team members!
        // <summary>
        NowLeaderOfRaid = 1160,
        // <summary>
        // The Rainbow Battle will start in %d second(s)!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RainbowBattleWillStart = 1161,
        // <summary>
        // You are in the Red Team.
        // <summary>
        InRedTeam = 1162,
        // <summary>
        // You are in the Blue Team.
        // <summary>
        InBlueTeam = 1163,
        // <summary>
        // You cannot enter now.
        // <summary>
        CannotEnterNow = 1164,
        // <summary>
        // You don't have any Protection Scrolls. Check and try again.
        // <summary>
        NoProtectionScrolls = 1165,
        // <summary>
        // Once you destroy the item, it cannot be restored. Do you really want to destroy it?
        // <summary>
        AskDestroyItem = 1166,
        // <summary>
        // You are already doing a highscore quest.
        // <summary>
        HighscoreQuest = 1167,
        // <summary>
        // Cannot be used twice.
        // <summary>
        CantUseTwice = 1168,
        // <summary>
        // The 3,000 basic SP were replenished with the event item.
        // <summary>
        ThreeThousandsSpPointsReplenished = 1169,
        // <summary>
        // 800 basic HP were replenished due to an event item effect.
        // <summary>
        HeightHundredHpReplenished = 1170,
        // <summary>
        // 800 basic MP were replenished due to an event item effect.
        // <summary>
        HeightHundredMpReplenished = 1171,
        // <summary>
        // The event item was not effective.
        // <summary>
        EventItemNotEffective = 1172,
        // <summary>
        // Item will be destroyed.
        // <summary>
        ItemWillDestroy = 1173,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1174 = 1174,
        // <summary>
        // You are not authorised to enter this place.
        // <summary>
        NotAuthorised = 1175,
        // <summary>
        // Only family members can enter the Land of Death.
        // <summary>
        NeedFamilyForLandOfDeath = 1176,
        // <summary>
        // Would you like to move to the Land of Death?
        // <summary>
        AskJoinLandOfDeath = 1177,
        // <summary>
        // You have conquered the base camp and your hiding status is now off.
        // <summary>
        ConqueredTheBaseCamp = 1178,
        // <summary>
        // Would you like to use %s?#13#10<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskWantToUse = 1179,
        // <summary>
        // You will be returned to the entrance of the Land of Death.
        // <summary>
        ReturnToEntranceLandOfDeath = 1180,
        // <summary>
        // Your NosMate was killed. Resurrecting in %d minutes.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NosmateKilledWillReviveS = 1181,
        // <summary>
        // The Land of Death will be closed soon.
        // <summary>
        LandOfDeathCloseSoon = 1182,
        // <summary>
        // The hunt for the Flying Fire Devil has begun.
        // <summary>
        FlyingFireDevilAppears = 1183,
        // <summary>
        // The Flying Fire Devil has vanished.
        // <summary>
        FlyingFireDevilVanished = 1184,
        // <summary>
        // You can now apply for the Rainbow Battle.
        // <summary>
        CanNowApplyForRainbow = 1185,
        // <summary>
        // You need to apply for the Rainbow Battle first.
        // <summary>
        NeedApplyForRainbow = 1186,
        // <summary>
        // The Rainbow Battle is already in progress, you cannot start another.
        // <summary>
        RainbowInProgress = 1187,
        // <summary>
        // The Rainbow Battle Test is starting now.
        // <summary>
        RainbowBattleStarted = 1188,
        // <summary>
        // You cannot do this because you are not taking part in the Rainbow Battle.
        // <summary>
        OnlyForRainbowBattle = 1189,
        // <summary>
        // You can try 10 seconds after the enemy takeover.
        // <summary>
        CanTryTenSecondsAfterTakeover = 1190,
        // <summary>
        // %s has received an item:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CharacterHasReceivedItem = 1191,
        // <summary>
        // You are now out of the Land of Death
        // <summary>
        OutOfLandOfDeath = 1192,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1193 = 1193,
        // <summary>
        // The Specialist Medal has expired.
        // <summary>
        SpecialistMedalExpired = 1194,
        // <summary>
        // Equipping this item makes it untradeable.#13#10Are you sure you want to equip it?#13#10
        // <summary>
        CannotTradeAskWearing = 1195,
        // <summary>
        // You have unsellable items in your list.#13#10Please try again.#13#10
        // <summary>
        UnsellableItemInList = 1196,
        // <summary>
        // You don't have enough production points.
        // <summary>
        NotEnoughProductionPoints = 1197,
        // <summary>
        // You cannot use that because it exceeds your maximum production points.
        // <summary>
        ExceedMaxProductionLevel = 1198,
        // <summary>
        // You cannot delete the mini-game as long as you still have earnings in it.
        // <summary>
        CannotDeleteMinigameWithEarnings = 1199,
        // <summary>
        // You cannot use it when you are already a member of a raid team.
        // <summary>
        CannotUseIteInRaid = 1200,
        // <summary>
        // Maximum number of members reached. You cannot use it.
        // <summary>
        MaximumMemberCountReached = 1201,
        // <summary>
        // The durability of this mini-game has ended and you cannot earn any more rewards from it.#13#10Start game anyway?
        // <summary>
        DurabilityEndedAskStart = 1202,
        // <summary>
        // You cannot be rewarded because you don't have enough production points.#13#10Start game anyway?
        // <summary>
        NotEnoughProductionPointsAskStart = 1203,
        // <summary>
        // You received %d points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReceivedPoints = 1204,
        // <summary>
        // This game offers no rewards.
        // <summary>
        NoRewardsGame = 1205,
        // <summary>
        // There is no appropriate reward for your points.
        // <summary>
        NoRewardsForPoints = 1206,
        // <summary>
        // You need to restore your mini-game's durablity.
        // <summary>
        NeedToRestoreDurability = 1207,
        // <summary>
        // You need to manage your earnings.
        // <summary>
        NeedManageYourEarning = 1208,
        // <summary>
        // The opponent is not online.
        // <summary>
        OpponentOffline = 1209,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1210 = 1210,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1211 = 1211,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1212 = 1212,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1213 = 1213,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1214 = 1214,
        // <summary>
        // You still have enough production points.
        // <summary>
        StillHaveEnoughProductionPoints = 1215,
        // <summary>
        // Coupons can only be used for repairs of 300 points or more.
        // <summary>
        CanNotUseCouponNow = 1216,
        // <summary>
        // There are no coupons.
        // <summary>
        NoCoupons = 1217,
        // <summary>
        // You have topped up %d points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ToppedUpPoints = 1218,
        // <summary>
        // %d production point were topped up.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ProductionPointsToppedUp = 1219,
        // <summary>
        // Do not use
        // <summary>
        DoNotUse1220 = 1220,
        // <summary>
        // Players of level 20 or less cannot be rewarded.#13#10Start the game?
        // <summary>
        NotRewardForLevelTwentyWantToStartQuestion = 1221,
        // <summary>
        // No required item: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        NoRequiredItem = 1222,
        // <summary>
        // Your pet is dead. You cannot use it.
        // <summary>
        PetIsDead = 1223,
        // <summary>
        // You do not have the deputy's authority.
        // <summary>
        NoDeputyAuthority = 1224,
        // <summary>
        // You cannot use it together with the Adventurer's Knapsack.
        // <summary>
        NotWithKnapsack = 1225,
        // <summary>
        // You cannot use it as a pair.
        // <summary>
        NotInPair = 1226,
        // <summary>
        // You cannot use the Medal of Erenia and the Adventurer's Medal together.
        // <summary>
        NoMedalEreniaAndAdventurerTogether = 1227,
        // <summary>
        // The effect has ended as the time has run out.
        // <summary>
        EffectTimedOut = 1228,
        // <summary>
        // You can only receive one item per day and account.
        // <summary>
        OnlyOnePerDayAndAccount = 1229,
        // <summary>
        // You can only receive one Red Magical Fairy per account.
        // <summary>
        OnlyOneRedFairyPerAccount = 1230,
        // <summary>
        // You cannot unequip fairies whilst a Fairy Booster is being used.
        // <summary>
        CannotUnequipWhileFairyBoosted = 1231,
        // <summary>
        // There is no warehouse here.
        // <summary>
        NoWarehouseHere = 1232,
        // <summary>
        // There is no fairy accompanying you.
        // <summary>
        NoFairyWithYou = 1233,
        // <summary>
        // The fairy can't use a booster.
        // <summary>
        FairyCanNotBoost = 1234,
        // <summary>
        // In shop
        // <summary>
        InShop1 = 1235,
        // <summary>
        // In shop
        // <summary>
        InShop2 = 1236,
        // <summary>
        // In shop
        // <summary>
        InShop3 = 1237,
        // <summary>
        // You can only use it with punk and bomb hairstyles.
        // <summary>
        OnlyWithPunkAndBomb = 1238,
        // <summary>
        // You cannot dye it any more.
        // <summary>
        CannotDyeItAnymore = 1239,
        // <summary>
        // You cannot remove items for quests in progress.
        // <summary>
        CannotRemoveProgressionQuestItems = 1240,
        // <summary>
        // You cannot store quest items in the warehouse.
        // <summary>
        CannotStoreInWarehouse = 1241,
        // <summary>
        // No bomb planted.
        // <summary>
        NoBombPlanted = 1242,
        // <summary>
        // Can be used to upgrade cards from 0-9.
        // <summary>
        ForCardsLessThanLevelNine = 1243,
        // <summary>
        // Can be used to upgrade cards from 10-14.
        // <summary>
        ForCardsMoreThanLevelNine = 1244,
        // <summary>
        // The Specialist Card can only be upgraded from job level 21.
        // <summary>
        SpecialistCardRequireLevelTwentyOne = 1245,
        // <summary>
        // The Specialist Card can only be upgraded further from job level 41.
        // <summary>
        SpecialistCardRequireLevelFourtyOne = 1246,
        // <summary>
        // The Specialist Card can only be upgraded further from job level 51.
        // <summary>
        SpecialistCardRequireLevelFiftyOne = 1247,
        // <summary>
        // The maximum has been reached. The Specialist Card cannot be upgraded any further.
        // <summary>
        MaximumUpgradeReached = 1248,
        // <summary>
        // You don't have enough Angel's Feathers.
        // <summary>
        NotEnoughAngelFeathers = 1249,
        // <summary>
        // You don't have enough Full Moon Crystals.
        // <summary>
        NotEnoughFullMoon = 1250,
        // <summary>
        // You don't have enough Shining Green Souls.
        // <summary>
        NotEnoughGreenSouls = 1251,
        // <summary>
        // You don't have enough Shining Red Souls.
        // <summary>
        NotEnoughRedSouls = 1252,
        // <summary>
        // You don't have enough Shining Blue Souls.
        // <summary>
        NotEnoughBlueSouls = 1253,
        // <summary>
        // Upgrade failed, but item was protected by Card Protection Scroll.
        // <summary>
        SpecialistUpgradeFailedItemsProtected = 1254,
        // <summary>
        // The Specialist Card's soul was destroyed, but the protection scroll saved the card itself.
        // <summary>
        SpecialistSouldProtected = 1255,
        // <summary>
        // Specialist Card's soul was destroyed.
        // <summary>
        SpecialistSouldDestroyed = 1256,
        // <summary>
        // You don't have enough Point Initialisation Potions.
        // <summary>
        NotEnoughSpecialistPoints = 1257,
        // <summary>
        // Points have been restored.
        // <summary>
        PointsRestored = 1258,
        // <summary>
        // Specialist Card must be equipped.
        // <summary>
        SpecialistCardEquiped = 1259,
        // <summary>
        // There are some skill points left.
        // <summary>
        SomeSkillsPointsLeft = 1260,
        // <summary>
        // This Specialist Card has already been reset.
        // <summary>
        SpecialistCardAlreadyReset = 1261,
        // <summary>
        // Specialist Card must be equipped.
        // <summary>
        SpecialistCardMustBeEquipped = 1262,
        // <summary>
        // Only for the use of Specialist Cards.
        // <summary>
        OnlyForSpecialistCard = 1263,
        // <summary>
        // Only for use with cards whose soul has been destroyed.
        // <summary>
        OnlyUseWithDestroyedSoul = 1264,
        // <summary>
        // Can't be used anymore because the soul was destroyed.
        // <summary>
        CantUseBecauseSoulDestroyed = 1265,
        // <summary>
        // The card whose soul was destroyed.
        // <summary>
        CardSoulDestroyed = 1266,
        // <summary>
        // The soul finds a new lease of life.
        // <summary>
        CardSoulRevived = 1267,
        // <summary>
        // Status applied.
        // <summary>
        StatusApplied = 1268,
        // <summary>
        // The item cannot be removed because its location has changed.
        // <summary>
        ItemLocationChanged = 1269,
        // <summary>
        // The remaining points have been used up.
        // <summary>
        RemainingPointsUsed = 1270,
        // <summary>
        // Do you really want to trade?
        // <summary>
        AskWantTrade = 1271,
        // <summary>
        // The box is now open.
        // <summary>
        BoxIsNowOpen = 1272,
        // <summary>
        // An account can only receive one present.
        // <summary>
        OnlyOnePresentPerAccount = 1273,
        // <summary>
        // The energy field cannot be found.
        // <summary>
        EnergyFieldNotFound = 1274,
        // <summary>
        // This is not possible near a portal.
        // <summary>
        NotPossibleCloseToPortal = 1275,
        // <summary>
        // This item could not be put in the warehouse.
        // <summary>
        CannotPutInWarehouse = 1276,
        // <summary>
        // Only possible from level 20
        // <summary>
        RequireLevelTwenty = 1277,
        // <summary>
        // Only possible once per day
        // <summary>
        OnlyOncePerDay = 1278,
        // <summary>
        // 10,000 basic SP have been added.
        // <summary>
        AddedTenThousandSpecialistPoint = 1279,
        // <summary>
        // You've received the 1 Year Anniversary Buff.
        // <summary>
        RecivedAnniversaryBuff = 1280,
        // <summary>
        // The effect of the 1 Year Anniversary Medal is still active.
        // <summary>
        AnniversaryMedalActive = 1281,
        // <summary>
        // The event is over. The effect of the 1 Year Anniversary Medal is now over.
        // <summary>
        EventIsOverMedalEffectOver = 1282,
        // <summary>
        // You got a Gold award:
        // <summary>
        GoldAward = 1283,
        // <summary>
        // You have received basic SP.
        // <summary>
        ReceivedBasicSpecialist = 1284,
        // <summary>
        // Equipment Protection Scroll. Please try again.
        // <summary>
        EquipmentProtectionScrollPleaseTryAgain = 1285,
        // <summary>
        // The item can only be used by the other gender.
        // <summary>
        NotCorrectGenderForItem = 1286,
        // <summary>
        // The monsters will appear in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MonsterWillAppearsInSeconds = 1287,
        // <summary>
        // %d people of the current members<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PeopleOfTheCurrentMember = 1289,
        // <summary>
        // Time limit exceeded!
        // <summary>
        TimeLimitExceeded = 1290,
        // <summary>
        // A gigantic monster has appeared!
        // <summary>
        GiganticMonsterAppeared = 1291,
        // <summary>
        // You must be level 50-99 to receive this.
        // <summary>
        MustBeLevelFiftyToReceiveThis = 1292,
        // <summary>
        // The Rainbow Battle cannot start because there is no opponent available.
        // <summary>
        NobodyReadyRainbowBattle = 1293,
        // <summary>
        // The fairy's properties could not be adopted because it has different properties.
        // <summary>
        FairyPropertyDifferent = 1294,
        // <summary>
        // Some use a modified rainbow.
        // <summary>
        SomeUseModifiedRainbow = 1295,
        // <summary>
        // You have already obtained the Power of Protection from Latheore's Egg.
        // <summary>
        AlreadyPowerLatheoreEgg = 1296,
        // <summary>
        // Your Power of Protection has disappeared due to the powerful magic surrounding Glacernon.
        // <summary>
        PowerOfProtectionDisapeared = 1297,
        // <summary>
        // Angel
        // <summary>
        Angel = 1298,
        // <summary>
        // Demon
        // <summary>
        Demon = 1299,
        // <summary>
        // You have obtained the power of %s from Latheore's Egg.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ObtainedPowerLatheoreEgg = 1300,
        // <summary>
        // Your family has obtained the power of %s from Latheore's Egg.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamillyObtainedPowerLatheoreEgg = 1301,
        // <summary>
        // The Specialist Card and Fairy have different attributes.
        // <summary>
        SpecialistAndFairyDifferentElement = 1302,
        // <summary>
        // That cannot be used here.
        // <summary>
        CanNotBeUsedHere = 1303,
        // <summary>
        // Report to the town now.
        // <summary>
        ReportToTownNow = 1304,
        // <summary>
        // The ship hasn't returned yet.
        // <summary>
        ShipHasNotReturnedYet = 1305,
        // <summary>
        // You cannot reach the enemy!
        // <summary>
        CannotReachEnemy = 1306,
        // <summary>
        // You cannot talk sense into the enemy.
        // <summary>
        CannotTalkSenseWithEnemy = 1307,
        // <summary>
        // Changed into the Power of Protection which your family belongs to!
        // <summary>
        ChangeIntoFamillyPower = 1308,
        // <summary>
        // You have lost the Power of Protection because you have joined a neutral family.
        // <summary>
        LostProtectionAsNeutralFamilly = 1309,
        // <summary>
        // Only those who have the Power of Protection can enter Glacernon.
        // <summary>
        FactionRequired = 1310,
        // <summary>
        // The ship is full!
        // <summary>
        ShipFull = 1311,
        // <summary>
        // Glacernon is full.
        // <summary>
        GlacernonFull = 1312,
        // <summary>
        // You have stolen the power from the enemy.
        // <summary>
        PowerFromEnemyStollen = 1313,
        // <summary>
        // The curse of Glacernon has transformed you into a seal for 30 seconds!
        // <summary>
        UnderCurseOfGlacernon = 1314,
        // <summary>
        // The %s Camp has summoned Lord Mukraju.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SummonedLordMukraju = 1315,
        // <summary>
        // Please log into the server again.
        // <summary>
        PleaseLogAgain = 1316,
        // <summary>
        // Go to Glacernon.
        // <summary>
        GoToGlacernon = 1317,
        // <summary>
        // The gate to Shares Canyon is open at the Central Barrier Tower in Bitoren Tundra!
        // <summary>
        SharesCanyonGateOpen = 1318,
        // <summary>
        // The gate to Lorten Forest is open at the Central Barrier Tower in Bitoren Tundra!
        // <summary>
        LortenForestGateOpen = 1319,
        // <summary>
        // The gate to the Shimmery Crystal Cave is open at the Central Barrier Tower in Bitoren Tundra!
        // <summary>
        ShimmeryCrystalCaveGateOpen = 1320,
        // <summary>
        // The gate to Radikun Beach is open at the Central Barrier Tower in Bitoren Tundra!
        // <summary>
        RadikunBeachGateOpen = 1321,
        // <summary>
        // The gate to the Shimmery Crystal Cave is open at the Central Barrier Tower in Bitoren Tundra!
        // <summary>
        ShimmeryCrystalCaveGateOpen2 = 1322,
        // <summary>
        // You cannot receive the Power of Protection right now!
        // <summary>
        NoProtectionPowerNow = 1323,
        // <summary>
        // You cannot approach the country because of the powerful magic surrounding Glacernon.
        // <summary>
        CannotJoinTheCountryGlacernon = 1324,
        // <summary>
        // Okay, we're setting off! Raise the anchor!
        // <summary>
        RaiseTheAnchor = 1325,
        // <summary>
        // You cannot move to the enemy's citadel.
        // <summary>
        CannotMoveToEnemyCitadel = 1326,
        // <summary>
        // You have obtained an item from a giant monster.
        // <summary>
        ObtainedItemFromGiantMonster = 1327,
        // <summary>
        // This item cannot be inserted.
        // <summary>
        ItemCanNotBeInserted = 1328,
        // <summary>
        // This is someone else's exclusive item. Unusable.
        // <summary>
        ItemBelongToSomebody = 1329,
        // <summary>
        // You cannot use this because the item's rarity level is too low.
        // <summary>
        ItemRarityTooLow = 1330,
        // <summary>
        // Do you want to add an option to the item?#13#10Other people won't be able to use it#13#10because it becomes your exclusive item when you add an option.#13#10
        // <summary>
        AskAddOptions = 1331,
        // <summary>
        // The existing option will be removed and a new option added.#13#10In this case, you have a 50%% chance of succeeding.#13#10Do you want to continue?#13#10
        // <summary>
        ExistingOptionsWillBeRemoved = 1332,
        // <summary>
        // The enemy stole your Power of Protection!
        // <summary>
        EnemyStolePowerOfProtection = 1333,
        // <summary>
        // You didn't receive an item because you didn't belong to the team.
        // <summary>
        NoItemBecauseNoTeam = 1334,
        // <summary>
        // Congratulations! You have killed the dungeon boss and obtained the holy item!
        // <summary>
        CongratulationsKillDungeonBoss = 1335,
        // <summary>
        // The raid dungeon will close in 10 seconds.
        // <summary>
        RaidDungeonCloseInTenSeconds = 1336,
        // <summary>
        // The seal on the gate to the dungeon boss is broken!
        // <summary>
        SealOfDungeonBossBroken = 1337,
        // <summary>
        // The gate to the dungeon boss is closed again.
        // <summary>
        GateToDungeonBossClosed = 1338,
        // <summary>
        // You need a higher level shell than the option that's already included.
        // <summary>
        NeedHigherLevelShell = 1339,
        // <summary>
        // The item option has been changed.
        // <summary>
        OptionChanged = 1340,
        // <summary>
        // A new option has been added.
        // <summary>
        OptionHasBeenAdded = 1341,
        // <summary>
        // The seal on the gate to the Dungeon Boss is broken!
        // <summary>
        SealOfGateBroken = 1342,
        // <summary>
        // Defeat the monster to break the seal on the gate to the dungeon boss!
        // <summary>
        DefeatMonsterToBreakSeal = 1343,
        // <summary>
        // You have already defeated the dungeon boss. You can continue hunting while the Time-Space is open.
        // <summary>
        AlreadyDefeatedDungeonBos = 1344,
        // <summary>
        // Incorrect equipment and option types.
        // <summary>
        IncorrectEquipmentOptionTypes = 1345,
        // <summary>
        // Incorrect option number or level.
        // <summary>
        IncorrectOptionNumberLevel = 1346,
        // <summary>
        // Incorrect value range.
        // <summary>
        IncorrectValueRange = 1347,
        // <summary>
        // All the options have been removed.
        // <summary>
        AllOptionsRemoved = 1348,
        // <summary>
        // Demons cannot move.
        // <summary>
        DemonsCannotMove = 1349,
        // <summary>
        // Angels cannot move.
        // <summary>
        AngelsCannotMove = 1350,
        // <summary>
        // The item cannot be inserted because the item level is too low.
        // <summary>
        NoItemInsertionLevelTooLow = 1351,
        // <summary>
        // A new option has been added.
        // <summary>
        NewOptionAdded = 1352,
        // <summary>
        // You cannot invite new family members while you are in Glacernon.
        // <summary>
        CannotInviteInFamilyInGlacernon = 1353,
        // <summary>
        // Receiving the Power of Protection.
        // <summary>
        ReceivingPowerProtection = 1354,
        // <summary>
        // Seal of Fire
        // <summary>
        SealOfFire = 1355,
        // <summary>
        // Seal of Darkness
        // <summary>
        SealOfDarkness = 1356,
        // <summary>
        // Seal of Water
        // <summary>
        SealOfWater = 1357,
        // <summary>
        // Seal of Light
        // <summary>
        SealOfLight = 1358,
        // <summary>
        // The Angel Camp has taken the %s!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AngelCampHasTaken = 1359,
        // <summary>
        // The Demon Camp has taken the %s!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        DemonCampHasTaken = 1360,
        // <summary>
        // Only shell items are usable.
        // <summary>
        OnlyShellUsable = 1361,
        // <summary>
        // Incorrect equipment and option types.
        // <summary>
        IncorrectEquipmentAndOptionType = 1362,
        // <summary>
        // HP restored.
        // <summary>
        HpRestored = 1363,
        // <summary>
        // MP restored.
        // <summary>
        MpRestored = 1364,
        // <summary>
        // That has no effect.
        // <summary>
        NoEffect = 1365,
        // <summary>
        // You cannot put on someone else's exclusive item.
        // <summary>
        NotYourExclusive = 1366,
        // <summary>
        // You cannot use this on the item you're carrying.
        // <summary>
        CantUseOnCarryingItem = 1367,
        // <summary>
        // You cannot add options to your partner's items.
        // <summary>
        CantShellPartnerItems = 1368,
        // <summary>
        // Unidentified shells cannot be inserted.
        // <summary>
        CantInsertUnidentifiedShells = 1369,
        // <summary>
        // The shell was broken because adding an option failed.
        // <summary>
        ShellBroken = 1370,
        // <summary>
        // Only shell item options can be read.
        // <summary>
        OnlyShellCanBeRead = 1371,
        // <summary>
        // The options on this item have already been identified.
        // <summary>
        OptionsAlreadyIdentified = 1372,
        // <summary>
        // You don't have enough pearls.
        // <summary>
        NotEnoughPearls = 1373,
        // <summary>
        // The options have been identified.
        // <summary>
        OptionsIdentified = 1374,
        // <summary>
        // This item has no options.
        // <summary>
        NoOptionsOnItem = 1375,
        // <summary>
        // You can only remove the weapon and armour options.
        // <summary>
        YouCanOnlyRemoveArmorAndWeaponOption = 1376,
        // <summary>
        // The option has been removed.
        // <summary>
        OptionRemoved = 1377,
        // <summary>
        // You cannot add any more options.
        // <summary>
        CantAddMoreOptions = 1378,
        // <summary>
        // Items imbued with options cannot be exchanged for a partner equipment.
        // <summary>
        NoOptionsOnPartnerItems = 1379,
        // <summary>
        // The item is now exclusive to %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ItemNowExclusiveToPlayerX = 1380,
        // <summary>
        // This is your exclusive item.
        // <summary>
        YourExclusiveItem = 1381,
        // <summary>
        // This item is exclusively bound to another player.
        // <summary>
        ExclusiveAnotherPlayer = 1382,
        // <summary>
        // You don't have enough perfume bottles.
        // <summary>
        NotEnoughPerfume = 1383,
        // <summary>
        // You have removed the previous owner's smell and made it your own.
        // <summary>
        EquipmentPerfumed = 1384,
        // <summary>
        // You cannot use it yet.
        // <summary>
        CantUseIt = 1385,
        // <summary>
        // Cannot be used in Glacernon.
        // <summary>
        OnlyGlacernon1 = 1386,
        // <summary>
        // <System>
        // <summary>
        System = 1387,
        // <summary>
        // Can only be used Glacernon.
        // <summary>
        OnlyGlacernon2 = 1388,
        // <summary>
        // You return to Shares Canyon after a while.
        // <summary>
        ReturnToSharesCanyon = 1389,
        // <summary>
        // The base camp has already been built.#13#10Will you rebuild it after removing the previous one?#13#10
        // <summary>
        BuildCampAfterRemovingTheLast = 1390,
        // <summary>
        // A new Angel Base Camp has been built!
        // <summary>
        AngelCampBuilt = 1391,
        // <summary>
        // A new Devil Base Camp has been built!
        // <summary>
        DevilCampBuilt = 1392,
        // <summary>
        // There is no base camp present.
        // <summary>
        NoBaseCamp = 1393,
        // <summary>
        // Only you can use your camp's flag.
        // <summary>
        OnlyYouCanCampFlag = 1394,
        // <summary>
        // Only players who joined a family can use it.
        // <summary>
        OnlyFamilyMemberCanUse = 1395,
        // <summary>
        // Can you only use your camp's kit.
        // <summary>
        CanYouOnlyUseCampKit = 1396,
        // <summary>
        // You cannot combine equipment which has already been combined.
        // <summary>
        CantCombineCombined = 1397,
        // <summary>
        // Gambling is only posible on equipment with a rarity level of 0.
        // <summary>
        RarityOnZero = 1398,
        // <summary>
        // You can only upgrade equipment of level 0-4.
        // <summary>
        OnlyUpgradeFromZeroToFour = 1399,
        // <summary>
        // No item available to dismantle.
        // <summary>
        NoItemToDismantle = 1400,
        // <summary>
        // You can only dismantle weapons and equipment.
        // <summary>
        DismantleOnlyEquipment = 1401,
        // <summary>
        // Cannot dismantle partner's weapons or equipment.
        // <summary>
        CantDismantlePartnerEquipment = 1402,
        // <summary>
        // Dismantle failed.
        // <summary>
        DismantleFailed = 1403,
        // <summary>
        // You didn't choose an item to upgrade.
        // <summary>
        ChooseItemToUpgrade = 1404,
        // <summary>
        // You can only upgrade level 1-9 Cellons.
        // <summary>
        CanOnlyUpgradeLevelOneToNineCellons = 1405,
        // <summary>
        // You didn't choose an item to upgrade.
        // <summary>
        NoItemToUpgradeChosen = 1406,
        // <summary>
        // Cellon upgrade successful.
        // <summary>
        CellonSuccessful = 1407,
        // <summary>
        // The upgrade failed and the cellon has disappeared.
        // <summary>
        FailedCellonDisappeared = 1408,
        // <summary>
        // Incorrect material.
        // <summary>
        IncorrectMaterial = 1409,
        // <summary>
        // %s is currently unavailable.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CurrentlyUnavailable = 1410,
        // <summary>
        // When you are revived, your HP and MP are fully restored and in PvP mode you are invincible for 5 seconds.#13#10Instead, the durability of your armour is reduced.#13#10Do you want to be revived?#13#10
        // <summary>
        AskRevive = 1411,
        // <summary>
        // Do you want to enter the arena?
        // <summary>
        AskEnterArena = 1412,
        // <summary>
        // Cannot start or cancel the Rainbow Battle.
        // <summary>
        NotBeAbleToStartOrCancelRainbowBattle = 1413,
        // <summary>
        // Summoning of family members complete.
        // <summary>
        SummonFamily = 1414,
        // <summary>
        // You return to Lorten Forest after a while.
        // <summary>
        ReturnToLorten = 1415,
        // <summary>
        // You return to Radikun Beach after a while.
        // <summary>
        ReturnToRadikun = 1416,
        // <summary>
        // You return to the Shimmery Crystal Cave after a while.
        // <summary>
        ReturnToShimmery = 1417,
        // <summary>
        // You are summoning your family members.
        // <summary>
        SummoningFamily = 1418,
        // <summary>
        // You can only use it in the Secret Lab.
        // <summary>
        UsableOnlyOnLab = 1419,
        // <summary>
        // Received Dona River Sand: amount gained
        // <summary>
        RecivedDonaSand = 1420,
        // <summary>
        // Cannot be removed before the materials have grown. - %d seconds<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CannotBeRemovedUntilGrowth = 1421,
        // <summary>
        // Cannot remove the structure as it is being used by someone.
        // <summary>
        StructureInUse = 1422,
        // <summary>
        // Somebody's partner is collecting materials.
        // <summary>
        SomebodyPartnerCollectingMaterials = 1423,
        // <summary>
        // Collecting failed.
        // <summary>
        CollectingFailed = 1424,
        // <summary>
        // Sorry, this server is closed. Please choose a different one!
        // <summary>
        ServerClosed = 1425,
        // <summary>
        // Players receive %s only once per account.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ReciveOnePerAccount = 1426,
        // <summary>
        // ] by [
        // <summary>
        By = 1427,
        // <summary>
        // *
        // <summary>
        Undefined1428 = 1428,
        // <summary>
        // *
        // <summary>
        Undefined1429 = 1429,
        // <summary>
        // *
        // <summary>
        Undefined1430 = 1430,
        // <summary>
        // Once worn this item is exclusively yours. Nobody else can use it after the change. Do you wish to equip it?#13#10
        // <summary>
        ItemNotExchangeableAfterUsage = 1431,
        // <summary>
        // You cannot change Specialist Partner Cards while in combat.
        // <summary>
        SpecialistParterCardCannotBeChangedWhileCombact = 1432,
        // <summary>
        // Your partner's level is insufficient.
        // <summary>
        PartnerLevelInsufficient = 1433,
        // <summary>
        // *
        // <summary>
        Undefined1434 = 1434,
        // <summary>
        // *
        // <summary>
        Undefined1435 = 1435,
        // <summary>
        // *
        // <summary>
        Undefined1436 = 1436,
        // <summary>
        // *
        // <summary>
        Undefined1437 = 1437,
        // <summary>
        // *
        // <summary>
        Undefined1438 = 1438,
        // <summary>
        // *
        // <summary>
        Undefined1439 = 1439,
        // <summary>
        // *
        // <summary>
        Undefined1440 = 1440,
        // <summary>
        // *
        // <summary>
        Undefined1441 = 1441,
        // <summary>
        // *
        // <summary>
        Undefined1442 = 1442,
        // <summary>
        // *
        // <summary>
        Undefined1443 = 1443,
        // <summary>
        // *
        // <summary>
        Undefined1444 = 1444,
        // <summary>
        // *
        // <summary>
        Undefined1445 = 1445,
        // <summary>
        // *
        // <summary>
        Undefined1446 = 1446,
        // <summary>
        // *
        // <summary>
        Undefined1447 = 1447,
        // <summary>
        // *
        // <summary>
        Undefined1448 = 1448,
        // <summary>
        // *
        // <summary>
        Undefined1449 = 1449,
        // <summary>
        // *
        // <summary>
        Undefined1450 = 1450,
        // <summary>
        // You need 2,000 contribution points to revive at this location.#13#10Would you like to revive now?#13#10
        // <summary>
        TwoThousandsContributionPointsToGetRevived = 1451,
        // <summary>
        // *
        // <summary>
        Undefined1452 = 1452,
        // <summary>
        // *
        // <summary>
        Undefined1453 = 1453,
        // <summary>
        // *
        // <summary>
        Undefined1454 = 1454,
        // <summary>
        // *
        // <summary>
        Undefined1455 = 1455,
        // <summary>
        // *
        // <summary>
        Undefined1456 = 1456,
        // <summary>
        // *
        // <summary>
        Undefined1457 = 1457,
        // <summary>
        // *
        // <summary>
        Undefined1458 = 1458,
        // <summary>
        // *
        // <summary>
        Undefined1459 = 1459,
        // <summary>
        // *
        // <summary>
        Undefined1460 = 1460,
        // <summary>
        // *
        // <summary>
        Undefined1461 = 1461,
        // <summary>
        // *
        // <summary>
        Undefined1462 = 1462,
        // <summary>
        // Your NosMate Guardian Angel saved your partner.
        // <summary>
        GuardianSaved = 1463,
        // <summary>
        // *
        // <summary>
        Undefined1464 = 1464,
        // <summary>
        // *
        // <summary>
        Undefined1465 = 1465,
        // <summary>
        // *
        // <summary>
        Undefined1466 = 1466,
        // <summary>
        // *
        // <summary>
        Undefined1467 = 1467,
        // <summary>
        // *
        // <summary>
        Undefined1468 = 1468,
        // <summary>
        // *
        // <summary>
        Undefined1469 = 1469,
        // <summary>
        // *
        // <summary>
        Undefined1470 = 1470,
        // <summary>
        // *
        // <summary>
        Undefined1471 = 1471,
        // <summary>
        // *
        // <summary>
        Undefined1472 = 1472,
        // <summary>
        // *
        // <summary>
        Undefined1473 = 1473,
        // <summary>
        // *
        // <summary>
        Undefined1474 = 1474,
        // <summary>
        // *
        // <summary>
        Undefined1475 = 1475,
        // <summary>
        // *
        // <summary>
        Undefined1476 = 1476,
        // <summary>
        // Cannot be transformed because the level is too low.
        // <summary>
        CannotBeTransformedLevelTooLow = 1477,
        // <summary>
        // *
        // <summary>
        Undefined1478 = 1478,
        // <summary>
        // You cannot use it on other players' NosMates.
        // <summary>
        CannotUseOnOtherPlayersNosMates = 1479,
        // <summary>
        // This item is bound to another player. You can make it yours by using Good Smelling Perfume.
        // <summary>
        ItemBoundToAnotherPlayer = 1480,
        // <summary>
        // You don't have enough reputation points to be revived.
        // <summary>
        NotEnoughReputationToRevived = 1481,
        // <summary>
        // *
        // <summary>
        Undefined1482 = 1482,
        // <summary>
        // You need 3,000 contribution points. Do you want to enter?
        // <summary>
        Confirm3000ContributionToEnter = 1483,
        // <summary>
        // You don't have enough contribution points to enter the raid dungeon.
        // <summary>
        NotEnoughContributionToEnterRaid = 1484,
        // <summary>
        // Do you want to save this spot and return to the village?#13#10
        // <summary>
        ConfirmSaveSpotAndReturnVillage = 1485,
        // <summary>
        // No point to return to.
        // <summary>
        NoPointToReturn = 1486,
        // <summary>
        // *
        // <summary>
        Undefined1487 = 1487,
        // <summary>
        // *
        // <summary>
        Undefined1488 = 1488,
        // <summary>
        // *
        // <summary>
        Undefined1489 = 1489,
        // <summary>
        // *
        // <summary>
        Undefined1490 = 1490,
        // <summary>
        // *
        // <summary>
        Undefined1491 = 1491,
        // <summary>
        // *
        // <summary>
        Undefined1492 = 1492,
        // <summary>
        // *
        // <summary>
        Undefined1493 = 1493,
        // <summary>
        // *
        // <summary>
        Undefined1494 = 1494,
        // <summary>
        // Your level is too low. You can complete this quest after level %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        LevelTooLowToCompleteQuest = 1495,
        // <summary>
        // *
        // <summary>
        Undefined1496 = 1496,
        // <summary>
        // *
        // <summary>
        Undefined1497 = 1497,
        // <summary>
        // *
        // <summary>
        Undefined1498 = 1498,
        // <summary>
        // *
        // <summary>
        Undefined1499 = 1499,
        // <summary>
        // *
        // <summary>
        Undefined1500 = 1500,
        // <summary>
        // *
        // <summary>
        Undefined1501 = 1501,
        // <summary>
        // *
        // <summary>
        Undefined1502 = 1502,
        // <summary>
        // *
        // <summary>
        Undefined1503 = 1503,
        // <summary>
        // *
        // <summary>
        Undefined1504 = 1504,
        // <summary>
        // Do you want to set %s as your point of return?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ConfirmSetPointOfReturn = 1505,
        // <summary>
        // You have requested to share your point of return with your party members.
        // <summary>
        RequestedSharePointOfReturn = 1506,
        // <summary>
        // %s has changed the point of return.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeoneChangedPointOfReturn = 1507,
        // <summary>
        // You have changed the same point of return for party members.
        // <summary>
        ChangedSamePointOfReturn = 1508,
        // <summary>
        // %s refused to share the point of return with party members.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeoneRefusedToSharePointOfReturn = 1509,
        // <summary>
        // You refused to share the point of return with party members.
        // <summary>
        RefusedSharePointOfReturn = 1510,
        // <summary>
        // *
        // <summary>
        Undefined1511 = 1511,
        // <summary>
        // *
        // <summary>
        Undefined1512 = 1512,
        // <summary>
        // *
        // <summary>
        Undefined1513 = 1513,
        // <summary>
        // %s has defeated a Demon Guardian.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeoneDefeatDemon = 1514,
        // <summary>
        // %s's power has been stolen by an Angel Guardian.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeonePowerStolenByAngel = 1515,
        // <summary>
        // %s has defeated an Angel Guardian.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeoneDefeatAngel = 1516,
        // <summary>
        // %s's power has been stolen by a Devil Guardian.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SomeonePowerStolenByDevil = 1517,
        // <summary>
        // There are not enough players to play together.
        // <summary>
        NotEnoughPlayerToPlay = 1518,
        // <summary>
        // %d Gold received as reward for victory.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        VictoryReceivedGold = 1519,
        // <summary>
        // %d fame received as reward for victory.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        VictoryReceivedFame = 1520,
        // <summary>
        // %d additional SP received as reward for victory.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        VictoryReceivedAdditionalSP = 1521,
        // <summary>
        // *
        // <summary>
        Undefined1522 = 1522,
        // <summary>
        // The sea cannot be crossed.
        // <summary>
        CannotCrossSea = 1523,
        // <summary>
        // *
        // <summary>
        Undefined1524 = 1524,
        // <summary>
        // *
        // <summary>
        Undefined1525 = 1525,
        // <summary>
        // Feed this to your pet to increase its loyalty and experience.
        // <summary>
        FeedPetIncreaseLoyaltyAndExperience = 1526,
        // <summary>
        // *
        // <summary>
        Undefined1527 = 1527,
        // <summary>
        // *
        // <summary>
        Undefined1528 = 1528,
        // <summary>
        // Feed this to your partner to increase its intimacy and experience.
        // <summary>
        FeedPartnerIncreaseIntimacyAndExperience = 1529,
        // <summary>
        // *
        // <summary>
        Undefined1530 = 1530,
        // <summary>
        // *
        // <summary>
        Undefined1531 = 1531,
        // <summary>
        // *
        // <summary>
        Undefined1532 = 1532,
        // <summary>
        // *
        // <summary>
        Undefined1533 = 1533,
        // <summary>
        // *
        // <summary>
        Undefined1534 = 1534,
        // <summary>
        // *
        // <summary>
        Undefined1535 = 1535,
        // <summary>
        // *
        // <summary>
        Undefined1536 = 1536,
        // <summary>
        // *
        // <summary>
        Undefined1537 = 1537,
        // <summary>
        // *
        // <summary>
        Undefined1538 = 1538,
        // <summary>
        // *
        // <summary>
        Undefined1539 = 1539,
        // <summary>
        // *
        // <summary>
        Undefined1540 = 1540,
        // <summary>
        // *
        // <summary>
        Undefined1541 = 1541,
        // <summary>
        // *
        // <summary>
        Undefined1542 = 1542,
        // <summary>
        // *
        // <summary>
        Undefined1543 = 1543,
        // <summary>
        // *
        // <summary>
        Undefined1544 = 1544,
        // <summary>
        // *
        // <summary>
        Undefined1545 = 1545,
        // <summary>
        // *
        // <summary>
        Undefined1546 = 1546,
        // <summary>
        // *
        // <summary>
        Undefined1547 = 1547,
        // <summary>
        // *
        // <summary>
        Undefined1548 = 1548,
        // <summary>
        // *
        // <summary>
        Undefined1549 = 1549,
        // <summary>
        // *
        // <summary>
        Undefined1550 = 1550,
        // <summary>
        // *
        // <summary>
        Undefined1551 = 1551,
        // <summary>
        // *
        // <summary>
        Undefined1552 = 1552,
        // <summary>
        // *
        // <summary>
        Undefined1553 = 1553,
        // <summary>
        // *
        // <summary>
        Undefined1554 = 1554,
        // <summary>
        // *
        // <summary>
        Undefined1555 = 1555,
        // <summary>
        // *
        // <summary>
        Undefined1556 = 1556,
        // <summary>
        // Remaining HP from %s : %d%%<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        RemainingHP = 1557,
        // <summary>
        // Your reputation has increased due to group member activity.
        // <summary>
        ReputationIncreasedByGroupMemberActivity = 1558,
        // <summary>
        // *
        // <summary>
        Undefined1559 = 1559,
        // <summary>
        // *
        // <summary>
        Undefined1560 = 1560,
        // <summary>
        // *
        // <summary>
        Undefined1561 = 1561,
        // <summary>
        // *
        // <summary>
        Undefined1562 = 1562,
        // <summary>
        // *
        // <summary>
        Undefined1563 = 1563,
        // <summary>
        // *
        // <summary>
        Undefined1564 = 1564,
        // <summary>
        // *
        // <summary>
        Undefined1565 = 1565,
        // <summary>
        // *
        // <summary>
        Undefined1566 = 1566,
        // <summary>
        // *
        // <summary>
        Undefined1567 = 1567,
        // <summary>
        // *
        // <summary>
        Undefined1568 = 1568,
        // <summary>
        // *
        // <summary>
        Undefined1569 = 1569,
        // <summary>
        // *
        // <summary>
        Undefined1570 = 1570,
        // <summary>
        // *
        // <summary>
        Undefined1571 = 1571,
        // <summary>
        // You cannot enter the Time-Space with more companions.
        // <summary>
        MaxCompanions = 1572,
        // <summary>
        // The Time-Space is already full. You cannot enter.
        // <summary>
        TimeSpaceAlreadyFull = 1573,
        // <summary>
        // *
        // <summary>
        Undefined1574 = 1574,
        // <summary>
        // The Instant Combat (Single) is activated.
        // <summary>
        SingleInstantCombatActivated = 1575,
        // <summary>
        // Cancel the Instant Combat (Single) to be able to start a regular Instant Combat.
        // <summary>
        CancelSingleInstantCombat = 1576,
        // <summary>
        // The family functions have not been activated. Please contact a GM.
        // <summary>
        NotActivatedFamilyFunction = 1577,
        // <summary>
        // Groupinvite
        // <summary>
        Groupinvite = 1578,
        // <summary>
        // Add
        // <summary>
        Add = 1579,
        // <summary>
        // Player cannot be found.
        // <summary>
        CannotFindPlayer = 1580,
        // <summary>
        // You can only invite other players to join your party on general fields.
        // <summary>
        GroupInviteOnlyPlayerOnGeneralFields = 1581,
        // <summary>
        // Player cannot join the party.
        // <summary>
        CannotJoinParty = 1582,
        // <summary>
        // You can only invite other players to be your friend on general fields.
        // <summary>
        FriendInviteOnlyPlayerOnGeneralFields = 1583,
        // <summary>
        // The player cannot receive your request.
        // <summary>
        CannotReceiveRequest = 1584,
        // <summary>
        // Instant Combat will begin.
        // <summary>
        InstantCombatWillBegin = 1585,
        // <summary>
        // *
        // <summary>
        Undefined1586 = 1586,
        // <summary>
        // You can receive only one quest a day.
        // <summary>
        ReceiveOnlyOneQuestPerDay = 1587,
        // <summary>
        // Family function not available. Please contact a GM.
        // <summary>
        NotAvailableFamilyFunction = 1588,
        // <summary>
        // Partylocation
        // <summary>
        PartyLocation = 1589,
        // <summary>
        // %s: Map no. %d <NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        MapNo = 1590,
        // <summary>
        // %s: The party member is in an unknown place.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GroupMemberInUnknownPlace = 1591,
        // <summary>
        // You are not in a party.
        // <summary>
        NotInGroup = 1592,
        // <summary>
        // The ship will leave in %d minutes.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ShipLeaveInMinutes = 1593,
        // <summary>
        // The ship will leave in 1 minute.
        // <summary>
        ShipLeaveInOneMinute = 1594,
        // <summary>
        // The ship will leave in 30 seconds.
        // <summary>
        ShipLeaveInThirtySeconds = 1595,
        // <summary>
        // The ship will leave in 10 seconds.
        // <summary>
        ShipLeaveInTenSeconds = 1596,
        // <summary>
        // You can board the ship at %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        BoardShipAt = 1597,
        // <summary>
        // Would you like to trade 6 Christmas Vouchers for Santa's Big Gift Box?
        // <summary>
        ConfirmTradeSixChristmasVouchers = 1598,
        // <summary>
        // Would you like to trade 12 Christmas Vouchers for Santa's Special Gift Box?
        // <summary>
        ConfirmTradeTwelveChristmasVouchers = 1599,
        // <summary>
        // You can keep items in your partner's inventory by using a Partner's Backpack.
        // <summary>
        KeepItemsInPartnerInvetoryUsingPartnerBackpack = 1600,
        // <summary>
        // You can keep items in your partner's inventory by using a Premium Medal.
        // <summary>
        KeepItemsInPartnerInvetoryUsingPremiumMedal = 1601,
        // <summary>
        // Please enter [Command] in the chat window to display the list of chat commands.
        // <summary>
        EnterCommandToSeeList = 1602,
        // <summary>
        // %d reputation points are required. Do you want to enter?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReputationPointsRequiredToEnter = 1603,
        // <summary>
        // Only players who are members of a family can enter the raid dungeon.
        // <summary>
        FamilyMemberOnlyEnterDungeon = 1604,
        // <summary>
        // Would you like to move to Bitoren Tundra?
        // <summary>
        AskMoveToTundra = 1605,
        // <summary>
        // You can trade as soon as your trading partner has declared an item to trade.
        // <summary>
        PartnerMustDeclareTrade = 1606,
        // <summary>
        // Your partner cancelled the trade.
        // <summary>
        PartnerCancelledTrade = 1607,
        // <summary>
        // Trade cancelled.
        // <summary>
        TradeCancelled3 = 1608,
        // <summary>
        // Your trading partner has asked for permission to change the traded item.
        // <summary>
        TradingPartnerAskedChangeItem = 1609,
        // <summary>
        // You cannot make a party with members of the other faction.
        // <summary>
        NoPartyWithOtherFaction = 1610,
        // <summary>
        // Warm body. For %d minutes you will be able to get items and experience as if you were in a normal state.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        WarmBody = 1611,
        // <summary>
        // Your body temperature slowly drops. For %d minutes you'll be able to obtain items and experience as if you were in a normal state.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        BodyIsGettingCold = 1612,
        // <summary>
        // The warm energy around your body disappears. The experience gain and probability of obtaining an item are decreased by the cold.
        // <summary>
        WarmBodyEnd = 1613,
        // <summary>
        // You can feel the cold. The experience gain and probability of obtaining an item are decreased. At 5 AM your body temperature will return to normal.
        // <summary>
        ColdBody = 1614,
        // <summary>
        // You need %d reputation points to revive at the place where you died.#13#10 Do you want to revive now? #13#10<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AmountOfReputationNeededToRevive = 1615,
        // <summary>
        // Congratulations! You defeated the boss!
        // <summary>
        CongratulationsKilledTheBoss = 1616,
        // <summary>
        // You will be teleported to the raid dungeon gate in 10 seconds.
        // <summary>
        TeleportToRaidDungeonGateInTenSeconds = 1617,
        // <summary>
        // Your contribution points and battle history have been reset by the strong power surrounding Glacernon.
        // <summary>
        ContributionAndBattleStatsReset = 1618,
        // <summary>
        // A player who isn't a member of a family can only use an Egg for Angels (Individual).
        // <summary>
        PlayerNotPartOfFamilyCanOnlyUseIndividualAngelEgg = 1619,
        // <summary>
        // You already have the Power of Angels.
        // <summary>
        AlreadyAngelFaction = 1620,
        // <summary>
        // Would you like to change your Power of Protection into the Power of Angels? #13#10 Your contribution points and battle history will be reset.
        // <summary>
        MessageToChangeFactionToAngelWithPointsReset = 1621,
        // <summary>
        // A player who isn't a member of a Family can only use an Egg for Demons (Individual).
        // <summary>
        PlayerNotPartOfFamilyCanOnlyUseIndividualDemonEgg = 1622,
        // <summary>
        // You already have the Power of Demons.
        // <summary>
        AlreadyDemonFaction = 1623,
        // <summary>
        // Would you like to change your Power of Protection into the Power of Demons? #13#10 Your contribution points and battle history will be reset.
        // <summary>
        MessageToChangeFactionToDemonWithPointsReset = 1624,
        // <summary>
        // A player who is a family member can only use an Egg for Angels (Family).
        // <summary>
        FamilyMemberPlayerCanOnlyUseAngelEgg = 1625,
        // <summary>
        // Only the family head can change the Power of Protection.
        // <summary>
        OnlyFamilyHeadAllowedToChangeFactions = 1626,
        // <summary>
        // A player who is a family member can only use the Egg for Demons (Family).
        // <summary>
        FamilyMemberPlayerCanOnlyUseDemonEgg = 1627,
        // <summary>
        // The raid dungeon gate at the Central Barrier Tower in Bitoren Tundra is open!
        // <summary>
        OpenedRaidAtCentralBarrierInBitorenTundra = 1628,
        // <summary>
        // You cannot confess your love to anybody else today.
        // <summary>
        CannotConfessLoveToday = 1629,
        // <summary>
        // 100%% Experience Boost Event is taking place (Target: Level 1-30)
        // <summary>
        EventExperienceFromLevelOneToThrity = 1630,
        // <summary>
        // You are playing this Time-Space in Loser Mode so you cannot gain any items or experience.
        // <summary>
        LoserModeActivatedOnTimeSpaceNoReward = 1631,
        // <summary>
        // *
        // <summary>
        Undefined1632 = 1632,
        // <summary>
        // *
        // <summary>
        Undefined1633 = 1633,
        // <summary>
        // *
        // <summary>
        Undefined1634 = 1634,
        // <summary>
        // *
        // <summary>
        Undefined1635 = 1635,
        // <summary>
        // Already registered.
        // <summary>
        AlreadyRegistered1 = 1636,
        // <summary>
        // Already registered in the raid list.
        // <summary>
        AlreadyRegistered2 = 1637,
        // <summary>
        // Mother Cuby
        // <summary>
        MotherCuby = 1638,
        // <summary>
        // Ginseng
        // <summary>
        Ginseng = 1639,
        // <summary>
        // Dark Castra
        // <summary>
        DarkCastra = 1640,
        // <summary>
        // Giant Black Spider
        // <summary>
        GiantBlackSpider = 1641,
        // <summary>
        // Massive Slade
        // <summary>
        MassiveSlade = 1642,
        // <summary>
        // Chicken King
        // <summary>
        ChickenKing = 1643,
        // <summary>
        // Namaju
        // <summary>
        Namaju = 1644,
        // <summary>
        // UNKNOWN
        // <summary>
        Unknown = 1645,
        // <summary>
        // Following player seeks members for the %s Raid:<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerSearchingMembersForRaidX = 1646,
        // <summary>
        // Only the leader who registered the raid can delete it.
        // <summary>
        OnlyLeaderCanDeleteRaid = 1647,
        // <summary>
        // Removed from the raid list.
        // <summary>
        RemovedFromRaidList = 1648,
        // <summary>
        // The raid does not exist.
        // <summary>
        RaidDoesNotExist = 1649,
        // <summary>
        // Failed to list in the auction.
        // <summary>
        FailedToListAuctions = 1650,
        // <summary>
        // *
        // <summary>
        Undefined1651 = 1651,
        // <summary>
        // Players of level 20 and above can participate in the raid.
        // <summary>
        RequiredLevelTwentyToEnterRaid = 1652,
        // <summary>
        // You will be revived in 20 seconds.#13#10 You can only be revived once.
        // <summary>
        MessageRevivedInTwentySecondWithAnotherDeathAvailable = 1653,
        // <summary>
        // You will be revived in 20 seconds.#13#10If you die again, you will be kicked out of the raid.
        // <summary>
        MessageRevivedInTwentySecondWithNoMoreDeathsAvailable = 1654,
        // <summary>
        // You have used all your lives.
        // <summary>
        FinishedLives = 1655,
        // <summary>
        // You are in %s's raid team.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        MessageTakingPartOfPlayersRaid = 1656,
        // <summary>
        // You will be revived in 20 seconds.#13#10If you die again, the raid will be cancelled.
        // <summary>
        MessageRevivedInTwentySecondWithNoMoreDeathsDuringRaid = 1657,
        // <summary>
        // No items available to sell.
        // <summary>
        NoItemToSell = 1658,
        // <summary>
        // Your specialist wings have been changed.
        // <summary>
        WingsChanged = 1659,
        // <summary>
        // You must first transform into the specialist whose wings you want to change.
        // <summary>
        TransformToChangeWings = 1660,
        // <summary>
        // You can only change the specialist's wings when the specialist card has been upgraded to +1 or above.
        // <summary>
        WingsOnlyFromPlusOne = 1661,
        // <summary>
        // Angel Wings are already being used.
        // <summary>
        AngelWingsUsed = 1662,
        // <summary>
        // Devil Wings are already being used.
        // <summary>
        DevilWingsUsed = 1663,
        // <summary>
        // Would you like to change the wings of the current specialist?
        // <summary>
        AskChangeWings = 1664,
        // <summary>
        // You cannot use this item.
        // <summary>
        CantUseItem = 1665,
        // <summary>
        // You cannot use that because it is too far away.
        // <summary>
        CantUseTooFar = 1666,
        // <summary>
        // Your friend has logged out. The friendship blessing buff has been neutralised.
        // <summary>
        FriendshipBuffRemovedBecuaseFriendOffline = 1667,
        // <summary>
        // You and %s have received the friendship blessing buff.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerAndFriendXReceivedFriendshipBuff = 1668,
        // <summary>
        // Since your friend has not logged in, you cannot receive the buff.#13#10Call your friend.
        // <summary>
        PlayerFriendNeedToBeOnlineToReceiveBuff = 1669,
        // <summary>
        // Your level is too low to continue.
        // <summary>
        LevelTooLowToContinue = 1670,
        // <summary>
        // The quest can only be completed once per day.
        // <summary>
        DailyQuestOncePerDay = 1671,
        // <summary>
        // You have already received the quest from the fortune-teller.
        // <summary>
        QuestAlreadyRecivedFromFortuneTeller = 1672,
        // <summary>
        // Giant Grasslin
        // <summary>
        GiantGrasslin = 1673,
        // <summary>
        // You don't have a key to open this.
        // <summary>
        NoKey = 1674,
        // <summary>
        // The chest could not be opened because the key is broken.
        // <summary>
        KeyBroken = 1675,
        // <summary>
        // The trap on the chest has been set off.
        // <summary>
        TrapOff = 1676,
        // <summary>
        // The chest is empty.
        // <summary>
        ChestEmpty = 1677,
        // <summary>
        // You have been rewarded with an item.
        // <summary>
        Rewarded = 1678,
        // <summary>
        // You have received a bag.
        // <summary>
        RecivedBag = 1679,
        // <summary>
        // Desert Robbers
        // <summary>
        DesertRobbers = 1680,
        // <summary>
        // You can only use HP and MP potions when mounted.
        // <summary>
        OnlyPotionInVehicle = 1681,
        // <summary>
        // You cannot use the item because your level is too low.
        // <summary>
        LevelTooLow = 1682,
        // <summary>
        // Not possible while mounted.
        // <summary>
        CantUseInVehicle = 1683,
        // <summary>
        // You can cancel the change with the Magic Carpet.
        // <summary>
        AllowToCancelChangeWithMagicCarpet = 1684,
        // <summary>
        // You can cancel the change with the Magic Scooter.
        // <summary>
        AllowToCancelChangeWithMagicScooter = 1685,
        // <summary>
        // Do you want to save your current location and return to the village in the desert?#13#10
        // <summary>
        AmuletMessageToSaveCurrentLocationAndReturnToDesertVillage = 1686,
        // <summary>
        // The sub-quest has already been completed.
        // <summary>
        SubQuestDone = 1687,
        // <summary>
        // That is not a sub-quest!
        // <summary>
        NotSubQuest = 1688,
        // <summary>
        // You must first complete the previous quest.
        // <summary>
        CompletePreviousQuest = 1689,
        // <summary>
        // Your level is too high to continue.
        // <summary>
        LevelTooHigh = 1690,
        // <summary>
        // You cannot go to your friend because you are in different places.
        // <summary>
        FriendInDifferentPlace = 1691,
        // <summary>
        // You cannot share the point of return with others.
        // <summary>
        CantSharePoint = 1692,
        // <summary>
        // The effect of the Premium Medal will be extended.
        // <summary>
        MedalExtend = 1693,
        // <summary>
        // The raid has already started.
        // <summary>
        RaidAlreadyStarted = 1694,
        // <summary>
        // There is no other team for the Rainbow Battle.
        // <summary>
        NoTeamForRainbowBattle = 1695,
        // <summary>
        // You cannot go back to the point of return.
        // <summary>
        CantBack = 1696,
        // <summary>
        // You cannot transform because of a bad effect.
        // <summary>
        CantTrasformBadEffect = 1697,
        // <summary>
        // You have received a tarot card.
        // <summary>
        RecivedTarot = 1698,
        // <summary>
        // *
        // <summary>
        Undefined1699 = 1699,
        // <summary>
        // *
        // <summary>
        Undefined1700 = 1700,
        // <summary>
        // *
        // <summary>
        Undefined1701 = 1701,
        // <summary>
        // *
        // <summary>
        Undefined1702 = 1702,
        // <summary>
        // *
        // <summary>
        Undefined1703 = 1703,
        // <summary>
        // *
        // <summary>
        Undefined1704 = 1704,
        // <summary>
        // *
        // <summary>
        Undefined1705 = 1705,
        // <summary>
        // *
        // <summary>
        Undefined1706 = 1706,
        // <summary>
        // *
        // <summary>
        Undefined1707 = 1707,
        // <summary>
        // *
        // <summary>
        Undefined1708 = 1708,
        // <summary>
        // *
        // <summary>
        Undefined1709 = 1709,
        // <summary>
        // *
        // <summary>
        Undefined1710 = 1710,
        // <summary>
        // *
        // <summary>
        Undefined1711 = 1711,
        // <summary>
        // *
        // <summary>
        Undefined1712 = 1712,
        // <summary>
        // *
        // <summary>
        Undefined1713 = 1713,
        // <summary>
        // *
        // <summary>
        Undefined1714 = 1714,
        // <summary>
        // *
        // <summary>
        Undefined1715 = 1715,
        // <summary>
        // *
        // <summary>
        Undefined1716 = 1716,
        // <summary>
        // *
        // <summary>
        Undefined1717 = 1717,
        // <summary>
        // *
        // <summary>
        Undefined1718 = 1718,
        // <summary>
        // *
        // <summary>
        Undefined1719 = 1719,
        // <summary>
        // *
        // <summary>
        Undefined1720 = 1720,
        // <summary>
        // *
        // <summary>
        Undefined1721 = 1721,
        // <summary>
        // *
        // <summary>
        Undefined1722 = 1722,
        // <summary>
        // *
        // <summary>
        Undefined1723 = 1723,
        // <summary>
        // *
        // <summary>
        Undefined1724 = 1724,
        // <summary>
        // *
        // <summary>
        Undefined1725 = 1725,
        // <summary>
        // *
        // <summary>
        Undefined1726 = 1726,
        // <summary>
        // *
        // <summary>
        Undefined1727 = 1727,
        // <summary>
        // *
        // <summary>
        Undefined1728 = 1728,
        // <summary>
        // *
        // <summary>
        Undefined1729 = 1729,
        // <summary>
        // You cannot transform into a monster while mounted.
        // <summary>
        CannotTransformInMonsterInVehicle = 1730,
        // <summary>
        // You cannot use a monster transformation item to prevent the transformation.
        // <summary>
        CannotUseMonsterTrasfornmationToPreventTrasformation = 1731,
        // <summary>
        // You can reverse the transformation with the Halloween Costume Scroll.
        // <summary>
        AllowToReverseTrasformationWithHalloweenCostumeScroll = 1732,
        // <summary>
        // You can reverse the transformation with the Halloween Costume Scroll (Event).
        // <summary>
        llowToReverseTrasformationWithHalloweenCostumeScrollEvent = 1733,
        // <summary>
        // You can stop the transformation with the magical Book of Halloween Transformation.
        // <summary>
        UseBookOfHalloweenTrasformationToRemoveTrasformation = 1734,
        // <summary>
        // You have not received the Bag of Halloween Treats.
        // <summary>
        RecivedHalloweenBag = 1735,
        // <summary>
        // Have you received the Bag of Halloween Treats?
        // <summary>
        AskRecivedHalloweenBag = 1736,
        // <summary>
        // You can only use recovery items while in monster form.
        // <summary>
        RecoveryOnlyInMonsterForm = 1737,
        // <summary>
        // You need 15 Bags of Halloween Treats.
        // <summary>
        NeedFifteenHalloweenBags = 1738,
        // <summary>
        // You cannot receive costumes that do not fit you.
        // <summary>
        CostumeNotFit = 1739,
        // <summary>
        // This costume is not appropriate for Halloween.
        // <summary>
        NotCostumeForHalloween = 1740,
        // <summary>
        // Take this bag of treats.
        // <summary>
        TakeBagOfTreats = 1741,
        // <summary>
        // I don't like tricks, so take these treats.
        // <summary>
        DontLikeTricks = 1742,
        // <summary>
        // You can only put the signposts up in villages.
        // <summary>
        SignpostOnlyInVillage = 1743,
        // <summary>
        // You can only use it in your Miniland.
        // <summary>
        UsableInMiniland = 1744,
        // <summary>
        // You cannot transform into a monster while you are a specialist.
        // <summary>
        CantTrasformInMonsterWhileSpecialist = 1745,
        // <summary>
        // *
        // <summary>
        Undefined1746 = 1746,
        // <summary>
        // *
        // <summary>
        Undefined1747 = 1747,
        // <summary>
        // *
        // <summary>
        Undefined1748 = 1748,
        // <summary>
        // *
        // <summary>
        Undefined1749 = 1749,
        // <summary>
        // Huge Snowman
        // <summary>
        HugeSnowman = 1750,
        // <summary>
        // You can only use this in your own Mini-Land.
        // <summary>
        OnlyForYourOwnMiniland = 1751,
        // <summary>
        // You can take the costume off again with the Ice Costume Scroll.
        // <summary>
        CostumeOffWitIcehScroll = 1752,
        // <summary>
        // You can take the costume off again with the Ice Costume Scroll (Event).
        // <summary>
        CostumeOffWitIcehScrollEvent = 1753,
        // <summary>
        // *
        // <summary>
        Undefined1754 = 1754,
        // <summary>
        // *
        // <summary>
        Undefined1755 = 1755,
        // <summary>
        // *
        // <summary>
        Undefined1756 = 1756,
        // <summary>
        // *
        // <summary>
        Undefined1757 = 1757,
        // <summary>
        // *
        // <summary>
        Undefined1758 = 1758,
        // <summary>
        // *
        // <summary>
        Undefined1759 = 1759,
        // <summary>
        // *
        // <summary>
        Undefined1760 = 1760,
        // <summary>
        // The character has already been blacklisted by the group.
        // <summary>
        CharacterBlacklistedByGroup = 1761,
        // <summary>
        // *
        // <summary>
        Undefined1762 = 1762,
        // <summary>
        // The character has already been blacklisted.
        // <summary>
        CharacterAlreadyBlacklisted = 1763,
        // <summary>
        // You have already been blacklisted.
        // <summary>
        AlreadyBlacklisted = 1764,
        // <summary>
        // You can only blacklist someone on general fields.
        // <summary>
        BlacklistImpossibleHere = 1765,
        // <summary>
        // You cannot blacklist family members.
        // <summary>
        CannotBlackListFamily = 1766,
        // <summary>
        // You cannot blacklist party members.
        // <summary>
        CannotBlackListGroup = 1767,
        // <summary>
        // You cannot blacklist members of your raid group.
        // <summary>
        CannotBlackListTeam = 1768,
        // <summary>
        // You cannot blacklist friends.
        // <summary>
        CannotBlackListFriend = 1769,
        // <summary>
        // This character has already been blacklisted.
        // <summary>
        CharacterBlacklisted = 1770,
        // <summary>
        // Because you already have 50 people on your blacklist, you cannot add any more.
        // <summary>
        MaximumBlacklistReached = 1771,
        // <summary>
        // Block
        // <summary>
        Block = 1772,
        // <summary>
        // *
        // <summary>
        Undefined1773 = 1773,
        // <summary>
        // Number of love testimonials received: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        LoveRecived = 1774,
        // <summary>
        // Do you want to transform back?
        // <summary>
        AskTransformBack = 1775,
        // <summary>
        // *
        // <summary>
        Undefined1776 = 1776,
        // <summary>
        // *
        // <summary>
        Undefined1777 = 1777,
        // <summary>
        // *
        // <summary>
        Undefined1778 = 1778,
        // <summary>
        // *
        // <summary>
        Undefined1779 = 1779,
        // <summary>
        // *
        // <summary>
        Undefined1780 = 1780,
        // <summary>
        // *
        // <summary>
        Undefined1781 = 1781,
        // <summary>
        // *
        // <summary>
        Undefined1782 = 1782,
        // <summary>
        // *
        // <summary>
        Undefined1783 = 1783,
        // <summary>
        // *
        // <summary>
        Undefined1784 = 1784,
        // <summary>
        // *
        // <summary>
        Undefined1785 = 1785,
        // <summary>
        // *
        // <summary>
        Undefined1786 = 1786,
        // <summary>
        // *
        // <summary>
        Undefined1787 = 1787,
        // <summary>
        // *
        // <summary>
        Undefined1788 = 1788,
        // <summary>
        // *
        // <summary>
        Undefined1789 = 1789,
        // <summary>
        // *
        // <summary>
        Undefined1790 = 1790,
        // <summary>
        // *
        // <summary>
        Undefined1791 = 1791,
        // <summary>
        // *
        // <summary>
        Undefined1792 = 1792,
        // <summary>
        // *
        // <summary>
        Undefined1793 = 1793,
        // <summary>
        // *
        // <summary>
        Undefined1794 = 1794,
        // <summary>
        // *
        // <summary>
        Undefined1795 = 1795,
        // <summary>
        // *
        // <summary>
        Undefined1796 = 1796,
        // <summary>
        // *
        // <summary>
        Undefined1797 = 1797,
        // <summary>
        // *
        // <summary>
        Undefined1798 = 1798,
        // <summary>
        // You are already married!
        // <summary>
        AlreadyMarried = 1799,
        // <summary>
        // Select an appropriate target!
        // <summary>
        SelectAppropriateTarget = 1800,
        // <summary>
        // This player is already married.
        // <summary>
        PlayerAlreadyMarried = 1801,
        // <summary>
        // Both members must agree to break up the group.
        // <summary>
        BothMustAgreeToBreakGroup = 1802,
        // <summary>
        // Would you like to propose to %s with Cupid's Arrow?#13#10(Warning: Cupid's Arrow will be consumed regardless of the result.)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskPropose = 1803,
        // <summary>
        // You cannot delete your spouse!
        // <summary>
        CantDeleteSpouse = 1804,
        // <summary>
        // You have separated from your spouse.
        // <summary>
        SpouseSeparated = 1805,
        // <summary>
        // You have proposed to %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HaveProposed = 1806,
        // <summary>
        // %s has proposed to you. Would you like to accept the proposal?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskAcceptPropose = 1807,
        // <summary>
        // Cannot be used.
        // <summary>
        CantBeUsed = 1808,
        // <summary>
        // Cannot be used while you are in a group.
        // <summary>
        CantUseInGroup = 1809,
        // <summary>
        // %s has declined %s's proposal.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        ProposalDeclined = 1810,
        // <summary>
        // %s and %s are now married.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayersMarried = 1811,
        // <summary>
        // Do you want to separate from your spouse?
        // <summary>
        AskSeparateSpouse = 1812,
        // <summary>
        // Do you want to save your position and return to the village?#13#10Click Cancel to go back to the village without saving your position.#13#10
        // <summary>
        AmuletMessageToSavePositionAndReturnToVillage = 1813,
        // <summary>
        // Do you want to save your position and return to the desert village?#13#10Click Cancel to go back to the desert village without saving your position.#13#10
        // <summary>
        AmuletMessageToSavePositionAndReturnToDesertVillage = 1814,
        // <summary>
        // The phantom's shackles have been weakened.
        // <summary>
        PhantomShacklesWeakened = 1815,
        // <summary>
        // The phantom has been shackled again.
        // <summary>
        PhantomShackledAgain = 1816,
        // <summary>
        // Illuminate!
        // <summary>
        Illuminate = 1817,
        // <summary>
        // Baron Berios is gathering the power of light.
        // <summary>
        BeriosGetPower = 1818,
        // <summary>
        // The phantom is gathering the power of light.
        // <summary>
        PhantomGetPower = 1819,
        // <summary>
        // Go back to the light!
        // <summary>
        GoBackToLight = 1820,
        // <summary>
        // Support me!
        // <summary>
        SupportMe = 1821,
        // <summary>
        // A phantom appears.
        // <summary>
        PhantomAppears = 1822,
        // <summary>
        // The 15th Anniversary Buff is now active!
        // <summary>
        AnniversaryBuffActivated = 1823,
        // <summary>
        // The effect of the 15th Anniversary Medal is still active.
        // <summary>
        AnniversaryMedalActivated = 1824,
        // <summary>
        // The effect of the 15th Anniversary Medal is now over.
        // <summary>
        AnniversaryMedalOver = 1825,
        // <summary>
        // If you put on a costume, I'll give you some more treats.
        // <summary>
        PutCostumeToGetTreats = 1826,
        // <summary>
        // You obviously know how to have fun at Halloween. Take two handfuls of sweets with you.
        // <summary>
        KnowHowToFunAtHalloween = 1827,
        // <summary>
        // The items have been successfully added to the NosBazaar.
        // <summary>
        ItemAddedToBazar = 1828,
        // <summary>
        // The price per piece must not exceed %d Gold. (Using the NosMerchant Medal you can enter a higher price.)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        UseMedalToEnterHigherPrice = 1829,
        // <summary>
        // Insufficient Gold available.
        // <summary>
        InsufficientGoldAvailable = 1830,
        // <summary>
        // The offer has been updated. The purchase has been aborted.
        // <summary>
        OfferUpdated = 1831,
        // <summary>
        // The item has disappeared as the usage period elapsed.
        // <summary>
        UsagePeriodFinished = 1832,
        // <summary>
        // You don't have enough Gold to pay the listing fee.
        // <summary>
        NoGoldToPayFee = 1833,
        // <summary>
        // You don't have enough items to list them.
        // <summary>
        NoItemsToListThem = 1834,
        // <summary>
        // You cannot accept the Gold as you would exceed the maximum Gold limit.
        // <summary>
        GoldLimitReachedCannotAcceptGoldFromTrade = 1835,
        // <summary>
        // You cannot send a request to the player as they are currently using the NosBazaar.
        // <summary>
        ExchangeNotAllowedIfPlayerIsUsingNosbazar = 1836,
        // <summary>
        // An error has occurred during the purchase.
        // <summary>
        NosbazarPurchaseError = 1837,
        // <summary>
        // You have bought the following item: %s x %d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        BoughtItem = 1838,
        // <summary>
        // This item cannot be listed.
        // <summary>
        CantListItem = 1839,
        // <summary>
        // The maximum number of items have already been listed. Remove item offers from the NosBazaar which have already expired or finished. (If you use a NosMerchant Medal you can list up to 100 items at the same time.)
        // <summary>
        ListedMaxItemsNumber = 1840,
        // <summary>
        // Insufficient space available in inventory.
        // <summary>
        NotEnoughSpace = 1841,
        // <summary>
        // The total price must not exceed %d Gold.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NotExceedMaxPrice = 1842,
        // <summary>
        // The purchase has been completed. Gold - %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PurchaseCompletedWithGoldUsed = 1843,
        // <summary>
        // Your NosMerchant Medal has expired. Close the NosBazaar menu and open it again.
        // <summary>
        NosMerchantExpired = 1844,
        // <summary>
        // The NosMerchant Medal effect is active.
        // <summary>
        NosMerchantActive = 1845,
        // <summary>
        // Insert the price of the item.
        // <summary>
        InsertPrice = 1846,
        // <summary>
        // You cannot accept their proposal.
        // <summary>
        CannotAcceptProposal = 1847,
        // <summary>
        // Are you sure you want to do this?
        // <summary>
        AreYouSure = 1848,
        // <summary>
        // You receive the following item: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        MessageReceiveFollowingItem = 1849,
        // <summary>
        // You receive a bell.
        // <summary>
        ReceiveBell = 1850,
        // <summary>
        // You cannot catch monsters with that.
        // <summary>
        CantCatchWithThat = 1851,
        // <summary>
        // You didn't catch the monster; it has escaped.
        // <summary>
        DidntCatch = 1852,
        // <summary>
        // The purchase has been completed successfully. %s x %d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        PurchaseCompleted = 1853,
        // <summary>
        // *
        // <summary>
        Undefined1854 = 1854,
        // <summary>
        // The Fire Wings are already equipped.
        // <summary>
        FireWingsAlreadyEquiped = 1855,
        // <summary>
        // %s has been appointed raid leader.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerBecameNewRaidLeader = 1856,
        // <summary>
        // As the recommended level does not correspond to that of the raid, a raidbox cannot be issued even if the raid is completed successfully.
        // <summary>
        PlayerLevelDoesNotMatchRaidRequirementsToReceiveBox = 1857,
        // <summary>
        // As %s's level does not correspond to that of the raid, the player will not be included in the lives or rewards received.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerLevelDoesNotMatchRaidRequirementsToReceiveReward = 1858,
        // <summary>
        // You have successfully completed this raid as a raid helper.
        // <summary>
        CompletedRaidAsHelper = 1859,
        // <summary>
        // The raid helper's mission has been completed successfully. %d reputation received.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        HelperMissionDone = 1860,
        // <summary>
        // The raid helper's mission has failed.
        // <summary>
        HelperMissionFailed = 1861,
        // <summary>
        // It's time! You're taking part in the raid helper's mission.
        // <summary>
        TakingHelperMission = 1862,
        // <summary>
        // *
        // <summary>
        Undefined1863 = 1863,
        // <summary>
        // *
        // <summary>
        Undefined1864 = 1864,
        // <summary>
        // *
        // <summary>
        Undefined1865 = 1865,
        // <summary>
        // Do you want to use the Magic Lamp to change your gender? Caution: Once you change your gender, you cannot change it back again.
        // <summary>
        AskChangeGender = 1866,
        // <summary>
        // You have changed your gender with the Magic Lamp.
        // <summary>
        GenderChanged = 1867,
        // <summary>
        // Please note that you can be attacked while you have the NosBazaar open.
        // <summary>
        AttackWhileBazar = 1868,
        // <summary>
        // With the NosMerchant Medal you can use the NosBazaar on all general maps at any time.
        // <summary>
        NosMerchantMedaleAllowPlayerToUseNosbazarOnAllGeneralMaps = 1869,
        // <summary>
        // The raid helper's mission can only be completed if at least three players are in the boss room when finishing the raid.
        // <summary>
        RaidHelpersMissionRequireThreePlayersInBossRoomToBeCompleted = 1870,
        // <summary>
        // *
        // <summary>
        Undefined1871 = 1871,
        // <summary>
        // The Magic Egg gives you the power to revive yourself without the raid team losing hearts.
        // <summary>
        MagicEggsDontLoseHearts = 1872,
        // <summary>
        // Cannot be used on NosMates that are already following you.
        // <summary>
        CannotBeUsedOnNosmateAlreadyFollowingPlayer = 1873,
        // <summary>
        // You cannot use it while your NosMate is unsettled. Time remaining: %d minutes<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CannotUseItemWhilePetIsUpsetAndTimeRemaining = 1874,
        // <summary>
        // You cannot use it while your NosMate is very unsettled. Time remaining: %d minutes<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CannotUseItemWhilePetIsVeryUpsetAndTimeRemaining = 1875,
        // <summary>
        // Chicken Queen
        // <summary>
        ChickenQueen = 1876,
        // <summary>
        // NosMates with negative loyality cannot follow you. Time remaining: %d minutes<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MateNegativeLoyality = 1877,
        // <summary>
        // The Little Chick has successfully grown into a Grumbly Chicky.
        // <summary>
        LittleChickEvolved = 1878,
        // <summary>
        // The Grumbly Chicky has successfully grown into a Chick Norris.
        // <summary>
        GrumblyChickyEvolved = 1879,
        // <summary>
        // The Little Chick's development has failed and it will now be unsettled for 30 minutes.
        // <summary>
        LittleChickEvolveFailed = 1880,
        // <summary>
        // The Grumbly Chicky's development has failed and it will now be unsettled for 50 minutes.
        // <summary>
        GrumblyChickEvolveFailed = 1881,
        // <summary>
        // [%s]'s Grumbly Chicky has successfully grown into a Chick Norris.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GrumblyChickyEvolveInfo = 1882,
        // <summary>
        // The first time you successfully complete the Chicken Queen Raid, everyone will have a 100% chance of receiving a Chicken Queen's Egg once per account.
        // <summary>
        AfterDefeatTheChickenQueenRaidEveryoneWillGetChickenEggOncePerAccount = 1883,
        // <summary>
        // The Specialist Card upgrade failed.
        // <summary>
        SpecialistUpgradeFailed = 1884,
        // <summary>
        // 1 %s has been consumed.
        // <summary>
        [Game18NArguments(typeof(string))]
        OneAlreadyBeingUsed = 1885,
        // <summary>
        // Can only be used if you are mounted.
        // <summary>
        CanOnlyUseMounted = 1886,
        // <summary>
        // You have reached the maximum number of pet slots.
        // <summary>
        MaxPetSlots = 1887,
        // <summary>
        // Do you want to permanently increase your pet slots by %d?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AskIncreasePetSlots = 1888,
        // <summary>
        // Pet slots permanently increased by %d slots.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PetSlotsIncreased = 1889,
        // <summary>
        // Smileys will now be hidden.
        // <summary>
        SmileysDisabled = 1890,
        // <summary>
        // Smileys will now be displayed.
        // <summary>
        SmileysEnabled = 1891,
        // <summary>
        // HP status will now be hidden.
        // <summary>
        HpStatusDisabled = 1892,
        // <summary>
        // HP status will now be displayed.
        // <summary>
        HpStatusEnabled = 1893,
        // <summary>
        // Buff sequence will now be hidden.
        // <summary>
        BuffSequenceHidden = 1894,
        // <summary>
        // Buff sequence will now be shown.
        // <summary>
        BuffSequenceShown = 1895,
        // <summary>
        // You need to take off your partner's equipment.
        // <summary>
        TakeOffPartnerEquipment = 1896,
        // <summary>
        // Your partner is eating the food very hesitantly.
        // <summary>
        PartnerEatHesitantly = 1897,
        // <summary>
        // You have already used the NosMate Summoning Book for this NosMate.
        // <summary>
        SummoningBookAlreadyUsed = 1898,
        // <summary>
        // You have used the NosMate Summoning Book for %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UsedMateSummoningBook = 1899,
        // <summary>
        // That is not currently possible.
        // <summary>
        ThatIsNotCurrentlyPossible = 1900,
        // <summary>
        // The partner is already accompanying you.
        // <summary>
        PartnerAlreadyAccompanying = 1901,
        // <summary>
        // The pet is already accompanying you.
        // <summary>
        PetAlreadyAccompanying = 1902,
        // <summary>
        // %s has been sent back to the Miniland.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SentBackToMiniland = 1903,
        // <summary>
        // The NosMate has been summoned.
        // <summary>
        MateSummoned = 1904,
        // <summary>
        // Should the NosMate return to the Miniland?
        // <summary>
        AskMateReturn = 1905,
        // <summary>
        // Glacerus the Ice Cold
        // <summary>
        GlacerusIceCold = 1906,
        // <summary>
        // The sacrifice effect has been lifted, because the selected player is outside of the area.
        // <summary>
        SacrificeEffectLiftedBecuaseSelectedPlayerLeftTheArea = 1907,
        // <summary>
        // The sacrifice effect has almost been lifted, because the distance to the selected player is getting too large.
        // <summary>
        SacrificeEffectLiftedBecuaseSelectedPlayerIsTooFarAways = 1908,
        // <summary>
        // You cannot upgrade this Specialist Card.
        // <summary>
        CantUpgradeSpecialist = 1909,
        // <summary>
        // That is not a target.
        // <summary>
        ThatIsNotATarget = 1910,
        // <summary>
        // Return to me after you have destroyed Glacerus' Ice Seal in the Time-Space.
        // <summary>
        ReturnToMeAfterHavingDefeatedGlacerus = 1911,
        // <summary>
        // You cannot put this Specialist Card in a Card Holder.
        // <summary>
        NotBeAbleToPutTheSelectedSpecialistCardIntoCardHolder = 1912,
        // <summary>
        // You cannot take part in the raid, because you are not carrying the Mystical Glacier Stone.
        // <summary>
        GlacerusAmuletNeeded = 1913,
        // <summary>
        // Glacerus: I'm exiling you into the eternal ice, weakling!
        // <summary>
        GlacerusMessageExilingYouInTheEternalIce = 1914,
        // <summary>
        // The daily limit for participating in the Element Raid has been reset.
        // <summary>
        DailyLimitElementRaidReset = 1915,
        // <summary>
        // Will you survive the ice storm?
        // <summary>
        WillSurviveIceStorm = 1916,
        // <summary>
        // Glacerus the Ice Cold channels cold and frost into a storm.
        // <summary>
        GlacerusStorm = 1917,
        // <summary>
        // Elisia: Save yourselves by getting into a protective square!
        // <summary>
        GlacerosStormMessageToGoInTheSafeSquare = 1918,
        // <summary>
        // You cannot transform here.
        // <summary>
        CantTransformHere = 1919,
        // <summary>
        // %s sacrifices themselves for %s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerSacrificesThemselvesForX = 1920,
        // <summary>
        // The Spanish riding cockerel has successfully hatched and you have received Marco Pollo.
        // <summary>
        MarcoPolloReceivedAfterFinishingSpanishRidingCockerel = 1921,
        // <summary>
        // Attack
        // <summary>
        Attack = 1922,
        // <summary>
        // Defence
        // <summary>
        Defence = 1923,
        // <summary>
        // HP/MP
        // <summary>
        HpMp = 1924,
        // <summary>
        // Element
        // <summary>
        Element = 1925,
        // <summary>
        // Fire resistance
        // <summary>
        FireResistance = 1926,
        // <summary>
        // Water resistance
        // <summary>
        WaterResistance = 1927,
        // <summary>
        // Light resistance
        // <summary>
        LightResistance = 1928,
        // <summary>
        // Shadow resistance
        // <summary>
        ShadowResistance = 1929,
        // <summary>
        // Perfecting the SP successful: +%d (%s)<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        PerfectingSpecialistSuccessful = 1930,
        // <summary>
        // Perfecting the SP failed
        // <summary>
        PerfectingSpecialistFailed = 1931,
        // <summary>
        // %s has defeated %s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerHasDefeteadPlayerX = 1932,
        // <summary>
        // If you leave the team now, you will receive a punishment before entering the team arena. Do you really wish to cancel?
        // <summary>
        IfLeavingTeamPlayerWillReceivePunishment = 1933,
        // <summary>
        // You don't have space in your inventory for further items.
        // <summary>
        SpaceForAdditionalObjectsReached = 1934,
        // <summary>
        // If you own %s (item) already, you cannot receive %s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        IfYouAlreadyOwnTheItemYouCannotReceiveThatAgain = 1935,
        // <summary>
        // The Arena of Talents is opening now on channel %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TalentArenaOpening = 1936,
        // <summary>
        // The Arena of Talents is open from %s-%s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        TalentArenaOpen = 1937,
        // <summary>
        // The Arena of Masters is opening now on channel %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        MasterArenaOpening = 1938,
        // <summary>
        // Sunday
        // <summary>
        Sunday = 1939,
        // <summary>
        // Monday
        // <summary>
        Monday = 1940,
        // <summary>
        // Tuesday
        // <summary>
        Tuesday = 1941,
        // <summary>
        // Wednesday
        // <summary>
        Wednesday = 1942,
        // <summary>
        // Thursday
        // <summary>
        Thursday = 1943,
        // <summary>
        // Friday
        // <summary>
        Friday = 1944,
        // <summary>
        // Saturday
        // <summary>
        Saturday = 1945,
        // <summary>
        // The Arena of Masters is open every week on %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ArenaMastersEveryWeek = 1946,
        // <summary>
        // %s-%s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        Dash = 1947,
        // <summary>
        // %s has left the team arena.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        LeftArenaTeam = 1948,
        // <summary>
        // You cannot create groups during registration.
        // <summary>
        CantPartyDuringQueue = 1949,
        // <summary>
        // The Arena of Masters' highscore and number of entries has been reset.
        // <summary>
        ArenaMasterHighscoreAndEntriesReset = 1950,
        // <summary>
        // Another %d minutes until the start of the battle. Good luck!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AnotherMinuteToStartTheBattle = 1951,
        // <summary>
        // Choose the sequence of the fighting participants, otherwise it will be set randomly.
        // <summary>
        ChoseSequenceOfPartecipantsOrItWillBeRandom = 1952,
        // <summary>
        // Erenia
        // <summary>
        Erenia = 1953,
        // <summary>
        // Zenas
        // <summary>
        Zenas = 1954,
        // <summary>
        // draw
        // <summary>
        Draw2 = 1955,
        // <summary>
        // %d Gold<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Gold = 1956,
        // <summary>
        // You have received %s as a reward from the Arena of Talents.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RewardFromArenaTalents = 1957,
        // <summary>
        // Points earned %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PointsEarned = 1958,
        // <summary>
        // The number of entries for the Arena of Masters has been increased by 1.
        // <summary>
        ArenaMastersEntriesIncreased = 1959,
        // <summary>
        // You can only register on the arena map.
        // <summary>
        RegisterAtArena = 1960,
        // <summary>
        // The penalty will last for another %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PenaltyLastInSeconds = 1961,
        // <summary>
        // You can only register %d times a day.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RegisterDailyLimit = 1962,
        // <summary>
        // You cannot register if you are in a group.
        // <summary>
        CantRegisterInGroup = 1963,
        // <summary>
        // Already registered.
        // <summary>
        AlreadyRegistered3 = 1964,
        // <summary>
        // Family level increased to %d!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        FamilyLevelIncreased = 1965,
        // <summary>
        // You cannot talk to others while you are using the warehouse.
        // <summary>
        CantTalkWhileWarehouse = 1966,
        // <summary>
        // %s Gold is required.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GoldRequired = 1967,
        // <summary>
        // It is not possible to use the warehouse right now.
        // <summary>
        CantUseWarehouse = 1968,
        // <summary>
        // Permissions have been changed.
        // <summary>
        PermissionsChanged = 1969,
        // <summary>
        // The 'Quote of the Day' has already been published. (Possible again from 5 AM)
        // <summary>
        QuotePublished = 1970,
        // <summary>
        // Player is already a member of this family.
        // <summary>
        PlayerAlreadyInFamily = 1971,
        // <summary>
        // This has already been purchased.
        // <summary>
        AlreadyPurchased = 1972,
        // <summary>
        // You have to purchase the standard version first.
        // <summary>
        RequestToPurchaseStandardVersionFirst = 1973,
        // <summary>
        // Only the family head can purchase it.
        // <summary>
        HeadCanPurchaseOnly = 1974,
        // <summary>
        // Your family level is insufficient.
        // <summary>
        FamilyLevelInsufficient = 1975,
        // <summary>
        // Family reward: %d FXP<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        FamilyReward = 1976,
        // <summary>
        // (%d per player)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PerNewPlayer = 1977,
        // <summary>
        // Reward: %d action points<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RewardActionPoints = 1978,
        // <summary>
        // Do you want to purchase a warehouse (%d slots)?#13#10<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AskPurchaseWarehouse = 1979,
        // <summary>
        // %d slots are available.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        SlotsAvailable = 1980,
        // <summary>
        // %d more slots available.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MoreSlotsAvailable = 1981,
        // <summary>
        // Item has been removed from warehouse - %d x %s<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        RemovedFromWarehouse = 1982,
        // <summary>
        // Item has been added to warehouse - %d x %s<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        AddedToWarehouse = 1983,
        // <summary>
        // An error occurred whilst listing in the warehouse - %d x %s<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        ErrorWhileWarehouse = 1984,
        // <summary>
        // Do you want to expand the warehouse by %d slots?#13#10<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AskExpandWarehouse = 1985,
        // <summary>
        // No family warehouse available.
        // <summary>
        NoFamilyWarehouseAvailable = 1986,
        // <summary>
        // The daily limit for using the warehouse (100 times per player) has been reached. Until 5 AM, only the family head can remove items.
        // <summary>
        FamilyWarehouseUsageDailyLimitReachedPerPlayer = 1987,
        // <summary>
        // The daily limit for using the warehouse (200 times per family) has been reached. Until 5 AM, only the family head can remove items.
        // <summary>
        FamilyWarehouseUsageDailyLimitReachedPerFamily = 1988,
        // <summary>
        // Do you want to increase the maximum number of family members (%d more players)?#13#10<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AskExpandFamily = 1989,
        // <summary>
        // The maximum number of family members has been increased.
        // <summary>
        FamilyExpanded = 1990,
        // <summary>
        // %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        User = 1991,
        // <summary>
        // %s has logged in.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UserHasLoggedIn = 1992,
        // <summary>
        // *
        // <summary>
        Undefined1893 = 1993,
        // <summary>
        // *
        // <summary>
        Undefined1894 = 1994,
        // <summary>
        // You've already received it.
        // <summary>
        YouHaveAlreadyReceivedIt = 1995,
        // <summary>
        // You failed miserably at gambling!
        // <summary>
        GamblingFailed = 1996,
        // <summary>
        // Captain Pete O'Peng
        // <summary>
        CaptainPeteOPeng = 1997,
        // <summary>
        // I will destroy you with the force of the seven seas!
        // <summary>
        ForceOfTheSevenSeas = 1998,
        // <summary>
        // Captain Pete O'Peng has set sea dragons on you.
        // <summary>
        SeaDragonsOnYou = 1999,
        // <summary>
        // Are you sure you want to use that??
        // <summary>
        WantToUseThat = 2000,
        // <summary>
        // Are you sure you want to gamble?
        // <summary>
        DoYouWantToGamble = 2001,
        // <summary>
        // You have already completed the day's quest.
        // <summary>
        DailyQuestAlredyCompleted = 2002,
        // <summary>
        // You have been encased in the heat of the Burning Sword.
        // <summary>
        HeatBurningSwordEncased = 2003,
        // <summary>
        // With the help of the Rune Piece you have arrived at the temple entrance.
        // <summary>
        UsedRunePieceToArriveAtTempleEntrance = 2004,
        // <summary>
        // Kertos
        // <summary>
        Kertos = 2005,
        // <summary>
        // Valakus
        // <summary>
        Valakus = 2006,
        // <summary>
        // Grenigas
        // <summary>
        Grenigas = 2007,
        // <summary>
        // URRGH!
        // <summary>
        Urrgh = 2008,
        // <summary>
        // Ggggggggggrrrrrrrrrrrrrrrr!
        // <summary>
        Ggggggggggrrrrrrrrrrrrrrrr = 2009,
        // <summary>
        // The power of the fire god will destroy everything!
        // <summary>
        FireGodDestroyEverything = 2010,
        // <summary>
        // %s has started to gather his strength.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        GatheringStrength = 2011,
        // <summary>
        // Grenigas has absorbed the Crystal of Life and earned new vitality.
        // <summary>
        AbsorbedCrystalLife = 2012,
        // <summary>
        // Grail the Tremendous Phoenix has transformed into an egg.
        // <summary>
        PhoenixIntoEgg = 2013,
        // <summary>
        // The tremendous phoenix Grail is reborn from the egg.
        // <summary>
        PhoenixReborned = 2014,
        // <summary>
        // 1 %s has been bought for %d Gold<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        HasBeenBoughtForGold = 2015,
        // <summary>
        // You have put the mount in the bead.
        // <summary>
        PutMountInBead = 2016,
        // <summary>
        // You have taken the mount out of the bead.
        // <summary>
        MountOutOfBead = 2017,
        // <summary>
        // Do you want to remove the mount from the bead?
        // <summary>
        AskMountRemoveFromBead = 2018,
        // <summary>
        // Phoenix, arise!
        // <summary>
        PhoenixArise = 2019,
        // <summary>
        // The smouldering lava stone has exploded.
        // <summary>
        SmoulderingLavaStoneExploded = 2020,
        // <summary>
        // The power of fire is gathering around Grenigas!
        // <summary>
        PowerAroundGrenigas = 2021,
        // <summary>
        // Your NosMate eats the food very tentatively.
        // <summary>
        MateEatTentatively = 2022,
        // <summary>
        // %s are already being used.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        BeingUsed = 2023,
        // <summary>
        // You can only use it if your pet is accompanying you.
        // <summary>
        UseOnlyIfPetAccompanyingPlayer = 2024,
        // <summary>
        // When you successfully complete the Chicken Queen raid, you have a 100%% chance of receiving a Mysterious Egg. Only possible once per account.
        // <summary>
        MysteriousEggReceivedOncePerAccountAfterFinishedChickenQueenRaid = 2025,
        // <summary>
        // Your pet has successfully developed.
        // <summary>
        PetDevelopmentSucceeded = 2026,
        // <summary>
        // %s's pet has successfully developed into a %s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PetDevelopedIntoX = 2027,
        // <summary>
        // Your pet's development has failed. It is now unsettled.
        // <summary>
        PetDevelopmentFailed = 2028,
        // <summary>
        // Your pet has hatched.
        // <summary>
        PetHatched = 2029,
        // <summary>
        // Your level is too low. You can only enter from level %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TooLowLevelToEntry = 2030,
        // <summary>
        // Click anywhere with your mouse to get up immediately.
        // <summary>
        ClickToGetUp = 2031,
        // <summary>
        // You will not automatically get up when you are resting.
        // <summary>
        FastGetUpDisabled = 2032,
        // <summary>
        // Lord Draco
        // <summary>
        LordDraco = 2033,
        // <summary>
        // You can take part in the %s raid %d times today.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        DailyEntriesLimitInfo = 2034,
        // <summary>
        // (Daily limit %d times + event %d times)<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(long), typeof(long))]
        DailyLimitEventTime = 2035,
        // <summary>
        // You need this item: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        NeedThisItem = 2036,
        // <summary>
        // You cannot take part in the raid because you are not carrying the Hero's Amulet of Fire.
        // <summary>
        FireAmuletNeededToRaid = 2037,
        // <summary>
        // The level of your specialist card is too low.
        // <summary>
        TooLowSpecialistLevel = 2038,
        // <summary>
        // Your specialist card's experience values are already at 100%%.
        // <summary>
        MaxSpecialistCardExperienceReached = 2039,
        // <summary>
        // The experience values have been increased to 100%%.
        // <summary>
        SetExperienceValueToMax = 2040,
        // <summary>
        // The daily limit for participating in the %s raid has been reset.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RaidEntriesLimitReset = 2041,
        // <summary>
        // You have reached your daily limit and cannot take part in the %s raid anymore.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RaidEntriesLimitReached = 2042,
        // <summary>
        // If you use %s you can take part in the raid again.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        UseItemToJoinRaid = 2043,
        // <summary>
        // You need the following item to take part in the raid: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        NeedItemToJoinRaid = 2044,
        // <summary>
        // You can only use the Handkerchief of Separation when your partner is not carrying any more equipment.
        // <summary>
        ReleasePartnerWithoutEquipmentOnly = 2045,
        // <summary>
        // That is only possible if your partner is accompanying you.
        // <summary>
        PartnerMustAccompanying = 2046,
        // <summary>
        // Your partner already has this skill.
        // <summary>
        PartnerHasSkill = 2047,
        // <summary>
        // You must first reverse your partner's transformation.
        // <summary>
        CancelPartnerSpecialist = 2048,
        // <summary>
        // Your partner needs more agility!
        // <summary>
        PartnerNeedAgility = 2049,
        // <summary>
        // Your partner now has the skill.
        // <summary>
        YourPartnerNowHasSkill = 2050,
        // <summary>
        // You must equip your partner with a Specialist Card first.
        // <summary>
        EquipPartnerWithSpecialist = 2051,
        // <summary>
        // This only works with a Specialist Card that has at least one skill.
        // <summary>
        SpecialistMustHasOneSkill = 2052,
        // <summary>
        // The required skill level is insufficient.
        // <summary>
        SkillLevelInsufficient = 2053,
        // <summary>
        // Do you want to change the chosen skill level?
        // <summary>
        AskChangeSkillLevelChosen = 2054,
        // <summary>
        // All skills have been reset.
        // <summary>
        AllSkillReset = 2055,
        // <summary>
        // The skill level has been changed.
        // <summary>
        SkillLevelChanged = 2056,
        // <summary>
        // The Specialist Card can only be worn by a partner who is accompanying you.
        // <summary>
        SpecialistCardEquippedOnlyIfParterAccompanyingPlayer = 2057,
        // <summary>
        // Do you want to put the Specialist Partner Card into a Card Holder?
        // <summary>
        AskPutSpecialistIntoHolder = 2058,
        // <summary>
        // Do you want to remove the Specialist Partner Card from the Card Holder?
        // <summary>
        AskRemoveSpecialistFromHolder = 2059,
        // <summary>
        // You have put the Specialist Partner Card into a Card Holder.
        // <summary>
        PutSpecialistIntoHolder = 2060,
        // <summary>
        // You took the Specialist Partner Card out of the Card Holder.
        // <summary>
        SpecialistPartnerCardOutOfHolder = 2061,
        // <summary>
        // Aegir the Angry
        // <summary>
        AegirAngry = 2062,
        // <summary>
        // Barni the Clever
        // <summary>
        BarniClever = 2063,
        // <summary>
        // Freya the Fateful
        // <summary>
        FreyaFateful = 2064,
        // <summary>
        // The side effects of transformation have vanished.
        // <summary>
        SideEffectTransformationVanished = 2065,
        // <summary>
        // Do you want to change all the skill levels?
        // <summary>
        WantToChangeAllSkillLevels = 2066,
        // <summary>
        // You must first complete the Viking Quest before you can do the raid.
        // <summary>
        YouMustfirstCompleteVikingQuestBeforeRaid = 2067,
        // <summary>
        // You cannot use it if skill level S has been reached.
        // <summary>
        CannotUseIfSkillLevelReached = 2068,
        // <summary>
        // Your partner's skill level is S. Do you really want to reset it?
        // <summary>
        PartnersSResetItQuestion = 2069,
        // <summary>
        // Your partner's agility has reached 100%.
        // <summary>
        PartnersAgilityMax = 2070,
        // <summary>
        // Find participants
        // <summary>
        FindParticipants = 2071,
        // <summary>
        // Find opposing team
        // <summary>
        FindOpposingTeam = 2072,
        // <summary>
        // May participate in the Arena of Talents %d more times.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MayParticipateArenaOfTalent = 2073,
        // <summary>
        // The maximum number of participants has been reached.
        // <summary>
        MaximumParticipantReached = 2074,
        // <summary>
        // No participants found
        // <summary>
        NoParticipantFound = 2075,
        // <summary>
        // No opposing team found
        // <summary>
        NoOposingTean = 2076,
        // <summary>
        // You cannot view any other battles as long as registration is in progress.
        // <summary>
        CanNotWatchWhileRegistered = 2077,
        // <summary>
        // No battle is currently taking place.
        // <summary>
        NoBattleCurrently = 2078,
        // <summary>
        // The opponent is not currently in combat.
        // <summary>
        OpponentNotInBattle = 2079,
        // <summary>
        // All participants must stay on a map.
        // <summary>
        AllParticipantMustStayOnMap = 2080,
        // <summary>
        // Amongst the participants there are players that are already registered.
        // <summary>
        AmongTheUsersThereArePlayersWhoAreAlreadyRegistered = 2081,
        // <summary>
        // This participant is currently being punished.
        // <summary>
        ThisParticipantIsCurrentlybeingPunished = 2082,
        // <summary>
        // One participant's number of entries is too low for the Arena of Masters.
        // <summary>
        OneParticipantsNumberofEntriesIsTooLowForTheArenaofMasters = 2083,
        // <summary>
        // This participant has a low level.
        // <summary>
        ParticipantHasLowLevel = 2084,
        // <summary>
        // The team arena has been closed due to a problem with the application.
        // <summary>
        TheTeamArenaHasBeenClosedDueToAProblemWithTheApplication = 2085,
        // <summary>
        // You are in team %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        InTeam = 2086,
        // <summary>
        // Winner! %s [%s]<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        Winner2087 = 2087,
        // <summary>
        // Winner! %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        Winner2088 = 2088,
        // <summary>
        // The game of hide-and-seek is coming to a close. Good item!
        // <summary>
        EndOfHideAndSeek = 2089,
        // <summary>
        // The participant has cancelled the registration.
        // <summary>
        ParticipantCancelledRegistration = 2090,
        // <summary>
        // Try putting the team together again.
        // <summary>
        TrySearchingNewTeam = 2091,
        // <summary>
        // *
        // <summary>
        ExperiencePoints = 2092,
        // <summary>
        // Search for registered team now
        // <summary>
        SearchRegisteredTeam = 2093,
        // <summary>
        // Will be called by another participant after a short time: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CalledByAnotherParticipant = 2094,
        // <summary>
        // Opposing team found
        // <summary>
        OpposingTeamFound = 2095,
        // <summary>
        // Found registered team
        // <summary>
        FoundRegisteredTeam = 2096,
        // <summary>
        // You cannot play the mini-game because your level is too low. It can only be played from level %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        LevelTooLowForMinigame = 2097,
        // <summary>
        // You cannot play the mini-game because your reputation is too low. It can only be played with a reputation of %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReputationTooLowForMinigame = 2098,
        // <summary>
        // The Golden Equipment Protection Scroll was successfully used.
        // <summary>
        GoldenEquipmentProtectionSuccessfull = 2099,
        // <summary>
        // No item was selected for upgrading. Please try again.
        // <summary>
        NoItemSelectedUpgrade = 2100,
        // <summary>
        // The Arena of Masters is over. You cannot enter anymore.
        // <summary>
        ArenaOfMasterOver = 2101,
        // <summary>
        // The fairy will now be stored in the Fairy Bead.
        // <summary>
        FairyInBead = 2102,
        // <summary>
        // The fairy has been removed from the Fairy Bead.
        // <summary>
        FairyOutOfBead = 2103,
        // <summary>
        // Remove the fairy from the Fairy Bead?
        // <summary>
        RemoveFairyOfBead = 2104,
        // <summary>
        // The number of entries for the Arena of Masters is insufficient.
        // <summary>
        NumberOfEntriesInsufficient = 2105,
        // <summary>
        // You cannot register for the Icebreaker when you have just died.
        // <summary>
        CannotRegisterIcebreakerAfterDeath = 2106,
        // <summary>
        // Shinobi the Silent
        // <summary>
        Shinobi = 2107,
        // <summary>
        // Lotus the Graceful
        // <summary>
        Lotus = 2108,
        // <summary>
        // Orkani the Turbulent
        // <summary>
        Orkani = 2109,
        // <summary>
        // You cannot enter when you're in combat.
        // <summary>
        CantEnterInCombat = 2110,
        // <summary>
        // CAUTION: The amulet's protection has expired.
        // <summary>
        AmuletExpired = 2111,
        // <summary>
        // %d minutes remaining to explore Caligor's Realm.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RemainingMinutesCaligor = 2112,
        // <summary>
        // The entrance to Caligor's Realm is closed.
        // <summary>
        EntranceCaligorsRealmClosed = 2113,
        // <summary>
        // Caligor's Realm is closed.
        // <summary>
        CaligorsRealmClosed = 2114,
        // <summary>
        // Caligor's Realm is open.
        // <summary>
        CaligorsRealmOpen = 2115,
        // <summary>
        // Unfortunately you cannot enter Caligor's Realm as the maximum number of players has been reached.
        // <summary>
        CaligorMapFull = 2116,
        // <summary>
        // You will be revived at the entrance to Caligor's Realm.
        // <summary>
        WillBeRevivedEntranceCaligor = 2117,
        // <summary>
        // You will be returned to the city and removed from the raid if nothing happens for 1 minute.
        // <summary>
        SentToCityInOneMinute = 2118,
        // <summary>
        // You measly worms - your time is up!
        // <summary>
        MeaslyWormsTimeIsUp = 2119,
        // <summary>
        // This player has blocked the option for Miniland invitations.
        // <summary>
        PlayerBlockMinilandInvitation = 2120,
        // <summary>
        // Miniland invitations blocked
        // <summary>
        MinilandInviteBlocked = 2121,
        // <summary>
        // Miniland invitations permitted
        // <summary>
        MinilandInvitePermitted = 2122,
        // <summary>
        // Foxy
        // <summary>
        Foxy = 2123,
        // <summary>
        // Maru
        // <summary>
        Maru = 2124,
        // <summary>
        // Give me rice cakes! Or I'll eat you!
        // <summary>
        GiveRiceCakesO = 2125,
        // <summary>
        // I'm going to wipe you all out!
        // <summary>
        GoingToWipeYouAll = 2126,
        // <summary>
        // Maru in Mother's Fur
        // <summary>
        Undefined2127 = 2127,
        // <summary>
        // Will be revived in 20 seconds.
        // <summary>
        WillReviveInTwentySeconds = 2128,
        // <summary>
        // Witch Laurena
        // <summary>
        WitchLaurena = 2129,
        // <summary>
        // You cannot use this item while you are transformed.
        // <summary>
        CannotUseThisItemWhileTransformed = 2130,
        // <summary>
        // Laurena: I shall punish your weakness with a curse.
        // <summary>
        LaurenaCurse = 2131,
        // <summary>
        // Get over here!
        // <summary>
        GetOverHere = 2132,
        // <summary>
        // Imp Cheongbi and Hongbi
        // <summary>
        ImpCheongbiHongbi = 2133,
        // <summary>
        // Imp Cheongbi
        // <summary>
        ImpCheongbi = 2134,
        // <summary>
        // Imp Hongbi
        // <summary>
        ImpHongbi = 2135,
        // <summary>
        // The target is too far away.
        // <summary>
        TargetTooFarAway = 2136,
        // <summary>
        // This quest cannot be cancelled during the event.
        // <summary>
        QuestCannotBeCancelledDuringEvent = 2137,
        // <summary>
        // Archangel Lucifer
        // <summary>
        ArchangelLucifer = 2138,
        // <summary>
        // Infected by a morose mood...
        // <summary>
        InfectedMoroseMood = 2139,
        // <summary>
        // Can only be started with a minimum of 20 group members.
        // <summary>
        ItCanOnlyBeInitiatedWithTwentyPeople = 2140,
        // <summary>
        // White Witch Laurena
        // <summary>
        WhiteWitchLaurena = 2141,
        // <summary>
        // Reputation cannot be increased because of a glitch in the Matrix. ;)
        // <summary>
        ReputationCannotBeIncreasedBecauseOfAGlitchInTheMatrix = 2142,
        // <summary>
        // Overseer Amon
        // <summary>
        OverseerAmon = 2143,
        // <summary>
        // Only %d seconds until the next one appears.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NumberOfSecondsUntilNextOneAppears = 2144,
        // <summary>
        // Yay! Carrots!
        // <summary>
        YayCarrots = 2145,
        // <summary>
        // Don't move!
        // <summary>
        DontMove = 2146,
        // <summary>
        // Nasty Lola! You stole all the treasure from the Ocean Palace. I will never forgive you for that!
        // <summary>
        NastyLolaWillNeverForgiveYou = 2147,
        // <summary>
        // The evil tortoise appears!
        // <summary>
        EvilTortoiseAppears = 2148,
        // <summary>
        // Lola Lopears is on a rampage!
        // <summary>
        LolaLopearsOnRampage = 2149,
        // <summary>
        // I'll be back! *wink*
        // <summary>
        IllBeBackWink = 2150,
        // <summary>
        // Raphael, you pilfering fiend, I'll never give you the treasure! Never!
        // <summary>
        RaphaelYouPilferingFiendIllNeverGiveYouTheTreasure = 2151,
        // <summary>
        // Hngh? I did it!
        // <summary>
        HnghIDidIt = 2152,
        // <summary>
        // I'll take over here! You deal with the others!
        // <summary>
        IllTakeOverHereYouDealWithTheOthers = 2153,
        // <summary>
        // Lola Lopears
        // <summary>
        LolaLopears = 2154,
        // <summary>
        // Lucy Lopears
        // <summary>
        LucyLopears = 2155,
        // <summary>
        // You've already sent your rating for today.
        // <summary>
        AlreadySentRatingToday = 2156,
        // <summary>
        // You have commended %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HaveCommendedPercentZero = 2157,
        // <summary>
        // You have been commended by %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HaveBeenCommendedByPercentZero = 2158,
        // <summary>
        // You cannot criticise that player any more.
        // <summary>
        CannotCriticiseThatPlayerAnyMore = 2159,
        // <summary>
        // You have criticised %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HaveCriticisedPercentZero = 2160,
        // <summary>
        // You have been criticised by %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        HaveBeenCriticisedByPercentZero = 2161,
        // <summary>
        // Popularity rankings have been reset.
        // <summary>
        PopularityRankingsReset = 2162,
        // <summary>
        // You cannot enter while mounted.
        // <summary>
        CannotEnterWhileMounted = 2163,
        // <summary>
        // The popularity rankings have been recalculated.
        // <summary>
        ThePopularityRankingsRecalculated = 2164,
        // <summary>
        // The reputation rankings have been recalculated.
        // <summary>
        TheReputationRankingsRecalculated = 2165,
        // <summary>
        // You don't have enough reputation points to enter the raid.
        // <summary>
        NoReputationForEnteringTheRaid = 2166,
        // <summary>
        // As you are already in the rankings, you can only earn more reputation from PvP or a Glacernon raid.
        // <summary>
        ReputationOnlyFromPvpAndGlacernon = 2167,
        // <summary>
        // Reputation reduced: -%d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReputationReduced = 2168,
        // <summary>
        // Only the top three players from the rankings can use it.
        // <summary>
        OnlyTheTopThreePlayers = 2169,
        // <summary>
        // Remaining hero message(s): %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RemainingHeroMessages = 2170,
        // <summary>
        // You have used all hero messages.
        // <summary>
        AllHeroMessagesUsed = 2171,
        // <summary>
        // Only players above level 30 can commend other players.
        // <summary>
        OnlyPlayersAboveLevelThirtyLead = 2172,
        // <summary>
        // Do you want to switch the Power of Protection to the Power of Demons? Wins/losses will be reset.
        // <summary>
        SwitchToDemon = 2173,
        // <summary>
        // Do you want to switch the Power of Protection to the Power of Angels? Wins/losses will be reset.
        // <summary>
        SwitchToAngel = 2174,
        // <summary>
        // The PvP rankings for Glacernon have been updated.
        // <summary>
        ThePvPRankingsForGlacernonUpdated = 2175,
        // <summary>
        // The PvP rankings for Glacernon have been reset.
        // <summary>
        ThePvPRankingsForGlacernonReset = 2176,
        // <summary>
        // You cannot gain any points because the difference between level and reputation is too large.
        // <summary>
        LevelAndReputationIsHighToGetPoints = 2177,
        // <summary>
        // The enemy is exhausted. You cannot leech any more points.
        // <summary>
        EnemyExhausted = 2178,
        // <summary>
        // You cannot commend other players in Glacernon.
        // <summary>
        CannotLeadInGlacernon = 2179,
        // <summary>
        // You can commend someone again in %d minute(s).<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CantCommendNow = 2180,
        // <summary>
        // Cowgirl Chloe
        // <summary>
        CowgirlChloe = 2181,
        // <summary>
        // The number of entries to the Arena of Talents has been increased by 1. (Remaining: %d)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ArenaTalenEntriesIncreased = 2182,
        // <summary>
        // (+Arena Booster %d)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ArenaBooster = 2183,
        // <summary>
        // Your reputation is not high enough.
        // <summary>
        ReputationNotHighEnough = 2184,
        // <summary>
        // You have received %s from the Arena Booster.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RecivedFromArenaBooster = 2185,
        // <summary>
        // You have received an additional reward from the Arena Booster.
        // <summary>
        HaveReceivedAnAdditionalRewardFromTheArenaBooster = 2186,
        // <summary>
        // Your points were reset by a higher power in Glacernon.
        // <summary>
        PointsWereResetHigherPowerInGlacernon = 2187,
        // <summary>
        // You can only commend the player once per day and account.
        // <summary>
        CanOnlyLeadOncePerDayAndAccount = 2188,
        // <summary>
        // You cannot escape because of Caligor's curse.
        // <summary>
        CannotEscapeCaligorsCurse = 2189,
        // <summary>
        // Fiona
        // <summary>
        Fiona = 2190,
        // <summary>
        // You cannot confront Caligor any more.
        // <summary>
        CannotConfrontCaligor = 2191,
        // <summary>
        // The portal has closed.
        // <summary>
        PortalHasClosed = 2192,
        // <summary>
        // You can only change the Power of Protection once per day.
        // <summary>
        PowerOfProtectionOncePerDay = 2193,
        // <summary>
        // Jinn
        // <summary>
        Jinn = 2194,
        // <summary>
        // You cannot enter because your reputation is too low. You can only enter with a reputation greater than %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CantEnterTooLowReputation = 2195,
        // <summary>
        // Ice Princess Eliza
        // <summary>
        IcePrincessEliza = 2196,
        // <summary>
        // Daniel Ducats
        // <summary>
        DanielDucats = 2197,
        // <summary>
        // The Audience with Erenia has started.
        // <summary>
        AudienceEreniaStarted = 2198,
        // <summary>
        // The Audience with Zenas is over.
        // <summary>
        AudienceZenasOver = 2199,
        // <summary>
        // The Audience with Erenia is over.
        // <summary>
        AudienceEreniaOver = 2200,
        // <summary>
        // Zenas' first test will start shortly.
        // <summary>
        ZenasFirstTestWillStart = 2201,
        // <summary>
        // We have to stop them! Punish these evil forces!
        // <summary>
        StopPunishEvilForces = 2202,
        // <summary>
        // You've passed Zenas' first test. The second will soon begin.
        // <summary>
        ZenasFirstTestPassed = 2203,
        // <summary>
        // I've almost finished my prayer. Please give me more encouragement!
        // <summary>
        AlmostFinishedPrayerPleaseGiveMeMoreEncouragement = 2204,
        // <summary>
        // You have passed Zenas' second test. The final test will soon begin.
        // <summary>
        ZenasSecondTestPassed = 2205,
        // <summary>
        // I'm weakening Zenas' power. Please protect me until I've finished my prayer.
        // <summary>
        ProtectMeDuringPrayer = 2206,
        // <summary>
        // Congratulations! You have passed all the tests! Goddess Zenas has been launched into orbit around Ancelloan.
        // <summary>
        ZenasAllTestPassed = 2207,
        // <summary>
        // Your champion level is too low to learn this skill.
        // <summary>
        HerolevelTooLowToLearnSkill = 2208,
        // <summary>
        // Welcome to the Forgotten Archipelago! Your champion level has been unlocked.
        // <summary>
        HeroLevelUnlocked = 2209,
        // <summary>
        // Martyr yourself for my power!
        // <summary>
        MartyrYourself = 2210,
        // <summary>
        // You can enter the Forgotten Archipelago once you reach level 85.
        // <summary>
        CanEnterArchipel = 2211,
        // <summary>
        // You cannot give up this quest.
        // <summary>
        CannotGiveUpQuest = 2212,
        // <summary>
        // Destroy the Tower of Seals!
        // <summary>
        DestroyTowerOfSeals = 2213,
        // <summary>
        // Erenia's first test will start shortly.
        // <summary>
        EreniasFirstTestWillStart = 2214,
        // <summary>
        // I will never give in! You devilish creatures!
        // <summary>
        NeverGiveInYouDevilishCreatures = 2215,
        // <summary>
        // Congratulations! You have passed all the tests! Destroy Erenia!
        // <summary>
        ErenaAllTestPAssed = 2216,
        // <summary>
        // You have failed the test. Goddess Erenia has awoken. Good luck!
        // <summary>
        EreniaFailedTest = 2217,
        // <summary>
        // You failed Zenas' final test. She's going on a rampage.
        // <summary>
        FailedLastZenasTest = 2218,
        // <summary>
        // Your champion level has increased.
        // <summary>
        HeroLevelIncreased = 2219,
        // <summary>
        // The Audience with Zenas has started.
        // <summary>
        AudienceZenasStarted = 2220,
        // <summary>
        // Champion gear cannot be used on partners.
        // <summary>
        HeroGearCannotBeUsedPartners = 2221,
        // <summary>
        // You cannot use the options on champion gear.
        // <summary>
        CannotUseOptionsOnChampionGear = 2222,
        // <summary>
        // Equipment to be sacrificed must have options to be able to start production.
        // <summary>
        EquipmentMustHaveOptionsForProduction = 2223,
        // <summary>
        // Archangel Lucifer, Zenas' 13th wing, has appeared.
        // <summary>
        ArchangelLuciferZenas13thWingAppeared = 2224,
        // <summary>
        // Goddess Zenas
        // <summary>
        GoddessZenas = 2225,
        // <summary>
        // Goddess Erenia
        // <summary>
        GoddessErenia = 2226,
        // <summary>
        // Come on out! Ooer! I've drawn a black one...
        // <summary>
        ComeOutOoer = 2227,
        // <summary>
        // The lots have spoken!
        // <summary>
        LotsHaveSpoken = 2228,
        // <summary>
        // Hey, take this kiss of death. *Muah*
        // <summary>
        HeytakethiskissofdeathMuah = 2229,
        // <summary>
        // Put your back into it!
        // <summary>
        Putyourbackintoit = 2230,
        // <summary>
        // Erenia's first test will start shortly.
        // <summary>
        EreniasfirsttestWillStartShortly = 2231,
        // <summary>
        // It's an ambush! Sneeky angels!
        // <summary>
        ItsAnAmbushSneekyAngels = 2232,
        // <summary>
        // You cannot be granted an Audience with Zenas.
        // <summary>
        YouCannotBeGrantedAnAudienceWithZenas = 2233,
        // <summary>
        // You have passed Zenas' second test. The final test will soon begin.
        // <summary>
        YouHavePassedZenasSecondTestTheFinalTestWillSoonBegin = 2234,
        // <summary>
        // You've passed Erenia's first test. The second will soon begin.
        // <summary>
        YouvepassedEreniasFirstTestTheSecondWillSoonBegin = 2235,
        // <summary>
        // Obey us and we will spare your lives.
        // <summary>
        Obeyusandwewillspareyourlives = 2236,
        // <summary>
        // The kiss of a goddess! Wow!
        // <summary>
        TheKissOfAGoddessWow = 2237,
        // <summary>
        // The Time-Space is closed.
        // <summary>
        TheTimeSpaceIsClosed = 2238,
        // <summary>
        // The Time-Space will close soon.
        // <summary>
        TheTimeSpaceWillCloseSoo = 2239,
        // <summary>
        // The Time-Space in Mystic Heaven will start shortly.
        // <summary>
        TheTimeSpaceInMysticHeavenWillStartShortly = 2240,
        // <summary>
        // The Time-Space in Hellord will start shortly.
        // <summary>
        TheTimeSpaceInHellordWillStartShortly = 2241,
        // <summary>
        // A guardian has appeared.
        // <summary>
        AGuardianHasAppeared = 2242,
        // <summary>
        // %s defeated %s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        Defeated = 2243,
        // <summary>
        // Failed to upgrade the status to 'phenomenal'.
        // <summary>
        FailedToUpgradeTheStatusTophenomenal = 2244,
        // <summary>
        // The gamble failed, but the item was protected.
        // <summary>
        TheGambleFaileButTheItemWasProtected = 2245,
        // <summary>
        // You have %d more minutes for the Time-Space.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MoreTimeForTimeSpace = 2246,
        // <summary>
        // You have passed Zenas' second test. The final test will soon begin.
        // <summary>
        SecondZenasTestPassed = 2247,
        // <summary>
        // %s defeated Erenia's Guardian.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerDefeatedEreniaGuardian = 2248,
        // <summary>
        // Zenas' Guardian defeated %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ZenasGuardianDefeated = 2249,
        // <summary>
        // You have been ejected from the Time-Space because you were defeated at the enemy's hand.
        // <summary>
        PlayerEjectedFromTimeSpaceDueToDeath = 2250,
        // <summary>
        // %s defeated Zenas' Guardian.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PlayerDefeatedZenasGuardian = 2251,
        // <summary>
        // Erenia's Guardian defeated %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        EreniaGuardianDefeated = 2252,
        // <summary>
        // Palina Puppet Master
        // <summary>
        PalinaPuppetMaster = 2253,
        // <summary>
        // Harlequin
        // <summary>
        Harlequin = 2254,
        // <summary>
        // Nelia Nymph
        // <summary>
        NeliaNymph = 2255,
        // <summary>
        // Little Princess Venus
        // <summary>
        LittlePrincessVenus = 2256,
        // <summary>
        // You cannot use an item whose appearance has been changed.
        // <summary>
        CannotUseItemWithChangedAppearance = 2257,
        // <summary>
        // Both materials must be permanent.
        // <summary>
        BothMaterialsMustBePermanent = 2258,
        // <summary>
        // Both materials must be bound (not tradeable) to change the appearance.
        // <summary>
        BothMaterialsMustBeBound = 2259,
        // <summary>
        // Mana block!
        // <summary>
        ManaBlock = 2260,
        // <summary>
        // You fool! Now you will know the power of a god!
        // <summary>
        YouFoolNowYouWillKnowThePowerOfAGod = 2261,
        // <summary>
        // Err... I can't do that...
        // <summary>
        ErrICantDoThat = 2262,
        // <summary>
        // Fernon's followers have appeared.
        // <summary>
        FernonFollowersHaveAppeared = 2263,
        // <summary>
        // The portal to the Temple Site will appear shortly.
        // <summary>
        ThePortalToTheTempleSiteWillAppearShortly = 2264,
        // <summary>
        // The portal to the Temple Site has disappeared.
        // <summary>
        TheTempleSitePortalDisable = 2265,
        // <summary>
        // The entrance to the Temple Site is still open for %d minutes.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        EntranceToTempleOpened = 2266,
        // <summary>
        // It isn't time to journey to the Temple Site yet.
        // <summary>
        ItIsntTimeToJourneyToTheTempleSiteYet = 2267,
        // <summary>
        // Can't find anything.
        // <summary>
        CantFindAnything = 2268,
        // <summary>
        // Incomplete Fernon
        // <summary>
        IncompleteFernon = 2269,
        // <summary>
        // Foolish mortals! Prepare to meet your maker!
        // <summary>
        FoolishMortalsPrepareToMeetYourMaker = 2270,
        // <summary>
        // The Incomplete Fernon is on a rampage.
        // <summary>
        TheIncompleteFernonIsOnARampage = 2271,
        // <summary>
        // The portal to the Temple Site has been created.
        // <summary>
        TheTempleSitePortalOpen = 2272,
        // <summary>
        // *
        // <summary>
        Undefined2273 = 2273,
        // <summary>
        // %d minutes remain to explore the Combat Arena.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ExploreArenaTime = 2274,
        // <summary>
        // The portal to the Combat Arena has been created.
        // <summary>
        TheCombatArenaPortalOpen = 2275,
        // <summary>
        // The portal to the Combat Arena has disappeared.
        // <summary>
        TheCombatArenaPortalDisappeared = 2276,
        // <summary>
        // You are fighting for the angels.
        // <summary>
        YouAreFightingForTheAngels = 2277,
        // <summary>
        // You are fighting for the demons.
        // <summary>
        YouAreFightingForTheDemons = 2278,
        // <summary>
        // You can only enter the Combat Arena once.
        // <summary>
        CanOnlyEnterTheCombatArenaOnce = 2279,
        // <summary>
        // You cannot enter the Combat Arena as the maximum number of players has been reached.
        // <summary>
        TheCombatArenaIsFull = 2280,
        // <summary>
        // %s has activated %s.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerHasActivatedXObject = 2281,
        // <summary>
        // You cannot receive the reward because you don't have enough action points.
        // <summary>
        NotEnoughActionPoints = 2282,
        // <summary>
        // Action points [%d]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ActionPoints = 2283,
        // <summary>
        // (Limited)
        // <summary>
        Limited = 2284,
        // <summary>
        // You treacherous fiends, how dare you!
        // <summary>
        YouTreacherousFiendsHowDareYou = 2285,
        // <summary>
        // My teeth! Nooooo!
        // <summary>
        MyTeethNooooo = 2286,
        // <summary>
        // Korr! That's tough!
        // <summary>
        KorrThatsTough = 2287,
        // <summary>
        // It's so delicious!
        // <summary>
        ItsSoDelicious = 2288,
        // <summary>
        // I will melt you all!
        // <summary>
        IWillMeltYouAll = 2289,
        // <summary>
        // There's a safe circle here!
        // <summary>
        TheresASafeCircleHere = 2290,
        // <summary>
        // You have reached the maximum number of partner slots.
        // <summary>
        MaximumPartnerSlots = 2291,
        // <summary>
        // Do you want to permanently increase your partner slots by %d?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        AskMorePartnerSlots = 2292,
        // <summary>
        // Partner slots will be permanently increased by %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PartnerSlotsIncreased = 2293,
        // <summary>
        // Registration for the Sheep Farm raid was withdrawn.
        // <summary>
        RegistrationForTheSheepFarmWasWithdrawn = 2294,
        // <summary>
        // Registration for the Dodge Meteor raid was withdrawn.
        // <summary>
        RegistrationForTheDodgeMeteorWasWithdrawn = 2295,
        // <summary>
        // Registration for the Royal Battle raid was withdrawn.
        // <summary>
        RegistrationForTheRoyalBattleWasWithdrawn = 2296,
        // <summary>
        // The Sheep Farm raid starts soon.
        // <summary>
        TheSheepFarmRaidStartsSoon = 2297,
        // <summary>
        // The Dodge Meteor raid starts soon.
        // <summary>
        TheDodgeMeteorRaidStartsSoon = 2298,
        // <summary>
        // The Royal Battle raid starts soon.
        // <summary>
        TheRoyalBattleRaidStartsSoon = 2299,
        // <summary>
        // The Bushi King Defence raid starts soon.
        // <summary>
        TheBushiKingDefenceRaidStartsSoon = 2300,
        // <summary>
        // Do you want to join the Sheep Farm raid?
        // <summary>
        WantToJoinTheSheepFarmRaid = 2301,
        // <summary>
        // You can now register for the Dodge Meteor raid.
        // <summary>
        CanNowRegisterForTheDodgeMeteorRaid = 2302,
        // <summary>
        // Do you want to join the Dodge Meteor raid?
        // <summary>
        WantToJoinTheDodgeMeteorRaid = 2303,
        // <summary>
        // You can now register for the Royal Battle raid.
        // <summary>
        CanNowRegisterForTheRoyalBattleRaid = 2304,
        // <summary>
        // You can now register for the Sheep Farm raid.
        // <summary>
        CanNowRegisterForTheSheepFarmRaid = 2305,
        // <summary>
        // Do you want to join the Royal Battle raid?
        // <summary>
        WantToJoinTheRoyalBattleRaid = 2306,
        // <summary>
        // You can now register for the Bushi King Defence raid.
        // <summary>
        CannowRegisterForTheBushiKingDefenceRaid = 2307,
        // <summary>
        // Do you want to join the Bushi King Defence raid?
        // <summary>
        WantToJoinTheBushiKingDefenceRaid = 2308,
        // <summary>
        // 1 minute until the game ends.
        // <summary>
        ServerWillShutdownInAMinute = 2309,
        // <summary>
        // You have successfully completed the Dodge Meteor raid.
        // <summary>
        TheDodgeMeteorRaidSuccessfullyCompleted = 2310,
        // <summary>
        // You receive the following item: Acorn x%d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        YouReceiveItemAcorn = 2311,
        // <summary>
        // 10 seconds later the meteor comes crashing down again.
        // <summary>
        TheMeteorComesAgainTenSecondsLater = 2312,
        // <summary>
        // Time's up.
        // <summary>
        Timesup = 2313,
        // <summary>
        // You did not complete the Dodge Meteor raid successfully.
        // <summary>
        TheDodgeMeteorRaidNotComplete = 2314,
        // <summary>
        // You have successfully completed the Royal Battle raid.
        // <summary>
        TheRoyalBattleCompletedSuccessfully = 2315,
        // <summary>
        // You did not complete the Royal Battle raid successfully because the time ran out.
        // <summary>
        TheAssaultOfTheRoyalBattleWasNotSuccessfullyCompleted = 2316,
        // <summary>
        // 1 minute until the game ends.
        // <summary>
        ServerWillShutdownInAMinute2 = 2317,
        // <summary>
        // %s has successfully completed the Royal Battle raid.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RoyalRaidSuccessed = 2318,
        // <summary>
        // You receive the following item: %s x%d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        YouWillReceiveTheFollowingObjectX = 2319,
        // <summary>
        // Cannot be changed after registration.
        // <summary>
        CannotBeChangedAfterRegistration = 2320,
        // <summary>
        // Registration starts in %d second(s).<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RegistrationStartsInSeconds = 2321,
        // <summary>
        // You have been defeated.
        // <summary>
        YouHaveBeenDefeated = 2322,
        // <summary>
        // The enemy is already defeated.
        // <summary>
        TheEnemyIsAlreadyDefeated = 2323,
        // <summary>
        // You are too far away. It can only be used within %d spaces.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ToFarAway = 2324,
        // <summary>
        // You can't hunt your own group members.
        // <summary>
        YouCantHuntYourOwnGroupMembers = 2325,
        // <summary>
        // You cannot register while you are in a raid team.
        // <summary>
        YouCantRegisterWhileYoureOnRaid = 2326,
        // <summary>
        // Registration time has expired.
        // <summary>
        RegistrationTimeHasExpired = 2327,
        // <summary>
        // You are already registered for another mini-game.
        // <summary>
        YouAreAlreadyRegisteredForAnotherMiniGame = 2328,
        // <summary>
        // Not enough players registered so the event was cancelled.
        // <summary>
        NotEnoughPlayersRegistered = 2329,
        // <summary>
        // You are wearing an incorrect amulet.
        // <summary>
        YouAreWearingAnIncorrectAmulet = 2330,
        // <summary>
        // This item has a number of options. Are you sure you want to sell it?
        // <summary>
        ThisArticleHasOptionsYouWantToSell = 2331,
        // <summary>
        // Bone Warrior Ragnar
        // <summary>
        BoneWarriorRagnar = 2332,
        // <summary>
        // **
        // <summary>
        Undefined2333 = 2333,
        // <summary>
        // The item can no longer be traded after use.#13#10Do you want to use this item?#13#10
        // <summary>
        RequestToUseObjectThatWillBecameNotExchangeable = 2334,
        // <summary>
        // You cannot join the raid because you aren't being accompanied by a pet.
        // <summary>
        YouCannotJoinTheRaidBecauseYouArentBeingAccompaniedByAPet = 2335,
        // <summary>
        // Let's get out of these creepy catacombs!
        // <summary>
        LetsGetOutOfTheseCreepyCatacombs = 2336,
        // <summary>
        // Defeat the rebels fighting against the resistance.
        // <summary>
        DefeatTheRebelsFighting = 2337,
        // <summary>
        // You succeeded in escaping from the Lost Catacombs. You have received Professor Macavity's Junk Box (Event) in reward.
        // <summary>
        YouSucceededInEscapingFromTheLostCatacombsAndYouHaveReceivedBoxReward = 2338,
        // <summary>
        // Who stole my wand? Come on, own up!
        // <summary>
        WhoStoleMywandComeOnOwnup = 2339,
        // <summary>
        // Baaah... I'm sooooo hungry...
        // <summary>
        BaaahImsooooohungry = 2340,
        // <summary>
        // Bahaha! You can't get away from me! You're mine!
        // <summary>
        BahahaYoucantgetawayfrommeYouremine = 2341,
        // <summary>
        // Test Subject
        // <summary>
        TestSubject = 2342,
        // <summary>
        // You deposit %s,000 Gold.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        DepositBank = 2343,
        // <summary>
        // You withdraw %s,000 Gold. (Fee: %s Gold)<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        WithdrawBank = 2344,
        // <summary>
        // Balance: %s,000 Gold; Carrying: %s Gold<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        BalanceBank = 2345,
        // <summary>
        // Please enter how much Gold you wish to deposit or withdraw.
        // <summary>
        HowMuchGoldDoYouWantToDepositOrWithdraw = 2346,
        // <summary>
        // Do you want to deposit %s,000 Gold?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        AskDeposit = 2347,
        // <summary>
        // Do you want to withdraw %s,000 Gold? (Fee: %s Gold)<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        AskWithdraw = 2348,
        // <summary>
        // Your credit rating at the Cuarry Bank depends on your reputation. This credit rating determines how large the fees are when you withdraw Gold. If you are a VIP, you are exempted from any fees. If you do not have enough Gold to pay the fees, you cannot withdraw the desired amount.
        // <summary>
        AFeeWillBeChargedToNonVIPsAtTheBank = 2349,
        // <summary>
        // Welcome to the Cuarry Bank! We accept deposits or withdrawals of between 1,000 and 100,000,000,000 Gold.%s <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        WelcomeToQuarry = 2350,
        // <summary>
        // Unfortunately an error has occurred.
        // <summary>
        UnfortunatelyAnErrorHasOccurred = 2351,
        // <summary>
        // You cannot send this person a request as they are currently using bank services.
        // <summary>
        ThisPersonIsUsingTheBankNow = 2352,
        // <summary>
        // We'll do our best. Thank you for using the Cuarry Bank.
        // <summary>
        ThankYouForUsingTheCuarryBank = 2353,
        // <summary>
        // You don't have enough Gold to pay the fee.
        // <summary>
        YouDontHaveAnyGoldToPay = 2354,
        // <summary>
        // You have to wait %d minutes before you can be invited.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CannotBeInvited = 2355,
        // <summary>
        // UI elements are now unlocked
        // <summary>
        UIElementsAreNowUnlocked = 2356,
        // <summary>
        // UI elements are now locked.
        // <summary>
        UIElementsAreNowLocked = 2357,
        // <summary>
        // Sorry, this is currently unavailable.
        // <summary>
        SorryThisIsCurrentlyUnavailable = 2358,
        // <summary>
        // You cannot send the invitation. Please try again in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CannotSendInvite = 2359,
        // <summary>
        // You've received a "welcome back" gift!
        // <summary>
        YouveReceivedAWelcomeBackGift = 2360,
        // <summary>
        // You can only have one Martial Artist character per server.
        // <summary>
        YouCanOnlyHaveOneMartialArtist = 2361,
        // <summary>
        // You must wait before creating a new Martial Artist character (%d days remaining).<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        CreateMartialTimeRemaining = 2362,
        // <summary>
        // Guardian Lucifer
        // <summary>
        Undefined2363 = 2363,
        // <summary>
        // Sheriff Chloe
        // <summary>
        Undefined2364 = 2364,
        // <summary>
        // Archdaemon Amon
        // <summary>
        Undefined2365 = 2365,
        // <summary>
        // Magic Student Yuna
        // <summary>
        MagicStudentYuna = 2366,
        // <summary>
        // The reward for level %d has been placed in your inventory.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        LevelRewardInInventory = 2367,
        // <summary>
        // You have sold %dx %s in the NosBazaar.<NEW_TYPE><1,0>
        // <summary>
        [Game18NArguments(typeof(long), typeof(string))]
        SoldItemBazar = 2368,
        // <summary>
        // The selling price has been changed to %d Gold.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NewSellingPrice = 2369,
        // <summary>
        // Amora
        // <summary>
        Amora = 2370,
        // <summary>
        // Do you want to open the treasure chest with %d Skeleton Keys?<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        UseSkeletonKeyToOpenChest = 2371,
        // <summary>
        // You don't have enough Skeleton Keys.
        // <summary>
        NotEnoughSkeletonKey = 2372,
        // <summary>
        // %s received {%s} in the jackpot.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        JackpotRecived = 2373,
        // <summary>
        // <Note>
        // <summary>
        Note = 2374,
        // <summary>
        // You cannot change the price as you have already sold some of the items. Please list the items again to change the price.
        // <summary>
        CannotChangePriceSoldItems = 2375,
        // <summary>
        // Already used. Can be used again after 5:00 AM.
        // <summary>
        AlreadyUsedCanBeUseAgainAtFive = 2376,
        // <summary>
        // This skill cannot be used.
        // <summary>
        YouCannotUseThisSkill = 2377,
        // <summary>
        // Family %s unlocked achievement: %s<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        FamilyUnlockAchievement = 2378,
        // <summary>
        // Family %s used a skill to increase experience earned.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamilyUsedSkillExperience = 2379,
        // <summary>
        // Family %s used a skill to increase gold earned.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamilyUsedSkillGold = 2380,
        // <summary>
        // Family %s used a skill to receive the Stamina Boost effect.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamilyUsedSkillStamina = 2381,
        // <summary>
        // Family %s used a skill to fill the Angels' raid bar.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamilyUsedSkillFillAngel = 2382,
        // <summary>
        // Family %s used a skill to fill the Demons' raid bar.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FamilyUsedSkillFillDemon = 2383,
        // <summary>
        // Mad March Hare
        // <summary>
        MadMarchHare = 2384,
        // <summary>
        // You have received %d action points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RecivedActionPoints = 2385,
        // <summary>
        // Purchased: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PurchasedItemX = 2386,
        // <summary>
        // %s has been used.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        ItemXHasBeenUsed = 2387,
        // <summary>
        // This item can no longer be used as the maximum duration has been reached.
        // <summary>
        ThisArticleHasReachedTheMaximumDuration = 2388,
        // <summary>
        // You can sign up for the Rainbow Battle now!
        // <summary>
        CanSignUpForTheRainbowBattleNow = 2389,
        // <summary>
        // Do you want to take part in the Rainbow Battle?
        // <summary>
        WantToTakePartInTheRainbowBattle = 2390,
        // <summary>
        // The Rainbow Battle is starting.
        // <summary>
        TheRainbowBattleIsStarting = 2391,
        // <summary>
        // Rainbow Battle Monthly Stats: %d Wins / %d Losses<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(long), typeof(long))]
        RainbowBattleMonthlyPlayerStatsList = 2392,
        // <summary>
        // %s has captured: %s<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerHasCapturedMobX = 2393,
        // <summary>
        // Our team's %s has been captured.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        FlagCapturedByEnemies = 2394,
        // <summary>
        // You cannot activate this function as the Rainbow Battle has already started.
        // <summary>
        YouCannotActivateThisFunctionAsTheRainbowStarted = 2395,
        // <summary>
        // Rainbow Battle deactivated.
        // <summary>
        RainbowBattleDeactivated = 2396,
        // <summary>
        // Rainbow Battle activated. Starting in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        RainbowBattleActivatedStartingMessageTime = 2397,
        // <summary>
        // Rainbow Battle:
        // <summary>
        RainbowBattle = 2398,
        // <summary>
        // Test Rainbow Battle cancelled. A regular Rainbow Battle is starting.
        // <summary>
        TheArcorisBattleTestHasBeenCancelledStartANormalArcorisBattle = 2399,
        // <summary>
        // %s has received the following effect: %s!<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerHasReceivedTheEffectX = 2400,
        // <summary>
        // You will be revealed if you try to rescue a frozen player.
        // <summary>
        YouWillBeRevealedIfYouRescueAFrozenPlayer = 2401,
        // <summary>
        // You will be revealed if you try to capture a Rainbow Crystal.
        // <summary>
        YouCouldBeRevealedIfYouTakeARainbowCrystal = 2402,
        // <summary>
        // %s freed %s from the ice.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerFreedPlayerXFromTheIce = 2403,
        // <summary>
        // %s defeated %d players.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        AmoutOfPlayersDefeatedByPlayerX = 2404,
        // <summary>
        // Frozen: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Frozen = 2405,
        // <summary>
        // Rescued: %d<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        Rescued = 2406,
        // <summary>
        // (Kill Streak: %d)<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        KillStreak = 2407,
        // <summary>
        // %s has captured: %s<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PlayerHasCaputeredTheXEnemyFlag = 2408,
        // <summary>
        // Enemy has captured: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        EnemyHasCapturedTheFlagX = 2409,
        // <summary>
        // If you can hold your bases for %d minutes, you'll win.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MessageWithTimeAvailableToWinHoldingBase = 2410,
        // <summary>
        // If you don't capture the enemy bases within %d minutes, you'll lose.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MessageWithTimeAvailableToCaptureEnemyBaseToWin = 2411,
        // <summary>
        // If you can hold your bases for %d seconds, you'll win.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MessageWithTimeAvailableToWinHoldingBase2 = 2412,
        // <summary>
        // If you don't capture the enemy bases within %d seconds, you'll lose.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        MessageWithTimeAvailableToCaptureEnemyBaseToWin2 = 2413,
        // <summary>
        // You have received a new emoticon!
        // <summary>
        NewEmoticonReceived = 2414,
        // <summary>
        // You already own this emoticon.
        // <summary>
        AlreadyHaveThisEmoticon = 2415,
        // <summary>
        // This emoticon cannot be used.
        // <summary>
        CannotUseThisEmoticon = 2416,
        // <summary>
        // You cannot join the Rainbow Battle as enough players have already registered.
        // <summary>
        NotEnoughPlayerRainbowBattle = 2417,
        // <summary>
        // You won the Rainbow Battle!
        // <summary>
        WonRainbowBattle = 2418,
        // <summary>
        // You lost the Rainbow Battle.
        // <summary>
        LostRainbowBattle = 2419,
        // <summary>
        // One-Winged Angel Perti
        // <summary>
        AngelPerti = 2420,
        // <summary>
        // The battle ends in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TheBattleEndsShortly = 2421,
        // <summary>
        // Do you want to add this title?
        // <summary>
        AskAddTitle = 2422,
        // <summary>
        // Added new title.
        // <summary>
        AddedNewTitle = 2423,
        // <summary>
        // Title changed or hidden.
        // <summary>
        TitleChangedOrHidden = 2424,
        // <summary>
        // Title effect changed or deactivated.
        // <summary>
        TitleEffectChangedOrDeactivated = 2425,
        // <summary>
        // The title will no longer be displayed.
        // <summary>
        TitleNotDisplayed = 2426,
        // <summary>
        // The title effect has been deactivated.
        // <summary>
        TitleEffectDeactivated = 2427,
        // <summary>
        // Using this item will allow you to change your character's name. To change the name, simply use the item and log in again.
        // <summary>
        ThisArticleAllowsYouToChangeYourName = 2428,
        // <summary>
        // You have already used this item to rename this character.
        // <summary>
        YouHaveAlreadyUsedThisItemToRenameThisCharacter = 2429,
        // <summary>
        // You can change this character's name. To do so, please log out and log back in again.
        // <summary>
        ToChangeYourCharacterNameYouHaveToLogoutAndGoBackToInitial = 2430,
        // <summary>
        // You can use the Renaming Card again in %d day(s).<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        YouCanUseRenamingCardLater = 2431,
        // <summary>
        // You have not changed your character name. Are you sure you want to continue?
        // <summary>
        YouHaventChangedYourNameSoBeSureToContinue = 2432,
        // <summary>
        // Applied the %s tattoo.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TattooAplied = 2433,
        // <summary>
        // Tattooing failed.
        // <summary>
        TattooingFailed = 2434,
        // <summary>
        // You already have a tattoo of this type.
        // <summary>
        AlreadyHaveTatooType = 2435,
        // <summary>
        // You cannot add another tattoo.
        // <summary>
        CanNotHaveOtherTatoo = 2436,
        // <summary>
        // You already have this tattoo.
        // <summary>
        AlreadyHaveThisTatoo = 2437,
        // <summary>
        // Major failure! Level has been reduced by 1.
        // <summary>
        LevelHasBeenReducedByOne = 2438,
        // <summary>
        // Major failure! However the Tattoo Safeguard Scroll prevented the level from dropping.
        // <summary>
        TheTattooProtectionScrollProtectedLevel = 2439,
        // <summary>
        // Removed the %s tattoo.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        TattooRemoved = 2440,
        // <summary>
        // Upgraded the %s tattoo! +%d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        TattooUpgraded = 2441,
        // <summary>
        // You can't carve any more runes as it is already at the highest level.
        // <summary>
        CannotCarveAnyMoreRunesAsItIsAlreadyTheHighestLevel = 2442,
        // <summary>
        // This weapon is damaged. You'll need a %s before you can equip runes onto it again.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        WeaponIsDamaged = 2443,
        // <summary>
        // This weapon is bound to another player. You can only carve runes into your own weapons. 
        // <summary>
        CannotCarveNotYourWeapon = 2444,
        // <summary>
        // Rune upgrade failed, all materials consumed.
        // <summary>
        RuneUpFailMaterialsConsumed = 2445,
        // <summary>
        // Rune upgrade failed, but the gear wasn't damaged thanks to the %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RuneUpFailWeaponNoDamaged = 2446,
        // <summary>
        // Rune upgrade failed. The weapon was damaged in the process. You can't upgrade a damaged weapon.
        // <summary>
        RuneUpFailWeaponDamaged = 2447,
        // <summary>
        // Upgraded the %s rune! +%d<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(long))]
        RuneUpgraded = 2448,
        // <summary>
        // You can't pass through here without the chief's permission.
        // <summary>
        CannotPassWithNoChiefPermission = 2449,
        // <summary>
        // Used the Rune of Fortune Scroll.
        // <summary>
        UsedRuneScroll = 2450,
        // <summary>
        // You don't have any Rune of Fortune Scrolls.
        // <summary>
        NoRuneScrolls = 2451,
        // <summary>
        // Rune upgrade failed, but none of the materials were consumed thanks to the %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RuneUpFailButProtectedMaterials = 2452,
        // <summary>
        // Can only be used on damaged gear.
        // <summary>
        OnlyUseOnDamagedWeapon = 2453,
        // <summary>
        // This weapon isn't damaged.
        // <summary>
        WeaponIsntDamaged = 2454,
        // <summary>
        // Repaired the damaged weapon.
        // <summary>
        FixedDamagedWeapon = 2455,
        // <summary>
        // Rune removed.
        // <summary>
        RuneRemoved = 2456,
        // <summary>
        // This gear doesn't have any runes.
        // <summary>
        WeaponHaveNoRunes = 2457,
        // <summary>
        // You'll be transported to Moritius in %d seconds.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TransportToMoritiusShortly = 2458,
        // <summary>
        // Quest Reward [Champion Experience]
        // <summary>
        QuestRewardChampionExperience = 2459,
        // <summary>
        // You can't upgrade your tattoo while you're using a skill.
        // <summary>
        CantUpTattooWhileUseSkill = 2460,
        // <summary>
        // You will be able to remove the tattoo when all your skills are off cooldown.
        // <summary>
        AbleToRemoveTattooWhenCooldownOff = 2461,
        // <summary>
        // You can't be tattooed while you're using a skill.
        // <summary>
        CantTattooedWhileUseSkill = 2462,
        // <summary>
        // Used the Tattoo Safeguard Scroll.
        // <summary>
        UsedTattooSafeScroll = 2463,
        // <summary>
        // You don't have any Tattoo Safeguard Scrolls.
        // <summary>
        NoTattooSafeScroll = 2464,
        // <summary>
        // %s's %s<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        Is = 2465,
        // <summary>
        // You must be champion level 10 to enter this area.
        // <summary>
        YouNeedHeroTenToGetIntoThatArea = 2466,
        // <summary>
        // You can't exchange gear equipped with runes for partner equipment.
        // <summary>
        YouCantTradeRuneWeaponsForPartnerEquipment = 2467,
        // <summary>
        // %d Job experience points<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        JobExperiencePoints = 2468,
        // <summary>
        // The Infinite Celestial Spire challenge cannot be started.
        // <summary>
        InfiniteCelestialSpireCannotStart = 2469,
        // <summary>
        // The Infinite Celestial Spire challenge is starting! Fight your way to the very top.
        // <summary>
        InfiniteCelestialSpireStarting = 2470,
        // <summary>
        // This has already been selected.
        // <summary>
        AlreadyBeenSelected = 2471,
        // <summary>
        // This NosMate has been registered for the raid.
        // <summary>
        NosMateRegisteredForRaid = 2472,
        // <summary>
        // You cannot enter the Celestial Spire because you're part of a raid team.
        // <summary>
        CannotEnterCelestialSpireWithoutTeam = 2473,
        // <summary>
        // You cannot join the raid team because you haven't yet completed a certain quest.
        // <summary>
        CannotJoinRaidMissingQuest = 2474,
        // <summary>
        // You cannot create a raid team because you haven't yet completed a certain quest.
        // <summary>
        CannotCreateRaidMissingQuest = 2475,
        // <summary>
        // The rift in the sky has been sealed. The monster invasion has been kept at bay for a short time.
        // <summary>
        RifInTheSkySealed = 2476,
        // <summary>
        // The rift in the sky has reopened. The monster invasion is continuing.
        // <summary>
        RifInTheSkyOpened = 2477,
        // <summary>
        // The evil overlord is summoning stronger units.
        // <summary>
        EvilOverlordSummoning = 2478,
        // <summary>
        // The evil overlord is summoning his strongest units.
        // <summary>
        EvilOverlordStrongestSummoning = 2479,
        // <summary>
        // You need the Celestial Spire Key in order to enter the Celestial Spire.
        // <summary>
        CelestialSpireKeyNeeded = 2480,
        // <summary>
        // You can reset the Celestial Spire and start again from the first level. However, your record will persist and you won't receive any special rewards a second time. Do you want to continue?
        // <summary>
        CelestialSpireResetHelp = 2481,
        // <summary>
        // Your Infinite Celestial Spire record has been reset. You can now restart the challenge from the first level.
        // <summary>
        CelestialSpireHasBeenReset = 2482,
        // <summary>
        // Defeat all the monsters and protect the totem.
        // <summary>
        ProtectTotemAndDefeatMonsters = 2483,
        // <summary>
        // Complete the Celestial Spire.
        // <summary>
        CompleteCelestialSpire = 2484,
        // <summary>
        // This is only available once you've completed a certain quest.
        // <summary>
        OnlyAvailableAfterQuests = 2485,
        // <summary>
        // You can only enter the spire once you've completed the corresponding quest.
        // <summary>
        SporeOnlyAvailableAfterQuests = 2486,
        // <summary>
        // Rune Solvent cannot be used on this gear.
        // <summary>
        RuneSolventCannotBeUsed = 2487,
        // <summary>
        // Rune level has been reduced by 1.
        // <summary>
        RuneLevelReduced = 2488,
        // <summary>
        // Failed to use the Rune Solvent.
        // <summary>
        FailedRuneSolvent = 2489,
        // <summary>
        // Time-Space Stone completed:
        // <summary>
        TimeSpaceStoneCompleted = 2490,
        // <summary>
        // Akhenaton the Cursed Pharaoh
        // <summary>
        AkhenatonCursedPharaoh = 2491,
        // <summary>
        // Not possible while in a party.
        // <summary>
        NotPossibleInGroup = 2492,
        // <summary>
        // This skin is not compatible with the equipped specialist card.
        // <summary>
        SkinNotCompatibleCard = 2494,
        // <summary>
        // This card cannot be upgraded.
        // <summary>
        CardCannotBeUpgraded = 2495,
        // <summary>
        // You can't fish here!
        // <summary>
        CanNotFishHere = 2496,
        // <summary>
        // You don't have any bait so you can't go fishing.
        // <summary>
        NoBaitForFishing = 2497,
        // <summary>
        // You don't have a fishing line so you can't go fishing.
        // <summary>
        NoFishingLine = 2498,
        // <summary>
        // Your fishing level is too low to fish here.
        // <summary>
        FishingLevelTooLow = 2499,
        // <summary>
        // This is only available to you when you cast your fishing line.
        // <summary>
        OnlyAvailableWhileFishing = 2500,
        // <summary>
        // Bad luck... Unfortunately, nothing bit.
        // <summary>
        BadLuck = 2501,
        // <summary>
        // Fishing time is up.
        // <summary>
        FishingTimeIsUp = 2502,
        // <summary>
        // I'm fishing already.
        // <summary>
        AlreadyFishing = 2503,
        // <summary>
        // Unfortunately, I didn't catch anything. I'll give it another try.
        // <summary>
        DidNotCatchAnything = 2504,
        // <summary>
        // Oh, my fishing line broke!
        // <summary>
        FishingLineBroke = 2505,
        // <summary>
        // Ugh, the fish ate the bait!
        // <summary>
        FishAitBait = 2507,
        // <summary>
        // You've caught the following bigger fish: %s <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CaughtBiggerFish = 2508,
        // <summary>
        // You've caught the following fish for the first time: %s <NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        CaughtFishFirstTime = 2509,
        // <summary>
        // You've caught all the fish in this region (levels %d-%d). Your reward for this achievement will be sent to you.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(long), typeof(long))]
        CaughtAllFish = 2510,
        // <summary>
        // Your Encyclopaedia of Fish is complete. Your reward for this achievement will be sent to you.
        // <summary>
        EncyclopediaOfFishComplete = 2511,
        // <summary>
        // Catch a fish with the following stats:
        // <summary>
        CatchFishStats = 2512,
        // <summary>
        // You have already reached the maximum daily limit for purchasing this item.
        // <summary>
        MaximumLimitForPurchasing = 2513,
        // <summary>
        // Available daily (%d/%d)<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(long), typeof(long))]
        AvailableDaily = 2514,
        // <summary>
        // You cannot use the warehouse while fishing.
        // <summary>
        CannotWarehouseWhileFishing = 2515,
        // <summary>
        // You cannot move while casting your line.
        // <summary>
        CannotMoveWhileCastingLine = 2516,
        // <summary>
        // Congratulations! %s is now a Master Angler!<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        MasterAngler = 2517,
        // <summary>
        // Cooking cancelled.
        // <summary>
        CookingCancelled = 2518,
        // <summary>
        // Cannot cook when requirements have not been met.
        // <summary>
        CannotCookRequirementNotMet = 2519,
        // <summary>
        // Excellent! Looks like your culinary skills worked.
        // <summary>
        CulinarySkillsWorked = 2520,
        // <summary>
        // Oh... I haven't cooked it through.
        // <summary>
        HaveNotCookedIt = 2521,
        // <summary>
        // Oops, I've made a mess!
        // <summary>
        HaveMadeMess = 2522,
        // <summary>
        // Your side job is already the same one the specialist currently has.
        // <summary>
        SideJobAlreadySame = 2523,
        // <summary>
        // Your side job will be changed to the specialist's job.
        // <summary>
        SideJobWillBeChanged = 2524,
        // <summary>
        // You need to choose your specialist as your side job first in order to change it.
        // <summary>
        ChooseSpecialistAsSideJobFirst = 2525,
        // <summary>
        // Do you want to change your side job to your specialist's job?
        // <summary>
        AskChangeSideJob = 2526,
        // <summary>
        // Item cannot be used at current satiety level.
        // <summary>
        ItemCannotBeUsedCurrentSasiety = 2527,
        // <summary>
        // Fullness points: + [%d]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        PositiveFullnessPoints = 2528,
        // <summary>
        // Fullness points: - [%d]<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        NegativeFullNessPoints = 2529,
        // <summary>
        // I'm full, I couldn't eat another morsel!
        // <summary>
        FullMorsel = 2530,
        // <summary>
        // You receive an extra raid box from the current Raid Box Event.
        // <summary>
        ExtraRaidBox = 2531,
        // <summary>
        // Cannot be used as the current Battle Pass season is over.
        // <summary>
        CannotUseAsBattlePassSeasonOver = 2532,
        // <summary>
        // You have received %d Battle Points.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReceivedBattlePoint = 2533,
        // <summary>
        // This item is currently unavailable.
        // <summary>
        ItemCurrentlyUnavailable = 2534,
        // <summary>
        // This Battle Pass season has finished.
        // <summary>
        BattlePassSeasonFinished = 2535,
        // <summary>
        // The specialist card can only be upgraded further from job level 61.
        // <summary>
        SpFurtherJobLevelSixtyOne = 2536,
        // <summary>
        // Can be used to upgrade cards from level 15-19.
        // <summary>
        UpgradeCardFromFifteenToNineteen = 2537,
        // <summary>
        // Only specialist cards of level +20 can be enchanted with a dragon item.
        // <summary>
        SpLevelTwentyEnchantedDragonItem = 2538,
        // <summary>
        // The specialist card already has this dragon item.
        // <summary>
        SpAlreadyHasDragonItem = 2539,
        // <summary>
        // This specialist card has been enchanted with the following item: %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        SpHasBeenEnchantedWithTheFollowingItem = 2540,
        // <summary>
        // Defeat all summoned monsters to remove the fog shield.
        // <summary>
        DefeatMonstersToRemoveFogShield = 2541,
        // <summary>
        // Use the energy of the zombie dragon captured from monsters to remove the fog of fear.
        // <summary>
        UseEnergyOfZombieDragonToRemoveFogOfFear = 2542,
        // <summary>
        // Alzanor is preparing a powerful ice attack. Go to the nearest frost deflector to avoid any damage.
        // <summary>
        AlzanorPreparingPowerfulIceAttack = 2543,
        // <summary>
        // You didn't manage to defend Dragonveil.
        // <summary>
        YouDidntManageToDefendDragonveil = 2544,
        // <summary>
        // Asgobas' Instant Combat has started.
        // <summary>
        AsgobasInstantCombatStarted = 2545,
        // <summary>
        // Asgobas' Instant Combat is about to start.
        // <summary>
        AsgobasInstantCombatAboutToStart = 2546,
        // <summary>
        // Do you want to join Asgobas' Instant Combat?
        // <summary>
        DoYouWantToJoinAsgobasInstantCombat = 2547,
        // <summary>
        // Asgobas' Instant Combat is ending.
        // <summary>
        AsgobasInstantCombatIsEnding = 2548,
        // <summary>
        // Asgobas' Instant Combat (Single) is activated.
        // <summary>
        AsgobasInstantCombatSingleActivated = 2549,
        // <summary>
        // Cancel Asgobas' Instant Combat (Single) to be able to start a regular Asgobas' Instant Combat.
        // <summary>
        CancelAsgobasInstantCombat = 2550,
        // <summary>
        // Asgobas is approaching.
        // <summary>
        AsgobasIsApproaching = 2552,
        // <summary>
        // Asgobas' attack will end in 20 seconds.
        // <summary>
        AsgobasAttackEndInTwentySeconds = 2553,
        // <summary>
        // Asgobas' attack is about to start.
        // <summary>
        AsgobasAttackAboutToStart = 2554,
        // <summary>
        // You received %d battle experience points as a reward for this phase.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReceivedBattleExperiencePointsForThisPhase = 2555,
        // <summary>
        // You received %d champion experience points as a reward for this phase.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReceivedChampionExperiencePointsForThisPhase = 2556,
        // <summary>
        // You received %d job experience points as a reward for this phase.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        ReceivedJobExperiencePointsForThisPhase = 2557,
        // <summary>
        // You no longer have a chance. Please wait until the attack ends.
        // <summary>
        NoLongerHaveChanceWaitAttackEnds = 2558,
        // <summary>
        // Asgobas flies higher into the air to recover.
        // <summary>
        AsgobasFliesHigher = 2559,
        // <summary>
        // Asgobas' magic makes him stronger.
        // <summary>
        AsgobasMagicStronger = 2560,
        // <summary>
        // Asgobas will only come down once you have defeated the summoned ice dragon.
        // <summary>
        AsgobasOnlyComeDownOnceDefeatIceDragon = 2561,
        // <summary>
        // The injured Asgobas retreats.
        // <summary>
        TheInjuredAsgobasRetreats = 2562,
        // <summary>
        // You will be revived in 20 seconds. You can them resume battle against Asgobas.
        // <summary>
        WillBeRevivedInTwentySecondsAsgobas = 2564,
        // <summary>
        // Wounded Asgobas has disappeared.
        // <summary>
        AsgobasDisappeared = 2566,
        // <summary>
        // The Land of Life will be closed soon.
        // <summary>
        LandOfLifeWillBeClosed = 2567,
        // <summary>
        // Wounded Asgobas has started hunting!
        // <summary>
        AsgobasHunting = 2568,
        // <summary>
        // Only family members can enter the Land of Life.
        // <summary>
        LandOfLifeOnlyFamilyMember = 2569,
        // <summary>
        // Revitalised Asgobas has started hunting!
        // <summary>
        RevitalizedAsgobasHunting = 2570,
        // <summary>
        // You will soon return to the Portal to the Land of Life.
        // <summary>
        ReturnPortalLandOfLife = 2571,
        // <summary>
        // Revitalised Asgobas has disappeared.
        // <summary>
        RevitalisedAsgobasDisappeared = 2572,
        // <summary>
        // You are now out of the Land of Life.
        // <summary>
        OutOfLandofLife = 2573,
        // <summary>
        // Remaining Land of Life Time: %d min.
        // <summary>
        [Game18NArguments(typeof(long))]
        RemainingLandOfLifeTime = 2574,
        // <summary>
        // You cannot enter the Land of Life as you have used up all your time. 
        // <summary>
        YouCannotEnterLandOfLife = 2575,
        // <summary>
        // You must leave the Land of Life as your time has run out. 
        // <summary>
        MustLeaveLandOfLife = 2576,
        // <summary>
        // Would you like to move to the Land of Life?
        // <summary>
        EnterLandOfLifeQuestion = 2577,
        // <summary>
        // Are you sure you want to change this tattoo loa skill?
        // <summary>
        ChangeTatooLoaSkill = 2578,
        // <summary>
        // Switched to the %s tattoo.
        // <summary>
        [Game18NArguments(typeof(string))]
        SwitchedToTattoo = 2579,
        // <summary>
        // Your skills need to be off cooldown before you can switch your loa or tattoo.
        // <summary>
        SkillNeedToBeOffToChangeTattoo = 2580,
        // <summary>
        // Are you sure you wish to remove all Cellon options from this item?
        // <summary>
        AreYouSureRemoveCellon = 2582,
        // <summary>
        // You did not receive a raid box as your level is too low for the rewards.
        // <summary>
        NotReceiveRaidBox = 2583,
        // <summary>
        // An altar has appeared somewhere.
        // <summary>
        AltarHasAppeared = 2584,
        // <summary>
        // Are you sure you want to sort your inventory?
        // <summary>
        SortInventoryQuestion = 2585,
        // <summary>
        // Are you sure you want to change the appearance of your wings?
        // <summary>
        AreYouSureChangeAppearanceWing = 2586,
        // <summary>
        // Are you sure you want to change the colour of your Retro Wings?
        // <summary>
        AreYouSureChangeColorRetroWings = 2587,
        // <summary>
        // Cannot be used with your currently equipped wings.
        // <summary>
        CannotUseEquippedWings = 2588,
        // <summary>
        // Your wings' appearance has been changed to: %s<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        WingsAppearanceHasChanged = 2589,
        // <summary>
        // You need to transform into a specialist first before resetting your wings' appearance.
        // <summary>
        NeedToTransformIntoSpecialistBeforeResetWings = 2590,
        // <summary>
        // Your wings' appearance has been reset to their original form.
        // <summary>
        WingsAppearanceReset = 2591,
        // <summary>
        // Do you want to reset your wings' appearance?
        // <summary>
        DoYouWantToResetWings = 2592,
        // <summary>
        // Skill cooldowns will be hidden.
        // <summary>
        SkillCooldownHidden = 2594,
        // <summary>
        // Skill cooldowns will be shown.
        // <summary>
        SkillCooldownSHown = 2595,
        // <summary>
        // Target HP will be hidden.
        // <summary>
        TargetHpHidden = 2596,
        // <summary>
        // Target HP will be shown.
        // <summary>
        TargetHpShown = 2597,
        // <summary>
        // Quest Reward [Level Up]
        // <summary>
        QuestRewardLevelUp = 2598,
        // <summary>
        // Quest Reward [Level/Job Level Up]
        // <summary>
        QuestRewardLevelJobLevelUp = 2599,
        // <summary>
        // Quest Reward [Job Level Up]
        // <summary>
        QuestRewardJobLevelUp = 2600,
        // <summary>
        // Quest Reward [Champion Level Up]
        // <summary>
        QuestRewardChampionLevelUp = 2601,
        // <summary>
        // You have received %d NosJewels.
        // <summary>
        [Game18NArguments(typeof(long))]
        YouHaveReceivedNosJewels = 2602,
        // <summary>
        // Alitus XV
        // <summary>
        AlitusXV = 2603,
        // <summary>
        // Alitus Prototype
        // <summary>
        AlitusPrototype = 2604,
        // <summary>
        // You should move into the blue area.
        // <summary>
        YouShouldMoveIntoTheBlueArea = 2605,
        // <summary>
        // You should move into the red area.
        // <summary>
        YouShouldMoveIntoTheRedArea = 2606,
        // <summary>
        // You should move into the yellow area.
        // <summary>
        YouShouldMoveIntoTheYellowArea = 2607,
        // <summary>
        // You should move into the black area.
        // <summary>
        YouShouldMoveIntoTheBlackArea = 2608,
        // <summary>
        // This object is already in use.
        // <summary>
        ThisObjectIsAlreadyInUse = 2609,
        // <summary>
        // This object has not been used yet.
        // <summary>
        ThisObjectHasNotBeenUsedYet = 2610,
        // <summary>
        // Interaction cancelled as you moved.
        // <summary>
        InteractionCancelledAsYouMoved = 2611,
        // <summary>
        // Can only be used on items that are bound to your character.
        // <summary>
        CanOnlyBeUsedOnBoundItems = 2612,
        // <summary>
        // This item cannot be traded at the moment.
        // <summary>
        ItemCannotBeTraded = 2613,
        // <summary>
        // Taming successful.
        // <summary>
        TamingSuccessful = 2614,
        // <summary>
        // No other actions can be carried out while casting.
        // <summary>
        NoOtherActionsWhileCasting = 2615,
        // <summary>
        // Highest star rating already reached.
        // <summary>
        HighestStarRatingReached = 2616,
        // <summary>
        // Cannot be used on pets without a star rating.
        // <summary>
        CannotBeUsedOnPetsWithoutStarRating = 2617,
        // <summary>
        // Star rating increased to %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        StarRatingIncreased = 2618,
        // <summary>
        // Training level reset to %d.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(long))]
        TrainingLevelReset = 2619,
        // <summary>
        // Training level increased.
        // <summary>
        TrainingLevelIncreased = 2620,
        // <summary>
        // Can only upgrade once the maximum training level has been reached.
        // <summary>
        CanOnlyUpgradeAtMaxTrainingLevel = 2621,
        // <summary>
        // Can only upgrade in your Miniland.
        // <summary>
        CanOnlyUpgradeInMiniland = 2622,
        // <summary>
        // Monsters cannot be tamed with this skill.
        // <summary>
        MonstersCannotBeTamed = 2623,
        // <summary>
        // Essence can only be extracted in your Miniland.
        // <summary>
        EssenceCanOnlyBeExtractedInMiniland = 2624,
        // <summary>
        // Essence can only be extracted from pets which have reached the maximum training level.
        // <summary>
        EssenceExtractionFromMaxTrainingLevelPets = 2625,
        // <summary>
        // This skill cannot be used on pets. 
        // <summary>
        SkillCannotBeUsedOnPets = 2626,
        // <summary>
        // You have received pet essence and released the animal.
        // <summary>
        ReceivedPetEssenceAndReleasedAnimal = 2627,
        // <summary>
        // Are you sure you want to extract the essence of this pet? The pet will be released when you extract its essence.
        // <summary>
        ConfirmPetEssenceExtraction = 2628,
        // <summary>
        // Are you sure you want to reset this pet's training level? The training level will be set back to 0 and all skills will be removed.
        // <summary>
        ConfirmPetTrainingLevelReset = 2629,
        // <summary>
        // The pet's training level is already at 0.
        // <summary>
        PetTrainingLevelIsZero = 2630,
        // <summary>
        // Taming failed.
        // <summary>
        TamingFailed = 2631,
        // <summary>
        // Tame pets as a Pet Trainer.
        // <summary>
        TamePetsAsPetTrainer = 2632,
        // <summary>
        // Increase the training level of your pet.
        // <summary>
        IncreasePetTrainingLevel = 2633,
        // <summary>
        // You cannot train your pet any more as it has already reached the maximum training level.
        // <summary>
        PetMaxTrainingLevelReached = 2634,
        // <summary>
        // You cannot train pets without a star rating.
        // <summary>
        CannotTrainPetsWithoutStarRating = 2635,
        // <summary>
        // Can only be reset in your Miniland.
        // <summary>
        CanOnlyResetInMiniland = 2636,
        // <summary>
        // Cannot be used because the pet is currently training or fighting.
        // <summary>
        CannotUseWhilePetTrainingOrFighting = 2637,
        // <summary>
        // The bead cannot contain a 6-star pet.
        // <summary>
        BeadCannotContainSixStarPet = 2638,
        // <summary>
        // You can only reset pets which have reached the maximum training level.
        // <summary>
        CanOnlyResetMaxTrainingLevelPets = 2639,
        // <summary>
        // Can only contain 6-star pets.
        // <summary>
        CanOnlyContainSixStarPets = 2640,
        // <summary>
        // [%s] has reached the maximum training level.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        PetReachedMaxTrainingLevel = 2641,
        // <summary>
        // %s has completed a Pet Book mission and received {%s}.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PetCompletedBookMission = 2642,
        // <summary>
        // %s has successfully increased the star rating of %s to 6 stars.<NEW_TYPE><0,1>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string))]
        PetStarRatingIncreased = 2643,
        // <summary>
        // %s has successfully upgraded {%s} to +%s. <NEW_TYPE><0,1,2>
        // <summary>
        [Game18NArguments(typeof(string), typeof(string), typeof(string))]
        PetUpgradedSkill = 2644,
        // <summary>
        // If you put the pet in the bead, it will keep its star rating, but its training level will be reset to 0. Do you want to put it in the bead?
        // <summary>
        ConfirmPutPetInBead = 2645,
        // <summary>
        // Wood Elf Archer
        // <summary>
        WoodElfArcher = 2646,
        // <summary>
        // This NosMate does not have the NosMate Summoning Book effect.
        // <summary>
        NosMateWithoutSummoningBookEffect = 2647,
        // <summary>
        // You have removed the NosMate Summoning Book effect from %s.<NEW_TYPE><0>
        // <summary>
        [Game18NArguments(typeof(string))]
        RemovedNosMateSummoningBookEffect = 2648,
    }
}
