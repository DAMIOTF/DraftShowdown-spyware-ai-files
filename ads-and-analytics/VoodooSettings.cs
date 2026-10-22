namespace Voodoo.Sauce.Core;

[CreateAssetMenu(fileName = "Assets/Resources/VoodooSettings", menuName = "VoodooSauce/Settings file", order = 1000)]
public class VoodooSettings : ScriptableObject, IVoodooSettings, IVoodooCoreSettings, IVoodooLogSettings
{
	public enum Position : int
	{
		Right = 0,
		Left = 1,
	}

	public const string NAME = "VoodooSettings"; //Field offset: 0x0
	public const string STORE_WORLDWIDE = "worldwide"; //Field offset: 0x0
	public const string STORE_CHINA = "china"; //Field offset: 0x0
	public const string DEFAULT_STORE = "worldwide"; //Field offset: 0x0
	private static VoodooSettings _instance; //Field offset: 0x0
	[HideInInspector]
	public string Store; //Field offset: 0x18
	[CustomLabel("Voodoo Server Access Token")]
	[ExplanationText("This token is mandatory to retrieve the VoodooSauce settings of your game. Ask your Voodoo contact to give you this token.")]
	public string AccessTokenID; //Field offset: 0x20
	[LargeHeader("Settings that you must edit yourself to control AB Tests, IAP, and Splash Screen", "Manual Settings")]
	[ReadOnly]
	[Separator]
	public string LastUpdateDate; //Field offset: 0x28
	[Header("Android Specific Options")]
	[Space]
	public VoodooSauceAndroidBuildTargetEnum AndroidBuildTargetEnum; //Field offset: 0x30
	[Tooltip("The new manifest merge is using nested node to ensure that all manifest added is merged regardless of it's level of nodes. If this cause an issue during the build, you can switch to the Legacy Manifest Merge Tools")]
	public bool UseLegacyManifestMergeTools; //Field offset: 0x34
	[Tooltip("By default the manifest wont merge attributes, if you need it, then you can enable this")]
	public bool UseAttributesMerging; //Field offset: 0x35
	[Tooltip("To debug the new manifest merging, enable the flag below and rebuild")]
	public bool NewManifestMergeDebug; //Field offset: 0x36
	[Tooltip("String should look like: 'Assets/[custom]/[path]/'; This path will be used in addition to the default path to get AndroidTemplate.json files, and use them for the build. So if you need to use AndroidTemplate.json you can maintain them in any path you want.")]
	public string AndroidTemplateJsonCustomPath; //Field offset: 0x38
	public VoodooJvmHeapSizeEnum JvmHeapSize; //Field offset: 0x40
	[Header("iOS Specific Options")]
	[Space]
	public bool RunXcode16BitcodeRemoval; //Field offset: 0x44
	[Tooltip("String should look like: 'Assets/[custom]/[path]/frameworks_to_embed.txt'; This path will be used in addition to the default VoodooSauce frameworks list. Use this if you need to add custom frameworks to embed without modifying VoodooSauce code.")]
	public string IosCustomFrameworksListPath; //Field offset: 0x48
	[FormerlySerializedAs("EnableFakeInUnityAds")]
	[Header("In Editor Ads")]
	public bool EnableInEditorUnityAds; //Field offset: 0x50
	public bool EnableInEditorRVAds; //Field offset: 0x51
	public bool EnableInEditorFSAds; //Field offset: 0x52
	public bool EnableInEditorAOAds; //Field offset: 0x53
	[Header("Super Premium Mode")]
	[Tooltip("[ONLY ON DEVELOPMENT MODE] Super Premium mode will automatically enable Premium mode, and Rewarded will always be ready and can trigger reward without watching the ads")]
	public bool EnableSuperPremiumMode; //Field offset: 0x54
	public VoodooFunnelsSettings VoodooFunnels; //Field offset: 0x58
	[Header("In-app Purchases")]
	[ReadOnly]
	public bool AndroidIAPEnabled; //Field offset: 0x60
	[ReadOnly]
	public bool iOSIAPEnabled; //Field offset: 0x61
	[FormerlySerializedAs("NoAdsBundleId")]
	[Tooltip("Your No-Ads in-app purchase product id for Android. You need to use the NoAdsButton component if you fill that field.")]
	public string AndroidNoAdsProductId; //Field offset: 0x68
	[FormerlySerializedAs("NoAdsBundleId")]
	[Tooltip("Your No-Ads in-app purchase product id for iOS. You need to use the NoAdsButton component if you fill that field.")]
	public string iOSNoAdsProductId; //Field offset: 0x70
	[Tooltip("Represents subscription upgrade/downgrade groups. Use these groups to specify which subscriptions can be upgraded/downgraded together within the same group. Setting it to \"None\" means that the subscription cannot be upgraded/downgraded.")]
	public string[] SubscriptionGroups; //Field offset: 0x78
	[Tooltip("Represents the family of products.Use these groups to specify which family exist.")]
	public string[] ProductsFamily; //Field offset: 0x80
	[Tooltip("The list of all products available for sale in the app")]
	public ProductDescriptor[] Products; //Field offset: 0x88
	[Header("In-app subscriptions, Apple's App-Specific Shared Secret")]
	[Tooltip("Get Verification Credentials from the app store connect. This key allows you to verify the auto-renewable subscriptions")]
	public string SubscriptionSharedKey; //Field offset: 0x90
	[Header("SplashScreen")]
	[Tooltip("Please provide your White studio logo on a transparent background with no margin.")]
	public Texture2D StudioLogoForSplashScreen; //Field offset: 0x98
	[Tooltip("Disable VS management of your Unity Splash Screen settings.  Any existing settings will not be reset.")]
	public bool DisableVSManagedSplashScreen; //Field offset: 0xA0
	[Header("App Rater")]
	[ReadOnly]
	[Tooltip("Apple Store Id of the game")]
	public string AppleStoreId; //Field offset: 0xA8
	[ReadOnly]
	public bool iOSAppRaterEnabled; //Field offset: 0xB0
	[ReadOnly]
	public bool AndroidAppRaterEnabled; //Field offset: 0xB1
	[Tooltip("Minimum delay when the App Rater can be displayed after the launch of the game (in seconds)")]
	public int AppRaterDelayAfterLaunchInSeconds; //Field offset: 0xB4
	[Tooltip("Minimum delay between two App Rater displays (in seconds)")]
	public int AppRaterPostponeCooldownInSeconds; //Field offset: 0xB8
	[Tooltip("Minimum number of games at which the App Rater will starts to be shown.If 0, the App Rater will never be shown after a game played")]
	public int AppRaterMinimumNumberOfGamesPlayed; //Field offset: 0xBC
	[Header("Misc")]
	[Tooltip("The primary color that will show on the GDPR popup")]
	public Color GdprPrimaryColor; //Field offset: 0xC0
	[Header("Banner")]
	[ReadOnly]
	public bool iOSBannerCloseButtonEnabled; //Field offset: 0xD0
	[ReadOnly]
	public bool AndroidBannerCloseButtonEnabled; //Field offset: 0xD1
	[Tooltip("Color of the banner background")]
	public Color BannerBackgroundColor; //Field offset: 0xD4
	[Tooltip("Sprite of the banner close button, if not set use the default one")]
	public Sprite BannerCloseButtonSprite; //Field offset: 0xE8
	[Tooltip("Position of the banner close button")]
	public Position BannerCloseButtonPosition; //Field offset: 0xF0
	[Tooltip("If enabled the banner background and close button position will automatically being adjusted based on Banner height from Mediation")]
	public bool EnableAutomaticBannerHeightAdjustment; //Field offset: 0xF4
	[Header("Interstitial ad frequency configuration : Default value")]
	[Tooltip("The number of cumulative seconds between sessions to wait before displaying the first interstitial ad. If the value is higher than -1, we will use cumulativeDelayInSecondsBeforeFirstInterstitialAd to delay the first interstitial based on the cumulative value instead of using delayInSecondsBeforeFirstInterstitialAd")]
	public int cumulativeDelayInSecondsBeforeFirstInterstitialAd; //Field offset: 0xF8
	[Tooltip("The number of seconds to wait before displaying the first interstitial ad.")]
	public int delayInSecondsBeforeFirstInterstitialAd; //Field offset: 0xFC
	[Tooltip("The number of seconds to wait before displaying the first interstitial ad during a session.")]
	public int delayInSecondsBeforeSessionFirstInterstitialAd; //Field offset: 0x100
	[Tooltip("The time interval, in seconds, between consecutive interstitial ad displays within an app or game.")]
	public int delayInSecondsBetweenInterstitialAds; //Field offset: 0x104
	[Tooltip("The maximum number of games or gameplay sessions that will occur before displaying an interstitial ad within a gaming application.")]
	public int maxGamesBetweenInterstitialAds; //Field offset: 0x108
	[Tooltip("The time interval, in seconds, between displaying a rewarded video ad and an interstitial ad within an app or game.")]
	public int delayInSecondsBetweenRewardedVideoAndInterstitial; //Field offset: 0x10C
	[Tooltip("If true, enable the functionality to replace a rewarded ad with an interstitial ad if the interstitial's CPM (Cost Per Mille) rate is higher.")]
	public bool enableReplaceRewardedIfInterstitialCpmHigher; //Field offset: 0x110
	[Tooltip("If true, enable the functionality to replace a rewarded ad with an alternative ad format if the rewarded ad fails to load or is unavailable.")]
	public bool enableReplaceRewardedIfNotLoaded; //Field offset: 0x111
	[Header("Build in Batch Mode")]
	[Tooltip("When building in batch mode (usually when using CI), VS would fetches the last changes from the Kitchen and updates the VS settings in prebuild phase.")]
	public bool RefreshKitchenSettingsBeforeBuildInBatchMode; //Field offset: 0x112
	[Header("VoodooLog")]
	[Tooltip("If true, a timestamp would add to the start of the log message")]
	public bool voodooLogAddTimestamp; //Field offset: 0x113
	[SerializeField]
	[Tooltip("[Playmode] If true, Debug.Log calls will be intercepted and errors/exceptions will be send to Crashlytics.")]
	private bool captureUnityLogs; //Field offset: 0x114
	[SerializeField]
	[Tooltip("[Build] If true, calls to log functions thar do not match the verbosity level will be compiled out when building.")]
	private bool compileOutLogsAtBuildTime; //Field offset: 0x115
	[SerializeField]
	[Tooltip("Configure Log Filtering Settings")]
	private LogFilteringSettings logFilteringSettings; //Field offset: 0x118
	[SerializeField]
	[WarningMessage("Defines the logging verbosity when playing in editor we recommend not to change it.")]
	private LogVerbosity logVerbosityPlayInEditor; //Field offset: 0x120
	[SerializeField]
	[Tooltip("Defines the logging verbosity for debug builds")]
	private LogVerbosity logVerbosityDebug; //Field offset: 0x124
	[SerializeField]
	[Tooltip("Defines the logging verbosity for development builds")]
	private LogVerbosity logVerbosityDevelopment; //Field offset: 0x128
	[SerializeField]
	[Tooltip("Defines the logging verbosity for release builds")]
	private LogVerbosity logVerbosityRelease; //Field offset: 0x12C
	[Header("Voodoo Analytics")]
	[Tooltip("If true, a local timestamp would add to context variables of every Voodoo Analytics event")]
	public bool EnableVoodooAnalyticsLocalTimestamp; //Field offset: 0x130
	public bool SendFirebaseInstallEvent; //Field offset: 0x131
	[LargeHeader("Settings sent from Voodoo Servers. Update by clicking 'Update from Online'", "Automatic Settings")]
	[Tooltip("If checked, the Android build won't be stopped because the Google Public Key is missing.")]
	[WarningMessage("By checking the checkbox above, you understand that you need to obfuscate your google public key before building for Android release. Check the toggle above to ignore the error. (CHECK ONLY FOR DEBUG OR TEST PURPOSES)")]
	public bool IgnoreTheGoogleKeyError; //Field offset: 0x132
	[Header("Bundle identifiers")]
	[ReadOnly]
	public string IOSBundleID; //Field offset: 0x138
	[ReadOnly]
	public string AndroidBundleID; //Field offset: 0x140
	[Header("Remote A/B Tests")]
	[ReadOnly]
	[Tooltip("Use Legacy A/B Tests or Remote A/B Tests via VoodooTune Config for Android")]
	public bool UseAndroidRemoteConfig; //Field offset: 0x148
	[ReadOnly]
	[Tooltip("Use Legacy A/B Tests or Remote A/B Tests via VoodooTune Config for iOS")]
	public bool UseIosRemoteConfig; //Field offset: 0x149
	[Header("Rewarded Ads Config")]
	[ReadOnly]
	[Tooltip("Display Interstitial instead of Rewarded Video if CPM Higher for iOS")]
	public bool EnableIosReplaceRewardedOnCpm; //Field offset: 0x14A
	[ReadOnly]
	[Tooltip("Display Interstitial instead of Rewarded Video if CPM Higher for Android")]
	public bool EnableAndroidReplaceRewardedOnCpm; //Field offset: 0x14B
	[Header("Rewarded Ads Config")]
	[ReadOnly]
	[Tooltip("Display Interstitial instead of Rewarded Video if RV is not loaded for iOS")]
	public bool EnableIosReplaceRewardedIfNotLoaded; //Field offset: 0x14C
	[ReadOnly]
	[Tooltip("Display Interstitial instead of Rewarded Video if RV is not loaded for Android")]
	public bool EnableAndroidReplaceRewardedIfNotLoaded; //Field offset: 0x14D
	[Header("Voodoo Analytics")]
	[ReadOnly]
	[Tooltip("Use Voodoo Analytics for iOS")]
	public bool UseIosVoodooAnalytics; //Field offset: 0x14E
	[ReadOnly]
	[Tooltip("Use Voodoo Analytics for Android")]
	public bool UseAndroidVoodooAnalytics; //Field offset: 0x14F
	[Header("Firebase Analytics")]
	[ReadOnly]
	[Tooltip("Use Firebase Analytics for iOS")]
	public bool UseIosFirebaseAnalytics; //Field offset: 0x150
	[ReadOnly]
	[Tooltip("Use Firebase Analytics for Android")]
	public bool UseAndroidFirebaseAnalytics; //Field offset: 0x151
	[Header("GameAnalytics")]
	[ReadOnly]
	[Tooltip("Your GameAnalytics iOS Game Key - copy/paste from the GA website")]
	public string GameAnalyticsIosGameKey; //Field offset: 0x158
	[ReadOnly]
	[Tooltip("Your GameAnalytics iOS Secret Key - copy/paste from the GA website")]
	public string GameAnalyticsIosSecretKey; //Field offset: 0x160
	[ReadOnly]
	[Tooltip("Exclude GameAnalytics SDK from iOS build")]
	public bool ExcludeGameAnalyticsIosSDK; //Field offset: 0x168
	[ReadOnly]
	[Tooltip("Your GameAnalytics Android Game Key - copy/paste from the GA website")]
	public string GameAnalyticsAndroidGameKey; //Field offset: 0x170
	[ReadOnly]
	[Tooltip("Your GameAnalytics Android Secret Key - copy/paste from the GA website")]
	public string GameAnalyticsAndroidSecretKey; //Field offset: 0x178
	[ReadOnly]
	[Tooltip("Exclude GameAnalytics SDK from Android build")]
	public bool ExcludeGameAnalyticsAndroidSDK; //Field offset: 0x180
	[Header("MaxAds - Ads keys")]
	[ReadOnly]
	[Tooltip("Leave the field blank if you don't want a certain kind of ads in your game")]
	public AdsKeys MaxAdsIosAdsKeys; //Field offset: 0x188
	[ReadOnly]
	[Tooltip("Leave the field blank if you don't want a certain kind of ads in your game")]
	public AdsKeys MaxAdsAndroidAdsKeys; //Field offset: 0x190
	[ReadOnly]
	public string MaxIosSdkKey; //Field offset: 0x198
	[ReadOnly]
	public string MaxAndroidSdkKey; //Field offset: 0x1A0
	[Tooltip("If true, disable MaxAds Quality Service SDK")]
	public bool DisableMaxAdsQualityServiceSDK; //Field offset: 0x1A8
	[Header("IronSource Mediation - keys")]
	[ReadOnly]
	[Tooltip("Leave the field blank if you don't want a certain kind of ads in your game")]
	public IronSourceKeys IronSourceIosKeys; //Field offset: 0x1B0
	[ReadOnly]
	public IronSourceKeys IronSourceAndroidKeys; //Field offset: 0x1B8
	[Header("AdMob")]
	[ReadOnly]
	[Tooltip("Ask your Voodoo agents for AdMob Android App Id")]
	public string AdMobAndroidAppId; //Field offset: 0x1C0
	[ReadOnly]
	[Tooltip("Ask your Voodoo agents for AdMob iOS App Id")]
	public string AdMobIosAppId; //Field offset: 0x1C8
	[Header("Adjust")]
	[ReadOnly]
	[Tooltip("Adjust iOS App Token")]
	public string AdjustIosAppToken; //Field offset: 0x1D0
	[ReadOnly]
	[Tooltip("Adjust Android App Token")]
	public string AdjustAndroidAppToken; //Field offset: 0x1D8
	[ReadOnly]
	[Tooltip("Conversion iOS Events")]
	public ConversionEventsSettings ConversionIosEvents; //Field offset: 0x1E0
	[ReadOnly]
	[Tooltip("Conversion Android Events")]
	public ConversionEventsSettings ConversionAndroidEvents; //Field offset: 0x1E8
	[Header("AppOpen Ads")]
	[ReadOnly]
	public bool EnableIosAppOpenAdSoftLaunch; //Field offset: 0x1F0
	[ReadOnly]
	public bool EnableAndroidAppOpenAdSoftLaunch; //Field offset: 0x1F1
	[ReadOnly]
	public AppOpenAdConfig iOSAppOpenAdConfig; //Field offset: 0x1F8
	[ReadOnly]
	public AppOpenAdConfig AndroidAppOpenAdConfig; //Field offset: 0x200
	[Header("Audio Ads")]
	[ReadOnly]
	public AudioAdConfig iOSAudioAdConfig; //Field offset: 0x208
	[ReadOnly]
	public AudioAdConfig AndroidAudioAdConfig; //Field offset: 0x210
	[Header("Audiomob")]
	[ReadOnly]
	public AudioMobConfig iOSAudioMobConfig; //Field offset: 0x218
	[ReadOnly]
	public AudioMobConfig AndroidAudioMobConfig; //Field offset: 0x220
	[Header("Sourcepoint")]
	[ReadOnly]
	public SourcepointConfiguration sourcepointIosConfiguration; //Field offset: 0x228
	[ReadOnly]
	public SourcepointConfiguration sourcepointAndroidConfiguration; //Field offset: 0x230
	[Header("Google Chrome Promotion")]
	[ReadOnly]
	public string googleChromePromotionAdjustToken; //Field offset: 0x238

