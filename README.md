# CnxDevSoft Backend Assignment

### Tools
- UI: Blazor Web App (SSR)
- API Framework: .NET
- Database: SQL Server
- ORM: Entity Framework
- API Documentation: Swagger

## Getting Started

### First, Edit SQL Server connection in "appsettings.json" to your Username and Password

```json
"ConnectionStrings": {
    "connSQLServer": "Server=localhost\\SQLEXPRESS;Database=mathop_db;User Id=<username>;Password=<password>;TrustServerCertificate=True;MultipleActiveResultSets=true;"
  }
```

### Then, Create Database and Schema with EF Migrations

```bash
dotnet ef database update
```

### Now, You can start the application and

Open [https://localhost:7171](https://localhost:7171) to use Blazor Web App for Math Operation Form
Open [https://localhost:7171/swagger](https://localhost:7171/swagger) to use Swagger API Document