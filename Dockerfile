FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

# Copy the source code
COPY ./src ./src

# Run the tests with detailed logging and check the results
CMD dotnet test src/Voucherify.Test/Voucherify.Test.csproj -l "console;verbosity=detailed" | \
    tee test_results.txt && \
    grep -E "failed: 0.*skipped: 0" test_results.txt || (echo "Tests failed or were skipped!" && exit 1)
