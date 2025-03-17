# Document Processing API Dashboard

Este proyecto consiste en una aplicación web para el procesamiento de documentos, compuesta por un backend en .NET 9 y un frontend en React.

## Requisitos Previos

### Backend
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/es/) (recomendado) o [Visual Studio Code](https://code.visualstudio.com/)

### Frontend
- [Node.js](https://nodejs.org/) (versión 18 o superior)
- [npm](https://www.npmjs.com/) (incluido con Node.js)

## Configuración del Proyecto

### Backend (.NET)

1. Configurar la base de datos:
   - Abrir SQL Server Management Studio
   - Ejecutar el script `BackendNet9/scriptDocument.sql` para crear la base de datos y sus tablas

2. Configurar el Backend:
   - Abrir la solución `BackendNet9/SolutionDocument/SolutionDocument.sln` en Visual Studio
   - Verificar la cadena de conexión en el archivo `appsettings.json`
   - Restaurar los paquetes NuGet
   - Compilar la solución

### Frontend (React)

1. Navegar al directorio del frontend:
   ```bash
   cd FrontEnd/document-processing-frontend
   ```

2. Instalar las dependencias:
   ```bash
   npm install
   ```

## Ejecutar la Aplicación

### Backend
1. Desde Visual Studio:
   - Presionar F5 o hacer clic en el botón "Iniciar"
   - El API estará disponible en `https://localhost:7777` (verificar el puerto exacto en las propiedades del proyecto)

2. Desde línea de comandos:
   ```bash
   cd BackendNet9/SolutionDocument
   dotnet run
   ```

### Frontend
1. Navegar al directorio del frontend:
   ```bash
   cd FrontEnd/document-processing-frontend
   ```

2. Iniciar la aplicación en modo desarrollo:
   ```bash
   npm start
   ```
   - La aplicación estará disponible en `http://localhost:3000`

## Estructura del Proyecto

### Backend
- `BackendNet9/`: Contiene el proyecto backend en .NET 9
  - `scriptDocument.sql`: Script para la creación de la base de datos
  - `SolutionDocument/`: Solución principal del backend

### Frontend
- `FrontEnd/`: Contiene el proyecto frontend en React
  - `document-processing-frontend/`: Aplicación React

## Características Principales
- Procesamiento de documentos
- Dashboard interactivo
- Gestión de documentos
- API RESTful
- Interfaz de usuario moderna y responsive