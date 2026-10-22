namespace QuestLab.DraftWar;

[StorageObject("DailyBitpackProfileData", False, False)]
public class DailyBitpackProfileData
{
	[JsonProperty("dbpo")]
	public int DailyBitPacksOpened; //Field offset: 0x28
	[JsonProperty("dbpu")]
	public int DailyBitPacksUnlocked; //Field offset: 0x2C
	[JsonProperty("dbrt")]
	public long DailyBitPacksResetTime; //Field offset: 0x30
	[JsonProperty("dblct")]
	public long LastDailyBitPackClaimTime; //Field offset: 0x38
	[JsonProperty("dbct")]
	public int DailyBitPackClaimedToday; //Field offset: 0x40

	public bool CanClaimAd
	{
		 get { } //Length: 152
	}

	public bool CanClaimSlot
	{
		 get { } //Length: 36
	}

	[JsonIgnore]
	public int DailyBitPackAdsClaimed
	{
		 get { } //Length: 316
	}

	public DailyBitpackProfileData() { }

	public bool get_CanClaimAd() { }

	public bool get_CanClaimSlot() { }

	public int get_DailyBitPackAdsClaimed() { }

	public override void MigrateLegacyProfile(ref DraftWarPlayerProfileDataLegacy legacyData) { }

}

