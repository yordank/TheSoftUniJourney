CREATE FUNCTION ufn_GetSalaryLevel(@salary MONEY)
RETURNS VARCHAR(100)
AS
 BEGIN
   DECLARE @result VARCHAR(10);
   IF(@salary<30000.00)
     SET @result='Low'
   IF(@salary<=50000 AND @salary>=30000)
	 SET @result='Average'
   IF(@salary>50000)
     SET @result='High'


   RETURN @result
 END

--SELECT [dbo].[ufn_GetSalaryLevel](Salary),Salary 
--   FROM Employees
--   ORDER BY Salary