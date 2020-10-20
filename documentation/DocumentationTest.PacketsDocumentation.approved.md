# NosCore.Packets's Documentation
## ClientPackets :

### Bank
- [gbox](src/NosCore.Packets/ClientPackets/Bank/NosCore.Packets.ClientPackets.Bank.GboxPacket.cs) *InExchange | InGame*

### Battle
- [mtlist](src/NosCore.Packets/ClientPackets/Battle/NosCore.Packets.ClientPackets.Battle.MultiTargetListPacket.cs) *InExchange | InGame*
- [multi_target_list_sub_packet](src/NosCore.Packets/ClientPackets/Battle/NosCore.Packets.ClientPackets.Battle.MultiTargetListSubPacket.cs) *InExchange | InGame*
- [ncif](src/NosCore.Packets/ClientPackets/Battle/NosCore.Packets.ClientPackets.Battle.NcifPacket.cs) *InExchange | InGame*
- [u_as](src/NosCore.Packets/ClientPackets/Battle/NosCore.Packets.ClientPackets.Battle.UseAoeSkillPacket.cs) *InExchange | InGame*
- [u_s](src/NosCore.Packets/ClientPackets/Battle/NosCore.Packets.ClientPackets.Battle.UseSkillPacket.cs) *InExchange | InGame*

### Bazaar
- [c_blist](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CBListPacket.cs) *InExchange | InGame*
- [c_buy](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CBuyPacket.cs) *InExchange | InGame*
- [c_mod](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CModPacket.cs) *InExchange | InGame*
- [c_reg](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CRegPacket.cs) *InExchange | InGame*
- [c_scalc](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CScalcPacket.cs) *InExchange | InGame*
- [c_skill](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CSkillPacket.cs) *InExchange | InGame*
- [c_slist](src/NosCore.Packets/ClientPackets/Bazaar/NosCore.Packets.ClientPackets.Bazaar.CSListPacket.cs) *InExchange | InGame*

### CharacterSelectionScreen
- [Char_DEL](src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/NosCore.Packets.ClientPackets.CharacterSelectionScreen.CharacterDeletePacket.cs) *OnCharacterScreen*
- [Char_NEW_JOB](src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/NosCore.Packets.ClientPackets.CharacterSelectionScreen.CharNewJobPacket.cs) *OnCharacterScreen*
- [Char_NEW](src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/NosCore.Packets.ClientPackets.CharacterSelectionScreen.CharNewPacket.cs) *OnCharacterScreen*
- [Char_REN](src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/NosCore.Packets.ClientPackets.CharacterSelectionScreen.CharRenamePacket.cs) *OnCharacterScreen*
- [game_start](src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/NosCore.Packets.ClientPackets.CharacterSelectionScreen.GameStartPacket.cs) *InGame*
- [select](src/NosCore.Packets/ClientPackets/CharacterSelectionScreen/NosCore.Packets.ClientPackets.CharacterSelectionScreen.SelectPacket.cs) *OnCharacterScreen*

### Chat
- [btk](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.BtkPacket.cs) *InExchange | InGame*
- [say](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.ClientSayPacket.cs) *InExchange | InGame*
- [:](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.FamilyChatPacket.cs) *InExchange | InGame*
- [;](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.GroupTalkPacket.cs) *InExchange | InGame*
- [hero](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.HeroPacket.cs) *InExchange | InGame*
- [!](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.TimeSpaceTalkPacket.cs) *InExchange | InGame*
- [/](src/NosCore.Packets/ClientPackets/Chat/NosCore.Packets.ClientPackets.Chat.WhisperPacket.cs) *InExchange | InGame*

### ClientPackets
- [lbs](src/NosCore.Packets/ClientPackets/ClientPackets/NosCore.Packets.ClientPackets.LbsPacket.cs) *InExchange | InGame*

### Commands
- [%Familydeputy](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyDeputyPacket.cs) *InExchange | InGame*
- [%Familydismiss](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyDismissPacket.cs) *InExchange | InGame*
- [%Familyhead](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyHeadPacket.cs) *InExchange | InGame*
- [%Familyinvite](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyInvitePacket.cs) *InExchange | InGame*
- [%Familykeeper](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyKeeperPacket.cs) *InExchange | InGame*
- [%Familyleave](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyLeavePacket.cs) *InExchange | InGame*
- [%Familyshout](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FamilyShoutPacket.cs) *InExchange | InGame*
- [$Adding](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.FriendInvitePacket.cs) *InExchange | InGame*
- [$Party](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.GroupInvitePacket.cs) *InExchange | InGame*
- [$Invite](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.MinilandInvitePacket.cs) *InExchange | InGame*
- [$Partylocation](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.PartyLocationPacket.cs) *InExchange | InGame*
- [$Accompany](src/NosCore.Packets/ClientPackets/Commands/NosCore.Packets.ClientPackets.Commands.TimeSpaceInvitePacket.cs) *InExchange | InGame*

