CREATE TABLE CustomerReviews
(
ReviewID INT PRIMARY KEY,
ReviewContent VARCHAR(255) NOT NULL,
ReviewGrade INT CHECK (ReviewGrade>=0 AND ReviewGrade<=10),
AirlineID INT CHECK (AirlineID>=1),
CustomerID INT CHECK (CustomerID>=1),
FOREIGN KEY (AirlineID) REFERENCES Airlines(AirlineID), 
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

CREATE TABLE CustomerBankAccounts
(
AccountID INT PRIMARY KEY CHECK (AccountID>=1),
AccountNumber VARCHAR(10) NOT NULL UNIQUE,
Balance NUMERIC(10,2) NOT NULL,
CustomerID INT CHECK (CustomerID>=1),
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)

)