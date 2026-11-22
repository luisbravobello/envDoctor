# Contexto de build: raíz del repositorio
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source
COPY global.json Directory.Build.props .editorconfig ./
COPY src/ src/
RUN dotnet restore src/EnvDoctor.Api/EnvDoctor.Api.csproj
RUN dotnet publish src/EnvDoctor.Api/EnvDoctor.Api.csproj -c Release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
COPY --from=build /app .
USER app
ENTRYPOINT ["dotnet", "EnvDoctor.Api.dll"]
