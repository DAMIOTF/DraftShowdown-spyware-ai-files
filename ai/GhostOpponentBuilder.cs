namespace QuestLab.DraftWar;

public static class GhostOpponentBuilder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<string, string> <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <TryCreate>b__0_0(string key) { }

	}


	private static List<Spell> BuildDeckSpells(List<SpellEntry> entries, GameCatalog catalog) { }

	private static List<Unit> BuildDeckUnits(List<UnitEntry> entries, GameCatalog catalog, ScriptableObjectProvider sop, out string failReason) { }

	private static Spell FindSpell(GameCatalog catalog, string spellId) { }

	private static float RollAiSmartness(int seekerTrophies, GameConfigManager gameConfig) { }

	public static bool TryCreate(PlayerPublicProfileData publicProfile, int seekerTrophies, out OpponentData opponent) { }

}

