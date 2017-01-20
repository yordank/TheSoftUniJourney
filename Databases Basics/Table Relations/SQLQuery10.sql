
SELECT TOP 5 
       e.EmployeeID,
       e.FirstName,
	   e.Salary,
	   d.Name
  FROM Employees AS e
 INNER JOIN Departments AS d
    ON e.DepartmentID=d.DepartmentID
 ORDER BY d.DepartmentID
