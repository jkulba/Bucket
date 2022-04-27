# Project Bucket Setup

## Bucket Web API
The Bucket project 

### Generate new project on GitHub.com



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