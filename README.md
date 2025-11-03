# .NET playground
Personal repository to test new .NET features, nuggets, integrations or just my personal play zone

## csharp-features
.NET projects compilation to test C# features

## dotnet-and-llms
.NET integration with Open API REST API's 

## efcore-and-middleware
.NET test project which implements Entity Framework Core as an ORM (it injects test data), a custom middleware and a test suite.
* No front. It's just an API - use Swagger to test requests
* It implements an in-memory database

## razor-pages-basic-webapp
Basic Razor Pages project to test deployment with Azure Web Apps. Done using [the following docs](https://learn.microsoft.com/en-us/azure/app-service/quickstart-dotnetcore?tabs=net80&pivots=development-environment-vs).  
It doesn't include any ORM or database.  

## razor-pages-ef-core
**Local** .NET project to test Razor Pages and it includes EF Core as ORM (local database - initialized on first execution). It has been done following [Microsoft's tutorials](https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-9.0&tabs=visual-studio).  
It features:
* MVC pattern
* sorting
* filtering
* pagination
