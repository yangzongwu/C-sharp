//--------------------------EmployeeManagement.csproj------------------------------------------------------------
//右键项目名，edit EmployeeManagement.csproj

<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework>
    <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Razor.Design" Version="2.2.0" PrivateAssets="All" />
  </ItemGroup>
</Project>
//============================================================================================
/*
TargetFrameword
此元素是用于指定应用程序的目标框架，即您希望为应用程序提供的API程序集
>Specifies the target framework for the application
>To sepcify a target frameword we use Target Framework Moniker(TFM)
Name                  Abbreviation      TFM
.NET Frameword        net               net451
                                        net472
.NET Core             netcoreapp        netcoreapp1.0
                                        netcoreapp2.2
                                        
 AspNetCoreHostingModel
 此元素指定应如何托管Asp.Net Core应用程序。它表示程序应该托管InProcess（进程内）还是OutOfProcess（进程外）。
 >Specifies how the application should be hosted
 >InProcess or OutOfProcess
 >InPocess hosts the app inside of the IIS worker process(w3wp.exe)
 >OutOfProcess hosting model forward web requests to a backend ASP.NET Core app running the Kestrel server
 >The default is OutOfProcess hosting

PackageReference
此元素用于包含对为您的应用程序安装的所有NuGet包的引用
Microsoft.AspNetCore.App：此NuGet包称为metapackage。metapackage本身是没有任何的内容的，它只是包含了其他包的依赖信息。
Microsoft.AspNetCore.App里面包含了ASP.NET Core 2.2及更高版本和Entity Framework Core 2.2及更高版本的所有组件。
>Used to Include a reference to the NuGet package that is installed for the application
>Metapackage--Microsoft.AspNetCore.App
>A metapackage has no content of its own
>It just contains a list of dependencies(other packages)
>When the version is not spepcified , an implicit version is specified by the SDK
>Rely on the implicit version rather than explicitly setting the version number on the package reference
*/
