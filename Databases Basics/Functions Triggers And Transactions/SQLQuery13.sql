CREATE PROCEDURE usp_CalculateFutureValueForAccount (@AccountId INT,@Rate FLOAT) 
AS
BEGIN
	
		SELECT ah.Id,
			   ah.FirstName,
			   ah.LastName,
			   a.Balance AS 'Current Balance',
			   [dbo].[ufn_CalculateFutureValue](a.Balance,@Rate,5) AS 'Balance in 5 years'
		  FROM AccountHolders AS ah
		  JOIN Accounts AS a
			ON ah.Id=a.AccountHolderId
		 WHERE a.Id=@AccountId
END


--EXEC usp_CalculateFutureValueForAccount 1002,0.1
 
 

