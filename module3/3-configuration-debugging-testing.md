# Module 3: Configuration, Debugging, and Testing in .NET Core

### Exceiption Handling Mechanisms
- Exeception Handling is one of the most important tasks in the application development cycle

#### Try-Catch Block
- The try block contains the code that may throw an exception and the catch block catches the exception and provides a way to handle it
- The finally block is optional and contains code that will be executed regardless

#### Global Exception Handling with Custom Middleware
- This is a good an effective approach to handling the exepction global level
- We could be caught all unhandled exception using this exception handler
- The benefit of using this approach is we can catch all exception in one place
- In this case we need to create custom middlewares

## Targeting Multiple Frameworks
- When you create a project it is recommended that you create a .NET standard class library as it provides compatibility with the wides range of consuming projects
- By using .NET Standard, you add cross platform support to a .NET library by default
- However, in some scenarios, you may need to include code that targets a particular framework


## Code Sharing
- Code sharing refers to the ability to reuse code across different projects and platforms
- This is achieved by creating libraries that can be shared between different applications rather than duplicating code in each projects

- Class Libraries
  - These are a collection of classes that can be compiled into a single assembly
  - These assemblies can be shared between .NET Core projects, allowing for code reuse.

- NuGet Packages
  - It is a package manager for .NET and allows developers to share and reuse code in the form of packages
- Portable Class Libraries (PCL)
  - PCL are the type of class libraries that can be compiled into single assembly
  - It can be shared between different .NET Platforms
- .NET Standard Libraries
  - .NET standard libraries is a set of APIs that are common across all .NET platforms
  - By targeting .NET standard, developers can share libraries across different .NET platforms

  ## Further Reading
  - [Exception Handling Mechanisms](https://www.tutorialspoint.com/asp.net/asp.net_error_handling.htm)
  - [Targetting Multiple Frameworks](https://learn.microsoft.com/en-us/nuget/create-packages/multiple-target-frameworks-project-file)
  - [Code Sharing](https://learn.microsoft.com/en-us/nuget/create-packages/multiple-target-frameworks-project-file)
  - [Debugging and Testing .NET Core Applications](https://learn.microsoft.com/en-us/visualstudio/debugger/quickstart-debug-aspnet?view=vs-2022)
