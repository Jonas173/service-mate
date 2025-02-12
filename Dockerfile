FROM ubuntu/dotnet-aspnet:8.0-24.04_stable AS build

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o build

FROM ubuntu/dotnet-aspnet:8.0-24.04_stable

WORKDIR /app
EXPOSE 80
COPY --from=build /app/build .

ENTRYPOINT ["dotnet", "service-mate.dll"]