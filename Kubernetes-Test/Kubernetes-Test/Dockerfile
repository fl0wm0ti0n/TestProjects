FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Kubernetes-Test/Kubernetes_Test.csproj", "Kubernetes-Test/"]

RUN dotnet restore "Kubernetes-Test/Kubernetes_Test.csproj"
COPY . .
WORKDIR "/src/Kubernetes-Test"
RUN dotnet build "Kubernetes_Test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kubernetes_Test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kubernetes_Test.dll"]