	public AppOpenAdConfig AppOpenAdConfig
	{
		 get { } //Length: 180
	}

	public bool BannerCloseButtonEnabled
	{
		 get { } //Length: 148
	}

	public bool CaptureUnityLogs
	{
		 get { } //Length: 8
	}

	public bool CompileOutLogsAtBuildTime
	{
		 get { } //Length: 8
	}

	public ConversionEventsSettings ConversionEvents
	{
		 get { } //Length: 144
	}

	public bool EnableAppOpenAdSoftLaunch
	{
		 get { } //Length: 136
	}

	public bool EnableReplaceRewardedIfNotLoaded
	{
		 get { } //Length: 148
	}

	public bool EnableReplaceRewardedOnCpm
	{
		 get { } //Length: 148
	}

	public AudioAdConfig GetAndroidAudioAdConfig
	{
		 get { } //Length: 8
	}

	public AudioAdConfig GetIosAudioAdConfig
	{
		 get { } //Length: 8
	}

	public bool IsIAPEnabled
	{
		 get { } //Length: 148
	}

	public bool LogAddTimestamp
	{
		 get { } //Length: 8
	}

	public LogFilteringSettings LogFilteringSettings
	{
		 get { } //Length: 8
	}

	public LogVerbosity LogVerbosityDebug
	{
		 get { } //Length: 8
	}

