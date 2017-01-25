--Problem 13.	Employees Minimum Salaries
--That’s it! You no longer work for Mr. Bodrog. You have decided to find a proper job as an analyst in SoftUni. 
--It’s not a surprise that you will use the SoftUni database. Things get more exciting here!
--Select the minimum salary from the employees for departments with ID (2,5,7) but only for those who are hired after 01/01/2000.

SELECT DepartmentID,MIN(Salary)
  FROM Employees
  WHERE DepartmentID IN (2,5,7) AND
        HireDate>'2000-01-01'
 GROUP BY DepartmentID 