# Project Bucket Setup

## Bucket Web API
The Bucket project 

### Generate new project on GitHub.com
I created a new project in GitHub.com and added a simple README.md.  I then cloned to my local dev machine to add the new project.

### Map SSH key to 
```shell
git config core.sshCommand "ssh -i ~/.ssh/id_ed25519"
```

```shell
dotnet new webapi -o Kulba.Service.Bucket
```

```shell
dotnet new xunit -o Kulba.Service.Bucket.Tests
```
### Add build file
I primarily use VSCode as my development environment.  A useful convention is to include a build.proj file that is used to reference all projects during build and run time.
```xml
<Project Sdk="Microsoft.Build.Traversal/3.1.6">
    <ItemGroup>
        <ProjectReference Include="**\*.*proj" />
    </ItemGroup>
</Project>
```
### Add global.json file
My development machines usually have multiple DotNet SDK versions.  A good convention for DotNet projects is to include a global.json file and set the expected version of the DotNet SDK.
```json
{
  "sdk": {
    "version": "6.0.202",
    "rollForward": "latestPatch"
  }
}
```
### Add editorconfig
Use the dotnet-cli to generate a new editor config file so that the source code can be formatted. The result of the following command generates a new editorconfig file.
```shell
dotnet new editorconfig
```
In order to manually format the code using the editorconfig, execute the following command in the root of the project.
```shell
dotnet format
```

### Dependencies
dotnet add package Serilog.AspNetCore
dotnet add package Serilog.Enrichers.Context
dotnet add package Serilog.Enrichers.Environment
dotnet add package Serilog.Enrichers.ExceptionData
dotnet add package Serilog.Enrichers.Thread
dotnet add package Serilog.Extensions.Hosting
dotnet add package Serilog.Settings.Configuration
dotnet add package Serilog.Sinks.Async
dotnet add package Serilog.Sinks.Console
dotnet add package Serilog.Sinks.Debug
dotnet add package Serilog.Sinks.File
dotnet add package Serilog.Sinks.Seq

dotnet add package Microsoft.Extensions.Hosting
dotnet add package Microsoft.Extensions.Hosting.WindowsServices
dotnet add package Microsoft.Extensions.Hosting.Systemd
dotnet add package Microsoft.Extensions.Http