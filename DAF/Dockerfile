FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY DAF.Web.csproj DAF/
RUN dotnet restore DAF.Web.csproj
COPY . .
WORKDIR /src/DAF
RUN dotnet build DAF.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DAF.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DAF.Web.dll"]
