--Problem 14.	Car Rental Database
--Using SQL queries create CarRental database with the following entities:
--	Categories (Id, Category, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
--	Cars (Id, PlateNumber, Make, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
--	Employees (Id, FirstName, LastName, Title, Notes)
--	Customers (Id, DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes)
--	RentalOrders (Id, EmployeeId, CustomerId, CarId, CarCondition, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
--
--Set most appropriate data types for each column.
-- Set primary key to each table. Populate each table with 3 records. 
--Make sure the columns that are present in 2 tables would be of the same data type.
-- Consider which fields are always required and which are optional.
-- Submit your CREATE TABLE and INSERT statements as Run queries & check DB.

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
Category NVARCHAR(30) NOT NULL,
DailyRate DECIMAL,
WeeklyRate DECIMAL,
WeekendRate DECIMAL
)

INSERT INTO Categories VALUES ('Microcar',10,20,49.99),('Minivan',12.99,19.99,49.99),('Full-size SUV',15.99,29.99,89.99)

CREATE TABLE Cars
(
Id INT PRIMARY KEY IDENTITY,
PlateNumber NVARCHAR(30) NOT NULL UNIQUE,
Make NVARCHAR(30) ,
Model NVARCHAR(30),
CarYear INT CHECK (1900<= CarYear AND CarYear <=YEAR(GETDATE())),
CategoryId INT,
Doors INT CHECK(Doors>=1),
Picture VARBINARY(MAX),
Condition NVARCHAR(30) CHECK(Condition IN  ('Good','Average','Poor') ),
Available BIT
FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
)

INSERT INTO Cars VALUES 
('CB1111AA','Лада','Нива',2001,3,4,0X123456789,'Good',1), 
('CА9999AA','Мерцедес','А Класа',2009,3,4,0X123456789,'Good',1),
('РОНАЛДО','Ферари','LaFerrari',1999,3,4,0X123456789,'Good',1)

CREATE TABLE Employees
 (
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(30) NOT NULL,
 LastName NVARCHAR(30) NOT NULL,
 Title NVARCHAR(30) DEFAULT 'None',
 Notes NVARCHAR(30) DEFAULT 'None'
 )

 INSERT INTO Employees(FirstName,LastName) VALUES
 ('Ivan','Ivanov'),
 ('Yordan','Ivanov'),
 ('Petar','Petrov')

 CREATE TABLE Customers
 (
 id INT PRIMARY KEY IDENTITY,
 DriverLicenceNumber NVARCHAR(30) UNIQUE  NOT NULL,
 FullName NVARCHAR(30) NOT NULL,
 [Address] NVARCHAR(30),
 City NVARCHAR(30),
 ZIPCode INT,
 Notes NVARCHAR(30) DEFAULT 'None'
 )

 INSERT INTO Customers(DriverLicenceNumber,FullName,[Address],City,ZIPCode) 
 VALUES 
 ('123455','Petar Ivanov','Sofia,Centar','Sofia',1000),  
 ('234567','Stoil Ivanov','Plovdiv,Centar','Plovdiv',4000),
 ('345678','Georgi Ivanov','Varna,Centar','Varna',9000)

  CREATE TABLE RentalOrders
  (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT,
	CustomerId INT,
	CarId INT,
	CarCondition NVARCHAR(30) CHECK(CarCondition in ('Good','Poor')),
	TankLevel NVARCHAR(30) CHECK (TankLevel in ('High','Low')) DEFAULT 'High',
	KilometrageStart INT DEFAULT 1,
	KilometrageEnd INT DEFAULT 2,
	TotalKilometrage INT DEFAULT 1,
	StartDate DATETIME DEFAULT GETDATE(), 
	EndDate DATETIME DEFAULT GETDATE(), 
	TotalDays INT DEFAULT 0, 
	RateApplied DECIMAL DEFAULT 0,
	TaxRate DECIMAL DEFAULT 1,
	OrderStatus NVARCHAR(30) DEFAULT 'Success', 
	Notes NVARCHAR(30) DEFAULT 'None'
	FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
	FOREIGN KEY (CarId) REFERENCES Cars(Id)
  )
  INSERT INTO  RentalOrders(
  EmployeeId,
  CustomerId,
  CarId,
  CarCondition
   )
    VALUES 
  (1,1,1,'Good' ),
  (1,1,1,'Poor' ),
  (1,1,1,'Good' )
 
