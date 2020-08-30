FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["LMSRestFullWebAPI/LMSRestFullWebAPI.csproj", "LMSRestFullWebAPI/"]
RUN dotnet restore "LMSRestFullWebAPI/LMSRestFullWebAPI.csproj"
COPY . .
WORKDIR "/src/LMSRestFullWebAPI"
RUN dotnet build "LMSRestFullWebAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LMSRestFullWebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LMSRestFullWebAPI.dll"]