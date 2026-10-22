namespace QuestLab.DraftWar;

public sealed class MatchSession
{
	[CompilerGenerated]
	private struct <AbandonTicket>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string ticket; //Field offset: 0xC
		public MatchSession <>4__this; //Field offset: 0x10
		public string reason; //Field offset: 0x14
		public int segment; //Field offset: 0x18
		private Awaiter<SubmitResultResp> <>u__1; //Field offset: 0x1C

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DumpDebugAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		private string <containerId>5__2; //Field offset: 0xC
		private int <segment>5__3; //Field offset: 0x10
		private string <userId>5__4; //Field offset: 0x14
		private string <source>5__5; //Field offset: 0x18
		private GetCandidateDebugResp <self>5__6; //Field offset: 0x1C
		private bool <hasRatedOpponent>5__7; //Field offset: 0x20
		private Awaiter<string> <>u__1; //Field offset: 0x24
		private Awaiter<GetCandidateDebugResp> <>u__2; //Field offset: 0x30

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureOwnSnapshotPublished>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int trophies; //Field offset: 0xC
		private Awaiter<bool> <>u__1; //Field offset: 0x10

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FightGhostDebugAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public string opponentId; //Field offset: 0xC
		private int <trophies>5__2; //Field offset: 0x10
		private Awaiter<OpponentData> <>u__1; //Field offset: 0x14

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FindMatchDebugAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool rememberFind; //Field offset: 0xC
		public double strength; //Field offset: 0x10
		private DebugContext <ctx>5__2; //Field offset: 0x18
		private Nullable<double> <overrideStrength>5__3; //Field offset: 0x28
		private FindMatchDebugResp <find>5__4; //Field offset: 0x38
		private Awaiter<DebugContext> <>u__1; //Field offset: 0x3C
		private Awaiter<FindMatchDebugResp> <>u__2; //Field offset: 0x54
		private double <botMu>5__5; //Field offset: 0x60
		private double <botRd>5__6; //Field offset: 0x68
		private Awaiter<GetCandidateDebugResp> <>u__3; //Field offset: 0x70

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FindOpponents>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder<OpponentData[]> <>t__builder; //Field offset: 0x4
		public MatchSession <>4__this; //Field offset: 0x10
		public GameMode gameMode; //Field offset: 0x14
		public int trophies; //Field offset: 0x18
		public int elo; //Field offset: 0x1C
		public int opponentCount; //Field offset: 0x20
		private double <seedPower>5__2; //Field offset: 0x28
		private FindMatchResp <find>5__3; //Field offset: 0x30
		private Awaiter<string> <>u__1; //Field offset: 0x34
		private Awaiter <>u__2; //Field offset: 0x40
		private Awaiter<FindMatchResp> <>u__3; //Field offset: 0x48
		private Awaiter<OpponentData> <>u__4; //Field offset: 0x54

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PublishSnapshotDebugAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		private Awaiter<bool> <>u__1; //Field offset: 0xC

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshHudAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool forceReconnect; //Field offset: 0xC
		private int <arenaDisplay>5__2; //Field offset: 0x10
		private double <seedPower>5__3; //Field offset: 0x18
		private bool <hasCard>5__4; //Field offset: 0x20
		private int <tropChip>5__5; //Field offset: 0x24
		private DebugContext <ctx>5__6; //Field offset: 0x28
		private Awaiter<DebugContext> <>u__1; //Field offset: 0x38
		private Awaiter<GetCandidateDebugResp> <>u__2; //Field offset: 0x50

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCandidateDebugAsync>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public int segment; //Field offset: 0xC
		public double strength; //Field offset: 0x10
		private DebugContext <ctx>5__2; //Field offset: 0x18
		private double <resolvedStrength>5__3; //Field offset: 0x28
		private Awaiter<DebugContext> <>u__1; //Field offset: 0x30
		private Awaiter<SetCandidateDebugResp> <>u__2; //Field offset: 0x48
		private Awaiter<GetCandidateDebugResp> <>u__3; //Field offset: 0x54

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SubmitResult>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder<RatedMatchFinishContext> <>t__builder; //Field offset: 0x4
		public MatchResult result; //Field offset: 0x10
		public MatchSession <>4__this; //Field offset: 0x14
		public int segment; //Field offset: 0x18
		private RatedMatchOutcome <outcome>5__2; //Field offset: 0x1C
		private double <seedPower>5__3; //Field offset: 0x20
		private SubmitResultResp <response>5__4; //Field offset: 0x28
		private Awaiter<bool> <>u__1; //Field offset: 0x2C
		private Awaiter<SubmitResultResp> <>u__2; //Field offset: 0x34
		private Awaiter <>u__3; //Field offset: 0x40

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SubmitTicket>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder<SubmitResultResp> <>t__builder; //Field offset: 0x4
		public MatchSession <>4__this; //Field offset: 0x10
		public string ticket; //Field offset: 0x14
		public RatedMatchOutcome outcome; //Field offset: 0x18
		public int segment; //Field offset: 0x1C
		public double seedPower; //Field offset: 0x20
		public bool consumeLocally; //Field offset: 0x28
		private Awaiter<SubmitResultResp> <>u__1; //Field offset: 0x2C

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryBuildGhost>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder<OpponentData> <>t__builder; //Field offset: 0x4
		public string opponentId; //Field offset: 0x10
		public int seekerTrophies; //Field offset: 0x14
		private TaskAwaiter<Dictionary<string, List<IStorageObject>>> <>u__1; //Field offset: 0x18

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryResolveDebugContext>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder<DebugContext> <>t__builder; //Field offset: 0x4
		public bool forceContainer; //Field offset: 0x1C
		public int segmentOverride; //Field offset: 0x20
		public bool log; //Field offset: 0x24
		private Awaiter<string> <>u__1; //Field offset: 0x28

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct DebugContext
	{
		public bool Ok; //Field offset: 0x0
		public string ContainerId; //Field offset: 0x4
		public int Segment; //Field offset: 0x8
		public string UserId; //Field offset: 0xC

	}

