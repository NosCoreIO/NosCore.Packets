# NosCore.Packets's Documentation
## ClientPackets :

### Bank
- [gbox](../src/NosCore.Packets/ClientPackets/Bank/GboxPacket.cs) *InGame*

### Battle
- [mtlist](../src/NosCore.Packets/ClientPackets/Battle/MultiTargetListPacket.cs) *InGame*
- [multi_target_list_sub_packet](../src/NosCore.Packets/ClientPackets/Battle/MultiTargetListSubPacket.cs) *InGame*
- [ncif](../src/NosCore.Packets/ClientPackets/Battle/NcifPacket.cs) *InTrade | InGame*
- [u_as](../src/NosCore.Packets/ClientPackets/Battle/UseAoeSkillPacket.cs) *InGame*
- [ob_a](../src/NosCore.Packets/ClientPackets/Battle/UseIconFalconSkillPacket.cs) *InGame*
- [u_s](../src/NosCore.Packets/ClientPackets/Battle/UseSkillPacket.cs) *InGame*

### BattlePassGift
- [bp_msel](../src/NosCore.Packets/ClientPackets/BattlePassGift/BpMselPacket.cs) *InGame*
- [bp_psel](../src/NosCore.Packets/ClientPackets/BattlePassGift/BpPselPacket.cs) *InGame*

### Bazaar
- [c_blist](../src/NosCore.Packets/ClientPackets/Bazaar/CBListPacket.cs) *InTrade | InGame*
- [c_buy](../src/NosCore.Packets/ClientPackets/Bazaar/CBuyPacket.cs) *InGame*
- [c_mod](../src/NosCore.Packets/ClientPackets/Bazaar/CModPacket.cs) *InGame*
- [c_reg](../src/NosCore.Packets/ClientPackets/Bazaar/CRegPacket.cs) *InGame*
- [c_scalc](../src/NosCore.Packets/ClientPackets/Bazaar/CScalcPacket.cs) *InGame*
- [c_skill](../src/NosCore.Packets/ClientPackets/Bazaar/CSkillPacket.cs) *InGame*
- [c_slist](../src/NosCore.Packets/ClientPackets/Bazaar/CSListPacket.cs) *InTrade | InGame*

### CharacterSelectionScreen
- [Char_DEL](../src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/CharacterDeletePacket.cs) *OnCharacterScreen*
- [Char_NEW_JOB](../src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/CharNewJobPacket.cs) *OnCharacterScreen*
- [Char_NEW](../src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/CharNewPacket.cs) *OnCharacterScreen*
- [Char_REN](../src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/CharRenamePacket.cs) *OnCharacterScreen*
- [game_start](../src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/GameStartPacket.cs) *InGame*
- [select](../src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/SelectPacket.cs) *OnCharacterScreen*

### Chat
- [btk](../src/NosCore.Packets/ClientPackets/Chat/BtkPacket.cs) *InTrade | InGame*
- [say](../src/NosCore.Packets/ClientPackets/Chat/ClientSayPacket.cs) *InTrade | InGame*
- [:](../src/NosCore.Packets/ClientPackets/Chat/FamilyChatPacket.cs) *InTrade | InGame*
- [;](../src/NosCore.Packets/ClientPackets/Chat/GroupTalkPacket.cs) *InTrade | InGame*
- [hero](../src/NosCore.Packets/ClientPackets/Chat/HeroPacket.cs) *InTrade | InGame*
- [!](../src/NosCore.Packets/ClientPackets/Chat/TimeSpaceTalkPacket.cs) *InGame*
- [/](../src/NosCore.Packets/ClientPackets/Chat/WhisperPacket.cs) *InTrade | InGame*

### ClientPackets
- [lbs](../src/NosCore.Packets/ClientPackets/ClientPackets/LbsPacket.cs) *InTrade | InGame*
- [pdtclose](../src/NosCore.Packets/ClientPackets/ClientPackets/PdtClosePacket.cs) *InGame*
- [sc_p_cts](../src/NosCore.Packets/ClientPackets/ClientPackets/ScpCtsPacket.cs) *InGame*

### Commands
- [%Familydeputy](../src/NosCore.Packets/ClientPackets/Commands/FamilyDeputyPacket.cs) *InTrade | InGame*
- [%Familydismiss](../src/NosCore.Packets/ClientPackets/Commands/FamilyDismissPacket.cs) *InTrade | InGame*
- [%Familyhead](../src/NosCore.Packets/ClientPackets/Commands/FamilyHeadPacket.cs) *InTrade | InGame*
- [%Familyinvite](../src/NosCore.Packets/ClientPackets/Commands/FamilyInvitePacket.cs) *InTrade | InGame*
- [%Familykeeper](../src/NosCore.Packets/ClientPackets/Commands/FamilyKeeperPacket.cs) *InTrade | InGame*
- [%Familyleave](../src/NosCore.Packets/ClientPackets/Commands/FamilyLeavePacket.cs) *InTrade | InGame*
- [%Familyshout](../src/NosCore.Packets/ClientPackets/Commands/FamilyShoutPacket.cs) *InTrade | InGame*
- [$Adding](../src/NosCore.Packets/ClientPackets/Commands/FriendInvitePacket.cs) *InTrade | InGame*
- [$Party](../src/NosCore.Packets/ClientPackets/Commands/GroupInvitePacket.cs) *InTrade | InGame*
- [$Invite](../src/NosCore.Packets/ClientPackets/Commands/MinilandInvitePacket.cs) *InTrade | InGame*
- [$Partylocation](../src/NosCore.Packets/ClientPackets/Commands/PartyLocationPacket.cs) *InTrade | InGame*
- [$Accompany](../src/NosCore.Packets/ClientPackets/Commands/TimeSpaceInvitePacket.cs) *InTrade | InGame*

