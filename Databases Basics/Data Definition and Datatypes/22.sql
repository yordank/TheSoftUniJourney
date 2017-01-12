--Problem 22.	Increase Employees Salary
--Use SoftUni database and increase the salary of all employees by 10%. Select only Salary column from the Employees table. Submit your query statements as Prepare DB & Run queries.
UPDATE Employees
SET SALARY = SALARY*1.1

SELECT Salary FROM Employees