### Drops
- [drop](src/NosCore.Packets/ClientPackets/Drops/NosCore.Packets.ClientPackets.Drops.DropPacket.cs) *InExchange | InGame*
- [get](src/NosCore.Packets/ClientPackets/Drops/NosCore.Packets.ClientPackets.Drops.GetPacket.cs) *InExchange | InGame*

### Exchanges
- [req_exc](src/NosCore.Packets/ClientPackets/Exchanges/NosCore.Packets.ClientPackets.Exchanges.ExchangeRequestPacket.cs) *InExchange | InGame*
- [exc_list](src/NosCore.Packets/ClientPackets/Exchanges/NosCore.Packets.ClientPackets.Exchanges.ExcListPacket.cs) *InExchange | InGame*

### Families
- [glmk](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.CreateFamilyPacket.cs) *InExchange | InGame*
- [glrm](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.FamilyDismissPacket.cs) *InExchange | InGame*
- [fmg](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.FamilyManagementPacket.cs) *InExchange | InGame*
- [fauth](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.FAuthPacket.cs) *InExchange | InGame*
- [fhis_cts](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.FhistCtsPacket.cs) *InExchange | InGame*
- [frank_cts](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.FrankCtsPacket.cs) *InExchange | InGame*
- [gidx](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.GidxPacket.cs) *InExchange | InGame*
- [glist](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.GListPacket.cs) *InExchange | InGame*
- [gjoin](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.JoinFamilyPacket.cs) *InExchange | InGame*
- [today_cts](src/NosCore.Packets/ClientPackets/Families/NosCore.Packets.ClientPackets.Families.TodayPacket.cs) *InExchange | InGame*

### Groups
- [pleave](src/NosCore.Packets/ClientPackets/Groups/NosCore.Packets.ClientPackets.Groups.PleavePacket.cs) *InExchange | InGame*

### Infrastructure
- [DAC](src/NosCore.Packets/ClientPackets/Infrastructure/NosCore.Packets.ClientPackets.Infrastructure.DacPacket.cs) *OnCharacterScreen*
- [0](src/NosCore.Packets/ClientPackets/Infrastructure/NosCore.Packets.ClientPackets.Infrastructure.ZeroPacket.cs) *OnCharacterScreen | InExchange | InGame*

### Inventory
- [b_i](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.BiPacket.cs) *InExchange | InGame*
- [mve](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.MvePacket.cs) *InExchange | InGame*
- [mvi](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.MviPacket.cs) *InExchange | InGame*
- [pdti](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.PdtiPacket.cs) *InExchange | InGame*
- [put](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.PutPacket.cs) *InExchange | InGame*
- [remove](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.RemovePacket.cs) *InExchange | InGame*
- [u_i](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.UseItemPacket.cs) *InExchange | InGame*
- [wear](src/NosCore.Packets/ClientPackets/Inventory/NosCore.Packets.ClientPackets.Inventory.WearPacket.cs) *InExchange | InGame*

### Login
- [NoS0575](src/NosCore.Packets/ClientPackets/Login/NosCore.Packets.ClientPackets.Login.NoS0575Packet.cs) *OnLoginScreen*
- [NoS0577](src/NosCore.Packets/ClientPackets/Login/NosCore.Packets.ClientPackets.Login.NoS0577Packet.cs) *OnLoginScreen*

### Mates
- [psl](src/NosCore.Packets/ClientPackets/Mates/NosCore.Packets.ClientPackets.Mates.PslPacket.cs) *InExchange | InGame*
- [ps_op](src/NosCore.Packets/ClientPackets/Mates/NosCore.Packets.ClientPackets.Mates.PsopPacket.cs) *InExchange | InGame*
- [suctl](src/NosCore.Packets/ClientPackets/Mates/NosCore.Packets.ClientPackets.Mates.SuCtlPacket.cs) *InExchange | InGame*
- [u_pet](src/NosCore.Packets/ClientPackets/Mates/NosCore.Packets.ClientPackets.Mates.UpetPacket.cs) *InExchange | InGame*
- [u_ps](src/NosCore.Packets/ClientPackets/Mates/NosCore.Packets.ClientPackets.Mates.UpsPacket.cs) *InExchange | InGame*

