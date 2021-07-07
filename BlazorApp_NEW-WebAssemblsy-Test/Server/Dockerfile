#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Server/BlazorApp_NEW-WebAssemblsy-Test.Server.csproj", "Server/"]
COPY ["Shared/BlazorApp_NEW-WebAssemblsy-Test.Shared.csproj", "Shared/"]
COPY ["Client/BlazorApp_NEW-WebAssemblsy-Test.Client.csproj", "Client/"]
RUN dotnet restore "Server/BlazorApp_NEW-WebAssemblsy-Test.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "BlazorApp_NEW-WebAssemblsy-Test.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorApp_NEW-WebAssemblsy-Test.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorApp_NEW-WebAssemblsy-Test.Server.dll"]