dotnet restore ./src/Voucherify/Voucherify.Client.csproj
dotnet build -c Release ./src/Voucherify/Voucherify.Client.csproj
dotnet pack -c Release ./src/Voucherify/Voucherify.Client.csproj

dotnet restore ./src/Voucherify/Voucherify.csproj
dotnet build -c Release ./src/Voucherify/Voucherify.csproj
dotnet pack -c Release ./src/Voucherify/Voucherify.csproj
