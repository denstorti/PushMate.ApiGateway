FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 14998
EXPOSE 44333

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY PushMate.ApiGateway/PushMate.ApiGateway.csproj PushMate.ApiGateway/
RUN dotnet restore PushMate.ApiGateway/PushMate.ApiGateway.csproj
COPY . .
WORKDIR /src/PushMate.ApiGateway
RUN dotnet build PushMate.ApiGateway.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PushMate.ApiGateway.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PushMate.ApiGateway.dll"]
