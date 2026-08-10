FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

# Copy the source code
COPY ./src ./src

# Run the tests with detailed logging and propagate dotnet test's exit code.
CMD ["dotnet", "test", "src/Voucherify.Test/Voucherify.Test.csproj", "-l", "console;verbosity=detailed"]
