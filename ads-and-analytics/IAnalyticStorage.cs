namespace Voodoo.Sauce.Internal.Analytics;

public interface IAnalyticStorage
{

	public string CreateRoundId() { }

	public void DecreaseGameCount() { }

	public int GetActivityDays() { }

	public int GetAppLaunchCount() { }

	public int GetAppOpenWatchedCount() { }

	public int GetAudioAdCount() { }

	public string GetCurrentLevel() { }

	public int GetDaysSinceInstall() { }

	public int GetDaysSinceLastSession() { }

	public Nullable<DateTime> GetFirstAppLaunchDate() { }

	public int GetGameCount() { }

	public float GetGameHighestScore() { }

	public string GetGameRoundId() { }

	public int GetInterstitialWatchedCount() { }

	public Nullable<DateTime> GetLastActiveDate() { }

	public int GetMrecCount() { }

	public int GetRewardedVideoWatchedCount() { }

	public int GetRvUsed() { }

	public int GetShowAppOpenCount() { }

	public int GetShowInterstitialCount() { }

	public int GetShowNativeAdsCount() { }

	public int GetShowRewardedVideoCount() { }

	public int GetSuccessfulGameCount() { }

	public double GetWinRate() { }

	public bool HasCurrentLevel() { }

	public bool HasGameHighestScore() { }

	public bool HasWinRate() { }

	public void IncreaseRvUsed() { }

	public void IncrementAppLaunchCount() { }

	public int IncrementAppOpenWatchedCount() { }

	public int IncrementAudioAdCount() { }

	public void IncrementGameCount() { }

	public int IncrementInterstitialWatchedCount() { }

	public int IncrementMrecCount() { }

	public int IncrementRewardedVideoWatchedCount() { }

	public int IncrementShowAppOpenCount() { }

	public int IncrementShowInterstitialCount() { }

	public int IncrementShowNativeAdsCount() { }

	public int IncrementShowRewardedVideoCount() { }

	public int IncrementSuccessfulGameCount() { }

	public bool IsFirstAppLaunch() { }

	public void PreLoad(IStorageProvider storageProvider = null) { }

	public void ResetRvUsed() { }

	public void RestoreGameRoundId(string id) { }

	public void SaveFirstAppLaunchDate() { }

	public void SaveLastActiveDate() { }

	public void UpdateCurrentLevel(string level) { }

	public bool UpdateGameHighestScore(float score) { }

}

