#!/bin/bash
set -euo pipefail

SCRIPT_ROOT="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

dotnet test -c Release /p:CollectCoverage=true \
/p:Exclude="[xunit.*]*" \
/p:CoverletOutputFormat=lcov /p:CoverletOutput="${SCRIPT_ROOT}/../lcov" \
"${SCRIPT_ROOT}/../test"