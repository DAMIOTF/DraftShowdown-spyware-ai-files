namespace Voodoo.Sauce.Internal.Analytics;

public static class AdjustWrapper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__30_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <LoadCacheUserId>b__30_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Stopwatch stopwatch; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal void <PullAdid>b__0(string adid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public AdjustAttribution adjustAttribution; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal void <OnAttributionChange>b__0(string adid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public string adid; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal void <SaveUserId>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Action<string> callback; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal void <RefreshAdjustIdAsync>b__0(string adId) { }

	}

	[CompilerGenerated]
	private sealed class <PullAdidAfterStartupDelay>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			 get { } //Length: 8
		}

		private object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			 get { } //Length: 8
		}

		[DebuggerHidden]
		public <PullAdidAfterStartupDelay>d__23(int <>1__state) { }

		private bool MoveNext() { }

		[DebuggerHidden]
		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private void System.IDisposable.Dispose() { }

	}

	private const string TAG = "AdjustWrapper"; //Field offset: 0x0
	private const string ADJUST_USER_ID_KEY = "vs_adjust_user_id"; //Field offset: 0x0
	private const float ADID_PULL_DELAY_SECONDS = 10; //Field offset: 0x0
	private const int ADID_FETCH_TIMEOUT_MILLISECONDS = 120000; //Field offset: 0x0
	private static readonly AttributionData AttributionData; //Field offset: 0x0
	private static bool _isInitialized; //Field offset: 0x8
	private static readonly Queue<AdjustAnalyticsEvent> EventsQueue; //Field offset: 0x10
	private static AdjustConfig _adjustConfig; //Field offset: 0x18
	internal static Action<Action<string>> AdidFetcher; //Field offset: 0x20

	private static AdjustWrapper() { }

	private static void AddAdjustSessionCallbackParameters() { }

	private static void AddAdjustSessionCallbackParameters(Dictionary<string, string> parameters) { }

	private static void ApplyUrlStrategy(AdjustConfig adjustConfig, bool isChinaBuild) { }

	internal static AdjustConfig BuildAdjustConfig(string adjustAppToken, AnalyticsProviderInfo info) { }

	private static void FetchAdid(Action<string> callback) { }

	private static void FetchAdidFromAdjust(Action<string> callback) { }

	private static AdjustLogLevel GetAdjustLogLevel() { }

	internal static AttributionData GetAttributionData() { }

	internal static AdjustConfig GetConfig() { }

	internal static void Initialize(string token, AnalyticsProviderInfo info) { }

	private static void InitializeAdjust(string adjustAppToken, AnalyticsProviderInfo info) { }

	internal static void Instantiate() { }

	private static void LoadCacheUserId() { }

	internal static void OnAttributionChange(AdjustAttribution adjustAttribution) { }

	internal static void PullAdid() { }

	[IteratorStateMachine(typeof(<PullAdidAfterStartupDelay>d__23))]
	private static IEnumerator PullAdidAfterStartupDelay() { }

	public static void RefreshAdjustIdAsync(bool isConsentGiven, bool isAdsEnforcementEnabled, Action<string> callback = null) { }

	private static void SaveUserId(string adid) { }

	private static void SchedulePullAdid() { }

	private static void SetAdjustThirdPartySharing(AnalyticsProviderInfo info) { }

	public static void TrackAdRevenue(AdjustAdRevenue adRevenue) { }

	private static void TrackAttributionEvent(AdjustAttribution adjustAttribution, string adId) { }

	public static void TrackEvent(string eventName, Dictionary<string, object> customVariables = null) { }

	private static bool TryPrepareAdjustGameObjectForManualInit() { }

}

