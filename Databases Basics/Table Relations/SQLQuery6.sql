CREATE TABLE Subjects
(
SubjectID INT PRIMARY KEY,
SubjectName VARCHAR(50)
)

CREATE TABLE Majors
(
MajorID INT PRIMARY KEY,
Name VARCHAR(50)
)

CREATE TABLE Students
(
StudentID INT PRIMARY KEY,
StudentNuber VARCHAR(50),
StudentName VARCHAR(50),
MajorID INT,
FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
PaymentID INT PRIMARY KEY,
PaymentDate Date,
PaymentAmount MONEY,
StudentID INT,
FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
)

CREATE TABLE Agenda
(
StudentID INT ,
SubjectID INT,
PRIMARY KEY (StudentID,SubjectID),
FOREIGN KEY (StudentID) REFERENCES Subjects(SubjectID),
FOREIGN KEY (SubjectID) REFERENCES Students(StudentID)
)