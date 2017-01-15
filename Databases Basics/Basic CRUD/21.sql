--Problem 21.	Increase Salaries
--Write a SQL query to increase salaries of all employees 
--that are in the Engineering, Tool Design, Marketing or Information 
--Services department by 12%. Then select Salaries column from the 
--Employees table. After that exercise restore your database to revert
-- those changes. Submit your query statements as Prepare DB & run queries.

SELECT 
  
CASE 
WHEN d.Name in ('Engineering', 'Tool Design','Marketing','Information Services') THEN Salary+Salary*12/100
 ELSE Salary
 END AS Salary
 FROM 
Employees AS e JOIN
Departments AS d
ON e.DepartmentID=d.DepartmentID