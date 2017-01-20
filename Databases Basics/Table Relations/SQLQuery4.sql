CREATE TABLE Teachers
(
TeacherID INT PRIMARY KEY,
Name VARCHAR(50),
ManagerID INT DEFAULT NULL,
FOREIGN KEY (ManagerID) REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers(TeacherID,Name,ManagerID)
 VALUES (101,'John',NULL),
 (102,'Maya',106),
 (103,'Silvia',106),
 (104,'Ted',105),
 (105,'Mark',101),
 (106,'Greta',101)
