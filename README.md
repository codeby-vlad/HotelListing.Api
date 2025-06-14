# HotelListing API

This is a RESTful API built with **.NET 9** for managing hotel listings and associated countries. It supports full CRUD operations, authentication using JWT tokens, logging via Serilog with Seq integration, and follows best practices for layered architecture and clean code.

## 🔗 Live Swagger (Azure)

You can explore and test the live API via Swagger UI:

👉 https://hotellistingapi-vlad.azurewebsites.net/swagger/index.html

---

## ✨ Features

- ✅ JWT-based authentication & authorization
- ✅ Role-based access control (Admin / User)
- ✅ Get, create, update, delete hotels and countries
- ✅ Pagination and filtering support
- ✅ Serilog integration for structured logging
- ✅ AutoMapper for DTO mapping
- ✅ HTTP logging for testing via `.http` files
- ✅ Clean layered architecture (Controllers, Repositories, DTOs, Config)

---

## ⚙️ Technologies Used

- .NET 9
- Entity Framework Core
- SQL Server
- JWT (System.IdentityModel.Tokens.Jwt)
- Serilog + Seq
- AutoMapper
- Swagger / Swashbuckle
- Docker (optional for local DB)

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- SQL Server (locally or via Docker)
- [Seq](https://datalust.co/seq) (optional, for local logging)

### 1. Clone the repository

```bash
git clone https://github.com/codeby-vlad/HotelListing.Api.git
cd HotelListing.Api
```

### 2. Configure `appsettings.json`

This file is already included in the repository.

You **must** set your own sensitive values in the following sections:

- Replace `%DB_PASSWORD%` in the connection string with your actual SQL Server password or configure it via an environment variable.
- Replace the `Key` field in `JwtSettings` with your own secure, secret key.  
  This key is used to sign JWT tokens and must be kept safe.

Do **not** commit real credentials, secrets, or connection strings to version control.


### 3. Apply EF Core migrations

```bash
dotnet ef database update
```

### 4. Run the API

```bash
dotnet run --project HotelListing.Api
```

Navigate to:  
[http://localhost:5170/swagger](http://localhost:5170/swagger)

---

## 📦 Features

- JWT-based authentication
- CRUD operations for Hotels and Countries
- Global error handling and validation
- Serilog logging with Seq integration
- Docker-compatible connection string option
- Modular architecture with DTOs, Repositories, and Services

---

## 🧪 API Testing

Use Swagger UI or tools like Postman to test endpoints.  
Base URL: `https://hotellistingapi-vlad.azurewebsites.net/swagger`
