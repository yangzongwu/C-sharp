//--------------------------EmployeeManagement.csproj------------------------------------------------------------
右键项目名，edit EmployeeManagement.csproj

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
>Specifies the target framework for the application
>To sepcify a target frameword we use Target Framework Moniker(TFM)
Name                  Abbreviation      TFM
.NET Frameword        net               net451
                                        net472
.NET Core             netcoreapp        netcoreapp1.0
                                        netcoreapp2.2
                                        
 AspNetCoreHostingModel
 >Specifies how the application should be hosted
 >InProcess or OutOfProcess
 >InPocess hosts the app inside of the IIS worker process(w3wp.exe)
 >OutOfProcess hosting model forward web requests to a backend ASP.NET Core app running the Kestrel server
 >The default is OutOfProcess hosting

PackageReference
>Used to Include a reference to the NuGet package that is installed for the application
>Metapackage--Microsoft.AspNetCore.App
>A metapackage has no content of its own
>It just contains a list of dependencies(other packages)
>When the version is not spepcified , an implicit version is specified by the SDK
>Rely on the implicit version rather than explicitly setting the version number on the package reference
*/
