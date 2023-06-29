FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BlazorApp7/BlazorApp7.csproj", "BlazorApp7/"]
RUN dotnet restore "BlazorApp7/BlazorApp7.csproj"
COPY . .
WORKDIR "/src/BlazorApp7"
RUN dotnet build "BlazorApp7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorApp7.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorApp7.dll"]