### Drops
- [drop](../src/NosCore.Packets/ClientPackets/Drops/DropPacket.cs) *InGame*
- [get](../src/NosCore.Packets/ClientPackets/Drops/GetPacket.cs) *InGame*

### Event
- [fb](../src/NosCore.Packets/ClientPackets/Event/FbPacket.cs) *InGame*
- [mkraid](../src/NosCore.Packets/ClientPackets/Event/MkRaidPacket.cs) *InGame*
- [rd](../src/NosCore.Packets/ClientPackets/Event/RdPacket.cs) *InGame*
- [revival](../src/NosCore.Packets/ClientPackets/Event/RevivalPacket.cs) *InGame*
- [rl](../src/NosCore.Packets/ClientPackets/Event/RlPacket.cs) *InGame*
- [rsel](../src/NosCore.Packets/ClientPackets/Event/RselPacket.cs) *InGame*
- [treq](../src/NosCore.Packets/ClientPackets/Event/TreqPacket.cs) *InGame*

### Exchanges
- [req_exc](../src/NosCore.Packets/ClientPackets/Exchanges/ExchangeRequestPacket.cs) *InGame*
- [exc_list](../src/NosCore.Packets/ClientPackets/Exchanges/ExcListPacket.cs) *InTrade | InGame*

### Families
- [glmk](../src/NosCore.Packets/ClientPackets/Families/CreateFamilyPacket.cs) *InGame*
- [glrm](../src/NosCore.Packets/ClientPackets/Families/FamilyDismissPacket.cs) *InGame*
- [fmg](../src/NosCore.Packets/ClientPackets/Families/FamilyManagementPacket.cs) *InGame*
- [fauth](../src/NosCore.Packets/ClientPackets/Families/FAuthPacket.cs) *InGame*
- [fhis_cts](../src/NosCore.Packets/ClientPackets/Families/FhistCtsPacket.cs) *InGame*
- [frank_cts](../src/NosCore.Packets/ClientPackets/Families/FrankCtsPacket.cs) *InGame*
- [fws](../src/NosCore.Packets/ClientPackets/Families/FwsPacket.cs) *InGame*
- [gidx](../src/NosCore.Packets/ClientPackets/Families/GidxPacket.cs) *InTrade | InGame*
- [glist](../src/NosCore.Packets/ClientPackets/Families/GListPacket.cs) *InTrade | InGame*
- [gjoin](../src/NosCore.Packets/ClientPackets/Families/JoinFamilyPacket.cs) *InGame*
- [today_cts](../src/NosCore.Packets/ClientPackets/Families/TodayPacket.cs) *InGame*

### Groups
- [pinv](../src/NosCore.Packets/ClientPackets/Groups/PinvPacket.cs) *InGame*
- [pleave](../src/NosCore.Packets/ClientPackets/Groups/PleavePacket.cs) *InTrade | InGame*

### Infrastructure
- [DAC](../src/NosCore.Packets/ClientPackets/Infrastructure/DacPacket.cs) *OnCharacterScreen*
- [0](../src/NosCore.Packets/ClientPackets/Infrastructure/ZeroPacket.cs) *OnCharacterScreen | InTrade | InGame*

### Instance
- [escape](../src/NosCore.Packets/ClientPackets/Instance/EscapePacket.cs) *InGame*
- [git](../src/NosCore.Packets/ClientPackets/Instance/GitPacket.cs) *InGame*
- [hidn](../src/NosCore.Packets/ClientPackets/Instance/HidnPacket.cs) *InGame*
- [rstart](../src/NosCore.Packets/ClientPackets/Instance/RStartPacket.cs) *InGame*
- [rxit](../src/NosCore.Packets/ClientPackets/Instance/RxitPacket.cs) *InGame*
- [score](../src/NosCore.Packets/ClientPackets/Instance/ScorePacket.cs) *InGame*
- [sreq](../src/NosCore.Packets/ClientPackets/Instance/SreqPacket.cs) *InGame*
- [taw](../src/NosCore.Packets/ClientPackets/Instance/TawPacket.cs) *InGame*
- [wreq](../src/NosCore.Packets/ClientPackets/Instance/WreqPacket.cs) *InGame*

