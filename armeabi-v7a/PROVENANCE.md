# ARMv7 build provenance and comparison

## Build identity

The included ARMv7 `build-metadata/AndroidManifest.xml` and `resources.arsc` were parsed with `aapt dump badging` after placing the two files in a temporary ZIP/APK container. The output identifies:

- package: `com.QuestLab.DraftWar` (Draft Showdown)
- version name/code: `1.18.0` / `812`
- target SDK: `36`
- requested permissions include `com.google.android.gms.permission.AD_ID`, `com.adjust.preinstall.READ_PERMISSION`, `android.permission.ACCESS_ADSERVICES_AD_ID`, `android.permission.ACCESS_ADSERVICES_ATTRIBUTION`, and `android.permission.ACCESS_ADSERVICES_TOPICS`.

The same procedure on `/home/dmtf/Documents/draftwar/arm64/base/AndroidManifest.xml` plus `resources.arsc` identifies the ARM64 source set as version `1.17.1` / `745`, with the same package and target SDK. Thus the ARMv7 source set is a newer app build, not merely a second-architecture copy of the ARM64 tree.

`build-metadata/aapt-badging.txt` records the relevant output and permissions. The Android permissions establish that the package requests access to advertising-ID/attribution-related APIs; they do not establish that every identifier was read or sent.

## Source material and limits

- Application declarations: `Cpp2IL-wynik-cs/DiffableCs/` under the original ARMv7 source root.
- Raw machine-code artifact: `Cpp2IL-wynik-isil/IsilDump/Scripts/QuestLab/DraftWar/MatchSession_NestedType__TryBuildGhost_d__21.txt`.
- Most C# method bodies are empty Cpp2IL stubs. Use these files to verify types, fields, constants, tooltips, and API names, not as proof that each method ran.
- The included raw ARM32 artifact is AArch32 disassembly for the async `TryBuildGhost` state machine; it explicitly says “No ISIL was generated.” It is retained because the user requested low-level IL/disassembly artifacts, but it is less readable than the ARM64 IL in the parent packet.

## Reproduce the build identity

For the extracted ARMv7 files:

```sh
zip -j /tmp/armv7-meta.apk /path/to/armeabi-v7a/base/AndroidManifest.xml /path/to/armeabi-v7a/base/resources.arsc
aapt dump badging /tmp/armv7-meta.apk
```

Use the corresponding `arm64/base/` files to verify version `1.17.1` / `745`.
