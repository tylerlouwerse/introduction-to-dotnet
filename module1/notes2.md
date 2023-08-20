# Module 1: .NET Core Architecture and .NET CLI

### What is .NET CLI?
- A cross platform tool for creating, resoring, building, and publishing .NET applications
- It supports installation of packages
- It supports commands that can create, build and run .NET Core projects
- It can be easily automated and integrated into build and deployment pipelines

To verify it is installed type:

`dotnet --version`

To get the list of all commands type:

`dotnet --help`

## .NET Core Platform
Consists of:
- **CLI Tools**: A set of tooling for development and deployment
- **Roslyn**: Language Compiler for C# and Visual Basic
- **CoreFX**: Set of framework libraries
- **CoreCLR**: A JIT based CLR (Command Language Runtime)

### .NET Core Language Compilers
- The comilers included in .NET Core are responsible for translating code
- Translates code written in C#, F#, and Visual Basic into Intermediate Language (IL) code
- IL is a low-level language that can be executed by the .NET runtime
- Roslyn language compiler is used for C# and Visual Basic
- F# Compiler (fsc.exe) is used to compile F# code

### .NET Core CLR
- CoreCLR is the .NET runtime (i.e. the execution engine) used in .NET Core
- It is responsible for compiling and executing .NET Core applications
- Provides features like garbage collection, just-in-time compilation, and exection handling
- One of the benefits of CoreCLR is its performance
- It is optimized for modern hardware
- It is lightweight and modular, it uses less resources than the full .NET framework

### .NET CoreFX
- CoreFX is foundation set of libraries that provides functionality to .NET Core applications
- It provides a wide range of libraries
- Those libraries provides functionality such as file I/O, networking, and collections
- It is modular so that developers can choose the libraries that are needed for the application

## Further Reading

- [Introduction to .NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/)
- [.NET CLI Commands](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet?source=recommendations)
- [The .NET Core Platform](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet?source=recommendations)
- [Building a basic .NET Core console application](https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0)