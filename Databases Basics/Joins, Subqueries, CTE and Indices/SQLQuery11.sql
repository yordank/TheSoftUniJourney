
SELECT MIN(AVG) AS MinAverageSalary 
  FROM 
(
SELECT e.DepartmentID,
       AVG(e.Salary) AS AVG
 FROM Employees AS e
 JOIN Departments AS d 
   ON e.DepartmentID=d.DepartmentID
GROUP BY e.DepartmentID
) AS tbl