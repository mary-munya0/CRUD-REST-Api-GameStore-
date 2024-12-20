# CRUD REST API Game Store

## Project Description
This project is a CRUD REST API built in C# using the ASP.NET Core framework. The API allows you to perform CRUD operations on a game store's database, where data is managed using Entity Framework (EF), which provides an object-relational mapping (ORM) between C# and SQL Server.

### Features:
- Create, Read, Update, and Delete game records.
- Interaction with a SQL database using Entity Framework.

## Technologies Used
- C#
- ASP.NET Core (Web API framework)
- Entity Framework Core(ORM for database operations)
- SQL Server(Database)
-  REST Client(for API testing)

## Installation

### Prerequisites:
- .NET 8.0 or higher

### Steps to install:
1. Clone this repository:
   git clone https://github.com/mary-munya0/CRUD-REST-Api-GameStore-.git
   cd CRUD-REST-Api-GameStore-
   
3. Install dependencies (make sure you have .NET SDK installed):
    dotnet restore
   
4. Navigate to the GameStore.Api directory:
      cd GameStore.Api
   
5. Apply migrations to set up the database:
    dotnet ef database update
   
6. Run the API:
    dotnet run

