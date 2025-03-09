dotnet restore ./tests/Demo.Benchmarks/Demo.Benchmarks.csproj
dotnet build --no-restore -c Release ./tests/Demo.Benchmarks/Demo.Benchmarks.csproj
dotnet run --project ./tests/Demo.Benchmarks/Demo.Benchmarks.csproj -c Release
