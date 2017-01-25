-- Problem 18.	**Salary Challenge
--Write a query that returns
--•	FirstName
--•	LastName
--•	DepartmentID
--for all employees who have salary higher than the average salary of their respective departments. Select only the first 10 rows. Order by DepartmentID.

 SELECT TOP 10  e1.FirstName,
	    e1.LastName,
		e1.DepartmentID
   FROM Employees AS e1
   JOIN
	 ( 
	   SELECT  DepartmentID,
			   AVG(Salary) AS AVGSalary
		 FROM Employees
		GROUP BY DepartmentID
	 ) AS e2
     ON e1.DepartmentID=e2.DepartmentID
    WHERE e1.Salary>e2.AVGSalary
    ORDER BY DepartmentID