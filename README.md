# Crud MVC API Dotnet with Specflow and Selenium
This repository contains a .NET Core solution with MVC and API projects. It also has a Unit Test solution using Specflow and Selenium. For more information check the README file.

- CrudMvcDotnet solution
  
  This .NET solution includes examples of MVC and API projects. CRUD is a simple product registration screen and its categories.
  The application database is SQL Server. EntityFramework is used in the project as well as migrations.
  Used Nuget packages:
    - MVC: Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools. 
    - API: Microsoft.EntityFrameworkCore.Tools, Swashbuckle.AspNetCore (Swagger optional)
    
- CrudMvcDotnetSpec solution

  This .NET solution includes example of unit test framework with Specflow and Selenium.
  Used Nuget packages: Selenium (Support, WebDriver, WebDriver.ChromeDriver), Specflow, Specflow.MsTest
  
- To run the MVC project in the CrudMvcDotnet solution, you start the application by accessing the port on the project property in the browser.
- To run the API project on the CrudMvcDotnet solution, you start the application and check it using Swagger or Postman.
- To run the test project on the CrudMvcDotnetSpec solution, you start the MVC CrudMvcDotnet application and run the tests in the explorer.
  
 
  
