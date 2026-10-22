namespace DraftShowdown;

public static class GameConfig
{
	[CompilerGenerated]
	private sealed class <Describe>d__21 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private KeyValuePair<string, string> <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x14
		private FieldInfo[] <>7__wrap1; //Field offset: 0x18
		private int <>7__wrap2; //Field offset: 0x1C
		private FieldInfo <configField>5__4; //Field offset: 0x20
		private object <config>5__5; //Field offset: 0x24
		private FieldInfo[] <>7__wrap5; //Field offset: 0x28
		private int <>7__wrap6; //Field offset: 0x2C

		private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
		{
			[DebuggerHidden]
			 get { } //Length: 12
		}

		private object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			 get { } //Length: 100
		}

		[DebuggerHidden]
		public <Describe>d__21(int <>1__state) { }

		private bool MoveNext() { }

		[DebuggerHidden]
		private IEnumerator<KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		[DebuggerHidden]
		private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private void System.IDisposable.Dispose() { }

	}

	public static ApplicationManagerConfig ApplicationManagerConfig; //Field offset: 0x0
	public static DraftAiConfig DraftAiConfig; //Field offset: 0x4
	public static DeterminismConfig DeterminismConfig; //Field offset: 0x8
	public static IapChangesConfig IapChangesConfig; //Field offset: 0xC
	public static PopupPriorityConfig PopupPriorityConfig; //Field offset: 0x10
	public static RvCapsConfig RvCapsConfig; //Field offset: 0x14
	public static ShowdownConfig ShowdownConfig; //Field offset: 0x18
	public static UnitsConfig UnitsConfig; //Field offset: 0x1C
	[CompilerGenerated]
	private static bool <IsLoaded>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static bool <IsIapChangesAssignmentResolved>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private static bool <IsShowdownAssignmentResolved>k__BackingField; //Field offset: 0x22

	public static bool IsIapChangesAssignmentResolved
	{
		[CompilerGenerated]
		 get { } //Length: 100
		[CompilerGenerated]
		private set { } //Length: 104
	}

	public static bool IsLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 100
		[CompilerGenerated]
		private set { } //Length: 104
	}

	public static bool IsShowdownAssignmentResolved
	{
		[CompilerGenerated]
		 get { } //Length: 100
		[CompilerGenerated]
		private set { } //Length: 104
	}

	private static GameConfig() { }

	public static void CreateGameConfig() { }

	[IteratorStateMachine(typeof(<Describe>d__21))]
	public static IEnumerable<KeyValuePair<string, string>> Describe() { }

	[CompilerGenerated]
	public static bool get_IsIapChangesAssignmentResolved() { }

	[CompilerGenerated]
	public static bool get_IsLoaded() { }

	[CompilerGenerated]
	public static bool get_IsShowdownAssignmentResolved() { }

	private static KeyValuePair<string, string> Row(string key, object value) { }

	[CompilerGenerated]
	private static void set_IsIapChangesAssignmentResolved(bool value) { }

	[CompilerGenerated]
	private static void set_IsLoaded(bool value) { }

	[CompilerGenerated]
	private static void set_IsShowdownAssignmentResolved(bool value) { }

}

