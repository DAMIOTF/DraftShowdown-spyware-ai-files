# ARMv7 / armeabi-v7a evidence

This directory contains selected artifacts from `/home/dmtf/Documents/draftwar/armeabi-v7a`. It is a separate build from the ARM64 source set in `../..`; its package metadata identifies it as version **1.18.0 (versionCode 812)**, versus ARM64 **1.17.1 (versionCode 745)**. See `PROVENANCE.md` for the reproducible metadata comparison.

## What is newly visible in this build

- `RvCapsConfig` defines control-cap constants for three rewarded-ad placements: store bit pack **2**, match-result ad **5**, and daily bit pack **1**. The same class exposes mutable cap fields. Daily bit-pack UI/profile declarations add ad slots, claim progress, claim eligibility and per-day counters.
- `ShopManager` declares rewarded-video display tagged by ad placement and per-tag daily ad-view counters. This is explicit ad-reward accounting, not an inference from a generic ad SDK.
- `AnalyticsConfig` adds Adjust milestone arrays for commander level, ranked matches, ranked league and cumulative IAP USD. `AdjustMilestoneEvent` stores a name, threshold and platform tokens; `AnalyticsManager` declares APIs for setting spend/ranked-match totals and dispatching milestone events. The build is instrumented to segment progression and cumulative spending through Adjust milestones.
- A dedicated `PlaytestBot` is explicitly described as a playtest bot; its settings say it plays four randomly selected meta units. This proves a bot in the playtest feature, not that live opponents are bots.
- `MatchSession` declares rated matchmaking, CSV fallback/roll, forced opponents and ghost construction; `NakamaRpcClient` has separate human/ghost candidate metrics. This proves the client contains both network matchmaking and ghost/bot machinery, not the proportion of either in real matches.

**Assessment:** the newer build strengthens the criticism: daily ad caps and per-ad reward counters are explicit, and Adjust milestones include cumulative IAP USD and competitive progression. This is an ad- and revenue-optimized design with extensive player profiling hooks. It is bad for player trust and privacy.

The evidence is still static. Cpp2IL-generated method bodies are empty; cap constants and schemas do not reveal effective remote values, actual ad impressions, or whether every analytics event was sent. The raw ARM32 file in `raw-isil-arm32/` is included as a low-level corroborating artifact; it is disassembly, and explicitly reports that no ISIL was generated.

## Contents

- `build-metadata/` — ARMv7 binary manifest/resource table and `aapt` package/permission output.
- `ai-matchmaking/` — playtest bot declarations and the 1.18.0 match-session/matchmaking types.
- `ads-monetization/` — daily ad-cap, ad-slot, ad-view accounting, and Adjust milestone declarations/excerpts.
- `raw-isil-arm32/` — one ARM32 disassembly for the ghost-construction async state machine; not high-level IL.

No complete SDK tree, full decompiler output, global metadata file, or SDK verification tokens are included.