### Miniland
- [addobj](src/NosCore.Packets/ClientPackets/Miniland/NosCore.Packets.ClientPackets.Miniland.AddobjPacket.cs) *InExchange | InGame*
- [mg](src/NosCore.Packets/ClientPackets/Miniland/NosCore.Packets.ClientPackets.Miniland.MinigamePacket.cs) *InExchange | InGame*
- [mjoin](src/NosCore.Packets/ClientPackets/Miniland/NosCore.Packets.ClientPackets.Miniland.MJoinPacket.cs) *InExchange | InGame*
- [mledit](src/NosCore.Packets/ClientPackets/Miniland/NosCore.Packets.ClientPackets.Miniland.MLEditPacket.cs) *InExchange | InGame*
- [rmvobj](src/NosCore.Packets/ClientPackets/Miniland/NosCore.Packets.ClientPackets.Miniland.RmvobjPacket.cs) *InExchange | InGame*

### Movement
- [dir](src/NosCore.Packets/ClientPackets/Movement/NosCore.Packets.ClientPackets.Movement.ClientDirPacket.cs) *InExchange | InGame*
- [preq](src/NosCore.Packets/ClientPackets/Movement/NosCore.Packets.ClientPackets.Movement.PreqPacket.cs) *InExchange | InGame*
- [pulse](src/NosCore.Packets/ClientPackets/Movement/NosCore.Packets.ClientPackets.Movement.PulsePacket.cs) *InExchange | InGame*
- [rest](src/NosCore.Packets/ClientPackets/Movement/NosCore.Packets.ClientPackets.Movement.SitPacket.cs) *InExchange | InGame*
- [walk](src/NosCore.Packets/ClientPackets/Movement/NosCore.Packets.ClientPackets.Movement.WalkPacket.cs) *InExchange | InGame*

### Npcs
- [n_run](src/NosCore.Packets/ClientPackets/Npcs/NosCore.Packets.ClientPackets.Npcs.NrunPacket.cs) *InExchange | InGame*
- [npc_req](src/NosCore.Packets/ClientPackets/Npcs/NosCore.Packets.ClientPackets.Npcs.RequestNpcPacket.cs) *InExchange | InGame*

### Parcel
- [pcl](src/NosCore.Packets/ClientPackets/Parcel/NosCore.Packets.ClientPackets.Parcel.PclPacket.cs) *InExchange | InGame*
- [pst](src/NosCore.Packets/ClientPackets/Parcel/NosCore.Packets.ClientPackets.Parcel.PstClientPacket.cs) *InExchange | InGame*

### Player
- [rsfi](src/NosCore.Packets/ClientPackets/Player/NosCore.Packets.ClientPackets.Player.RsfiPacket.cs) *InExchange | InGame*
- [snap](src/NosCore.Packets/ClientPackets/Player/NosCore.Packets.ClientPackets.Player.SnapPacket.cs) *InExchange | InGame*
- [tit_eq](src/NosCore.Packets/ClientPackets/Player/NosCore.Packets.ClientPackets.Player.TitEqPacket.cs) *InExchange | InGame*
- [up_gr](src/NosCore.Packets/ClientPackets/Player/NosCore.Packets.ClientPackets.Player.UpgradePacket.cs) *InExchange | InGame*

### Quest
- [qt](src/NosCore.Packets/ClientPackets/Quest/NosCore.Packets.ClientPackets.Quest.QtPacket.cs) *InExchange | InGame*
- [script](src/NosCore.Packets/ClientPackets/Quest/NosCore.Packets.ClientPackets.Quest.ScriptClientPacket.cs) *InExchange | InGame*

### Quicklist
- [qset](src/NosCore.Packets/ClientPackets/Quicklist/NosCore.Packets.ClientPackets.Quicklist.QsetPacket.cs) *InExchange | InGame*

### Relations
- [bldel](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.BlDelPacket.cs) *InExchange | InGame*
- [blins](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.BlInsPacket.cs) *InExchange | InGame*
- [$bl](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.BlPacket.cs) *InExchange | InGame*
- [fdel](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.FdelPacket.cs) *InExchange | InGame*
- [fins](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.FinsPacket.cs) *InExchange | InGame*
- [$fl](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.FlPacket.cs) *InExchange | InGame*
- [reloadfinfo](src/NosCore.Packets/ClientPackets/Relations/NosCore.Packets.ClientPackets.Relations.ReloadFinfoPacket.cs) *InExchange | InGame*

