FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["LMS.WEB.Portal/LMS.WEB.Portal.csproj", "LMS.WEB.Portal/"]
RUN dotnet restore "LMS.WEB.Portal/LMS.WEB.Portal.csproj"
COPY . .
WORKDIR "/src/LMS.WEB.Portal"
RUN dotnet build "LMS.WEB.Portal.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LMS.WEB.Portal.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LMS.WEB.Portal.dll"]