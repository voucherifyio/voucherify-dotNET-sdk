# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build & Test Commands
- Build solution: `dotnet build -c Release`
- Run all tests: `dotnet test -c Release`
- Run specific test: `dotnet test --filter "FullyQualifiedName=Voucherify.Test.TestClassName.TestMethodName"`
- Create NuGet package: `dotnet pack ./src/Voucherify/Voucherify.csproj -c Release`

## Code Style Guidelines
- Use C# conventions with PascalCase for classes, methods, properties
- Use camelCase for local variables and parameters
- Include XML comments for public APIs
- Target multiple frameworks: netstandard2.0/2.1, net48, net8.0, net9.0
- Dependencies: Newtonsoft.Json for serialization, RestSharp for HTTP requests
- Use nullable reference types with `annotations` setting
- Handle HTTP errors using appropriate exception handling
- Follow async/await patterns for asynchronous operations
- Follow RESTful API client patterns from the Voucherify SDK
- Use explicit types rather than var when type isn't obvious from assignment