	public LogVerbosity LogVerbosityDevelopment
	{
		 get { } //Length: 8
	}

	public LogVerbosity LogVerbosityPlayInEditor
	{
		 get { } //Length: 8
	}

	public LogVerbosity LogVerbosityRelease
	{
		 get { } //Length: 8
	}

	public bool MaxAdsQualityServiceEnabled
	{
		 get { } //Length: 16
	}

	public string MaxSdkKey
	{
		 get { } //Length: 160
	}

	public string NoAdsBundleId
	{
		 get { } //Length: 108
	}

	public SourcepointConfiguration SourcepointConfiguration
	{
		 get { } //Length: 176
	}

	public bool UseFirebaseAnalytics
	{
		 get { } //Length: 148
	}

	public bool UseRemoteConfig
	{
		 get { } //Length: 148
	}

	public bool UseVoodooAnalytics
	{
		 get { } //Length: 148
	}

	public VoodooSettings() { }

	public static VoodooSettings Get(bool forceReload = false) { }

	public AppOpenAdConfig get_AppOpenAdConfig() { }

	public bool get_BannerCloseButtonEnabled() { }

	public bool get_CaptureUnityLogs() { }

	public bool get_CompileOutLogsAtBuildTime() { }

	public ConversionEventsSettings get_ConversionEvents() { }

