--Problem 16.	Create SoftUni Database
--Now create bigger database called SoftUni. You will use database in the future tasks. It should hold information about
--	Towns (Id, Name)
--	Addresses (Id, AddressText, TownId)
--	Departments (Id, Name)
--	Employees (Id, FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId)
--Id columns are auto incremented starting from 1 and increased by 1 (1, 2, 3, 4…). Make sure you use appropriate data types for each column. Add primary and foreign keys as constraints for each table. Use only SQL queries. Consider which fields are always required and which are optional.

CREATE TABLE Towns
(
Id INT UNIQUE IDENTITY,
Name NVARCHAR(30)
)

ALTER TABLE Towns
ADD CONSTRAINT PK_Towns PRIMARY KEY (Id)

CREATE TABLE Addresses
(
Id INT UNIQUE IDENTITY,
AddressText NVARCHAR(30),
TownId INT 
)
ALTER TABLE Addresses
ADD CONSTRAINT FK_Adresses FOREIGN KEY (TownId) REFERENCES Towns(Id)

ALTER TABLE Addresses
ADD CONSTRAINT PK_Adresses PRIMARY KEY (Id)

CREATE TABLE Departments
(
Id INT UNIQUE IDENTITY,
Name NVARCHAR(30)
)
ALTER TABLE Departments
ADD CONSTRAINT PK_Departments PRIMARY KEY(Id)

CREATE TABLE Employees
(
Id INT UNIQUE IDENTITY, 
FirstName NVARCHAR(30), 
MiddleName NVARCHAR(30), 
LastName NVARCHAR(30), 
JobTitle NVARCHAR(30), 
DepartmentId INT, 
HireDate DATETIME, 
Salary DECIMAL, 
AddressId INT
)
ALTER TABLE Employees
ADD CONSTRAINT FK1_Employees FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)

ALTER TABLE Employees
ADD CONSTRAINT FK2_Employees FOREIGN KEY (AddressId) REFERENCES Addresses(Id)

ALTER TABLE Employees
ADD CONSTRAINT PK_Employees PRIMARY KEY (Id)