### Shops
- [buy](src/NosCore.Packets/ClientPackets/Shops/NosCore.Packets.ClientPackets.Shops.BuyPacket.cs) *InExchange | InGame*
- [c_close](src/NosCore.Packets/ClientPackets/Shops/NosCore.Packets.ClientPackets.Shops.CClosePacket.cs) *OnCharacterScreen | InExchange | InGame*
- [m_shop](src/NosCore.Packets/ClientPackets/Shops/NosCore.Packets.ClientPackets.Shops.MShopPacket.cs) *InExchange | InGame*
- [sell_list](src/NosCore.Packets/ClientPackets/Shops/NosCore.Packets.ClientPackets.Shops.SellListPacket.cs) *InExchange | InGame*
- [sell](src/NosCore.Packets/ClientPackets/Shops/NosCore.Packets.ClientPackets.Shops.SellPacket.cs) *InExchange | InGame*
- [shopping](src/NosCore.Packets/ClientPackets/Shops/NosCore.Packets.ClientPackets.Shops.ShoppingPacket.cs) *InExchange | InGame*

### Specialists
- [sl](src/NosCore.Packets/ClientPackets/Specialists/NosCore.Packets.ClientPackets.Specialists.SpTransformPacket.cs) *InExchange | InGame*

### UI
- [guri](src/NosCore.Packets/ClientPackets/UI/NosCore.Packets.ClientPackets.UI.GuriPacket.cs) *InExchange | InGame*

### Warehouse
- [deposit](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.DepositPacket.cs) *InExchange | InGame*
- [f_deposit](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.FDepositPacket.cs) *InExchange | InGame*
- [f_repos](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.FReposPacket.cs) *InExchange | InGame*
- [f_stash_end](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.FStashEndPacket.cs) *OnCharacterScreen | InExchange | InGame*
- [f_withdraw](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.FWithdrawPacket.cs) *InExchange | InGame*
- [repos](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.ReposPacket.cs) *InExchange | InGame*
- [stash_end](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.StashEndPacket.cs) *OnCharacterScreen | InExchange | InGame*
- [withdraw](src/NosCore.Packets/ClientPackets/Warehouse/NosCore.Packets.ClientPackets.Warehouse.WithdrawPacket.cs) *InExchange | InGame*

## ServerPackets :

### Auction
- [rc_blist](src/NosCore.Packets/ServerPackets/Auction/NosCore.Packets.ServerPackets.Auction.RcbListPacket.cs) *InExchange | InGame*
- [rc_slist](src/NosCore.Packets/ServerPackets/Auction/NosCore.Packets.ServerPackets.Auction.RcsListPacket.cs) *InExchange | InGame*

### Bank
- [gb](src/NosCore.Packets/ServerPackets/Bank/NosCore.Packets.ServerPackets.Bank.GbPacket.cs) *InExchange | InGame*

### Battle
- [bf](src/NosCore.Packets/ServerPackets/Battle/NosCore.Packets.ServerPackets.Battle.BfPacket.cs) *InExchange | InGame*
- [cancel](src/NosCore.Packets/ServerPackets/Battle/NosCore.Packets.ServerPackets.Battle.CancelPacket.cs) *InExchange | InGame*
- [ct](src/NosCore.Packets/ServerPackets/Battle/NosCore.Packets.ServerPackets.Battle.CtPacket.cs) *InExchange | InGame*
- [ms_c](src/NosCore.Packets/ServerPackets/Battle/NosCore.Packets.ServerPackets.Battle.MscPacket.cs) *InExchange | InGame*
- [mslot](src/NosCore.Packets/ServerPackets/Battle/NosCore.Packets.ServerPackets.Battle.MslotPacket.cs) *InExchange | InGame*
- [su](src/NosCore.Packets/ServerPackets/Battle/NosCore.Packets.ServerPackets.Battle.SuPacket.cs) *InExchange | InGame*

