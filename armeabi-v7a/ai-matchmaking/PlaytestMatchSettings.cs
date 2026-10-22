namespace QuestLab.DraftWar;

[CreateAssetMenu(fileName = "PlaytestMatchSettings", menuName = "ScriptableObjects/PlaytestMatchSettings", order = 1)]
public class PlaytestMatchSettings : ScriptableObject
{
	[Tooltip("The Playtest match bot plays 4 of these units, picked at random.")]
	public List<UnitType> MetaUnits; //Field offset: 0xC

	public PlaytestMatchSettings() { }

}

