# Findings and source references

Analyzed source root: `/home/dmtf/Documents/draftwar/arm64` (ARM64 decompilation). Line numbers below refer to those source files unless a path is given. The separate `armeabi-v7a/` subdirectory contains artifacts from the ARMv7 build.

## A. Bot opponents and matchmaking

### Evidence

- `Cpp2IL-wynik-arm64/DiffableCs/Scripts/QuestLab/DraftWar/GhostOpponentBuilder.cs`, lines 26–28: declares `RollAiSmartness(...)` and `TryCreate(PlayerPublicProfileData publicProfile, int seekerTrophies, out OpponentData opponent)`.
- `Cpp2IL-wynik-arm64/DiffableCs/Scripts/QuestLab/DraftWar/AiOpponentPlayer.cs`, lines 3, 77, 112, 132–134: declares `AiOpponentPlayer : IBattlePlayer`, an AI smartness field, constructor, card selection and draft-pick methods.
- `draft-analysis/DraftAi-branch-investigation.txt`, lines 395–397 and 426–428: IL call arguments pass `aiSmartness` to `DraftAi.DrawCardExponential` or `DraftAi.DrawCard`.
- `draft-analysis/DraftAi-callsite-investigation.txt`, lines 586–603 and 623–631: call sites in `AiOpponentPlayer` and `DraftState` invoke those draft algorithms.
- `draft-analysis/DraftAi-scoring-details.txt`, e.g. lines 60–105: scoring uses unit level, tendency, unit count and configured weights.
- `Cpp2IL-wynik-arm64/DiffableCs/Scripts/QuestLab/DraftWar/OpponentProvider.cs`, lines 210–216: declares opponent-pool generation APIs for trophy and Elo ranges.
- `Cpp2IL-wynik-arm64/DiffableCs/Scripts/QuestLab/DraftWar/NetworkOpponentPlayer.cs`, line 3, and `NakamaRpcClient.cs`, line 463: declare a network opponent and the `nakama.api.RatedMatchmaking` service.
- `Cpp2IL-wynik-arm64/DiffableCs/Scripts/QuestLab/DraftWar/RatedMatchSession.cs`, lines 306–317 and 364–373: declares rated matchmaking, a `FallbackCsv(...)` route and `TryBuildGhost(...)`.

### Assessment

**Bot-controlled opponents and ghost generation are in the game.** Draft choices are not merely random labels: the IL evidence routes through `DraftAi` scoring/weighting logic. This is direct evidence that the game can present AI-controlled opponents.

**The bot-majority claim is not established.** The same build includes network opponent and rated-matchmaking paths. The declarations do not show which path is chosen in each game mode or how often either path is used. No player-population statistics or representative match sample is included. A majority claim requires match data, not inference from bot classes.

The C# files in `DiffableCs` are generated stubs with empty method bodies. Treat their type names and signatures as structural evidence; the IL snippets are the stronger evidence for executable AI draft logic.

## B. Advertising and monetization

### Evidence

- `base/play-services-ads.properties`: Google Play Services Ads client, version 25.4.0.
- `base/play-services-ads-identifier.properties`: Google Play Services Ads Identifier client, version 18.1.0.
- `base/firebase-analytics.properties`: Firebase Analytics client, version 23.2.0.
- `Cpp2IL-wynik-arm64/DiffableCs/VoodooSauce/Voodoo/Sauce/Core/VoodooSettings.cs`, lines 108–124: interstitial frequency settings include delay before ads and maximum games between interstitials. The setting comments explicitly describe replacing a rewarded ad with an interstitial when the interstitial CPM is higher, or using an alternative format when the rewarded ad is unavailable.
- `Cpp2IL-wynik-arm64/DiffableCs/VoodooSauce/Voodoo/Sauce/Internal/Ads/AdDisplayConditions.cs`, lines 7–17, 23–28 and 29–54: ad eligibility states, timers and game counters; visible defaults include 5 seconds between rewarded video and interstitial and 60-second app-open intervals. Other thresholds are injected through constructors/settings rather than exposed here as active runtime values.
- Original `AdsManager.cs`, lines 31–40, 230, 263–273, and `Interstitial.cs`, line 193: declares interstitial/rewarded managers, a second interstitial, and `ShowTwoFsInARow(...)`. This is SDK capability, not proof that two ads were shown in a particular session.
- `base/META-INF/com/applovin/mediation/*/verification.properties`: 16 AppLovin MAX adapter manifests—Google Ad Manager, Google, Moloco, InMobi, ByteDance, Mintegral, Facebook, ironSource, Yandex, Fyber, Vungle, Verve, PubMatic, Unity Ads, BidMachine and YSO Network. Bundled adapters are not proof that every network was active.
- `split_config.arm64_v8a/lib/arm64-v8a/libAdjoeWave.so`, `libapminsightb.so` and `libapplovin-native-crash-reporter.so`: native libraries included in the build. Their names alone do not establish what data they send.