### Bazaar
- [rc_buy](src/NosCore.Packets/ServerPackets/Bazaar/NosCore.Packets.ServerPackets.Bazaar.RCBuyPacket.cs) *InExchange | InGame*
- [rc_reg](src/NosCore.Packets/ServerPackets/Bazaar/NosCore.Packets.ServerPackets.Bazaar.RCRegPacket.cs) *InExchange | InGame*
- [rc_scalc](src/NosCore.Packets/ServerPackets/Bazaar/NosCore.Packets.ServerPackets.Bazaar.RCScalcPacket.cs) *InExchange | InGame*

### CharacterSelectionScreen
- [clist_end](src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/NosCore.Packets.ServerPackets.CharacterSelectionScreen.ClistEndPacket.cs) *OnCharacterScreen | InExchange | InGame*
- [clist](src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/NosCore.Packets.ServerPackets.CharacterSelectionScreen.ClistPacket.cs) *OnCharacterScreen*
- [clist_start](src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/NosCore.Packets.ServerPackets.CharacterSelectionScreen.ClistStartPacket.cs) *InExchange | InGame*
- [OK](src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/NosCore.Packets.ServerPackets.CharacterSelectionScreen.OkPacket.cs) *InExchange | InGame*
- [scene](src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/NosCore.Packets.ServerPackets.CharacterSelectionScreen.ScenePacket.cs) *InExchange | InGame*
- [success](src/NosCore.Packets/ServerPackets/CharacterSelectionScreen/NosCore.Packets.ServerPackets.CharacterSelectionScreen.SuccessPacket.cs) *InExchange | InGame*

### Chats
- [IconInfo](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.IconInfoPacket.cs) *InExchange | InGame*
- [sayi2](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.Sayi2Packet.cs) *InExchange | InGame*
- [sayi](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SayiPacket.cs) *InExchange | InGame*
- [sayitem](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SayItemPacket.cs) *InExchange | InGame*
- [sayitemt](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SayItemtPacket.cs) *InExchange | InGame*
- [say](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SayPacket.cs) *InExchange | InGame*
- [say_p](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SayPetPacket.cs) *InExchange | InGame*
- [sayt](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SaytPacket.cs) *InExchange | InGame*
- [spk](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.SpeakPacket.cs) *InExchange | InGame*
- [talk](src/NosCore.Packets/ServerPackets/Chats/NosCore.Packets.ServerPackets.Chats.TalkPacket.cs) *InExchange | InGame*

### Entities
- [char_sc](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.CharScPacket.cs) *InExchange | InGame*
- [drop](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.DropPacket.cs) *InExchange | InGame*
- [mv](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.MovePacket.cs) *InExchange | InGame*
- [out](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.OutPacket.cs) *InExchange | InGame*
- [req_info](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.ReqInfoPacket.cs) *InExchange | InGame*
- [rest](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.RestPacket.cs) *InExchange | InGame*
- [st](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.StPacket.cs) *InExchange | InGame*
- [tp](src/NosCore.Packets/ServerPackets/Entities/NosCore.Packets.ServerPackets.Entities.TpPacket.cs) *InExchange | InGame*

### Event
- [rbr](src/NosCore.Packets/ServerPackets/Event/NosCore.Packets.ServerPackets.Event.RbrPacket.cs) *InExchange | InGame*

### Exchanges
- [exc_close](src/NosCore.Packets/ServerPackets/Exchanges/NosCore.Packets.ServerPackets.Exchanges.ExcClosePacket.cs) *InExchange | InGame*
- [exc_list](src/NosCore.Packets/ServerPackets/Exchanges/NosCore.Packets.ServerPackets.Exchanges.ServerExcListPacket.cs) *InExchange | InGame*

### Families
- [ginfo](src/NosCore.Packets/ServerPackets/Families/NosCore.Packets.ServerPackets.Families.GInfoPacket.cs) *InExchange | InGame*

### Groups
- [pinit](src/NosCore.Packets/ServerPackets/Groups/NosCore.Packets.ServerPackets.Groups.PinitPacket.cs) *InExchange | InGame*
- [pinit_sub_packet](src/NosCore.Packets/ServerPackets/Groups/NosCore.Packets.ServerPackets.Groups.PinitSubPacket.cs) *InExchange | InGame*
- [pjoin](src/NosCore.Packets/ServerPackets/Groups/NosCore.Packets.ServerPackets.Groups.PjoinPacket.cs) *InExchange | InGame*

