# Breakdown Management App

## Description
This is a basic application to manage breakdowns, including creating, updating, and listing breakdowns.

## Requirements
- .NET Core SDK
- Node.js
- MySQL Server

## Setup

### SQL
1. I have provided a SQL query in `breakdown.sql`
2. Run this in SQL to create the db and required fields.

### Backend
1. Navigate to the `BreakdownAPI` directory.
2. Update the connection string in `appsettings.json` to match your MySQL setup.
3. Run the application:
   dotnet run

### Frontend
1. Navigate to `BreakdownFrontend` directory.
2. Run `npm install` to install dependencies.
3. Update `BreakdownService.js` with the correct API_URL based on what your .net API port is.
4. Run `npm start`