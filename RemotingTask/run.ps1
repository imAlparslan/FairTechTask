$RemotingLibPath = "src/RemotingTask.RemoteObjects/RemotingTask.RemoteObjects.csproj"
$serverExePath = "src/RemotingTask.Server/bin/Debug/RemotingTask.Server.exe"
$FormExePath = "src/RemotingTask.Client/bin/Debug/RemotingTask.Client.exe"
$buildCommand = "dotnet build src\RemotingTask.RemoteObjects\"

# Uzak sunucu objelerinin durduğu clsLib'i derler
Invoke-Expression $buildCommand

# uzak sunucuyu başlatr
Start-Process -FilePath $serverExePath

# Win form uygulamasını başlatır
Start-Process -FilePath $FormExePath