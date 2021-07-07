#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SignalRCoreContainerTest.Server/SignalRCoreContainerTest.Server.csproj", "SignalRCoreContainerTest.Server/"]
COPY ["SignalRCoreContainerTest.Lib/SignalRCoreContainerTest.Lib.csproj", "SignalRCoreContainerTest.Lib/"]
RUN dotnet restore "SignalRCoreContainerTest.Server/SignalRCoreContainerTest.Server.csproj"
COPY . .
WORKDIR "/src/SignalRCoreContainerTest.Server"
RUN dotnet build "SignalRCoreContainerTest.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SignalRCoreContainerTest.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SignalRCoreContainerTest.Server.dll"]