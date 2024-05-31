# Flex Management System

## Overview
Flex Management System is a C# console application designed to streamline the management of educational institutions by integrating with an SQL Server Database. The application supports four user roles: Student, Faculty, Admin Office, and Admin. Each role has unique functionalities tailored to their needs, enhancing the overall management and communication within the institution. 

## Features
### Student
- **View Attendance**: Students can check their attendance records.
- **Submit Feedback**: Students can provide feedback on courses and faculty.
- **User Interface**: A simple and intuitive interface for students to interact with the system.

### Faculty
- **View Allocated Courses**: Faculty members can see the courses assigned to them.
- **Manage Course Materials**: Faculty can upload and manage course materials (if applicable).

### Admin Office
- **Allocate Courses**: Admin office personnel can allocate courses to faculty members and manage the scheduling.
- **View and Manage Feedback**: Admin office can review feedback submitted by students and take necessary actions.

### Admin
- **User Management**: Admins can create, update, or delete user accounts for all roles.
- **System Configuration**: Admins can configure system settings and manage overall system integrity.

## Prerequisites
- **.NET SDK**: Ensure you have the .NET SDK installed on your machine. You can download it from [here](https://dotnet.microsoft.com/download).
- **SQL Server**: Install SQL Server and configure a database for the application.

## Installation
1. **Clone the Repository**
   ```
   git clone https://github.com/yourusername/flex-management-system.git
   cd flex-management-system
   ```

2. **Setup Database**
- **Create a new database in SQL Server.**
- **Execute the provided SQL script (database.sql) to create the necessary tables and schema.**
- **Update the connection string in appsettings.json with your SQL Server database details.**

3.**Build the Application**
   ```
   dotnet build
   ```
4.**Run the Application**
   ```
   dotnet run
   ```

## Configuration
### Database Connection
Edit the appsettings.json file to configure the database connection string:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;"
  }
}
```


