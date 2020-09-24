FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY simple-crud-microsservice/simple-crud-microsservice.csproj simple-crud-microsservice/
RUN dotnet restore simple-crud-microsservice/simple-crud-microsservice.csproj
COPY . .
WORKDIR /src/simple-crud-microsservice
RUN dotnet build simple-crud-microsservice.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish simple-crud-microsservice.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "simple-crud-microsservice.dll"]
