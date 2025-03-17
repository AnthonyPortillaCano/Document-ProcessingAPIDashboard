# Document Processing API Dashboard

This project consists of a web application for document processing, composed of a .NET 9 backend and a React frontend.

## Prerequisites

### Backend
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/es/) (recommended) or [Visual Studio Code](https://code.visualstudio.com/)

### Frontend
- [Node.js](https://nodejs.org/) (version 18 or higher)
- [npm](https://www.npmjs.com/) (included with Node.js)

## Project Setup

### Backend (.NET)

1. Database setup:
   - Open SQL Server Management Studio
   - Execute the script `BackendNet9/scriptDocument.sql` to create the database and its tables

2. Backend configuration:
   - Open the solution `BackendNet9/SolutionDocument/SolutionDocument.sln` in Visual Studio
   - Verify the connection string in the `appsettings.json` file
   - Restore NuGet packages
   - Build the solution

### Frontend (React)

1. Navigate to the frontend directory:
   ```bash
   cd FrontEnd/document-processing-frontend
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

## Running the Application

### Backend
1. From Visual Studio:
   - Press F5 or click the "Start" button
   - The API will be available at `https://localhost:7201/swagger/index.html` (verify the exact port in the project properties)

2. From command line:
   ```bash
   cd BackendNet9/SolutionDocument
   dotnet run
   ```

### Frontend
1. Navigate to the frontend directory:
   ```bash
   cd FrontEnd/document-processing-frontend
   ```

2. Start the application in development mode:
   ```bash
   npm start
   ```
   - The application will be available at `http://localhost:3000`

## Project Structure

### Backend
- `BackendNet9/`: Contains the .NET 9 backend project
  - `scriptDocument.sql`: Database creation script
  - `SolutionDocument/`: Main backend solution

### Frontend
- `FrontEnd/`: Contains the React frontend project
  - `document-processing-frontend/`: React application

## Main Features
- Document processing
- Interactive dashboard
- Document management
- RESTful API
- Modern and responsive user interface

## Support

For any issues or inquiries, please create an issue in the repository.