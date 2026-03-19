# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Hugging Face](https://huggingface.co/) Serverless Inference API, auto-generated from the HuggingFace OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Includes hand-written extensions for Microsoft.Extensions.AI `IChatClient` integration. Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build HuggingFace.slnx

# Build for release (also produces NuGet package)
dotnet build HuggingFace.slnx -c Release

# Run integration tests (requires HUGGINGFACE_API_KEY env var)
dotnet test src/tests/HuggingFace.IntegrationTests/HuggingFace.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/HuggingFace && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `Generated/` is **auto-generated** — do not manually edit files in `src/libs/HuggingFace/Generated/`.

1. `src/libs/HuggingFace/openapi.yaml` — the HuggingFace OpenAPI spec
3. `src/libs/HuggingFace/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Hand-Written Extensions

These files are **not** auto-generated and can be edited manually:

- `src/libs/HuggingFace/Extensions/HuggingFaceApi.ChatClient.cs` — Microsoft.Extensions.AI `IChatClient` implementation
- `src/libs/HuggingFace/Extensions/StringExtensions.cs` — String utility extensions

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/HuggingFace/` | Main SDK library (`HuggingFaceClient`) |
| `src/tests/HuggingFace.IntegrationTests/` | Integration tests against real HuggingFace API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Dependencies:** `Microsoft.Bcl.AsyncInterfaces`, `Microsoft.Extensions.AI.Abstractions`
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
