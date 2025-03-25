# Użycie obrazu bazowego
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etap budowania
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Skopiowanie plików .csproj
COPY MarvelComicsApi/MarvelComicsApi.csproj MarvelComicsApi/

# Przywracanie zależności
RUN dotnet restore MarvelComicsApi/MarvelComicsApi.csproj

# Skopiowanie reszty kodu źródłowego
COPY . .

# Budowanie API
WORKDIR /src/MarvelComicsApi
RUN dotnet build MarvelComicsApi.csproj -c $BUILD_CONFIGURATION -o /app/build

# Publikowanie projektu
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish MarvelComicsApi.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Finalny obraz
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Punkt wejścia
ENTRYPOINT ["dotnet", "MarvelComicsApi.dll"]
