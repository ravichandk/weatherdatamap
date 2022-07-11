# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY WeatherApp/*.csproj ./WeatherApp/
COPY Infrastructure/*.csproj ./Infrastructure/
COPY Models/*.csproj ./Models/
COPY Services.Impl/*.csproj ./Services.Impl/
COPY WeatherServicesTests/*.csproj ./WeatherServicesTests/
RUN dotnet restore 

# copy everything else and build app
COPY WeatherApp/. ./WeatherApp/
COPY Infrastructure/. ./Infrastructure/
COPY Models/. ./Models/
COPY Services.Impl/. ./Services.Impl/
COPY WeatherServicesTests/. ./WeatherServicesTests/
WORKDIR /source/WeatherApp
RUN dotnet publish -c release -o /app 

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "WeatherApp.dll"]
