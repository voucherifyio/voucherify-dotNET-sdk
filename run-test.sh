dotnet restore ./src/Tests/Voucherify.Tests.csproj
dotnet build -c Release ./src/Tests/Voucherify.Tests.csproj
dotnet test -c Release ./src/Tests/Voucherify.Tests.csproj