namespace Voodoo.Sauce.Internal.Analytics;

public class AnalyticsSettings : ScriptableObject
{
	public const string NAME = "AnalyticsSettings"; //Field offset: 0x0
	public const string RelativePath = "Assets/Resources/VSSettings/"; //Field offset: 0x0
	private static AnalyticsSettings _settings; //Field offset: 0x0
	public const string RelativePathFromResources = "VSSettings/"; //Field offset: 0x0
	public string platform; //Field offset: 0x18
	public string store; //Field offset: 0x20
	public bool useFirebaseAnalytics; //Field offset: 0x28
	public bool useRemoteConfig; //Field offset: 0x29
	public string adjustAppToken; //Field offset: 0x30
	public string noAdsBundleId; //Field offset: 0x38
	public bool useVoodooAnalytics; //Field offset: 0x40
	public ConversionEventsSettings conversionEvents; //Field offset: 0x48
	public bool isChinaStore; //Field offset: 0x50
	public string appleStoreId; //Field offset: 0x58
	public VoodooFunnelsSettings voodooFunnels; //Field offset: 0x60
	public string gameAnalyticsGameKey; //Field offset: 0x68
	public string gameAnalyticsSecretKey; //Field offset: 0x70
	public bool excludeGameAnalyticsSDK; //Field offset: 0x78
	[ReadOnly]
	public string facebookAppId; //Field offset: 0x80

	public AnalyticsSettings() { }

	public static string GetRelativePath() { }

	public static string GetRelativePathByPlatformAndStore(string platform, string store) { }

	public static string GetRelativePathFromResources() { }

	public static string GetRelativePathFromResourcesByPlatformAndStore(string platform, string store) { }

	public static AnalyticsSettings Load() { }

	public static AnalyticsSettings Load(string platformToLoad, string storeToLoad) { }

	public static string NameByPlatformAndStore(string platform, string store) { }

	public static AnalyticsSettings RuntimeLoad() { }

}

