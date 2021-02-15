# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./Sorts/*.csproj ./Sorts/
COPY ./Fundamentals/*.csproj ./Fundamentals/
COPY ./Fundamentals.Tests/*.csproj ./Fundamentals.Tests/
COPY ./Fundamentals.Cmd/*.csproj ./Fundamentals.Cmd/
RUN ls
RUN dotnet restore Fundamentals.sln

# copy everything else and build app
COPY Sorts/. ./Sorts/
COPY Fundamentals/. ./Fundamentals/
COPY Fundamentals.Tests/. ./Fundamentals.Tests/
COPY Fundamentals.Cmd/. ./Fundamentals.Cmd/
WORKDIR /source/Fundamentals.Cmd
RUN dotnet publish -c Debug -o /app --no-restore

# final stage/image
FROM build AS final
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Fundamentals.Cmd.dll"]
