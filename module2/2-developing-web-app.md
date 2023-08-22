# Module 2: Develop Web Application using ASP.NET MVC

### Understanding the MVC Pattern
- MVC stands for MOdel, View, and Controller
- MVC seperates an application into three components, and decoules those components
- Model are the domain classes that represent the entity
- View is a UI component which also allows interaction and displays the final output to the end user
- The controller is the request handlers and interacts with the model and view

#### The Model
- Model represents the shape of the data
- A Model is a class that represents the data and the business logic of the application
- Responsible for defining the data entities, validating input, and performing database operations
- Using in conjunction with data access technologies such as Entity Framework, LINQ, or SQ

#### The View
- View is responsible for rendering the user interface of the application
- View displays model data to the user and also enbles them to modify them
- A view is typically defined as an HTML template that includes server-side code to render data
- Views can use a variety of technologies to render HTML, including Razor, ASPX, and others
- Client-side technologies such as Javascript and CSS can be used to enhance the user interface

#### The Controller
- A controller is responsible for handling user input and updating the model and the view
- IT is the components that handles requests from the client
- Performs necessary operations on the model and selectsf the right view to render the response
- Controller is defindes as a class that inherits from the base controller class ASP.NET MVC
- Includes action methods that correspond to user requests and perform operations on the model

## Model-View-Controller Communication
1. The browser sends a request to the controller
2. If it requires a view then it will return that view
3. If it requires a data exchange then it will interact with the model
4. The controller responds to the browser

### Model to Model
- We can communicate from Model to Model via parameters/composition

### Model to View
- To communicate Model to View, you have to follow the path: Model > Controller > View
- We can't directly move from Model to View
- First, the Model object is made in the Controller and then it is passed to the View

#### We Can pass the data or communicate from Model to View by these three steps
1. Take the object in the action of a Controller
2. Pass Model object as a parameter to View
3. Use @model to include Model on the View page

### Model to Controller
- Create an object of Model class in Controller to accesss the Model in controller

### View to Model
- To communicate View to Model, you have to follow the path: View > Controller > Model
- We can't directly move from View to Model
- First, you have to submit data to the controller and then pass it to the  model

#### To pass the data from View to Model, you have to follow these three steps
1. Submit HTML form to a controller
2. Create an object of Model in Controller
3. Pass Values to the Model object

#### View to View
- We can move from one view to another view by using partial views

#### View to Controller
We can move data from view to controller by submitting forms to controllers or by
- JSON
- AJAX Calls
- Javascript
- Partial Views

### Controller to Model
- We can move from Controller to Model just like we move from Model to Controller

### View to Controller
We can move data from controller to view in the following ways;
- By using viewBag
- ViewData
- TempData

### Controller to Controller
- We can move from on Controller to another by using RedirectToAction(); and then pass the name of the specific action

## Further Reading
- [Understainding MVC Pattern](https://www.tutorialspoint.com/mvc_framework/mvc_framework_introduction.htm)
- [Model-View-Controller Communication](https://www.geeksforgeeks.org/mvc-design-pattern/)
- [Handling requests and responses in a .NET MVC Core web application](https://www.c-sharpcorner.com/article/asp-net-core-mvc-request-life-cycle/)