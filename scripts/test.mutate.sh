#!/bin/bash
set -euo pipefail

SCRIPT_ROOT="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

echo "!!WARNING!! This script generates test coverage file and runs tests for netstandard and netcoreapp targets"

cd ${SCRIPT_ROOT}/../test
dotnet stryker