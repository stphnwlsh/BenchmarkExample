FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build

WORKDIR /sln

# Copy Files
COPY . .

# Dotnet Restore
RUN dotnet restore -v minimal

# Dotnet Build
RUN dotnet build --no-restore -c Release -v minimal

# Dotnet Run
CMD dotnet run --project ./BenchmarkApp/BenchmarkApp.csproj --no-build -c Release