### Inventory
- [e_info](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.EInfoPacket.cs) *InExchange | InGame*
- [eq](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.EqPacket.cs) *InExchange | InGame*
- [equip](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.EquipPacket.cs) *InExchange | InGame*
- [exts](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.ExtsPacket.cs) *InExchange | InGame*
- [gold](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.GoldPacket.cs) *InExchange | InGame*
- [inv](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.InvPacket.cs) *InExchange | InGame*
- [ivn](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.IvnPacket.cs) *InExchange | InGame*
- [pairy](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.PairyPacket.cs) *InExchange | InGame*
- [get](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.ServerGetPacket.cs) *InExchange | InGame*
- [slinfo](src/NosCore.Packets/ServerPackets/Inventory/NosCore.Packets.ServerPackets.Inventory.SlInfoPacket.cs) *InExchange | InGame*

### Login
- [failc](src/NosCore.Packets/ServerPackets/Login/NosCore.Packets.ServerPackets.Login.FailcPacket.cs) *OnLoginScreen*
- [it](src/NosCore.Packets/ServerPackets/Login/NosCore.Packets.ServerPackets.Login.ItPacket.cs) *InExchange | InGame*
- [mz](src/NosCore.Packets/ServerPackets/Login/NosCore.Packets.ServerPackets.Login.MzPacket.cs) *InExchange | InGame*
- [NsTeST](src/NosCore.Packets/ServerPackets/Login/NosCore.Packets.ServerPackets.Login.NsTestPacket.cs) *OnLoginScreen*
- [NsTeST_sub_packet](src/NosCore.Packets/ServerPackets/Login/NosCore.Packets.ServerPackets.Login.NsTeStSubPacket.cs) *OnLoginScreen*

### Map
- [eff_g](src/NosCore.Packets/ServerPackets/Map/NosCore.Packets.ServerPackets.Map.GroundEffectPacket.cs) *InExchange | InGame*
- [mapout](src/NosCore.Packets/ServerPackets/Map/NosCore.Packets.ServerPackets.Map.MapOutPacket.cs) *InExchange | InGame*

### Mates
- [pski](src/NosCore.Packets/ServerPackets/Mates/NosCore.Packets.ServerPackets.Mates.PSkiPacket.cs) *InExchange | InGame*
- [say_p](src/NosCore.Packets/ServerPackets/Mates/NosCore.Packets.ServerPackets.Mates.SayPetPacket.cs) *InExchange | InGame*
- [sc_n](src/NosCore.Packets/ServerPackets/Mates/NosCore.Packets.ServerPackets.Mates.ScnPacket.cs) *InExchange | InGame*
- [sc_p](src/NosCore.Packets/ServerPackets/Mates/NosCore.Packets.ServerPackets.Mates.ScpPacket.cs) *InExchange | InGame*

### Miniland
- [mlpt](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MinilandPointPacket.cs) *InExchange | InGame*
- [mlinfobr](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MlInfoBrPacket.cs) *InExchange | InGame*
- [mlinfo](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MlinfoPacket.cs) *InExchange | InGame*
- [mlintro](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MlintroPacket.cs) *InExchange | InGame*
- [mlobjlst](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MlobjlstPacket.cs) *InExchange | InGame*
- [mlobj](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MlobjPacket.cs) *InExchange | InGame*
- [mlo_info](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MloInfoPacket.cs) *InExchange | InGame*
- [mlo_lv](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MloLvPacket.cs) *InExchange | InGame*
- [mlo_mg](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MloMgPacket.cs) *InExchange | InGame*
- [mlo_pmg](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MloPmgPacket.cs) *InExchange | InGame*
- [mlo_rw](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MloRwPacket.cs) *InExchange | InGame*
- [mlo_st](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.MloStPacket.cs) *InExchange | InGame*
- [useobj](src/NosCore.Packets/ServerPackets/Miniland/NosCore.Packets.ServerPackets.Miniland.UseObjPacket.cs) *InExchange | InGame*

### MiniMap
- [at](src/NosCore.Packets/ServerPackets/MiniMap/NosCore.Packets.ServerPackets.MiniMap.AtPacket.cs) *InExchange | InGame*
- [c_map](src/NosCore.Packets/ServerPackets/MiniMap/NosCore.Packets.ServerPackets.MiniMap.CMapPacket.cs) *InExchange | InGame*
- [rsfp](src/NosCore.Packets/ServerPackets/MiniMap/NosCore.Packets.ServerPackets.MiniMap.RsfpPacket.cs) *InExchange | InGame*

### Movement
- [dir](src/NosCore.Packets/ServerPackets/Movement/NosCore.Packets.ServerPackets.Movement.DirPacket.cs) *InExchange | InGame*