### Inventory
- [b_i](../src/NosCore.Packets/ClientPackets/Inventory/BiPacket.cs) *InGame*
- [isort](../src/NosCore.Packets/ClientPackets/Inventory/ISortPacket.cs) *InGame*
- [mve](../src/NosCore.Packets/ClientPackets/Inventory/MvePacket.cs) *InGame*
- [mvi](../src/NosCore.Packets/ClientPackets/Inventory/MviPacket.cs) *InGame*
- [pdti](../src/NosCore.Packets/ClientPackets/Inventory/PdtiPacket.cs) *InGame*
- [put](../src/NosCore.Packets/ClientPackets/Inventory/PutPacket.cs) *InGame*
- [remove](../src/NosCore.Packets/ClientPackets/Inventory/RemovePacket.cs) *InGame*
- [sortopen](../src/NosCore.Packets/ClientPackets/Inventory/SortOpenPacket.cs) *InGame*
- [u_i](../src/NosCore.Packets/ClientPackets/Inventory/UseItemPacket.cs) *InGame*
- [wear](../src/NosCore.Packets/ClientPackets/Inventory/WearPacket.cs) *InGame*

### Login
- [NoS0575](../src/NosCore.Packets/ClientPackets/Login/NoS0575Packet.cs) *OnLoginScreen*
- [NoS0577](../src/NosCore.Packets/ClientPackets/Login/NoS0577Packet.cs) *OnLoginScreen*

### Mates
- [psl](../src/NosCore.Packets/ClientPackets/Mates/PslPacket.cs) *InGame*
- [ps_op](../src/NosCore.Packets/ClientPackets/Mates/PsopPacket.cs) *InGame*
- [ptctl](../src/NosCore.Packets/ClientPackets/Mates/PtctlPacket.cs) *InGame*
- [say_p](../src/NosCore.Packets/ClientPackets/Mates/SayPPacket.cs) *InGame*
- [suctl](../src/NosCore.Packets/ClientPackets/Mates/SuCtlPacket.cs) *InGame*
- [u_pet](../src/NosCore.Packets/ClientPackets/Mates/UpetPacket.cs) *InGame*
- [u_ps](../src/NosCore.Packets/ClientPackets/Mates/UpsPacket.cs) *InGame*

### Miniland
- [addobj](../src/NosCore.Packets/ClientPackets/Miniland/AddobjPacket.cs) *InGame*
- [mg](../src/NosCore.Packets/ClientPackets/Miniland/MinigamePacket.cs) *InGame*
- [mjoin](../src/NosCore.Packets/ClientPackets/Miniland/MJoinPacket.cs) *InGame*
- [mledit](../src/NosCore.Packets/ClientPackets/Miniland/MLEditPacket.cs) *InGame*
- [rmvobj](../src/NosCore.Packets/ClientPackets/Miniland/RmvobjPacket.cs) *InGame*
- [useobj](../src/NosCore.Packets/ClientPackets/Miniland/UseObjPacket.cs) *InGame*

### Movement
- [dir](../src/NosCore.Packets/ClientPackets/Movement/ClientDirPacket.cs) *InTrade | InGame*
- [preq](../src/NosCore.Packets/ClientPackets/Movement/PreqPacket.cs) *InTrade | InGame*
- [pulse](../src/NosCore.Packets/ClientPackets/Movement/PulsePacket.cs) *InTrade | InGame*
- [rest](../src/NosCore.Packets/ClientPackets/Movement/SitPacket.cs) *InTrade | InGame*
- [walk](../src/NosCore.Packets/ClientPackets/Movement/WalkPacket.cs) *InGame*

### Npcs
- [n_run](../src/NosCore.Packets/ClientPackets/Npcs/NrunPacket.cs) *InGame*
- [npc_req](../src/NosCore.Packets/ClientPackets/Npcs/RequestNpcPacket.cs) *InGame*

### Parcel
- [pcl](../src/NosCore.Packets/ClientPackets/Parcel/PclPacket.cs) *InGame*
- [pst](../src/NosCore.Packets/ClientPackets/Parcel/PstClientPacket.cs) *InGame*

### Player
- [bp_close](../src/NosCore.Packets/ClientPackets/Player/BpClosePacket.cs) *InGame*
- [bpm](../src/NosCore.Packets/ClientPackets/Player/BpmPacket.cs) *InGame*
- [bpo](../src/NosCore.Packets/ClientPackets/Player/BpoPacket.cs) *InGame*
- [bp_open](../src/NosCore.Packets/ClientPackets/Player/BpOpenPacket.cs) *InGame*
- [bpp](../src/NosCore.Packets/ClientPackets/Player/BppPacket.cs) *InGame*
- [bpt](../src/NosCore.Packets/ClientPackets/Player/BptPacket.cs) *InGame*
- [compl](../src/NosCore.Packets/ClientPackets/Player/ComplPacket.cs) *InGame*
- [eqinfo](../src/NosCore.Packets/ClientPackets/Player/EquipmentInfoPacket.cs) *InGame*
- [rsfi](../src/NosCore.Packets/ClientPackets/Player/RsfiPacket.cs) *InGame*
- [snap](../src/NosCore.Packets/ClientPackets/Player/SnapPacket.cs) *InTrade | InGame*
- [tit_eq](../src/NosCore.Packets/ClientPackets/Player/TitEqPacket.cs) *InTrade | InGame*
- [up_gr](../src/NosCore.Packets/ClientPackets/Player/UpgradePacket.cs) *InGame*

