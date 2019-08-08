FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Friends.API/Friends.API.csproj", "Friends.API/"]
RUN dotnet restore "Friends.API/Friends.API.csproj"
COPY . .
WORKDIR "/src/Friends.API"
RUN dotnet build "Friends.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Friends.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Friends.API.dll"]
