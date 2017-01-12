--Problem 15.	Hotel Database
--Using SQL queries create Hotel database with the following entities:
--	Employees (Id, FirstName, LastName, Title, Notes)
--	Customers (AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
--	RoomStatus (RoomStatus, Notes)
--	RoomTypes (RoomType, Notes)
--	BedTypes (BedType, Notes)
--	Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
--	Payments (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
--	Occupancies (Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
--Set most appropriate data types for each column. Set primary key to each table. Populate each table with 3 records. Make sure the columns that are present in 2 tables would be of the same data type. Consider which fields are always required and which are optional. Submit your CREATE TABLE and INSERT statements as Run queries & check DB.

CREATE TABLE Employees 
(
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(30) , 
 LastName NVARCHAR(30) , 
 Title NVARCHAR(30) , 
 Notes NVARCHAR(30)
)
INSERT INTO Employees VALUES 
('Ivan','Ivanov','Title','Notes'),
('Yordan','Ivanov','Title','Notes'),
('Ivanka','Ivanov','Title','Notes')

CREATE TABLE Customers
(
AccountNumber INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30), 
LastName NVARCHAR(30), 
PhoneNumber NVARCHAR(30), 
EmergencyName NVARCHAR(30), 
EmergencyNumber NVARCHAR(30), 
Notes NVARCHAR(30)
)

INSERT INTO Customers VALUES
('PETAR','PETROV','0888121212','PESHO','123456789','None'),
('IVAN','PETROV','0888121219','VANIO','123456790','None'),
('YORDAN','PETROV','0888121218','DANCHO','123456791','None')

CREATE TABLE RoomStatus
(
RoomStatus NVARCHAR(30) PRIMARY KEY,
Notes NVARCHAR(30)
)

INSERT INTO RoomStatus VALUES 
('Free','It is FREE'),
('Booked','It is BOOKED'),
('Closed','It is CLOSED')

CREATE TABLE RoomTypes
(
RoomType NVARCHAR(30) PRIMARY KEY,
Notes NVARCHAR(30)
)

INSERT INTO RoomTypes VALUES 
('Small','Up to 30 squres'),
('Meduim','Between 30 and 60 squares'),
('Large','60 plus squares')

CREATE TABLE BedTypes
(
BedType NVARCHAR(30) Primary Key,
Notes NVARCHAR(30)
)

INSERT INTO BedTypes VALUES 
('One','One bed'),
('Two','Two bed'),
('Three','Three bed') 
 
 CREATE TABLE	Rooms
  (
  RoomNumber INT PRIMARY KEY IDENTITY,
  RoomType NVARCHAR(30),
  BedType NVARCHAR(30),
  Rate DECIMAL, 
  RoomStatus NVARCHAR(30), 
  Notes NVARCHAR(30)
  FOREIGN KEY (RoomType) REFERENCES RoomTypes(RoomType),
  FOREIGN KEY (BedType)  REFERENCES BedTypes(BedType),
  FOREIGN KEY (RoomStatus) REFERENCES RoomStatus(RoomStatus)
  )

  INSERT INTO Rooms VALUES 
  ('Small','One',9.99,'Booked','None'),
  ('Large','Two',19.99,'Booked','None'),
  ('Small','One',8.99,'Free','None')

CREATE TABLE Payments
 (
 Id INT PRIMARY KEY IDENTITY, 
 EmployeeId INT , 
 PaymentDate DATETIME, 
 AccountNumber INT , 
 FirstDateOccupied DATETIME, 
 LastDateOccupied DATETIME, 
 TotalDays INT, 
 AmountCharged DECIMAL, 
 TaxRate DECIMAL, 
 TaxAmount DECIMAL, 
 PaymentTotal DECIMAL, 
 Notes NVARCHAR(30)
 
 FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
 FOREIGN KEY (AccountNumber) REFERENCES Customers(AccountNumber),
  

 )
 INSERT INTO Payments VALUES 
 (1,GETDATE(),2,GETDATE(),GETDATE(),0,1,1,1,1,'None'),
 (2,GETDATE(),1,GETDATE(),GETDATE(),0,1,1,1,1,'None'),
 (2,GETDATE(),2,GETDATE(),GETDATE(),0,1,1,1,1,'None')

 CREATE TABLE Occupancies 
 (
 Id INT PRIMARY KEY IDENTITY, 
 EmployeeId INT, 
 DateOccupied DATETIME, 
 AccountNumber INT, 
 RoomNumber INT, 
 RateApplied DECIMAL, 
 PhoneCharge NVARCHAR(30), 
 Notes NVARCHAR(30)

 FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
 FOREIGN KEY (AccountNumber) REFERENCES Customers(AccountNumber),
 FOREIGN KEY (RoomNumber) REFERENCES Rooms(RoomNumber)
 )

 INSERT INTO Occupancies VALUES 
 (1,GETDATE(),3,3,11.1,'0888291866','None'),
 (2,GETDATE(),3,3,11.1,'0888291866','None'),
 (3,GETDATE(),3,3,11.1,'0888291866','None')