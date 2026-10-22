namespace QuestLab.DraftWar;

[StorageObject("ShopProfileData", False, False)]
public class ShopProfileData
{
	[JsonProperty("shaw")]
	public StringIntDictionary ShopItemAdsWatchedToday; //Field offset: 0x28
	[JsonProperty("shawt")]
	public StringLongDictionary LastShopItemAdsWatchedTime; //Field offset: 0x2C
	[JsonProperty("shdu")]
	public StringLongDictionary ShopItemDailyUnlockTime; //Field offset: 0x30
	[JsonProperty("shslc")]
	public StringLongDictionary ShopItemSubscriptionLastClaim; //Field offset: 0x34
	[JsonProperty("shsx")]
	public StringLongDictionary SubscriptionExpirationDatesUTC; //Field offset: 0x38
	[JsonProperty("shao")]
	public StringLongDictionary ActiveOffers; //Field offset: 0x3C
	[JsonProperty("shopending")]
	public StringIntDictionary PendingOfferFirstDisplays; //Field offset: 0x40
	[JsonProperty("shbpshown")]
	public bool BattlePassPopupShown; //Field offset: 0x44
	[JsonProperty("shnt")]
	public long LastNotificationResetTime; //Field offset: 0x48
	[JsonProperty("shno")]
	public bool OffersNotificationSeenToday; //Field offset: 0x50
	[JsonProperty("shnd")]
	public bool DailyDealsNotificationSeenToday; //Field offset: 0x51
	[JsonProperty("shnb")]
	public bool BitPacksNotificationSeenToday; //Field offset: 0x52
	[JsonProperty("shnr")]
	public bool ResourcesNotificationSeenToday; //Field offset: 0x53
	[JsonProperty("shdt")]
	public long LastDailyDealResetTime; //Field offset: 0x58
	[JsonProperty("shdc")]
	public int DailyDealResetCount; //Field offset: 0x60
	[JsonProperty("shdr")]
	public UnitType[] DailyDealUnitRewards; //Field offset: 0x64
	[JsonProperty("shdm")]
	public bool[] IsDailyDealMarkedGranted; //Field offset: 0x68
	[JsonProperty("shda")]
	public int DailyDealArenaIndex; //Field offset: 0x6C
	[JsonProperty("shrs")]
	public int DailyDealRandomSeed; //Field offset: 0x70
	[JsonProperty("shgit")]
	public StringLongDictionary GrantedIapTransactions; //Field offset: 0x74
	[JsonProperty("shiusd")]
	public int IapCumulativeUsd; //Field offset: 0x78

	public ShopProfileData() { }

	public override int GetCurrentVersion() { }

	public override void HandleVersionIncrease() { }

	public override void InitFromDefaults() { }

	public override void MigrateLegacyProfile(ref DraftWarPlayerProfileDataLegacy legacyData) { }

}

