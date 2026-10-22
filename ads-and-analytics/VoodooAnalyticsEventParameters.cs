namespace Voodoo.Sauce.Internal.Analytics;

public class VoodooAnalyticsEventParameters : VanEventBasicParameters
{
	private const string FAKE_VALUE = "fake"; //Field offset: 0x0
	[CanBeNull]
	private string _vsVersion; //Field offset: 0x10
	[CanBeNull]
	private string _appBundleId; //Field offset: 0x18
	[CanBeNull]
	private string _appVersion; //Field offset: 0x20
	[CanBeNull]
	private string _platform; //Field offset: 0x28
	[CanBeNull]
	private string _developerDeviceId; //Field offset: 0x30
	[CanBeNull]
	private string _firstAppLaunchDate; //Field offset: 0x38
	[CanBeNull]
	private string _mediation; //Field offset: 0x40
	[CanBeNull]
	private string _segmentationUuid; //Field offset: 0x48
	[CanBeNull]
	private string _abTestUuid; //Field offset: 0x50
	[CanBeNull]
	private string _abTestCohortUuid; //Field offset: 0x58
	private string _abTestTreatmentUuid; //Field offset: 0x60
	[CanBeNull]
	private string _abTestVersionUuid; //Field offset: 0x68
	[CanBeNull]
	private string _gamingId; //Field offset: 0x70
	[CanBeNull]
	private AttributionData _attributionData; //Field offset: 0x78

	private static PrivacyCore Privacy
	{
		 get { } //Length: 84
	}

	public VoodooAnalyticsEventParameters() { }

	private static PrivacyCore get_Privacy() { }

	public override string GetAbTestCohortUuid() { }

	public override string GetAbTestTreatmentUuid() { }

	public override string GetAbTestUuid() { }

	public override string GetAbTestVersionUuid() { }

	public override bool GetAdsConsentGiven() { }

	public override string GetAdvertisingId() { }

	public override bool GetAnalyticsConsentGiven() { }

	public override int GetAndroidDeveloperDeviceIdScope() { }

	public override string GetAppBundleId() { }

	public override int GetAppLaunchCount() { }

	public override string GetAppVersion() { }

	public override string GetAttributionDataName() { }

	public override string GetAttributionDataUserId() { }

	public override string GetConnectivity() { }

	public override string GetCurrentLevel() { }

	public override string GetDeveloperDeviceId() { }

	public override string GetFirstAppLaunchDate() { }

	public override int GetGameCount() { }

	public override string GetGamingId() { }

	public override string GetIdfaAuthorizationStatus() { }

	public override string GetInstallStore() { }

	public override string GetLocale() { }

	public override string GetManufacturer() { }

	public override string GetMediation() { }

	public override string GetModel() { }

	public override string GetOSVersion() { }

	public override string GetPlatform() { }

	public override string GetScreenResolution() { }

	public override string GetSegmentationUuid() { }

	public override string GetUserId() { }

	public override string GetVSVersion() { }

	public override bool HasLimitAdTrackingEnabled() { }

	public override void SetAbTestCohortUuid(string abTestCohortUuid) { }

	public override void SetAbTestTreatmentUuid(string treatmentId) { }

	public override void SetAbTestUuid(string abTestUuid) { }

	public override void SetAbTestVersionUuid(string abTestVersionUuid) { }

	public override void SetAppBundleId(string appBundleId) { }

	public override void SetAppVersion(string appVersion) { }

	public override void SetGamingId(string gamingId) { }

	public override void SetMediation(string mediation) { }

	public override void SetSegmentationUuid(string segmentationUuid) { }

	public override void SetVsVersion(string vsVersion) { }

}

