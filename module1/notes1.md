# Module 1: Introduction to .NET Development

### What is .NET core?
- .NET Core is a free open-source, cross platform that runs on Windows, MacOS and Linux OS
- .NET fully supports C# and F# and supports Visual Basic .NET
- It is a subset of the larger .NET Framework
- It was introduced by Microsoft in 2016 as a successor to the .NET Framework
- .NET Core is written from scratch to make it modular, lightweight, and fast
- It has core features that are required to run a basic .NET Core app
- It also includes rich set of APIs and framework, such as ASP.NET Core for building web applications

### Why use .NET Core?
- Cross platform: Easier for developers to create applications that can be used on multiple platforms
- Performance: It is built with performance in mind
- Coud-ready: Designed to work in cloud environments
- Modern Development: Provides developers with modern tools and techniques

### Features of .NET Core
Open Source
Cross Platfrom
Modular Architecture
Supports Multiple Languages
Consistent
CLI Tools
Flexible Deployment
Compatibility


## Version history

#### Supported Versions
- .NET 7 - End of Support May 14, 2024
- .NET 6 - End of Support Nov 12, 2024

#### Unsupported Versions:
- .NET 5, 3.1 3.0, 2.2, 2.1, 2.0, 1.1, 1.0

Net Core 1.0 was released on June 27, 2016 along with Microsoft Visual Studio 2015 which enables .NET Core development

.NET Core 2.0 was released on August 14, 2017


## What's the difference between .NET framework and .NET core?
| Based On | .NET Core | .NET Framework |
|-|-|-|
| Open Source | .NET Core is open source | Certain components are open source |
| Cross-Platform | Compatible with Windows, Linux, and MacOS | Compatible with Windows OS |
| Application Models | Does not support desktop applications | Supports desktop and web applications |
| Performance | Offers high performance and scalability | Less effective in comparison to .NET Core |
| Security | Does not have features like Code Access Security | Code access security feature is present |


## What is ASP.NET Core?
- ASP.NET Core is a free and open source web framework and successor to ASP.NET, developed by Microsoft. It is a modular framework that runs on both the full .NET Framework, on Windows, and cross platform.
- A unified framework for building web UI and web APIs
- It has build in dependency injection
- Perfectly suited for Docker containers
- It has built in support for SPA with client-side frameworks like Angular, React, Vue

### Features of ASP.NET Core
- Cross Platform Support
- High Performance
- Less Code
- Easy Maintenance
- Cloud Based Application Development Support

### What's the difference between ASP.NET and ASP.NET Core applications?
ASP.NET Core and ASP.NET Framework are both server-side web-application frameworks developed by midcrosoft for software development. .NET Core is essentially a new version of .NET Framework. 


| Domain | ASP.NET | ASP.NET Core |
|-|-|-|
| Platform Support | ASP.NET is build for Windows | ASP.NET Core runs on Windows, Mac, and Linux |
| Architecture | Based on .NET Framework | Based on .NET Core |
| Dependencies | Less control over dependencies | Strict control over dependencies |
| File Support | WCF, WF, WPF, VB, Web Config, and more | No support for global.asaz, Web config |
| Components | WebForms, MVC and Web API | MVC, WebAPI, Razor Pages, and Blazor |
| Visual Studio | Support of all versions | Support of latest versions from 2015 |


## ASP.NET Core Project Folder Structure
- The details of the default project can be seen in the solution explorer
- It displays all the projects related to a single solution
- Project folder structure is organized in a hierarchical manner
- Each level representing a different aspect of the application

### .csproj
- not supported by the inital versions of ASP.NET Core
- by clicking on it you can enable the property settins and change the target framework and some implicit settings

### launchSettings.json
- Includes visible setting profiles and debug settings

### /dependencies
- Whenever you use NuGet package to add any third party dependencies a specific dependencies folder will be generated

### /wwwroot
- Includes static files or folders to be used in other applications such as CSS, Javascript, any Bootstrap or Javascript libraries, along with some images if you wanted to use them

### /Pages
- Holds Razor pages (see later notes)


## How can I set up a development environment?

1. Check for .NET CLI Install

`dotnet --version`

2. Find your project type

`dotnet new list`

Common examples include console, webapp

3. Generate a project

`dotnet new {project_type} -n {project_name}`

