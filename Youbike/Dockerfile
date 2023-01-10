FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Youbike/Youbike.csproj", "Youbike/"]
RUN dotnet restore "Youbike/Youbike.csproj"
COPY . .
WORKDIR "/src/Youbike"
RUN dotnet build "Youbike.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Youbike.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Youbike.dll"]
