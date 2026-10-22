namespace QuestLab.DraftWar;

public sealed class AiOpponentPlayer : IBattlePlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SpellDeckEntry, Spell> <>9__19_0; //Field offset: 0x8
		public static Func<Spell, Spell> <>9__19_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Spell <PickCard>b__19_0(SpellDeckEntry e) { }

		internal Spell <PickCard>b__19_3(Spell s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public AiOpponentPlayer <>4__this; //Field offset: 0x10
		public int matchRound; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal bool <PickCard>b__1(Spell s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public SpellDeckEntry e; //Field offset: 0x10

		public <>c__DisplayClass19_1() { }

		internal bool <PickCard>b__2(Spell s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_2
	{
		public IReadOnlyList<UnitComponent> playerUnits; //Field offset: 0x10
		public IReadOnlyList<UnitComponent> opponentUnits; //Field offset: 0x18
		public Func<UnitType, UnitDisplayInfoData> getUnitInfo; //Field offset: 0x20
		public Dictionary<Spell, float> weighted; //Field offset: 0x28
		public float maxWeight; //Field offset: 0x30
		public <>c__DisplayClass19_0 CS$<>8__locals1; //Field offset: 0x38

		public <>c__DisplayClass19_2() { }

		internal float <PickCard>b__4(Spell s) { }

		internal bool <PickCard>b__5(Spell s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Spell spell; //Field offset: 0x10
		public int matchRound; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal bool <CanPlay>b__0(CardEffect c) { }

		internal bool <CanPlay>b__1(CardEffect c) { }

	}

	private readonly float _aiSmartness; //Field offset: 0x10
	private readonly List<CardEffect> _selectedCards; //Field offset: 0x18
	private readonly List<CardEffect> _roundSelectedCards; //Field offset: 0x20
	[CompilerGenerated]
	private readonly UnitDeck <Deck>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly PlayerDisplayData <DisplayData>k__BackingField; //Field offset: 0x30

	public UnitDeck Deck
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public PlayerDisplayData DisplayData
	{
		[CompilerGenerated]
		 get { } //Length: 28
	}

	public UnitTeam FieldPosition
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<CardEffect> RoundSelectedCards
	{
		 get { } //Length: 8
	}

	public IReadOnlyList<CardEffect> SelectedCards
	{
		 get { } //Length: 8
	}

	public AiOpponentPlayer(OpponentData opponentData, UnitDeck opponentDeck) { }

	public void BeginRound() { }

	private bool CanPlay(Spell spell, int matchRound) { }

	[CompilerGenerated]
	public UnitDeck get_Deck() { }

	[CompilerGenerated]
	public PlayerDisplayData get_DisplayData() { }

	public UnitTeam get_FieldPosition() { }

	public IReadOnlyList<CardEffect> get_RoundSelectedCards() { }

	public IReadOnlyList<CardEffect> get_SelectedCards() { }

	public UniTask InitializeDeckAsync(UnitDeck localPlayerDeck, CancellationToken ct) { }

	private CardEffect PickCard(int draftRound, int matchRound) { }

	public UniTask<CardEffect> PickDraftCardAsync(CardEffect localPlayerPick, int draftRound, int matchRound, CancellationToken ct) { }

}

