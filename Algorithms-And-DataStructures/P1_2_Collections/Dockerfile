FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["P1_2_Collections/P1_2_Collections.csproj", "P1_2_Collections/"]
RUN dotnet restore "P1_2_Collections/P1_2_Collections.csproj"
COPY . .
WORKDIR "/src/P1_2_Collections"
RUN dotnet build "P1_2_Collections.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "P1_2_Collections.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "P1_2_Collections.dll"]
