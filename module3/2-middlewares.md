# Module 3: Middlewares

### Working with Middleware
- Middleware in ASP.NET Core controls how our application responds to HTTP requests
- They are software components assembled into a pipeline ito handle requests and responses
- Every section of the middleware can handle either request or response or both
- In this way, we can develop a system flow by the help of middleware in the applications which handle the request situations that may not be handled properly by core applications

### Middleware Request Pipeline
- In this, requests are processed beginning with request and ending with response
- The pipeline specifices how the application should respond to the HTTP request.
- The Request arriving from the browser goes through the pipeline and back
- The individual components that make up the pipeline are called the Middleware

1. Kestrel - A server that can be run on many OS
2. Server sends request through request pipeline (session, auth, etc.)
3. Response is passed back through the pipeline

### Some Common Middleware
- Authentication
- Static File
- Routing
- Session
- Execption Handling
- Cross-Origin Resource Sharing (CORS)
- HTTPS Redirection

### How the Middleware Request Pipeline Works
- First, the HTTP Request arrives (directly or via external web server) at the application
- The Kestrel Web Server picks up the Request and creates the httpContext and passes it to the First Middleware in the request pipeline
- The First Middleware then takes over, processes the request and passes it to the next Middleware
- This goes on until it reaches the last middleware
- The last one returns the request back to the previous middleware, terminating the request pipeline.
- Finally, the response reaches kestrel, which returns the response back to the client
- Any of the middleware in the request pipeline can terminate the request pipeline by simply not passing the request to the next middleware

### Built in Middleware and Custom Middleware

#### Built-in Middleware
- Authentication
- CORS
- Diagnostics
- HTTPS Redirection
- Request Localization
- Routing
- HTTP Method Override
- MVC

#### Custom Middleware
- The custom middleware component is like any other .NET class with Invoke() method
- However, in order to execute next middleware in sequence it should have RequestDelegate type parameter in the constructor
- Custom middleware in .NET Core allows developer to execute code before or after request response cycle

## Further Reading
- [Working with Middlewares](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-5.0)
- [Middleware Request Pipeline](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/request-response?view=aspnetcore-7.0)
- [Build in Middlewares and Custom Middlewares](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-7.0)