#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SbAdmin2/SbAdmin2.csproj", "SbAdmin2/"]
RUN dotnet restore "SbAdmin2/SbAdmin2.csproj"
COPY . .
WORKDIR "/src/SbAdmin2"
RUN dotnet build "SbAdmin2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SbAdmin2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SbAdmin2.dll"]