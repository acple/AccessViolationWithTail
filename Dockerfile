FROM mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview8-alpine
WORKDIR /build
COPY . .
RUN dotnet test -c Release

