#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CorePortfolioProject/CorePortfolioProject.csproj", "CorePortfolioProject/"]
RUN dotnet restore "CorePortfolioProject/CorePortfolioProject.csproj"
COPY . .
WORKDIR "/src/CorePortfolioProject"
RUN dotnet build "CorePortfolioProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CorePortfolioProject.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CorePortfolioProject.dll"]