### Quest
- [qt](../src/NosCore.Packets/ClientPackets/Quest/QtPacket.cs) *InGame*
- [script](../src/NosCore.Packets/ClientPackets/Quest/ScriptClientPacket.cs) *InGame*

### Quicklist
- [qset](../src/NosCore.Packets/ClientPackets/Quicklist/QsetPacket.cs) *InTrade | InGame*

### Relations
- [bldel](../src/NosCore.Packets/ClientPackets/Relations/BlDelPacket.cs) *InTrade | InGame*
- [blins](../src/NosCore.Packets/ClientPackets/Relations/BlInsPacket.cs) *InTrade | InGame*
- [$bl](../src/NosCore.Packets/ClientPackets/Relations/BlPacket.cs) *InTrade | InGame*
- [fdel](../src/NosCore.Packets/ClientPackets/Relations/FdelPacket.cs) *InTrade | InGame*
- [fins](../src/NosCore.Packets/ClientPackets/Relations/FinsPacket.cs) *InTrade | InGame*
- [fl](../src/NosCore.Packets/ClientPackets/Relations/FlPacket.cs) *InGame*
- [reloadfinfo](../src/NosCore.Packets/ClientPackets/Relations/ReloadFinfoPacket.cs) *InTrade | InGame*

### Shops
- [buy](../src/NosCore.Packets/ClientPackets/Shops/BuyPacket.cs) *InGame*
- [c_close](../src/NosCore.Packets/ClientPackets/Shops/CClosePacket.cs) *OnCharacterScreen | InTrade | InGame*
- [m_shop](../src/NosCore.Packets/ClientPackets/Shops/MShopPacket.cs) *InGame*
- [pdtse](../src/NosCore.Packets/ClientPackets/Shops/PdtsePacket.cs) *InGame*
- [sell_list](../src/NosCore.Packets/ClientPackets/Shops/SellListPacket.cs) *InTrade | InGame*
- [sell](../src/NosCore.Packets/ClientPackets/Shops/SellPacket.cs) *InGame*
- [shopclose](../src/NosCore.Packets/ClientPackets/Shops/ShopClosePacket.cs) *InGame*
- [shopping](../src/NosCore.Packets/ClientPackets/Shops/ShoppingPacket.cs) *InGame*

### Specialists
- [s_carrier](../src/NosCore.Packets/ClientPackets/Specialists/SCarrierPacket.cs) *InGame*
- [sl](../src/NosCore.Packets/ClientPackets/Specialists/SpTransformPacket.cs) *InGame*

### UI
- [gop](../src/NosCore.Packets/ClientPackets/UI/GopPacket.cs) *InGame*
- [guri](../src/NosCore.Packets/ClientPackets/UI/GuriPacket.cs) *InGame*

### Warehouse
- [deposit](../src/NosCore.Packets/ClientPackets/Warehouse/DepositPacket.cs) *InTrade | InGame*
- [f_deposit](../src/NosCore.Packets/ClientPackets/Warehouse/FDepositPacket.cs) *InTrade | InGame*
- [f_repos](../src/NosCore.Packets/ClientPackets/Warehouse/FReposPacket.cs) *InTrade | InGame*
- [f_stash_end](../src/NosCore.Packets/ClientPackets/Warehouse/FStashEndPacket.cs) *OnCharacterScreen | InTrade | InGame*
- [f_withdraw](../src/NosCore.Packets/ClientPackets/Warehouse/FWithdrawPacket.cs) *InTrade | InGame*
- [repos](../src/NosCore.Packets/ClientPackets/Warehouse/ReposPacket.cs) *InTrade | InGame*
- [stash_end](../src/NosCore.Packets/ClientPackets/Warehouse/StashEndPacket.cs) *OnCharacterScreen | InTrade | InGame*
- [withdraw](../src/NosCore.Packets/ClientPackets/Warehouse/WithdrawPacket.cs) *InTrade | InGame*

## ServerPackets :

### Arena
- [bsc](../src/NosCore.Packets/ServerPackets/Arena/BscPacket.cs) *InGame*
- [ta_call](../src/NosCore.Packets/ServerPackets/Arena/TaCallPacket.cs) *InGame*

### Auction
- [rc_blist](../src/NosCore.Packets/ServerPackets/Auction/RcbListPacket.cs) *InGame*
- [rc_slist](../src/NosCore.Packets/ServerPackets/Auction/RcsListPacket.cs) *InGame*

### Bank
- [gb](../src/NosCore.Packets/ServerPackets/Bank/GbPacket.cs) *InGame*

