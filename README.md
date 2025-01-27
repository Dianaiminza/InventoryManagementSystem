## Inventory Management System
An inventory management system built with ASP.NET Core and C# for efficiently managing inventory items, suppliers, categories, and transactions. This system allows users to track stock levels, record purchases and sales, and generate reports.

## Features
### Inventory Management:

- Add, view, update, and delete inventory items
- Track stock levels, prices, and descriptions
- Categorize inventory items (e.g., Electronics, Furniture)

### Suppliers Management:

- Maintain a list of suppliers for each inventory item
- Sales and Purchases:

### Record sales transactions
- Record purchase orders to restock inventory

### User Roles and Authentication:

- Admin, Manager, and Staff roles with different levels of access

### Database:

- Uses Entity Framework Core for data access and SQL Server as the database

## Technologies Used
- ASP.NET Core 6.0 (or latest version)
- Entity Framework Core for ORM and database access
- SQL Server (or any other relational database)
- ASP.NET Core Identity for authentication and role-based authorization
- AutoMapper for object mapping (optional)
- MVC Pattern for front-end and backend logic (or Web API, depending on your choice)

## Setup
### Prerequisites
- Install .NET 6.0 SDK (or the version you are using) from here.
- Install SQL Server (or use a cloud database like Azure SQL).

## Clone the Repository
```
git clone https://github.com/Dianaiminza/InventoryManagementSystem.git
cd InventorymanagementSystem
```
## Configure the Database

Open appsettings.json and configure the connection string for your database.

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=yourserver;Database=InventoryDB;User Id=yourusername;Password=yourpassword;"
  }
}

```
Create the database by running the following command:

```
dotnet ef database update
```
To run the application locally, use the following command:
```
dotnet run
```


