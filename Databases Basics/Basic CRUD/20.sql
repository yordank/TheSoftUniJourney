--Problem 20.	 Last 7 Hired Employees
--Write a SQL query to find last 7 hired employees. Select their first, last name and their hire date. Submit your query statements as Prepare DB & run queries.

SELECT TOP 7 FirstName,LastName,HireDate
 FROM Employees
 ORDER BY HireDate DESC