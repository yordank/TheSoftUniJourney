--Problem 15.	Employees Maximum Salaries
--Find the max salary for each department. Filter those which have max salaries not in the range 30000 and 70000;
--Example:

SELECT DepartmentID,
       MAX(Salary) AS MaxSalaries
  FROM Employees
 GROUP BY DepartmentID
 HAVING Max(Salary) NOT BETWEEN 30000 AND 70000