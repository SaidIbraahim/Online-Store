This is a full-stack ASP.NET Core MVC project for an online Store. It includes CRUD operations for managing customer information.

---

## Features

- CRUD operations for managing customer information
- Responsive UI built with Bootstrap
- Integration with Entity Framework Core for database operations
- Inetgrated with SQL Server for data storage

---

## Technologies Used

- **Framework:** ASP.NET Core MVC
- **Database:** SQL Server 
- **ORM:** Entity Framework Core
- **Frontend:** Bootstrap


## Prerequisites

Ensure you have the following installed:

- .NET SDK 6.0 or later
- SQL Server or Azure SQL Database
- Visual Studio or Visual Studio Code
- Git (for version control)

---

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/SaidIbraahim/Online-Store.git
cd Online-Store
```

---

### 2. Update Connection String

Edit the `appsettings.json` file to configure your database connection string.

```json
"ConnectionStrings": {
  "DefaultConnection": "Your-Database-Connection-String-Here"
}
```

---

### 3. Apply Migrations

Run the following commands to apply migrations and create the database schema:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 4. Run the Application

#### Using .NET CLI:
```bash
dotnet run
```

#### Using Visual Studio:
1. Open the solution file in Visual Studio.
2. Press `F5` to run the application.

---

## Usage

### Register a New Customer
1. Navigate to the "Register New Customer" page.
2. Fill out the customer details and click **Register**.
3. The new customer will be added to the database and displayed in the list.

### Edit a Customer
1. Go to the customer list page.
2. Click **Edit** next to the customer you want to update.
3. Update the details and click **Update**.

### Delete a Customer
1. Go to the customer list page.
2. Click **Delete** next to the customer you want to remove.
3. Confirm the deletion.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
```
