# Module 3: Dependency Injections and IoC Containers

### ASP.NET Core Environment Variables
- ASP.NET Environment Variables uses the variable called ASPNETCORE_ENVIRONMENT
- It points towrads the runtime environment
- The value of variable can be anything but usually be a Production, Staging, and Development
- The value is case insensitive in Windows an dMac OS bus it is case sensitive on Linux
- The Environment varaiable defines the runtime environment for which the application runs
- They are mainly used to specify Environment application executingm enabling the application to configure it

#### Development
- This process will be used dugint he application development
- While using Visual Studio, the setting will be denoted in project's debug, like IIS Express


#### Staging
- It is Pre-Production Environment used for testing after the application development

#### Production
- The Production Environment is used while the application executes during the live process where the end-user works on it

## Dependency Injection in ASP.NET Core
- DI is used to achieve loosely coupling between objects so that applications can be maintained in an easy manner
- Here, .NET runtime engine automatically injects objects of dependency classes
- It injects mainly through the contructor of the Controllers, thus making the job of the developer much easer
- The concept of DI arises from a principle software design called Dependency Inversion Principle

## Loosely Coupled vs. Tightly Coupled Architecture

### Loosely Coupled Architecture
- In this, components or modules within a system have minimal dependencies on each other
- This means that each component can be easily upgraded without affecting other components
- Often used in distributed systems, where components are spread across different servers
- By decoupling the components, it becomes easier to scale the system
- It also makes the system more resilient to failures, as a failure in one component does not necessarily cause the entire system to fail

### Tightly Coupled Architecture
- It is an architectural style where a number of application components are interdependent
- This means that a change in one component will likely impact other components
- For instance, a bank ATM relies on the hardware, built-in firmware and applications, and the main banking app to enable a consumer to withdraw cash or use ATM-specific services.
- The ATM will not function if any of these components fail

## Terms
- Dependency Injection (DI)
- Inversion of Control (IoC)

## Further Reading
- [ASP.NET Core Environment Variables](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-5.0#environment-variables)
- [Dependency Injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0)
- [Built in IOC Containers in ASP.NET Core Application](https://www.tutorialsteacher.com/core/internals-of-builtin-ioc-container-in-aspnet-core)