# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./Kulba.Service.Bucket/Kulba.Service.Bucket.csproj" --disable-parallel
RUN dotnet publish "./Kulba.Service.Bucket/Kulba.Service.Bucket.csproj" -c Release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000

ENTRYPOINT [ "dotnet", "Kulba.Service.Bucket.dll" ]