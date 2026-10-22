namespace QuestLab.DraftWar;

public class DailyBitPackContainer : MonoBehaviour
{
	private const string AnimAdWatchComplete = "AdWatchComplete"; //Field offset: 0x0
	private const string AnimTimerEnd = "TimerEnd"; //Field offset: 0x0
	private const string AnimSetNormal = "SetNormal"; //Field offset: 0x0
	private const string AnimSetComplete = "SetComplete"; //Field offset: 0x0
	private const string AnimSetTimer = "SetTimer"; //Field offset: 0x0
	[Foldout("References")]
	[SerializeField]
	private Animator animator; //Field offset: 0x10
	[Foldout("References")]
	[SerializeField]
	private DailyBitPackSlot[] slots; //Field offset: 0x14
	[Foldout("References")]
	[SerializeField]
	private TMP_Text timer; //Field offset: 0x18
	[Foldout("References")]
	[SerializeField]
	private Button adButton; //Field offset: 0x1C
	[SerializeField]
	private DailyBitPackAdSlot _adPackPrefab; //Field offset: 0x20
	[SerializeField]
	private RectTransform _adPackRoot; //Field offset: 0x24
	[SerializeField]
	private RectTransform _adRow; //Field offset: 0x28
	[SerializeField]
	private TMP_Text _adClaimText; //Field offset: 0x2C
	[SerializeField]
	private RectTransform _backgroundPanel; //Field offset: 0x30
	[SerializeField]
	private float _adRowMaxWidth; //Field offset: 0x34
	private readonly List<DailyBitPackAdSlot> _adPacks; //Field offset: 0x38
	private bool _adLayoutDirty; //Field offset: 0x3C
	private int _adClaimed; //Field offset: 0x40
	private int _adTotal; //Field offset: 0x44

	public UnityEvent AdClick
	{
		 get { } //Length: 28
	}

	public DailyBitPackContainer() { }

	public UnityEvent get_AdClick() { }

	public DailyBitPackSlot GetSlot(int index) { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RefreshAdClaimText() { }

	public void SetAd() { }

	public void SetAdProgress(int claimed, int total) { }

	internal void SetDailyBitPackAdButtonInteractable(bool interactable) { }

	public void SetNormal() { }

	public void SetPackSlotsState(int dailyBitPacksOpened, int dailyBitPacksUnlocked) { }

	public void SetRemainingTime(TimeSpan timeSpan) { }

	public void SetSlots(BitPackType[] bitPackTypes) { }

	public void SetTimer() { }

	public void ShowAdCompleteAnimation() { }

	public void ShowResetAnimation() { }

	private void UpdateAdLayout() { }

}

