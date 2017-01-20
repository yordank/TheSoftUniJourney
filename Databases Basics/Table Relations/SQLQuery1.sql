
CREATE TABLE Persons
(
PersonID INT NOT NULL,
FirstName NVARCHAR(50),
Salary MONEY,
PassportID INT
)

CREATE TABLE Passports
(
PassportID INT PRIMARY KEY,
PassportNumber NVARCHAR(50)
)

ALTER TABLE Persons
ADD CONSTRAINT PK_Persons PRIMARY KEY (PersonID)

ALTER TABLE Persons
ADD FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)


 

INSERT INTO Passports VALUES
(101,'N34FG21B'),
(102,'K65LO4R7'),
(103,'ZE657QP2')

INSERT  INTO Persons(PersonID,FirstName,Salary,PassportID) VALUES 
(1,'Roberto',43300.00,102),
(2,'Tom',56100.00,103),
(3,'Roberto',60200.00,101) 

 