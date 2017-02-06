  
DELETE FROM 
EmployeesProjects 
WHERE EmployeeID IN (SELECT   EmployeeID      
                     FROM Employees
                     WHERE DepartmentID IN (7,8) )

UPDATE Employees
SET ManagerID=NULL

ALTER TABLE Departments
ALTER COLUMN ManagerID INT NULL
  
UPDATE Departments 
SET ManagerID=NULL 

DELETE 
FROM Employees
WHERE DepartmentID IN (7,8)
  
DELETE FROM
Departments  
WHERE DepartmentID IN (7,8)