### Battle
- [bf](../src/NosCore.Packets/ServerPackets/Battle/BfPacket.cs) *InGame*
- [cancel](../src/NosCore.Packets/ServerPackets/Battle/CancelPacket.cs) *InGame*
- [ct](../src/NosCore.Packets/ServerPackets/Battle/CtPacket.cs) *InGame*
- [die](../src/NosCore.Packets/ServerPackets/Battle/DiePacket.cs) *InGame*
- [ms_c](../src/NosCore.Packets/ServerPackets/Battle/MscPacket.cs) *InGame*
- [mslot](../src/NosCore.Packets/ServerPackets/Battle/MslotPacket.cs) *InGame*
- [sr](../src/NosCore.Packets/ServerPackets/Battle/SkillResetPacket.cs) *InGame*
- [su](../src/NosCore.Packets/ServerPackets/Battle/SuPacket.cs) *InGame*
- [vb](../src/NosCore.Packets/ServerPackets/Battle/VbPacket.cs) *InGame*

### Bazaar
- [rc_buy](../src/NosCore.Packets/ServerPackets/Bazaar/RCBuyPacket.cs) *InGame*
- [rc_reg](../src/NosCore.Packets/ServerPackets/Bazaar/RCRegPacket.cs) *InGame*
- [rc_scalc](../src/NosCore.Packets/ServerPackets/Bazaar/RCScalcPacket.cs) *InGame*

### CharacterSelectionScreen
- [clist_end](../src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/ClistEndPacket.cs) *OnCharacterScreen | InGame*
- [clist](../src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/ClistPacket.cs) *OnCharacterScreen*
- [clist_start](../src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/ClistStartPacket.cs) *InGame*
- [OK](../src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/OkPacket.cs) *InGame*
- [scene](../src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/ScenePacket.cs) *InGame*
- [success](../src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/SuccessPacket.cs) *InGame*

### Chats
- [csp](../src/NosCore.Packets/ServerPackets/Chats/BubblePacket.cs) *InGame*
- [IconInfo](../src/NosCore.Packets/ServerPackets/Chats/IconInfoPacket.cs) *InGame*
- [inbox](../src/NosCore.Packets/ServerPackets/Chats/InboxPacket.cs) *InGame*
- [sayi2](../src/NosCore.Packets/ServerPackets/Chats/Sayi2Packet.cs) *InGame*
- [sayi](../src/NosCore.Packets/ServerPackets/Chats/SayiPacket.cs) *InGame*
- [sayitem](../src/NosCore.Packets/ServerPackets/Chats/SayItemPacket.cs) *InGame*
- [sayitemt](../src/NosCore.Packets/ServerPackets/Chats/SayItemtPacket.cs) *InGame*
- [say](../src/NosCore.Packets/ServerPackets/Chats/SayPacket.cs) *InGame*
- [say_p](../src/NosCore.Packets/ServerPackets/Chats/SayPetPacket.cs) *InGame*
- [sayt](../src/NosCore.Packets/ServerPackets/Chats/SaytPacket.cs) *InGame*
- [spk](../src/NosCore.Packets/ServerPackets/Chats/SpeakPacket.cs) *InGame*
- [talk](../src/NosCore.Packets/ServerPackets/Chats/TalkPacket.cs) *InGame*

### Entities
- [ca_t](../src/NosCore.Packets/ServerPackets/Entities/CatPacket.cs) *InGame*
- [char_sc](../src/NosCore.Packets/ServerPackets/Entities/CharScPacket.cs) *InGame*
- [drop](../src/NosCore.Packets/ServerPackets/Entities/DropPacket.cs) *InGame*
- [mv](../src/NosCore.Packets/ServerPackets/Entities/MovePacket.cs) *InGame*
- [out](../src/NosCore.Packets/ServerPackets/Entities/OutPacket.cs) *InGame*
- [req_info](../src/NosCore.Packets/ServerPackets/Entities/ReqInfoPacket.cs) *InGame*
- [rest](../src/NosCore.Packets/ServerPackets/Entities/RestPacket.cs) *InGame*
- [st](../src/NosCore.Packets/ServerPackets/Entities/StPacket.cs) *InGame*
- [tp](../src/NosCore.Packets/ServerPackets/Entities/TpPacket.cs) *InGame*

### Event
- [rbr](../src/NosCore.Packets/ServerPackets/Event/RbrPacket.cs) *InGame*

### Exchanges
- [exc_close](../src/NosCore.Packets/ServerPackets/Exchanges/ExcClosePacket.cs) *InGame*
- [exc_list](../src/NosCore.Packets/ServerPackets/Exchanges/ServerExcListPacket.cs) *InGame*

### Families
- [ginfo](../src/NosCore.Packets/ServerPackets/Families/GInfoPacket.cs) *InGame*

### Groups
- [pinit](../src/NosCore.Packets/ServerPackets/Groups/PinitPacket.cs) *InGame*
- [pinit_sub_packet](../src/NosCore.Packets/ServerPackets/Groups/PinitSubPacket.cs) *InGame*
- [pjoin](../src/NosCore.Packets/ServerPackets/Groups/PjoinPacket.cs) *InGame*

