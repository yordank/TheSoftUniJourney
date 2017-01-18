--Problem 16.	Employees Count Salaries
--Count the salaries of all employees who don’t have a manager.

SELECT COUNT(*)
  FROM Employees AS Count
 WHERE ManagerID IS NULL
   