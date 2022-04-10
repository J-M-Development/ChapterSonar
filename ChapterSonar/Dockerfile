#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ChapterSonar/ChapterSonar.csproj", "ChapterSonar/"]
RUN dotnet restore "ChapterSonar/ChapterSonar.csproj"
COPY . .
WORKDIR "/src/ChapterSonar"
RUN dotnet build "ChapterSonar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChapterSonar.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChapterSonar.dll"]