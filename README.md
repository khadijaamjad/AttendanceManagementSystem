# AttendanceManagementSystem
Using C#windows forms , ADO .NET, SQL

TO MAKE SQL TABLES, USE THIS CODE

Create Table Employees
(
EmpID int primary key IDENTITY(1,1),
Emp_Fname nvarchar(50) not null,
Emp_Lname nvarchar(50),
Emp_Dept nvarchar(20),
Emp_Designation nvarchar(20),
)

Create table Attendance
(
EmpID int,
EmpStatus nvarchar(10),
AttendanceDate date,
Foreign key (EmpID) references Employees(EmpID),
)
