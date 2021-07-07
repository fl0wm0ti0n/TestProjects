#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SignalRCoreContainerTest.ConsoleTestTwo/SignalRCoreContainerTest.ConsoleTestTwo.csproj", "SignalRCoreContainerTest.ConsoleTestTwo/"]
COPY ["SignalRCoreContainerTest.Lib/SignalRCoreContainerTest.Lib.csproj", "SignalRCoreContainerTest.Lib/"]
RUN dotnet restore "SignalRCoreContainerTest.ConsoleTestTwo/SignalRCoreContainerTest.ConsoleTestTwo.csproj"
COPY . .
WORKDIR "/src/SignalRCoreContainerTest.ConsoleTestTwo"
RUN dotnet build "SignalRCoreContainerTest.ConsoleTestTwo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SignalRCoreContainerTest.ConsoleTestTwo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SignalRCoreContainerTest.ConsoleTestTwo.dll"]