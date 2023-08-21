# Model 2: Configuring .NET Core Web Applciation

### Serving Static Files
- Process of delivering files like HTML, CSS, images, and other assets to the client's web browser
- ASP.NET Core includes middleware that can serve static files from a specified directory
- To serve static files in ASP.NET Core, you need to do the following
  - Add StaticFiles mdidleware to the pipeline in the Configure method of the Startup class
  - Configre StaticFiles middleware options, like file provider, default file name
  - Add static filest to "wwwroot" directory or embed them as resources in the application
- With these steps, ASP.NET Core will serve the static files when a client requests them

### wwwroot Folder
- The "wwwroot" folder is the default root folder for static files
- It stores static resources like HTML, CSS, JS, images and more
- Files outside this folder are not directly accessible to clients
- In ASP.NET Core Applications, the Static files can be stored in any folder under the webroot folder and can be accessed with a relative path to that root
- This has been changed in ASP.NET Core
- Now, we can store any static files under wwwroot folder only, all other files are blocked on http request

## State Management in ASP.NET Core
- State management in ASP.NET is an object and preserves type state control
- This is because ASP.NET applications are basically stateless
- In ASP.NET, the information of users is stored and maintained untill the user session ends
- Each time the page is posted to the server, a new instance of the Web page class is created
- Whenever the user enters information this information might get lost in the round trip from the browser (MSDN), if the enter into the web application

### State Management Techniques
| Storage approach | Storage mechanism |
| - | - |
| Cookies | HTTP cookies. May include data stored using server-side app code |
| Session State | HTTP cookies and sever-side app code |
| Temp Data | HTTP cookies or session state |
| Query strings | HTTP query strings |
| Hidden fiels | HTTP form fields |
| HttpContext.Items | Server-side app code |
| Cache | Server-side app code |

## Routing Configuration
- Routing helps in mapping incoming URLs to controller and their corresponding action methods
- ASP.NET introduced Routing to eliminate the needs of mapping each URL with a physical file
- Routing enables us to define a URL pattern that maps to the request handler
- This request handler can be a file or a class

### Default action methods
- Every controller can have default action method as per configured route in RoutConfig
- By default the Index() method is a defautl action method for any controller
- Also you can change the default action name as per your requirement in the RouteConfig class

## Further Reading
- [Serving Static Files](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-5.0)
- [Session and State Management](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-5.0)
- [Routing Configurations](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-5.0)
- [Hosting Environments in .NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-5.0)