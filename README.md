# Stock Portfolio App

A full-stack project that combines a .NET Core API with a React frontend.  
Users can register and log in, search for companies using the Financial Modeling Prep (FMP) API, and manage their own stock portfolio.

## Features

- Authentication: Register and login with JWT token stored in localStorage  
- Portfolio Management: Add or remove stocks from a personal portfolio  
- Company Search: Search NASDAQ companies with real-time data via FMP API  
- Responsive UI: Built with React, TypeScript, and React Router  
- .NET API: Backend endpoints for authentication and portfolio CRUD  

## Tech Stack

- **Frontend:** React, TypeScript, React Hook Form, Yup, Axios  
- **Backend:** ASP.NET Core Web API, Entity Framework, SQL Database  
- **External API:** Financial Modeling Prep (FMP)  

## Project Structure
```text
Tutorial/
│── frontend/       # React client (login, search, portfolio UI)
│── Tutorial.API/   # .NET backend (auth + portfolio endpoints)
```

## Setup Instructions

### 1. Clone the repository
```bash
git clone https://github.com/shabab11715/StockPortfolioApp
cd StockPortfolioApp
```

### 2. Backend (.NET API)
```bash
cd Tutorial.API
dotnet run
```
Runs at: http://localhost:5165

### 3. Frontend (React)
```bash
cd frontend
npm install
npm start
```
Runs at: http://localhost:3000

## Configuration Notes

For the React frontend, create a `.env` file inside the `frontend/` folder and add your Financial Modeling Prep (FMP) API key:

```bash
REACT_APP_API_KEY=your_fmp_api_key_here
```

Be sure to update the API key in `appsettings.json` under the relevant configuration section. This ensures both the frontend and backend have access to the correct API credentials.