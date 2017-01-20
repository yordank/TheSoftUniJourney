CREATE TABLE Students
(
StudentID INT PRIMARY KEY,
Name NVARCHAR(50)
)

INSERT INTO Students(StudentID,Name)
VALUES (1,'Mila'),
	(2,'Toni'),
	(3,'Ron')


CREATE TABLE Exams
(
ExamID INT PRIMARY KEY,
Name NVARCHAR(50)
)


INSERT INTO Exams(ExamID,Name)
VALUES (101,'Spring MVC'),
(102,'Neo4j'),
(103,'Oracle 11g')


CREATE TABLE StudentsExams
(
StudentID INT, 
ExamID INT,
PRIMARY KEY (StudentID,ExamID),
FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
)


INSERT INTO StudentsExams(StudentID,ExamID)
VALUES (1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)
