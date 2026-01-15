2C2P PAYMENT-STATS-SERVICE
=========================

A simple full-stack payment statistics system built for technical assignments  
and interview discussions.

This project is designed specifically for **2C2P technical assignments and interviews**.

---

## Tech Stack

**Backend**
- .NET 8
- ASP.NET Core Web API
- C#
- Entity Framework Core
- Swagger (OpenAPI)

**Frontend**
- React
- TypeScript
- Vite
- Tailwind CSS

**Infrastructure**
- Docker
- Docker Compose

---

## Project Structure
```
root
├── frontend/ React + TypeScript dashboard
├── backend/ .NET Core Web API
└── docker-compose.yml
```

## Frontend
A lightweight dashboard for displaying payment data.

**Responsibilities**
- Display payment statistics (min, max, average, count)
- Show transaction list
- Filter data by currency
- Conect with backend APIs

## Backend
REST API service that provides payment statistics and transaction data.

**Responsibilities**
- Expose payment-related APIs
- Handle transaction data
- Apply basic business logic

## Design Notes
This project applies SOLID principles where they add clarity and maintainability.  
SOLID is not always the best solution and should be applied based on project scope,  
time constraints, and team size.


With additional time, the backend can be extended to use a full MSSQL database  
for more realistic, production-ready data handling.

## Author
**Jetsada Jinaka**  
Software Engineer