### Inventory
- [e_info](../src/NosCore.Packets/ServerPackets/Inventory/EInfoPacket.cs) *InGame*
- [eq](../src/NosCore.Packets/ServerPackets/Inventory/EqPacket.cs) *InGame*
- [equip](../src/NosCore.Packets/ServerPackets/Inventory/EquipPacket.cs) *InGame*
- [exts](../src/NosCore.Packets/ServerPackets/Inventory/ExtsPacket.cs) *InGame*
- [gold](../src/NosCore.Packets/ServerPackets/Inventory/GoldPacket.cs) *InGame*
- [inv](../src/NosCore.Packets/ServerPackets/Inventory/InvPacket.cs) *InGame*
- [ivn](../src/NosCore.Packets/ServerPackets/Inventory/IvnPacket.cs) *InGame*
- [pairy](../src/NosCore.Packets/ServerPackets/Inventory/PairyPacket.cs) *InGame*
- [get](../src/NosCore.Packets/ServerPackets/Inventory/ServerGetPacket.cs) *InGame*
- [slinfo](../src/NosCore.Packets/ServerPackets/Inventory/SlInfoPacket.cs) *InGame*

### Login
- [failc](../src/NosCore.Packets/ServerPackets/Login/FailcPacket.cs) *OnLoginScreen*
- [it](../src/NosCore.Packets/ServerPackets/Login/ItPacket.cs) *InGame*
- [mz](../src/NosCore.Packets/ServerPackets/Login/MzPacket.cs) *InGame*
- [NsTeST](../src/NosCore.Packets/ServerPackets/Login/NsTestPacket.cs) *OnLoginScreen*
- [NsTeST_sub_packet](../src/NosCore.Packets/ServerPackets/Login/NsTeStSubPacket.cs) *OnLoginScreen*

### Map
- [bc](../src/NosCore.Packets/ServerPackets/Map/BcPacket.cs) *InGame*
- [bgm2](../src/NosCore.Packets/ServerPackets/Map/Bgm2Packet.cs) *InGame*
- [bgm](../src/NosCore.Packets/ServerPackets/Map/BgmPacket.cs) *InGame*
- [eff_g](../src/NosCore.Packets/ServerPackets/Map/GroundEffectPacket.cs) *InGame*
- [mapout](../src/NosCore.Packets/ServerPackets/Map/MapOutPacket.cs) *InGame*

### Mates
- [ib](../src/NosCore.Packets/ServerPackets/Mates/IbPacket.cs) *InGame*
- [psd](../src/NosCore.Packets/ServerPackets/Mates/PsdPacket.cs) *InGame*
- [pski](../src/NosCore.Packets/ServerPackets/Mates/PSkiPacket.cs) *InGame*
- [sc_n](../src/NosCore.Packets/ServerPackets/Mates/ScnPacket.cs) *InGame*
- [sc_p](../src/NosCore.Packets/ServerPackets/Mates/ScpPacket.cs) *InGame*

### Miniland
- [mlpt](../src/NosCore.Packets/ServerPackets/Miniland/MinilandPointPacket.cs) *InGame*
- [mlinfobr](../src/NosCore.Packets/ServerPackets/Miniland/MlInfoBrPacket.cs) *InGame*
- [mlinfo](../src/NosCore.Packets/ServerPackets/Miniland/MlinfoPacket.cs) *InGame*
- [mlintro](../src/NosCore.Packets/ServerPackets/Miniland/MlintroPacket.cs) *InGame*
- [mlobjlst](../src/NosCore.Packets/ServerPackets/Miniland/MlobjlstPacket.cs) *InGame*
- [mlobj](../src/NosCore.Packets/ServerPackets/Miniland/MlobjPacket.cs) *InGame*
- [mlo_info](../src/NosCore.Packets/ServerPackets/Miniland/MloInfoPacket.cs) *InGame*
- [mlo_lv](../src/NosCore.Packets/ServerPackets/Miniland/MloLvPacket.cs) *InGame*
- [mlo_mg](../src/NosCore.Packets/ServerPackets/Miniland/MloMgPacket.cs) *InGame*
- [mlo_pmg](../src/NosCore.Packets/ServerPackets/Miniland/MloPmgPacket.cs) *InGame*
- [mlo_rw](../src/NosCore.Packets/ServerPackets/Miniland/MloRwPacket.cs) *InGame*
- [mlo_st](../src/NosCore.Packets/ServerPackets/Miniland/MloStPacket.cs) *InGame*
- [useobj](../src/NosCore.Packets/ServerPackets/Miniland/UseObjPacket.cs) *InGame*

### MiniMap
- [at](../src/NosCore.Packets/ServerPackets/MiniMap/AtPacket.cs) *InGame*
- [c_map](../src/NosCore.Packets/ServerPackets/MiniMap/CMapPacket.cs) *InGame*
- [rsfp](../src/NosCore.Packets/ServerPackets/MiniMap/RsfpPacket.cs) *InGame*
- [wp](../src/NosCore.Packets/ServerPackets/MiniMap/WpPacket.cs) *InGame*

### Movement
- [dir](../src/NosCore.Packets/ServerPackets/Movement/DirPacket.cs) *InGame*

