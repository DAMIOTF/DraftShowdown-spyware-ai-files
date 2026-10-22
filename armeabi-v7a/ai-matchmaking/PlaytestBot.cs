namespace QuestLab.DraftWar;

public static class PlaytestBot
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UnitDeckEntry, int> <>9__2_1; //Field offset: 0x4
		public static Func<UnitDeckEntry, int> <>9__2_2; //Field offset: 0x8
		public static Func<SpellDeckEntry, int> <>9__2_3; //Field offset: 0xC
		public static Func<UnitType, float> <>9__3_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Build>b__2_1(UnitDeckEntry e) { }

		internal int <Build>b__2_2(UnitDeckEntry e) { }

		internal int <Build>b__2_3(SpellDeckEntry s) { }

		internal float <PickUnits>b__3_0(UnitType _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public UnitDisplayInfo displayInfo; //Field offset: 0x8

		public <>c__DisplayClass2_0() { }

		internal bool <Build>b__0(UnitType unitType) { }

	}

	public const int UnitCount = 4; //Field offset: 0x0
	public const float Smartness = 50; //Field offset: 0x0

	public static OpponentData Build(PlaytestMatchSettings settings) { }

	public static int CardLevel(int playerBestLevel, int startingLevel) { }

	public static int CommanderLevel(int playerLevel, int maxLevel) { }

	public static int Mastery(int playerBestMastery, int maxMastery) { }

	public static List<UnitType> PickUnits(IEnumerable<UnitType> metaUnits, Func<UnitType, bool> isReleased) { }

}

