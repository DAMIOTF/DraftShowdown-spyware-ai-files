namespace QuestLab.DraftWar;

public class MatchMakingState : GameState
{
	[CompilerGenerated]
	private struct <OnPush>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public MatchMakingState <>4__this; //Field offset: 0x14
		private GameflowManager <gameflowManager>5__2; //Field offset: 0x18
		private int <trophies>5__3; //Field offset: 0x1C
		private int <elo>5__4; //Field offset: 0x20
		private Awaiter<OpponentData[]> <>u__1; //Field offset: 0x24

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRollEnd>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public MatchMakingState <>4__this; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartAnimation>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public MatchMakingState <>4__this; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private void MoveNext() { }

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly MatchMakingUi matchMakingUi; //Field offset: 0xC
	private readonly OpponentData forcedOpponent; //Field offset: 0x10
	private OpponentData opponent; //Field offset: 0x14
	private MatchSession matchSession; //Field offset: 0x18
	private bool popped; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly GameMode <GameMode>k__BackingField; //Field offset: 0x20

	public GameMode GameMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public MatchSession MatchSession
	{
		 get { } //Length: 8
	}

	public MatchMakingState(GameMode gameMode, OpponentData forcedOpponent = null) { }

	[CompilerGenerated]
	public GameMode get_GameMode() { }

	public MatchSession get_MatchSession() { }

	public OpponentData GetOpponentData() { }

	public override void OnPop() { }

	[AsyncStateMachine(typeof(<OnPush>d__11))]
	public override void OnPush() { }

	[AsyncStateMachine(typeof(<OnRollEnd>d__14))]
	private void OnRollEnd() { }

	[AsyncStateMachine(typeof(<StartAnimation>d__13))]
	private void StartAnimation() { }

}

