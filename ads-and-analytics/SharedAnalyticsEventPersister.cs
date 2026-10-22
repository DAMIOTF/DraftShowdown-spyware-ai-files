namespace Voodoo.Sauce.Internal.Analytics;

internal class SharedAnalyticsEventPersister : IAnalyticsEventPersister
{
	private const string BASE_ANALYTICS_URL = "https://vs-api.voodoo-{0}.io/push-analytics-v2"; //Field offset: 0x0

	public SharedAnalyticsEventPersister() { }

	public void Initialize(string proxyServer) { }

	public void PersistEvent(PersistableAnalyticsEvent persistableAnalyticsEvent) { }

}