	private static readonly List<Type> GhostStorageTypes; //Field offset: 0x0
	private static string _debugSource; //Field offset: 0x4
	private static string _debugContainerId; //Field offset: 0x8
	private static string _debugUserId; //Field offset: 0xC
	private static string _debugOpponentId; //Field offset: 0x10
	private static string _debugOpponentName; //Field offset: 0x14
	private static int _debugSegment; //Field offset: 0x18
	private static int _lastGoodSegment; //Field offset: 0x1C
	private readonly IOpponentSource _source; //Field offset: 0x8
	private readonly OpponentData _forcedPick; //Field offset: 0xC
	private string _containerId; //Field offset: 0x10
	private string _ticket; //Field offset: 0x14
	private RatedMatchStartContext _startAnalytics; //Field offset: 0x18
	[CompilerGenerated]
	private OpponentData <Opponent>k__BackingField; //Field offset: 0x1C

	public OpponentData Opponent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public RatedMatchStartContext StartAnalytics
	{
		 get { } //Length: 8
	}

	private static MatchSession() { }

	public MatchSession(IOpponentSource source, OpponentData forcedPick = null) { }

	private MatchSession(OpponentData opponent) { }

	[AsyncStateMachine(typeof(<AbandonTicket>d__24))]
	private UniTask AbandonTicket(string ticket, int segment, string reason, string opponentId) { }

	private static void AppendCandidate(StringBuilder sb, string title, string userId, string name, GetCandidateDebugResp candidate) { }

	[AsyncStateMachine(typeof(<DumpDebugAsync>d__39))]
	public static UniTask DumpDebugAsync() { }

	[AsyncStateMachine(typeof(<EnsureOwnSnapshotPublished>d__18))]
	private static UniTask EnsureOwnSnapshotPublished(int trophies) { }

	private OpponentData[] FallbackCsv(int trophies, int opponentCount, string reason, FindMatchResp find = null) { }

	[AsyncStateMachine(typeof(<FightGhostDebugAsync>d__36))]
	public static UniTask FightGhostDebugAsync(string opponentId) { }

	[AsyncStateMachine(typeof(<FindMatchDebugAsync>d__40))]
	public static UniTask FindMatchDebugAsync(double strength, bool rememberFind = true) { }

	private static T FindObject(List<IStorageObject> objects) { }

	[AsyncStateMachine(typeof(<FindOpponents>d__15))]
	public UniTask<OpponentData[]> FindOpponents(GameMode gameMode, int trophies, int elo, int opponentCount) { }

	private static string FormatDump(string source, string containerId, int segment, string selfId, GetCandidateDebugResp self, bool hasRatedOpponent, string opponentId, string opponentName, GetCandidateDebugResp opponent) { }

	private static string FormatFindDebug(string containerId, int segment, Nullable<double> strength, FindMatchDebugResp find) { }

	private static string FormatFindTelemetry(FindMatchResp find) { }

	private static string FormatRating(double mu, double rd, double sigma) { }

	private static string FormatSetCandidate(string containerId, string userId, int segment, double strength, SetCandidateDebugResp set) { }

	private static string FormatTier(int tier, int relaxations = 0) { }

	private static string FormatUnix(long unix) { }

	public static MatchSession ForOpponent(OpponentData opponent) { }

	[CompilerGenerated]
	public OpponentData get_Opponent() { }

	public RatedMatchStartContext get_StartAnalytics() { }

	public static void InvalidateHudContext() { }

	private static void LogDump(string text) { }

	private static void LogDumpLine(string line) { }

	private static RatedMatchOutcome MapOutcome(MatchResult result) { }

	private static string N(double value) { }

	[AsyncStateMachine(typeof(<PublishSnapshotDebugAsync>d__37))]
	public static UniTask PublishSnapshotDebugAsync() { }

	[AsyncStateMachine(typeof(<RefreshHudAsync>d__38))]
	public static UniTask RefreshHudAsync(bool forceReconnect = false) { }

	private static UniTask RefreshHudIfVisibleAsync() { }

	private static void RememberFind(string source, int segment, string containerId, string opponentId, string opponentName, FindMatchResp find = null) { }

	private static int ResolveHudSegment() { }

	private OpponentData[] RollCsv(GameMode gameMode, int trophies, int elo, int opponentCount) { }

	[CompilerGenerated]
	private void set_Opponent(OpponentData value) { }

	[AsyncStateMachine(typeof(<SetCandidateDebugAsync>d__41))]
	public static UniTask SetCandidateDebugAsync(double strength, int segment) { }

	[AsyncStateMachine(typeof(<SubmitResult>d__16))]
	public UniTask<RatedMatchFinishContext> SubmitResult(MatchResult result, int segment) { }

	[AsyncStateMachine(typeof(<SubmitTicket>d__25))]
	private UniTask<SubmitResultResp> SubmitTicket(string ticket, RatedMatchOutcome outcome, int segment, double seedPower, bool consumeLocally) { }

	[AsyncStateMachine(typeof(<TryBuildGhost>d__21))]
	private static UniTask<OpponentData> TryBuildGhost(string opponentId, int seekerTrophies) { }

	[AsyncStateMachine(typeof(<TryResolveDebugContext>d__43))]
	private static UniTask<DebugContext> TryResolveDebugContext(int segmentOverride = 0, bool log = true, bool forceContainer = false) { }

	private string UnratedReason(GameMode gameMode, int arenaIndex) { }

}

