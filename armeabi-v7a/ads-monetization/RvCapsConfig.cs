namespace DraftShowdown;

public class RvCapsConfig
{
	public const int ControlStoreBitPackDailyCap = 2; //Field offset: 0x0
	public const int ControlMatchResultAdDailyCap = 5; //Field offset: 0x0
	public const int ControlDailyBitPackDailyCap = 1; //Field offset: 0x0
	public int StoreBitPackDailyCap; //Field offset: 0x8
	public int MatchResultAdDailyCap; //Field offset: 0xC
	public int DailyBitPackDailyCap; //Field offset: 0x10

	public RvCapsConfig() { }

}

