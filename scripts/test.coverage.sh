#!/bin/bash
set -euo pipefail

SCRIPT_ROOT="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

echo "!!WARNING!! This script generates test coverage file and runs tests for netstandard and netcoreapp targets"

dotnet test -c Release /p:CollectCoverage=true \
/p:Exclude="[xunit.*]*" \
/p:CoverletOutputFormat=lcov /p:CoverletOutput="${SCRIPT_ROOT}/../lcov" \
"${SCRIPT_ROOT}/../test"