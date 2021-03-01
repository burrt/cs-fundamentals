#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Fundamentals.Cmd/Fundamentals.Cmd.csproj", "Fundamentals.Cmd/"]
COPY ["Sorts/Sort.csproj", "Sorts/"]
COPY ["Fundamentals/Fundamentals.csproj", "Fundamentals/"]
RUN dotnet restore "Fundamentals.Cmd/Fundamentals.Cmd.csproj"
COPY . .
WORKDIR "/src/Fundamentals.Cmd"
RUN dotnet build "Fundamentals.Cmd.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fundamentals.Cmd.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fundamentals.Cmd.dll"]