//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum NrunRunnerType : short
    {
        ChangeClass = 1,
        UpgradeItem = 2,
        GetXCompanion = 3, // The type is the VNum of the companion, used for the 3 first companions (via TS dialog).
        PetManagement = 4,
        FinishedTSDialog = 5,
        FinishedTSDialog2 = 6,
        CellonItem = 10,
        ProbabilityUIs = 12,
        TimeCircle = 13,
        OpenProduction = 14,
        SetPlaceOfRevival = 15,
        Teleport = 16,
        GoToArena = 17, // Types. 0 = Arena, 1 = Family Arena
        TimeCircleSkill = 18,
        FinishedTs = 19,
        FamilyStartOrDisband = 23,
        TeleportActV = 26,
        OldExchangeForXGift = 31,
        OldExchangeForAirwaves = 32, // Dr. W Event
        OldExchangeForChristmasGiftBox = 34,
        OldExchangeForChristmasSnowmanRaidSeal = 35,
        ExchangeFor11thAnniversaryMedal = 36, //Required letters: 'N', 'O', 'S', 'Y', 'E', 'A', 'R', '11'
        ExchangeForFullSP = 37, //Required letters: 'N', 'O', 'S' | Only once per day
        ExchangeFor11thAnniversaryBuff = 38, //Required letters: 'Y', 'E', 'A', 'R', '11'

        ExchangeForEasterEggFairy =
            40, //Requires: Soul of Easter and 4 Easter Eggs, one each in Red, Blue, Yellow and White.
        ExchangeForEasterGrasslinSeal = 41, //Requires: three lots of Rice, Chicken Drumsticks and Bamboo.
        GoToWeddingGazebo = 45,
        ExchangeForRedMagicalFairy = 46, //Requires: 20 Red Mooncakes.
        ExchangeForHalloweenBox = 47, //Requires: 10 pumpkins.
        ExchangeForThanksgivingGiftBox = 49, //Requires: 5x Monster Potato Seedlings
        OpenNosBazaar = 60,
        ExchangeForGrenigasRaidSeal = 61, //Requires: the left and right pieces of Grenigas' Raid Seal
        GoToGrenigasTemple = 62, //Requires: 1 Rune Piece
        GetDailyQuestSerizardIceFlowerOil = 65,
        GetDailyQuestFireAlchemistHeatResistancePotion = 66,

        GetDailyQuestAkamurMerchantMilitaryEngineerEliminateMonsters =
            67, //The monsters are in the Region of the Burning Sword.
        GetDailyQuestContructionMaterial = 68,
        ExchangeFor10xIceFlowerOil = 69, //Requires: 5 Akamur Coupons.
        ExchangeForMagicCamel = 70, //Requires: 90 Akamur Coupons. (No tradable)
        ExchangeForMagicCamelBox = 71, //Requires: 300 Akamur Coupons. (The box is tradeable, not the camel)
        ExchangeForHalloweenCostumeScroll = 72, //Requires: 10 Yellow Pumpkins Sweets.
        ExchangeForHalloweenCostumeScroll2 = 73, //Requires: 10 Black Pumpkins Sweets.
        ExchangeForJackOLanternSeal = 74, //Requires: 30 Yellow Pumpkins Sweets.
        ExchangeForJackOLanternSeal2 = 75, //Requires: 30 Black Pumpkins Sweets.
        ExchangeForJackOLanternSealPlusHalloweenBlessing = 76, //Requires: 1 Bag of Sweets.
        GetDailyQuestHalloweenMary = 77,
        GetDailyQuestHalloweenEvaEnergy = 78,
        GetDailyQuestHalloweenMalcolmMix = 79,
        GetDailyQuestHalloweenTeomanTopp = 80,
        GetDailyQuestHalloweenEric = 81,
        GetSantaClausDailyChristmasQuest = 82,
        Unknown = 83, //Related with Christmas Mysterious Bell Bag
        ExchangeForSealedChristmasVessel = 84, //30 Fresh cake
        ExchangeForSealedChristmasVessel2 = 85, //30 Chocolate cake
        ExchangeForChristmasSnowmanRaidSeal = 86, //30 Fresh cake
        ExchangeForChristmasSnowmanRaidSeal2 = 87, //30 Chocolate cake
        ExchangeForChristmasGiftBox = 88, //5 Christmas Stockings
        GetDailyQuestChristmasSlugg = 30021,
        GetDailyQuestChristmasEvaEnergy = 30023, //Defeat Snowman Raid.
        GetDailyQuestChristmasMalcolmMix = 30024,
        GetDailyQuestChristmasTeodorTopp = 92,
        GetDailyQuestChristmasSorayaStyle = 93,
        GetDailyQuestEasterMimiMentor = 94, //Kill Chicken Queen
        ExchangeForEasterBox = 95, //Requires: 5 Golden Easter Eggs.
        ExchangeForEasterChickenQueenSeal = 96, //Requires: 30 Chocolate Rabbits.
        GetDailyQuestEasterSlugg = 97,
        GetDailyQuestEasterCalvinCoach = 98,
        GetDailyQuestEasterEvaEnergy = 99,
        GetDailyQuestEasterMalcolmMix = 100,
        GetQuestHeroesOfFire = 110, //Level 75
        ExchangeForLordDracosRaidSeal = 111,
        GetQuestChristmasTheVikingFamily = 128, //Level 20, obtained from the Snow Fairy.
        ExchangeForHappyNewYearGoldenBox_x10 = 129,
        ExchangeForHappyNewYearBox_x10 = 130,
        GetQuestGlacerusTheIceCold = 131, //Level 80
        GoToGlacerusCave = 132,
        ExchangeForGlacerusRaidSeal = 133,
        GetQuestReturnBorrowedPowder = 134,
        ArenaRegisterTalent = 135,
        ArenaRegisterMaster = 136,
        ArenaEnterAsSpectatorSelection = 137,
        ArenaEnterAsSpectatorTalent = 138,
        ArenaEnterAsSpectatorMaster = 139,
        ArenaGetRecordMaster = 140,
        FinishedTS2 = 144,
        ExchangeForSP5 = 145,
        ExchangeForRubyOfCompletion = 146,
        ExchangeForSP6 = 147,
        ExchangeForSapphireOfCompletion = 148,
        GoToLandOfDeath = 150,
        ExchangeReservesForRandomGift = 155, //Only used on KR client
        GetQuestBewitchedSoldiers = 193,
        ExchangeForCleansingPowder = 194,

        ExchangeFor2xWitchLaurenaSeal =
            195, //Requires: five Seeds of Damnation. You can collect them in the Cave of Ghosts.
        GetQuestForTheRealmOfHeroes = 196,
        GetQuestRaphaelStory = 197,
        GetXQuestFromDialog2Quest = 200, //Related with GetXQuest
        GetQuestGingsengDagger = 201,
        GetQuestGrahamCrusarder = 300,
        GoToForgottenArchipelago = 301,
        GetQuestMissingScout = 302,
        QuestMissingScoutOption1 = 303,
        QuestMissingScoutOption2 = 304,

        GoToShip = 305,
        //GoToAncelloansWill = 306,
        //GoToCylloan = 307,
        GetQuestBarnisSoul = 308,
        GoToTartHapendam = 313,
        ReturnFromTartHapendam = 314,
        GetQuestJeniffer = 315,
        Get10thAnniversaryCake = 318, //Obtained via Eva Energy, only available once and for Archers.
        Get10thAnniversaryEpicFirecracker = 319, //Obtained via Malcolm Mix, only available once and for Mages.
        Get10thAnniversaryLegendarySword = 320, //Obtained via Teodor Topp, only available once and for Swordsmans.
        OpenBankFacilities = 321,
        GetSavingsBook = 322,
        GetBuffTartHapendamMartialArts = 323,
        GetSecondMartialArtistQuest = 324, //Related with Martial Artist - The Water Heroine
        ExchangeForChristmasRedNosedReindeerMagicSleigh = 325,
        GetQuestChristmasDestroyFiends = 326,
        GetQuestAmoraStory = 327,
        GetDailyQuestEasterEvaEnergy2 = 328, //March Hare one, requires: 10 Cleansed Eggs
        ExchangeForCleansedEggs = 330, //Required: 10 Rotten Eggs and Soul Gem Refiner.
        TriggerDialogHistoryMarchHare = 331, //Generates the Dialog 466
        SkyTower = 338,
        GetThirdMartialArtistQuest = 340, //Used to obtain the Martial Artist SP3, type = quest id = 6332
        ChangePassion = 580,
        OpenShop = 900,
        GoToXTimeSpace = 1000, //Types = TS id. The ones used are: 518-524, 608.
        GetQuestFromNPC = 1500,
        GetHalloweenBagOfSweets = 1503,
        ExchangeForBagOfSweets = 1504,
        OldGetQuestEasterCalvinCoach = 1506,
        GetDailyQuestSummerCaptainJackPanon = 1507,
        GetTemporaryPirateSP = 1508,
        ExchangeForPirateSeal = 1509, //Requires: 10 Mariner's Symbols and 10 Treasure Map Fragments.
        Unknown6 = 1510, //Delted content?
        GambleForThePirateSP = 1511, //Requires: 1k gold and a Pirate SP Fragment
        Unknown7 = 1512, //Delted content?
        Unknown8 = 1513, //''
        Unknown9 = 1514, //''
        Unknown10 = 1515, //''
        Unknown11 = 1516, //''
        OpenFamilyWarehouse = 1600,
        OpenFamilyWarehouseHistory = 1601,
        OldPurchaseWarehouse = 1602, //21 slots. Requires: 500k gold and Family Level 2
        OldExpandWarehouse = 1603, //Expands to 28 slots. Requires: 2kk gold and Family Level 7
        ExtendNumberOfFamilyMembersBy20 = 1604, //Requires: 5kk gold and Family Level 5
        ExtendNumberOfFamilyMembersBy30 = 1605, //Requires: 10kk gold and Family Level 9

        GetXSPQuest =
            2000, //Types = quest ids. Types/ids used for: SP1 (2008), SP2 (2014), The Laboratory's Secret (2022), Jajamaru (2030), Sakura's Seal (2048), SP3 (2060), SP4 (2100).
        GetXSPCard = 2001, //Types: 1 = Pyjama Card, 2 = SP1, 3 = SP2.
        GoToSPStone = 2002, //Only used for TS: 2107, 2108, 2109, 2111, 2112
        GetQuestListFromNPC = 3000,
        GetQuestFromList = 3001,
        GetQuestHigherTimeSpaceScore = 3002,
        GetXQuest = 3006, //Types = quest ids. Used for 284 quests.
        RainbowBattleRegistration = 4000,
        GoToShipGlacernon = 5001,
        ReturnFromGlacernon = 5002,
        CheckBoatSchedule = 5003, //Seems unused.
        CancelShipTravelGlacernon = 5004,
        GoToShipMortazDesert = 5011,
        ReturnFromMortazDesert = 5012,
        CancelShipTravelMortazDesert = 5014,
        OldExchangeForChristmasLittleGiftBox = 6000,
        OldExchangeForChristmasReindeerAntlers = 6001,
        OldExchangeChristmasVouchers = 6002,
        OldGetQuestChristmasEliminateMonsters = 6008,
        Unknown12 = 6009, //Deleted content?
        Unknown13 = 6010, //''
        Unknown14 = 6011, //''
        ExchangeForHappyNewYearGoldenBox = 6013, //Required golden letters: 'H', 'A', 'A', 'P', 'Y'
        ExchangeForHappyNewYearBox = 6014, //Required letters: 'N', 'E', 'W', 'Y', 'E', 'A', 'R',
        ExchangeForChristmasBell = 6015,
        OldExchangeForChristmasGiftBox2 = 6016,
        ExchangeForNewYearGiftBox = 6017, //Requires: 5 Stolen Gift Bags and 5 Stolen Lucky Charms.

    }
}
