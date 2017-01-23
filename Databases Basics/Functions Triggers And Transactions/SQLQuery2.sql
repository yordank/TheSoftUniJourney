CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber (@money Money)
AS
BEGIN
  SELECT FirstName,LastName
    FROM Employees
   WHERE Salary>=@money
END

--EXEC usp_GetEmployeesSalaryAboveNumber 35000
