PAYMENT-STATS-FRONTEND
=====================

A simple and clean frontend dashboard built with React + TypeScript  
for displaying payment statistics and transaction data from a backend API.

This project is designed for 2C2P technical assignments and interviews 

## Features

- Display payment statistics
  - Minimum payment
  - Maximum payment
  - Average payment
  - Transaction count
- Filter statistics by currency (query param)
- Display payment transaction list in a table
- Styled with Tailwind CSS
- API-driven (backend agnostic)
---

## Tech Stack

- React
- TypeScript
- Vite
- Tailwind CSS
- Fetch API (Need to use configs from .env to set path in fureture!)
---

## Installation

### 1. Install dependencies

```bash
npm install

npm run dev

## Directory Structure
```
└── components
├── |—— StatsCard.tsx
├── |—— TransactionTable.tsx
└── styles
├── |—— global.css
├── |—— layout.css
└── type
├── |—— PaymentStats.ts
├── |—— PaymentTransaction.ts
└── App.tsx
└── index.css
└── main.tsx
└── dockerfile
```

Note: This project follows a simple structure and is not meant to be a final architecture.
Tailwind utilities are extracted into CSS files using @apply to keep the code clean and easy to maintain.

```
## Author
**Jetsada Jinaka**  
Software Engineer
