namespace QuestLab.DraftWar;

public class DailyBitPackAdSlot : MonoBehaviour
{
	[SerializeField]
	private Image _pack; //Field offset: 0x10
	[SerializeField]
	private GameObject _completed; //Field offset: 0x14
	[SerializeField]
	private Color _claimedColor; //Field offset: 0x18

	public DailyBitPackAdSlot() { }

	public void SetClaimed(bool claimed) { }

}

