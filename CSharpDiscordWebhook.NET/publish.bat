@echo off
set root_path=%cd%

del /F /Q bin\Release\*.nupkg

dotnet pack CSharpDiscordWebhook.NET.csproj -c Release
dotnet nuget push bin\Release\*.nupkg --api-key %NUGET_API_KEY% --source https://api.nuget.org/v3/index.json --skip-duplicate

del /F /Q bin\Release\*.nupkg
pause