### Parcel
- [parcel](../src/NosCore.Packets/ServerPackets/Parcel/ParcelPacket.cs) *InGame*
- [post](../src/NosCore.Packets/ServerPackets/Parcel/PostPacket.cs) *InGame*
- [pst](../src/NosCore.Packets/ServerPackets/Parcel/PstPacket.cs) *InGame*

### Player
- [bn](../src/NosCore.Packets/ServerPackets/Player/BnPacket.cs) *InGame*
- [c_info](../src/NosCore.Packets/ServerPackets/Player/CInfoPacket.cs) *InGame*
- [c_mode](../src/NosCore.Packets/ServerPackets/Player/CModePacket.cs) *InGame*
- [cond](../src/NosCore.Packets/ServerPackets/Player/CondPacket.cs) *InGame*
- [dance](../src/NosCore.Packets/ServerPackets/Player/DancePacket.cs) *InGame*
- [eff](../src/NosCore.Packets/ServerPackets/Player/EffectPacket.cs) *InGame*
- [fd](../src/NosCore.Packets/ServerPackets/Player/FdPacket.cs) *InGame*
- [fish](../src/NosCore.Packets/ServerPackets/Player/FishPacket.cs) *InGame*
- [food](../src/NosCore.Packets/ServerPackets/Player/FoodPacket.cs) *InGame*
- [fs](../src/NosCore.Packets/ServerPackets/Player/FsPacket.cs) *InGame*
- [levelup](../src/NosCore.Packets/ServerPackets/Player/LevelUpPacket.cs) *InGame*
- [lev](../src/NosCore.Packets/ServerPackets/Player/LevPacket.cs) *InGame*
- [npinfo](../src/NosCore.Packets/ServerPackets/Player/NpInfoPacket.cs) *InGame*
- [rage](../src/NosCore.Packets/ServerPackets/Player/RagePacket.cs) *InGame*
- [sc](../src/NosCore.Packets/ServerPackets/Player/ScPacket.cs) *InGame*
- [scr](../src/NosCore.Packets/ServerPackets/Player/ScrPacket.cs) *InGame*
- [stat](../src/NosCore.Packets/ServerPackets/Player/StatPacket.cs) *InGame*
- [tc_info](../src/NosCore.Packets/ServerPackets/Player/TcInfoPacket.cs) *InGame*
- [titinfo](../src/NosCore.Packets/ServerPackets/Player/TitleInfoPacket.cs) *InGame*
- [title](../src/NosCore.Packets/ServerPackets/Player/TitlePacket.cs) *InGame*
- [tit](../src/NosCore.Packets/ServerPackets/Player/TitPacket.cs) *InGame*

### Portals
- [gp](../src/NosCore.Packets/ServerPackets/Portals/GpPacket.cs) *InGame*

### Quest
- [qsti](../src/NosCore.Packets/ServerPackets/Quest/QstiPacket.cs) *InGame*
- [qstlist](../src/NosCore.Packets/ServerPackets/Quest/QstlistPacket.cs) *InGame*
- [script](../src/NosCore.Packets/ServerPackets/Quest/ScriptPacket.cs) *InGame*
- [targetoff](../src/NosCore.Packets/ServerPackets/Quest/TargetOffPacket.cs) *InGame*
- [target](../src/NosCore.Packets/ServerPackets/Quest/TargetPacket.cs) *InGame*

### Quicklist
- [qset](../src/NosCore.Packets/ServerPackets/Quicklist/QsetClientPacket.cs) *InGame*
- [qslot](../src/NosCore.Packets/ServerPackets/Quicklist/QSlotPacket.cs) *InGame*

### Relations
- [blinit](../src/NosCore.Packets/ServerPackets/Relations/BlinitPacket.cs) *InGame*
- [finfo](../src/NosCore.Packets/ServerPackets/Relations/FinfoPacket.cs) *InGame*
- [finfo_sub_packets](../src/NosCore.Packets/ServerPackets/Relations/FinfoSubPackets.cs) *InGame*
- [finit](../src/NosCore.Packets/ServerPackets/Relations/FinitPacket.cs) *InGame*

### Shop
- [ishop](../src/NosCore.Packets/ServerPackets/Shop/IshopPacket.cs) *InGame*
- [n_inv_skills](../src/NosCore.Packets/ServerPackets/Shop/NInvFamilySkillSubPacket.cs) *InGame*
- [n_inv_item](../src/NosCore.Packets/ServerPackets/Shop/NInvItemSubPacket.cs) *InGame*
- [n_inv](../src/NosCore.Packets/ServerPackets/Shop/NInvPacket.cs) *InGame*
- [pflag](../src/NosCore.Packets/ServerPackets/Shop/PflagPacket.cs) *InGame*
- [pidx](../src/NosCore.Packets/ServerPackets/Shop/PidxPacket.cs) *InGame*
- [pidx_sub_packet](../src/NosCore.Packets/ServerPackets/Shop/PidxSubPacket.cs) *InGame*
- [shop_end](../src/NosCore.Packets/ServerPackets/Shop/ShopEndPacket.cs) *InGame*
- [shop](../src/NosCore.Packets/ServerPackets/Shop/ShopPacket.cs) *InGame*
- [s_memoi2](../src/NosCore.Packets/ServerPackets/Shop/SMemoi2Packet.cs) *InGame*
- [s_memoi](../src/NosCore.Packets/ServerPackets/Shop/SMemoiPacket.cs) *InGame*
- [s_memo](../src/NosCore.Packets/ServerPackets/Shop/SMemoPacket.cs) *InGame*

