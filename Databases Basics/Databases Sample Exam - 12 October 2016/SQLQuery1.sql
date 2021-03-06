CREATE TABLE DepositTypes
(
DepositTypeID INT PRIMARY KEY,
Name VARCHAR(20)
)

CREATE TABLE Deposits
(
DepositID INT PRIMARY KEY IDENTITY,
Amount DECIMAL (10,2),
StartDate DATE,
EndDate DATE,
DepositTypeID INT ,
CustomerID INT,
FOREIGN KEY (DepositTypeID) REFERENCES DepositTypes(DepositTypeID) ,
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) 

)



CREATE TABLE EmployeesDeposits
(
EmployeeID INT,
DepositID INT ,
FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
FOREIGN KEY (DepositID) REFERENCES Deposits(DepositID),
PRIMARY KEY(EmployeeID,DepositID)  
)

CREATE TABLE CreditHistory
(
CreditHistoryID INT PRIMARY KEY,
Mark CHAR(1),
StartDate DATE,
EndDate DATE,
CustomerID INT,
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) 
)

CREATE TABLE Payments
(
PaymentID INT PRIMARY KEY,
Date DATE,
Amount DECIMAL (10,2),
LoanID INT ,
FOREIGN KEY (LoanID) REFERENCES Loans(LoanID)
)

CREATE TABLE Users
(
UserID INT PRIMARY KEY,
UserName VARCHAR(20),
Password VARCHAR(20),
CustomerID INT UNIQUE,
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

ALTER TABLE Employees
ADD  ManagerID INT DEFAULT NULL,
 FOREIGN KEY (ManagerID) REFERENCES Employees(EmployeeID) 