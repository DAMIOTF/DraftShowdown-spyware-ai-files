namespace QuestLab.DraftWar;

[CreateAssetMenu(fileName = "AnalyticsConfig", menuName = "ScriptableObjects/AnalyticsConfig", order = 1)]
public sealed class AnalyticsConfig : ScriptableObject
{
	[SerializeField]
	private AdjustPlatformEvent m_PurchaseConsumableEvent; //Field offset: 0xC
	[SerializeField]
	private AdjustPlatformEvent m_PurchaseNonConsumableEvent; //Field offset: 0x10
	[SerializeField]
	private AdjustMilestoneEvent[] m_ArenaUnlockedMilestones; //Field offset: 0x14
	[SerializeField]
	private AdjustMilestoneEvent[] m_BattleWinMilestones; //Field offset: 0x18
	[SerializeField]
	private AdjustMilestoneEvent[] m_PurchaseCountMilestones; //Field offset: 0x1C
	[SerializeField]
	private AdjustMilestoneEvent[] m_CommanderLevelMilestones; //Field offset: 0x20
	[SerializeField]
	private AdjustMilestoneEvent[] m_RankedMatchMilestones; //Field offset: 0x24
	[SerializeField]
	private AdjustMilestoneEvent[] m_RankedLeagueMilestones; //Field offset: 0x28
	[SerializeField]
	private AdjustMilestoneEvent[] m_IapCumulativeUsdMilestones; //Field offset: 0x2C

	public IReadOnlyList<AdjustMilestoneEvent> ArenaUnlockedMilestones
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<AdjustMilestoneEvent> BattleWinMilestones
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<AdjustMilestoneEvent> CommanderLevelMilestones
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<AdjustMilestoneEvent> IapCumulativeUsdMilestones
	{
		 get { } //Length: 8
	}

	public AdjustPlatformEvent PurchaseConsumableEvent
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<AdjustMilestoneEvent> PurchaseCountMilestones
	{
		 get { } //Length: 8
	}

	public AdjustPlatformEvent PurchaseNonConsumableEvent
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<AdjustMilestoneEvent> RankedLeagueMilestones
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<AdjustMilestoneEvent> RankedMatchMilestones
	{
		 get { } //Length: 8
	}

	public AnalyticsConfig() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_ArenaUnlockedMilestones() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_BattleWinMilestones() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_CommanderLevelMilestones() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_IapCumulativeUsdMilestones() { }

	public AdjustPlatformEvent get_PurchaseConsumableEvent() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_PurchaseCountMilestones() { }

	public AdjustPlatformEvent get_PurchaseNonConsumableEvent() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_RankedLeagueMilestones() { }

	public IReadOnlyList<AdjustMilestoneEvent> get_RankedMatchMilestones() { }

}