### Assessment

**This is an ad-revenue-first setup, and that is bad for players.** The shipped SDK surface is built around configurable interstitial frequency and multiple ad formats; the CPM-based replacement setting expressly allows ad yield to override the format the player was expecting. The SDK also exposes a two-full-screen-ad sequence. That is a concrete, evidence-backed criticism of the monetization design.

The static decompilation does not provide active remote-config values or a recorded session. It therefore does not establish that CPM replacement or back-to-back ads were enabled in the observed build, or the exact number of ads a player saw. State those facts accurately: the capability and settings are present; runtime frequency was not measured.

## C. Analytics, identifiers and privacy

### Evidence

- `Cpp2IL-wynik-arm64/DiffableCs/VoodooSauce/Voodoo/Sauce/Internal/Analytics/VoodooAnalyticsEventParameters.cs`, lines 15–32 and 51–105: declares fields/getters for developer device ID, first-launch date, mediation, A/B/segmentation UUIDs, gaming ID, advertising ID, IDFA status, user ID, game count, current level, model, OS, locale, install store, screen resolution and ad/analytics consent.
- `.../SharedAnalyticsParametersProvider.cs`, lines 8–38: declares getters for analytics IDs, device/connectivity parameters and segmentation/A-B identifiers.
- `.../SharedAnalyticsEventPersister.cs`, lines 3–11: contains `https://vs-api.voodoo-{0}.io/push-analytics-v2` and a `PersistEvent(...)` declaration.
- `.../AdjustWrapper.cs`, lines 101–108 and 145–157: declares Adjust/ADID handling, consent-aware ID refresh, third-party-sharing API, ad-revenue tracking and event tracking.
- `.../AnalyticsSettings.cs`, lines 9–24: configuration fields for Firebase Analytics, Remote Config, Voodoo Analytics, Adjust, GameAnalytics and Facebook App ID.
- `base/assets/bin/Data/RuntimeInitializeOnLoads.json`: initializer list contains `AdjustSdk.Scripts`.
- `base/assets/UnityServicesProjectConfiguration.json`: lists Unity Analytics, Authentication, Remote Config and Purchasing; the environment label is `production`.
- `.../IAnalyticStorage.cs`: analytics API names counters for ad formats, app launches, game count, level, active days, game results and win rate.

### Assessment

**The build contains a broad analytics/ad-tracking design with advertising and device/user identifiers plus gameplay/ad metrics. That is a substantial privacy concern and deserves criticism.** The decompilation also contains a Voodoo event-persistence endpoint and APIs for Adjust attribution, ad revenue and third-party sharing.

The evidence is static. Most `DiffableCs` methods have empty bodies, so field/API declarations and an endpoint string are not a packet capture. This bundle does not prove that every field was populated or transmitted during a particular session, identify every recipient, or prove a sale of personal data. **Do not label this a proven data sale.** The defensible claim is extensive analytics/ad-tracking capability and third-party SDK integration.

## D. Additional ARMv7 evidence (version 1.18.0 / code 812)

