#!/usr/bin/env bash
set -euo pipefail

# Manual OpenAPI source based on Microsoft Learn MAI image generation docs:
# https://learn.microsoft.com/en-us/azure/foundry/foundry-models/how-to/use-foundry-models-mai

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace MicrosoftFoundry \
  --clientClassName MicrosoftFoundryClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:api-key \
  --exclude-deprecated-operations