### Parcel
- [parcel](src/NosCore.Packets/ServerPackets/Parcel/NosCore.Packets.ServerPackets.Parcel.ParcelPacket.cs) *InExchange | InGame*
- [post](src/NosCore.Packets/ServerPackets/Parcel/NosCore.Packets.ServerPackets.Parcel.PostPacket.cs) *InExchange | InGame*
- [pst](src/NosCore.Packets/ServerPackets/Parcel/NosCore.Packets.ServerPackets.Parcel.PstPacket.cs) *InExchange | InGame*

### Player
- [bn](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.BnPacket.cs) *InExchange | InGame*
- [c_info](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.CInfoPacket.cs) *InExchange | InGame*
- [c_mode](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.CModePacket.cs) *InExchange | InGame*
- [cond](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.CondPacket.cs) *InExchange | InGame*
- [eff](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.EffectPacket.cs) *InExchange | InGame*
- [eqinfo](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.EquipmentInfoPacket.cs) *InExchange | InGame*
- [fd](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.FdPacket.cs) *InExchange | InGame*
- [fs](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.FsPacket.cs) *InExchange | InGame*
- [levelup](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.LevelUpPacket.cs) *InExchange | InGame*
- [lev](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.LevPacket.cs) *InExchange | InGame*
- [npinfo](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.NpInfoPacket.cs) *InExchange | InGame*
- [pflag](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.PFlagPacket.cs) *InExchange | InGame*
- [rage](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.RagePacket.cs) *InExchange | InGame*
- [sc](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.ScPacket.cs) *InExchange | InGame*
- [scr](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.ScrPacket.cs) *InExchange | InGame*
- [stat](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.StatPacket.cs) *InExchange | InGame*
- [tc_info](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.TcInfoPacket.cs) *InExchange | InGame*
- [titinfo](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.TitleInfoPacket.cs) *InExchange | InGame*
- [title](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.TitlePacket.cs) *InExchange | InGame*
- [tit](src/NosCore.Packets/ServerPackets/Player/NosCore.Packets.ServerPackets.Player.TitPacket.cs) *InExchange | InGame*

### Portals
- [gp](src/NosCore.Packets/ServerPackets/Portals/NosCore.Packets.ServerPackets.Portals.GpPacket.cs) *InExchange | InGame*

### Quest
- [qsti](src/NosCore.Packets/ServerPackets/Quest/NosCore.Packets.ServerPackets.Quest.QstiPacket.cs) *InExchange | InGame*
- [qstlist](src/NosCore.Packets/ServerPackets/Quest/NosCore.Packets.ServerPackets.Quest.QstlistPacket.cs) *InExchange | InGame*
- [script](src/NosCore.Packets/ServerPackets/Quest/NosCore.Packets.ServerPackets.Quest.ScriptPacket.cs) *InExchange | InGame*
- [targetoff](src/NosCore.Packets/ServerPackets/Quest/NosCore.Packets.ServerPackets.Quest.TargetOffPacket.cs) *InExchange | InGame*
- [target](src/NosCore.Packets/ServerPackets/Quest/NosCore.Packets.ServerPackets.Quest.TargetPacket.cs) *InExchange | InGame*

### Quicklist
- [qset](src/NosCore.Packets/ServerPackets/Quicklist/NosCore.Packets.ServerPackets.Quicklist.QsetClientPacket.cs) *InExchange | InGame*
- [qslot](src/NosCore.Packets/ServerPackets/Quicklist/NosCore.Packets.ServerPackets.Quicklist.QSlotPacket.cs) *InExchange | InGame*

### Relations
- [blinit](src/NosCore.Packets/ServerPackets/Relations/NosCore.Packets.ServerPackets.Relations.BlinitPacket.cs) *InExchange | InGame*
- [finfo](src/NosCore.Packets/ServerPackets/Relations/NosCore.Packets.ServerPackets.Relations.FinfoPacket.cs) *InExchange | InGame*
- [finfo_sub_packets](src/NosCore.Packets/ServerPackets/Relations/NosCore.Packets.ServerPackets.Relations.FinfoSubPackets.cs) *InExchange | InGame*
- [finit](src/NosCore.Packets/ServerPackets/Relations/NosCore.Packets.ServerPackets.Relations.FinitPacket.cs) *InExchange | InGame*

