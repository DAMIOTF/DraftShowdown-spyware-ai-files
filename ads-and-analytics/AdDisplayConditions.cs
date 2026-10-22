namespace Voodoo.Sauce.Internal.Ads;

public class AdDisplayConditions
{
	internal enum AdConditionState : int
	{
		FirstInterstitialReadyToShow = 0,
		FirstInterstitialTooEarly = 1,
		InterstitialTooEarlyAndNotEnoughGamesPlayed = 2,
		EnoughGamesWerePlayed = 3,
		RewardedVideoWasPlayedRecently = 4,
		InterstitialReadyToShow = 5,
		InterstitialWasPlayedRecently = 6,
		AppOpenWasPlayedRecently = 7,
		AppOpenReadyToShow = 8,
		AppOpenTooEarly = 9,
		Disabled = 10,
	}

	private const string TAG = "AdDisplayConditions"; //Field offset: 0x0
	private const string PREFS_FIRST_APP_LAUNCH = "VoodooSauce.Interstitial.FirstAppLaunch"; //Field offset: 0x0
	private const string TIME_SPENT_IN_APP_SINCE_FIRST_APP_LAUNCH = "VoodooSauce.Interstitial.TimeSpentInAppAfterFirstLaunch"; //Field offset: 0x0
	private const int DEFAULT_DELAY_IN_SECONDS_BETWEEN_REWARDED_VIDEO_AND_INTERSTITIAL = 5; //Field offset: 0x0
	private const float DEFAULT_DELAY_IN_SECONDS_IN_BACKGROUND_BEFORE_APP_OPEN_AD = 60; //Field offset: 0x0
	private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_APP_OPEN_ADS = 60; //Field offset: 0x0
	private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_INTERSTITIAL_AND_APP_OPEN_AD = 0; //Field offset: 0x0
	private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_REWARDED_VIDEO_AND_APP_OPEN_AD = 5; //Field offset: 0x0
	private const float DEFAULT_DELAY_IN_SECONDS_BETWEEN_APP_OPEN_AD_AND_INTERSTITIAL = 0; //Field offset: 0x0
	private readonly int _delayInSecondsBeforeFirstInterstitialAd; //Field offset: 0x10
	private readonly int _cumulativeDelayInSecondsBeforeFirstInterstitialAd; //Field offset: 0x14
	private readonly int _delayInSecondsBeforeSessionFirstInterstitial; //Field offset: 0x18
	private readonly int _delayInSecondsBetweenInterstitialAds; //Field offset: 0x1C
	private readonly int _maxGamesPlayedBetweenInterstitials; //Field offset: 0x20
	private readonly int _delayInSecondsBetweenRewardedVideoAndInterstitial; //Field offset: 0x24
	private readonly float _delayInSecondsInBackgroundBeforeAppOpenAd; //Field offset: 0x28
	private readonly float _delayInSecondsBetweenAppOpenAds; //Field offset: 0x2C
	private readonly float _delayInSecondsBetweenInterstitialAndAppOpenAd; //Field offset: 0x30
	private readonly float _delayInSecondsBetweenRewardedVideoAndAppOpenAd; //Field offset: 0x34
	private readonly float _delayInSecondsBetweenAppOpenAdAndInterstitial; //Field offset: 0x38
	private bool _firstEverInterstitialDisplayed; //Field offset: 0x3C
	private bool _firstSessionInterstitialDisplayed; //Field offset: 0x3D
	private int _gamesPlayedSinceLastInterstitial; //Field offset: 0x40
	private Nullable<float> _lastInterstitialTime; //Field offset: 0x44
	private readonly bool _rewardedVideosDelayFullscreen; //Field offset: 0x4C
	private Nullable<float> _lastRewardedVideoTime; //Field offset: 0x50
	private bool _appOpenAdEnabled; //Field offset: 0x58
	private Nullable<float> _lastAppOpenTime; //Field offset: 0x5C
	private float _amountOfTimeInBackground; //Field offset: 0x64
	private Nullable<float> _backgroundStartTime; //Field offset: 0x68
	private float _timeSpentInAppSinceFirstLaunch; //Field offset: 0x70

	public AdDisplayConditions(AdDisplayConditions currentAdDisplayConditions, int delayInSecondsBeforeFirstInterstitialAd, int delayInSecondsBeforeSessionFirstInterstitial, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial, float delayInSecondsBetweenAppOpenAdAndInterstitial, int cumulativeDelayInSecondsBeforeFirstInterstitialAd = -1) { }

	public AdDisplayConditions(int delayInSecondsBeforeFirstInterstitialAdAd, int delayInSecondsBeforeSessionFirstInterstitial, int delayInSecondsBetweenInterstitialAds, int maxGamesBetweenInterstitialAds, int delayInSecondsBetweenRewardedVideoAndInterstitial, float delayInSecondsInBackgroundBeforeAppOpenAd, float delayInSecondsBetweenAppOpenAds, float delayInSecondsBetweenInterstitialAndAppOpenAd, float delayInSecondsBetweenRewardedVideoAndAppOpenAd, float delayInSecondsBetweenAppOpenAdAndInterstitial, int cumulativeDelayInSecondsBeforeSessionFirstInterstitial = -1, bool appOpenAdEnabled = false) { }

	public string AppOpenConditionsToString() { }

	public void AppOpenDisplayed() { }

	public bool AreAppOpenConditionsMet() { }

	public bool AreInterstitialConditionsMet() { }

	internal void DisableAppOpenAd() { }

	internal void EnableAppOpenAd() { }

	public string GetAppOpenConditionStatusString() { }

	public string GetAppOpenConditionTimeString() { }

	internal AdConditionState GetCurrentAppOpenConditionState() { }

	internal AdConditionState GetCurrentInterstitialConditionState() { }

	public string GetInterstitialConditionStatusString() { }

	public string GetInterstitialConditionTimeString() { }

	public float GetTotalTimeSpentPlayingInSeconds() { }

	internal void IncrementBackgroundTime(float seconds) { }

	public void IncrementGamesPlayed() { }

	public string InterstitialConditionsToString() { }

	public void InterstitialDisplayed(bool shown) { }

	public void OnApplicationFocus(bool isFocused) { }

	public void OnApplicationPause(bool pauseStatus, bool isAdShowing) { }

	public void ResetBackgroundTimer() { }

	internal void ResetFirstEverInterstitialDisplayed() { }

	internal void ResetGamesPlayed() { }

	internal void ResetLastAppOpenTime() { }

	internal void ResetLastInterstitialTime() { }

	internal void ResetLastRewardedVideoTime() { }

	public void RewardedVideoDisplayed(bool completed) { }

	internal void SetFirstEverInterstitialDisplayed() { }

	internal void SetGamesPlayed(int gamesPlayed) { }

	internal void SetLastAppOpenTime(float secondsAgo) { }

	internal void SetLastInterstitialTime(float secondsAgo) { }

	internal void SetLastRewardedVideoTime(float secondsAgo) { }

}

