# Employee Management System - Razor Pages

A simple Employee Management System built with ASP.NET Core Razor Pages and Entity Framework Core.

## 🚀 Features

- **View Employees**: Display all employees in a responsive table format
- **Add Employees**: Add new employees with form validation
- **Modern UI**: Bootstrap-based responsive design
- **Data Validation**: Client-side and server-side validation
- **Database Integration**: SQL Server with Entity Framework Core
- **Auto Database Creation**: Database and tables are created automatically on first run

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core 8.0
- **UI**: Razor Pages with Bootstrap 5
- **Database**: SQL Server with Entity Framework Core 9.0
- **Validation**: Data Annotations with jQuery Validation
- **Language**: C# 12

## 📋 Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any SQL Server instance)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone <repository-url>
cd RazorPages(Practice-purpose)
```

### 2. Navigate to Project Directory

```bash
cd "RazorPages(Practice-purpose)"
```

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Update Connection String

Edit the `appsettings.json` file and update the connection string to match your SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME\\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}
```

**Note**: Replace `YOUR_SERVER_NAME` with your actual SQL Server instance name.

### 5. Run the Application

```bash
dotnet run
```

The application will:
- Build the project
- Create the database automatically
- Create the Employees table
- Start the web server

### 6. Access the Application

Open your browser and navigate to: `http://localhost:5075`

## 📁 Project Structure

```
RazorPages(Practice-purpose)/
├── Data/
│   ├── AppDbContext.cs          # Entity Framework DbContext
│   └── Employee.cs              # Employee entity model
├── Migrations/                  # Database migrations
├── Pages/
│   ├── Employee.cshtml          # Employee management page
│   ├── Employee.cshtml.cs       # Page model with business logic
│   ├── Index.cshtml             # Home page
│   ├── Privacy.cshtml           # Privacy page
│   └── Shared/
│       ├── _Layout.cshtml       # Main layout template
│       └── _ValidationScriptsPartial.cshtml
├── wwwroot/                     # Static files (CSS, JS, images)
├── appsettings.json             # Application configuration
├── Program.cs                   # Application entry point
└── README.md                    # This file
```

## 🗄️ Database Schema

### Employees Table

| Column | Type | Constraints | Description |
|--------|------|-------------|-------------|
| Id | int | Primary Key, Identity | Unique employee identifier |
| Name | nvarchar(100) | Not Null | Employee's full name |
| Position | nvarchar(100) | Not Null | Employee's job position |

## 🎯 Usage

### Adding an Employee

1. Navigate to the "Employees" page using the navigation menu
2. Fill in the employee form:
   - **Name**: Enter the employee's full name (required, max 100 characters)
   - **Position**: Enter the employee's job position (required, max 100 characters)
3. Click "Add Employee" button
4. The employee will be added to the database and displayed in the table

### Viewing Employees

- All employees are displayed in a responsive table format
- The table shows Employee ID, Name, and Position
- If no employees exist, a helpful message is displayed

## 🔧 Configuration

### Connection String Options

The connection string supports various SQL Server configurations:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=ServerName;Database=DatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
  }
}
```

**Parameters:**
- `Server`: SQL Server instance name
- `Database`: Database name (will be created if it doesn't exist)
- `Trusted_Connection=True`: Use Windows Authentication
- `MultipleActiveResultSets=true`: Enable MARS
- `TrustServerCertificate=true`: Trust server certificate (for development)

### Development vs Production

For production environments, consider:
- Using SQL Server Authentication instead of Windows Authentication
- Removing `TrustServerCertificate=true` and properly configuring SSL certificates
- Using environment-specific configuration files

## 🐛 Troubleshooting

### Common Issues

1. **SQL Server Connection Error**
   - Ensure SQL Server is running
   - Verify the server name in the connection string
   - Check if SQL Server Browser service is running

2. **SSL Certificate Error**
   - The connection string includes `TrustServerCertificate=true` for development
   - For production, configure proper SSL certificates

3. **Port Already in Use**
   - The application runs on port 5075 by default
   - Check `Properties/launchSettings.json` to change the port

4. **Database Creation Fails**
   - Ensure the SQL Server user has database creation permissions
   - Check SQL Server logs for detailed error messages

### Build Errors

If you encounter build errors:

```bash
# Clean and rebuild
dotnet clean
dotnet build

# Restore packages
dotnet restore
```

## 🚀 Deployment

### Development
The application is ready to run in development mode with the current configuration.

### Production
For production deployment:

1. Update connection string to use production SQL Server
2. Remove development-specific settings
3. Configure proper SSL certificates
4. Set up proper logging
5. Consider using Azure SQL Database or other cloud database services

## 📝 License

This project is for practice purposes. Feel free to use and modify as needed.

## 🤝 Contributing

This is a practice project. Feel free to:
- Add new features
- Improve the UI
- Add more validation
- Implement CRUD operations (Edit, Delete)
- Add search and filtering capabilities

## 📞 Support

If you encounter any issues:
1. Check the troubleshooting section above
2. Review the application logs
3. Ensure all prerequisites are installed
4. Verify SQL Server connectivity

---

**Happy Coding! 🎉**
