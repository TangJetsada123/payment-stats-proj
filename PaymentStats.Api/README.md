2C2P PAYMENT-STATS-SERVER
===================

This simple and clean backend service built with **.NET 8 Web API**  
for calculating payment statistics and serving payment transaction data via REST APIs.

This project is designed for **2C2P technical assignments and interviews**,  
with a focus on **clean architecture principles, separation of concerns, and readability**.

---

## Features

- Provide payment statistics
  - Minimum payment amount
  - Maximum payment amount
  - Average payment amount
  - Transaction count
- Filter statistics by currency (query parameter)
- Provide payment transaction list
- RESTful API design
- In-memory data
- Ready for Docker & containerized environments

---
## Tech Stack
- .NET 8
- ASP.NET Core Web API
- C#
- Entity Framework Core (optional / ready for MSSQL)
- Swagger (OpenAPI)
- Docker & Docker Compose

---

## Architecture Overview

This project follows a **layered architecture** inspired by **SOLID principles**:

- **Controller** — Handles HTTP requests and responses
- **Service** — Contains business logic
- **Repository** — Handles data access
- **Model / DTO** — Domain models and response contracts
- **Utils / Helpers** — Shared helper logic (e.g. currency normalization)

Each layer depends on **interfaces**, making the codebase easy to test, extend, and refactor.

---

## Directory Structure
```
PaymentStats.Api
│
├── Controllers
│ └── PaymentStatsController.cs
│
├── Services
│ ├── PaymentStatsService.cs
│ └── Interfaces
│     └── IPaymentStatsService.cs
│
├── Data
│ ├── PaymentStatsRepository.cs
│ └── Interfaces
│     └── IPaymentStatsRepository.cs
│
├── Models
│ └── PaymentTransaction.cs
│
├── DTO
│ └── PaymentStatsDto.cs
│
├── Utils
│ └── CurrencyCheckHelper.cs
│
├── Program.cs
├── payment_data.json
├── appsettings.json
└── Dockerfile

Note: This project applies SOLID principles, but SOLID is not always the best solution.The chosen approach depends on factors such as time constraints, team size, and project scope.
If more time were available, the next step would be to use an MSSQL database to support full data storage and real use cases.
```

## Author
**Jetsada Jinaka**  
Software Engineer