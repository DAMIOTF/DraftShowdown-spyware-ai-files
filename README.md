# DraftShowdown: evidence packet

This packet collects selected artifacts from the ARM64 and ARMv7 decompilations in `../arm64` and `../armeabi-v7a`. It is a focused evidence bundle, not a complete APK dump or an independent runtime audit. Original inputs were not modified.

## The blunt assessment

**The build contains bot-controlled opponents, an extensive ad/analytics stack, and monetization settings that explicitly optimize ad delivery around frequency and CPM. That is a bad, player-hostile design.** In particular, Voodoo settings expose controls for interstitial timing/game counts and an option to replace a rewarded ad with an interstitial when the interstitial CPM is higher. The analytics schema includes advertising/device/user identifiers and gameplay metrics, and the decompilation contains a Voodoo analytics endpoint. Those are serious privacy and trust concerns.

## What the artifacts establish

- The game has `AiOpponentPlayer` and a `GhostOpponentBuilder` path; the AI selects draft cards using scoring/weighting logic and an `aiSmartness` value. The binary also contains local-opponent generation and network rated-matchmaking types.
- The shipped code/dependencies include Google Mobile Ads, Firebase Analytics, Adjust/Voodoo analytics APIs, Google advertising-ID support, and 16 AppLovin MAX mediation adapter manifests.
- The ad SDK exposes configurable time/game thresholds for interstitials, app-open and rewarded-ad interactions. It contains an API for two full-screen ads in a row. The settings include CPM-based rewarded-to-interstitial replacement.
- Analytics declarations include fields/getters for advertising ID, developer device ID, gaming/user IDs, device properties, A/B cohorts, game count, current level and ad/analytics consent. A Voodoo event-persistence endpoint is present in the decompilation.
- The separate ARMv7 1.18.0 build adds daily rewarded-ad cap controls/accounting and Adjust milestone schemas for ranked progression and cumulative IAP USD. This is direct evidence of ad-reward tracking and spending/progression analytics hooks.

## Claims these files do not establish

**They do not prove that most matches are against bots.** Bot and ghost opponents are real code paths, but network opponents and rated matchmaking are present too; this packet contains no population statistics or representative live-match sample.

**They do not prove that player data is sold.** They show analytics/ad identifiers, event schemas, integration APIs and an endpoint—not a sale, a payment, or a contract authorizing sale.

**They do not establish an exact number of ads per match or minute.** The SDK has frequency controls and aggressive monetization capabilities, but the runtime values/configuration and observed ad counts are not included here.

These boundaries are not excuses for the design. They are the line between a forceful, evidence-backed criticism and an unsupported accusation. Do not claim “most players are bots” or “they sell your data” from this packet alone.

## Contents

- `ai/` — AI/ghost and local-vs-network opponent evidence, including selected IL/ASM excerpts.
- `ads-and-analytics/` — ad frequency/CPM settings, analytics fields/endpoint, SDK metadata and adapter inventory.
- `armeabi-v7a/` — separate ARMv7 evidence directory; see its README for provenance and architecture-specific notes.
- `FINDINGS.md` — detailed findings, source paths, line references and interpretation.
- `SHA256SUMS` — hashes for copied evidence files. The prose indexes and checksum file itself are excluded.

## Reading the decompilation

The `DiffableCs` files are Cpp2IL-generated declarations; empty method bodies mean the decompiler did not reconstruct the implementation. Use them for class/field/API names, not as proof that every method ran. The IL and AArch64 assembly excerpts provide lower-level evidence for the bot draft logic. For claims about actual transmitted data, actual bot share, or ad frequency, this static packet must be supplemented with runtime traffic/match measurements.
