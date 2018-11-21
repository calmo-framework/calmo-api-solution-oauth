# Calmô API Solution with OAuth Authentication

Visual Studio solution based on WebAPI with Domain Driven Design, implemented with Calmô Framework, Owin and Swagger.

## Features
- [RESTful](https://docs.oracle.com/javaee/6/tutorial/doc/gijqy.html) Web Services
- Based on [Domain Driven Design](https://www.wikiwand.com/en/Domain-driven_design) and [MVC pattern](https://www.wikiwand.com/en/Model%E2%80%93view%E2%80%93controller)
- User [CRUD](https://www.wikiwand.com/en/Create,_read,_update_and_delete) for sample purposes;
- [Swagger](https://swagger.io/) for API documentation;
- [Calmô Framework](https://github.com/calmo-framework/calmo-net) and it's magical data access (with samples)

## Structure
There are three projects in the solution:
- API Project - the actual API holder
- Domain Project - business logic
- Repository Project - data access

## Installation
- Download the ```Calmo API Solution OAuth.zip``` file from ```/dist```
- **Move** (don't extract it) it to your Visual Studio template folder (Windows 10/VS2017: ```C:\Users\[YourUsername]\Documents\Visual Studio 2017\Templates\ProjectTemplates\Visual C#```)
- Open Visual Studio
- Select ```File > New > C# > Calmo API Solution```
- Select ```Tools > NuGet Package Manager > Package Manager Console ```
- Run ```Update-Package -reinstall```
- You will be prompted to overwrite ```SwaggerConfig.cs``` with this message: ```File 'App_Start\SwaggerConfig.cs' already exists in project '[YOUR_PROJECT_NAME].Api'. Do you want to overwrite it?```
- Just answer ```N```
- Open ```TokenProvider.cs``` and apply your authentication logic
- Done, now you have a token-based API with Swagger for documentation. To use it, just run your project and go to ```/swagger```.
- Happy coding :)