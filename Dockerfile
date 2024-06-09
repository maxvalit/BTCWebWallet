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

ARG BTCRPC_HOST
ARG BTCRPC_PORT
ARG BTCRPC_USER
ARG BTCRPC_PWD

WORKDIR /App
COPY --from=build-env /BTCWebWallet .
ENTRYPOINT ["dotnet", "BTCWebWallet.dll"]