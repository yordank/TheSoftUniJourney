CREATE PROCEDURE usp_EmployeesBySalaryLevel (@level VARCHAR(100))
AS
BEGIN
	 SELECT  
	       FirstName,
		   LastName
	   FROM Employees
	  WHERE [dbo].[ufn_GetSalaryLevel](Salary)=@level
END

--EXEC usp_EmployeesBySalaryLevel 'High'