	public bool get_EnableAppOpenAdSoftLaunch() { }

	public bool get_EnableReplaceRewardedIfNotLoaded() { }

	public bool get_EnableReplaceRewardedOnCpm() { }

	public AudioAdConfig get_GetAndroidAudioAdConfig() { }

	public AudioAdConfig get_GetIosAudioAdConfig() { }

	public bool get_IsIAPEnabled() { }

	public bool get_LogAddTimestamp() { }

	public LogFilteringSettings get_LogFilteringSettings() { }

	public LogVerbosity get_LogVerbosityDebug() { }

	public LogVerbosity get_LogVerbosityDevelopment() { }

	public LogVerbosity get_LogVerbosityPlayInEditor() { }

	public LogVerbosity get_LogVerbosityRelease() { }

	public bool get_MaxAdsQualityServiceEnabled() { }

	public string get_MaxSdkKey() { }

	public string get_NoAdsBundleId() { }

	public SourcepointConfiguration get_SourcepointConfiguration() { }

	public bool get_UseFirebaseAnalytics() { }

	public bool get_UseRemoteConfig() { }

	public bool get_UseVoodooAnalytics() { }

	public string GetAdjustAppToken() { }

	public AudioMobConfig GetAudioMobConfig() { }

	public IronSourceKeys GetIronSourceKeys() { }

	public static bool IsAdUnitFieldName(string fieldName) { }

	public bool IsChinaStore() { }

	[Obsolete]
	public static VoodooSettings Load() { }

}

