#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Manual OpenAPI source based on Microsoft Learn MAI image generation docs:
# https://learn.microsoft.com/en-us/azure/foundry/foundry-models/how-to/use-foundry-models-mai
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace MicrosoftFoundry \
  --clientClassName MicrosoftFoundryClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:api-key \
  --exclude-deprecated-operations
