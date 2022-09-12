FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5192
ENV ASPNETCORE_URLS=http://+:5192


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "RS2Seminarski.WebAPI/RS2Seminarski.WebAPI.csproj" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ADD ./RS2Seminarski.WebAPI/SeedFiles/Images/Exercises ./SeedFiles/Images/Exercises

ENTRYPOINT ["dotnet", "RS2Seminarski.WebAPI.dll"] 