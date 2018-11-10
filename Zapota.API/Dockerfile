FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 65061
EXPOSE 44367

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Zapota.API/Zapota.API.csproj", "Zapota.API/"]
RUN dotnet restore "Zapota.API/Zapota.API.csproj"
COPY . .
WORKDIR "/src/Zapota.API"
RUN dotnet build "Zapota.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Zapota.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Zapota.API.dll"]