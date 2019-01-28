#!/usr/bin/env bash

#exit if any command fails
set -e

dotnet restore

dotnet build ./src/Voucherify/Voucherify.csproj -c Release -f net20
dotnet build ./src/Voucherify/Voucherify.csproj -c Release -f net35
dotnet build ./src/Voucherify/Voucherify.csproj -c Release -f net40
dotnet build ./src/Voucherify/Voucherify.csproj -c Release -f net451
dotnet build ./src/Voucherify/Voucherify.csproj -c Release -f netstandard20

dotnet build ./src/Voucherify/Voucherify.Client.csproj -c Release -f net20
dotnet build ./src/Voucherify/Voucherify.Client.csproj -c Release -f net35
dotnet build ./src/Voucherify/Voucherify.Client.csproj -c Release -f net40
dotnet build ./src/Voucherify/Voucherify.Client.csproj -c Release -f net451
dotnet build ./src/Voucherify/Voucherify.Client.csproj -c Release -f netstandard20
