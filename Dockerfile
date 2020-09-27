FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["RunnerCode/RunnerCode.csproj", "RunnerCode/"]
RUN dotnet restore "RunnerCode/RunnerCode.csproj"
COPY . .
WORKDIR "/src/RunnerCode"
RUN dotnet build "RunnerCode.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RunnerCode.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RunnerCode.dll"]
