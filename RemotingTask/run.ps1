$RemotingLibPath = "src/RemotingTask.RemoteObjects/RemotingTask.RemoteObjects.csproj"
$serverExePath = "src/RemotingTask.Server/bin/Debug/RemotingTask.Server.exe"
$FormExePath = "src/RemotingTask.Client/bin/Debug/RemotingTask.Client.exe"
$buildRemoteObjectCommand = "dotnet build src\RemotingTask.RemoteObjects\"
$buildClientCommand = "dotnet build src\RemotingTask.Client\"
$buildServerCommand = "dotnet build src\RemotingTask.Server\"


# Projeleri derler
Invoke-Expression $buildRemoteObjectCommand
Invoke-Expression $buildServerCommand
Invoke-Expression $buildClientCommand

# uzak sunucuyu başlatr
Start-Process -FilePath $serverExePath

# Win form uygulamasını başlatır
Start-Process -FilePath $FormExePath