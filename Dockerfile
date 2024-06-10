FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /BTCWebWallet

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

ENV RPC__HOST="127.0.0.1"
ENV RPC__PORT=1433
ENV RPC__USER=test
ENV RPC__PWD=pwd

WORKDIR /App
COPY --from=build-env /BTCWebWallet/out .
ENTRYPOINT ["dotnet", "BTCWebWallet.dll"]