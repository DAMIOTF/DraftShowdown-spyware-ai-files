namespace QuestLab.DraftWar;

public sealed class AdjustMilestoneEvent
{
	[SerializeField]
	private string m_Name; //Field offset: 0x8
	[SerializeField]
	private int m_Threshold; //Field offset: 0xC
	[SerializeField]
	private string m_AndroidToken; //Field offset: 0x10
	[SerializeField]
	private string m_IosToken; //Field offset: 0x14

	public string Name
	{
		 get { } //Length: 8
	}

	public int Threshold
	{
		 get { } //Length: 8
	}

	public string Token
	{
		 get { } //Length: 8
	}

	public AdjustMilestoneEvent() { }

	public string get_Name() { }

	public int get_Threshold() { }

	public string get_Token() { }

}