### Shop
- [ishop](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.IshopPacket.cs) *InExchange | InGame*
- [n_inv_skills](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.NInvFamilySkillSubPacket.cs) *InExchange | InGame*
- [n_inv_item](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.NInvItemSubPacket.cs) *InExchange | InGame*
- [n_inv](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.NInvPacket.cs) *InExchange | InGame*
- [pflag](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.PflagPacket.cs) *InExchange | InGame*
- [pidx](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.PidxPacket.cs) *InExchange | InGame*
- [pidx_sub_packet](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.PidxSubPacket.cs) *InExchange | InGame*
- [shop_end](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.ShopEndPacket.cs) *InExchange | InGame*
- [shop](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.ShopPacket.cs) *InExchange | InGame*
- [s_memoi2](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.SMemoi2Packet.cs) *InExchange | InGame*
- [s_memo](src/NosCore.Packets/ServerPackets/Shop/NosCore.Packets.ServerPackets.Shop.SMemoPacket.cs) *InExchange | InGame*

### Specialists
- [sd](src/NosCore.Packets/ServerPackets/Specialists/NosCore.Packets.ServerPackets.Specialists.SdPacket.cs) *InExchange | InGame*
- [slinfo](src/NosCore.Packets/ServerPackets/Specialists/NosCore.Packets.ServerPackets.Specialists.SlInfoPacket.cs) *InExchange | InGame*
- [sp](src/NosCore.Packets/ServerPackets/Specialists/NosCore.Packets.ServerPackets.Specialists.SpPacket.cs) *InExchange | InGame*

### UI
- [act6](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.Act6Packet.cs) *InExchange | InGame*
- [bsinfo](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.BSInfoPacket.cs) *InExchange | InGame*
- [ch_dm](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.ChDMPacket.cs) *InExchange | InGame*
- [delay](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.DelayPacket.cs) *InExchange | InGame*
- [dlg](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.DlgPacket.cs) *InExchange | InGame*
- [guri](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.GuriPacket.cs) *InExchange | InGame*
- [icon](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.IconPacket.cs) *InExchange | InGame*
- [infoi](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.InfoiPacket.cs) *InExchange | InGame*
- [info](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.InfoPacket.cs) *InExchange | InGame*
- [modal](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.ModalPacket.cs) *InExchange | InGame*
- [msgi](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.MsgiPacket.cs) *InExchange | InGame*
- [msg](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.MsgPacket.cs) *InExchange | InGame*
- [p_clear](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.PclearPacket.cs) *InExchange | InGame*
- [qnai2](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.Qnai2Packet.cs) *InExchange | InGame*
- [qna](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.QnaPacket.cs) *InExchange | InGame*
- [ta_rank](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.TARankPacket.cs) *InExchange | InGame*
- [wopen](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.WopenPacket.cs) *InExchange | InGame*
- [zzim](src/NosCore.Packets/ServerPackets/UI/NosCore.Packets.ServerPackets.UI.ZzimPacket.cs) *InExchange | InGame*

### Visibility
- [cl](src/NosCore.Packets/ServerPackets/Visibility/NosCore.Packets.ServerPackets.Visibility.ClPacket.cs) *InExchange | InGame*
- [in](src/NosCore.Packets/ServerPackets/Visibility/NosCore.Packets.ServerPackets.Visibility.InPacket.cs) *InExchange | InGame*

### Warehouse
- [f_stash_all](src/NosCore.Packets/ServerPackets/Warehouse/NosCore.Packets.ServerPackets.Warehouse.FStashAllPacket.cs) *InExchange | InGame*
- [f_stash](src/NosCore.Packets/ServerPackets/Warehouse/NosCore.Packets.ServerPackets.Warehouse.FStashClientPacket.cs) *InExchange | InGame*
- [p_stash_all](src/NosCore.Packets/ServerPackets/Warehouse/NosCore.Packets.ServerPackets.Warehouse.PStashAllPacket.cs) *InExchange | InGame*
- [p_stash](src/NosCore.Packets/ServerPackets/Warehouse/NosCore.Packets.ServerPackets.Warehouse.PStashClientPacket.cs) *InExchange | InGame*
- [stash_all](src/NosCore.Packets/ServerPackets/Warehouse/NosCore.Packets.ServerPackets.Warehouse.StashAllPacket.cs) *InExchange | InGame*
- [stash](src/NosCore.Packets/ServerPackets/Warehouse/NosCore.Packets.ServerPackets.Warehouse.StashClientPacket.cs) *InExchange | InGame*