`armeabi-v7a/PROVENANCE.md` records a reproducible `aapt dump badging` comparison: the ARMv7 source set is package `com.QuestLab.DraftWar`, version `1.18.0` / code `812`; the ARM64 source set is the same package at `1.17.1` / code `745`. The ARMv7 manifest requests `AD_ID`, Adjust preinstall, and Android AdServices ID/attribution/topics permissions. A permission request proves the capability was declared, not that an identifier was accessed.

### Daily rewarded-ad mechanics

- `armeabi-v7a/ads-monetization/RvCapsConfig.cs`: declares control constants `2` for store bit-pack ads, `5` for match-result ads, and `1` for daily bit-pack ads, plus mutable fields for those daily caps. `GameConfig.cs` includes an `RvCapsConfig` field.
- `armeabi-v7a/ads-monetization/DailyBitPackAdSlot.cs`, `DailyBitPackContainer.cs`, and `DailyBitpackProfileData.cs`: declare an ad button/row, slot claim progress, `CanClaimAd`, per-day claimed count, and reset timestamps.
- `armeabi-v7a/ads-monetization/ShopProfileData.cs`: persists ads-watched-today counts and the last ad-watch time by item/tag.
- `armeabi-v7a/ads-monetization/ShopManager-ad-excerpt.txt`: declares `ShowRewardedVideo(..., adTag)`, `IncreaseAdsWatchedToday(adTag, ...)`, and ad reward calculation.

**Assessment:** this build explicitly models daily rewarded-ad caps, placement tags, and reward/claim progress. That is not a generic SDK accident; ad views are part of the game's reward and accounting model. The control constants and declarations do not establish the effective remote-configured limit or actual impressions.

### Spending and progression analytics

- `armeabi-v7a/ads-monetization/AnalyticsConfig.cs`: adds Adjust milestone arrays for commander level, ranked matches, ranked league, and cumulative IAP USD; the ARM64 1.17.1 `AnalyticsConfig.cs` does not declare those four arrays.
- `armeabi-v7a/ads-monetization/AdjustMilestoneEvent.cs`: holds serialized event name, threshold, Android token and iOS token.
- `armeabi-v7a/ads-monetization/AnalyticsManager-milestones-excerpt.txt`: declares APIs to establish/log milestones, set cumulative IAP USD and ranked-match counts, and track Adjust milestone events.

**Assessment:** the ARMv7 1.18.0 build is configured structurally to associate Adjust events with player progression and cumulative spending thresholds. This is targeted monetization analytics and a serious privacy concern. The generated method bodies do not establish that a particular user's event was transmitted.

### Bot and ghost matchmaking

- `armeabi-v7a/ai-matchmaking/PlaytestBot.cs` and `PlaytestMatchSettings.cs`: explicitly declare a playtest bot with four randomly selected meta units and `Smartness = 50`. This proves a playtest bot, not live PvP bots.
- `armeabi-v7a/ai-matchmaking/MatchSession.cs` and `MatchMakingState.cs`: declare rated matchmaking, CSV fallback/roll, forced opponents and ghost construction in the 1.18.0 match-session pipeline.
- `armeabi-v7a/ai-matchmaking/NakamaRpcClient-ghost-excerpt.txt`: the rated-match protocol has distinct human and ghost strength/uncertainty/volatility/last-seen fields.
- `armeabi-v7a/raw-isil-arm32/MatchSession_NestedType__TryBuildGhost_d__21.txt`: raw ARM32 disassembly associated with ghost construction; the file says “No ISIL was generated.” It is corroborative machine code, not readable high-level behavior.

**Assessment:** the newer build has explicit bot/ghost machinery and a dedicated playtest bot, alongside rated network matchmaking. None of that supplies a live bot/human ratio.

## E. What evidence would settle the remaining questions

1. **Bot share:** collect a representative, privacy-safe sample of match records and document how human, ghost, fallback and network opponents are distinguished.
2. **Ad frequency:** inspect active build/remote-config values and record repeatable sessions with version, region, consent state and gameplay scenario; count actual impressions.
3. **Data in transit and sale:** capture requests and fields, identify recipients, and compare those transfers against the privacy policy, SDK contracts and any evidence of payment or sale. The current static artifacts do not establish a sale.