### Specialists
- [sd](../src/NosCore.Packets/ServerPackets/Specialists/SdPacket.cs) *InGame*
- [sp](../src/NosCore.Packets/ServerPackets/Specialists/SpPacket.cs) *InGame*

### UI
- [act6](../src/NosCore.Packets/ServerPackets/UI/Act6Packet.cs) *InGame*
- [ascr](../src/NosCore.Packets/ServerPackets/UI/AscrPacket.cs) *InGame*
- [bsinfo](../src/NosCore.Packets/ServerPackets/UI/BSInfoPacket.cs) *InGame*
- [ch_dm](../src/NosCore.Packets/ServerPackets/UI/ChDMPacket.cs) *InGame*
- [delay](../src/NosCore.Packets/ServerPackets/UI/DelayPacket.cs) *InGame*
- [dlgi](../src/NosCore.Packets/ServerPackets/UI/DlgiPacket.cs) *InGame*
- [dlg](../src/NosCore.Packets/ServerPackets/UI/DlgPacket.cs) *InGame*
- [fishopen](../src/NosCore.Packets/ServerPackets/UI/FishOpenPacket.cs) *InGame*
- [guri](../src/NosCore.Packets/ServerPackets/UI/GuriPacket.cs) *InGame*
- [icon](../src/NosCore.Packets/ServerPackets/UI/IconPacket.cs) *InGame*
- [infoi2](../src/NosCore.Packets/ServerPackets/UI/Infoi2Packet.cs) *InGame*
- [infoi](../src/NosCore.Packets/ServerPackets/UI/InfoiPacket.cs) *InGame*
- [info](../src/NosCore.Packets/ServerPackets/UI/InfoPacket.cs) *InGame*
- [modali](../src/NosCore.Packets/ServerPackets/UI/ModaliPacket.cs) *InGame*
- [modal](../src/NosCore.Packets/ServerPackets/UI/ModalPacket.cs) *InGame*
- [msgi2](../src/NosCore.Packets/ServerPackets/UI/Msgi2Packet.cs) *InGame*
- [msgi](../src/NosCore.Packets/ServerPackets/UI/MsgiPacket.cs) *InGame*
- [msg](../src/NosCore.Packets/ServerPackets/UI/MsgPacket.cs) *InGame*
- [p_clear](../src/NosCore.Packets/ServerPackets/UI/PclearPacket.cs) *InGame*
- [qnai2](../src/NosCore.Packets/ServerPackets/UI/Qnai2Packet.cs) *InGame*
- [qnai](../src/NosCore.Packets/ServerPackets/UI/QnaiPacket.cs) *InGame*
- [qna](../src/NosCore.Packets/ServerPackets/UI/QnaPacket.cs) *InGame*
- [rdi](../src/NosCore.Packets/ServerPackets/UI/RdiPacket.cs) *InGame*
- [shopclose](../src/NosCore.Packets/ServerPackets/UI/ShopClosePacket.cs) *InGame*
- [ta_rank](../src/NosCore.Packets/ServerPackets/UI/TARankPacket.cs) *InGame*
- [ta_close](../src/NosCore.Packets/ServerPackets/UI/TeamArenaClosePacket.cs) *InGame*
- [twk](../src/NosCore.Packets/ServerPackets/UI/TwkPacket.cs) *InGame*
- [umi](../src/NosCore.Packets/ServerPackets/UI/UmiPacket.cs) *InGame*
- [wopen](../src/NosCore.Packets/ServerPackets/UI/WopenPacket.cs) *InGame*
- [zzim](../src/NosCore.Packets/ServerPackets/UI/ZzimPacket.cs) *InGame*

### Visibility
- [cl](../src/NosCore.Packets/ServerPackets/Visibility/ClPacket.cs) *InGame*
- [in](../src/NosCore.Packets/ServerPackets/Visibility/InPacket.cs) *InGame*

### Warehouse
- [f_stash_all](../src/NosCore.Packets/ServerPackets/Warehouse/FStashAllPacket.cs) *InGame*
- [f_stash](../src/NosCore.Packets/ServerPackets/Warehouse/FStashClientPacket.cs) *InGame*
- [p_stash_all](../src/NosCore.Packets/ServerPackets/Warehouse/PStashAllPacket.cs) *InGame*
- [p_stash](../src/NosCore.Packets/ServerPackets/Warehouse/PStashClientPacket.cs) *InGame*
- [stash_all](../src/NosCore.Packets/ServerPackets/Warehouse/StashAllPacket.cs) *InGame*
- [stash](../src/NosCore.Packets/ServerPackets/Warehouse/StashClientPacket.cs) *InGame*
