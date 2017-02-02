CREATE PROCEDURE usp_DepositMoney (@AccountId INT,@moneyAmount MONEY)
AS
BEGIN
	 
		UPDATE Accounts 
		SET   Balance=@moneyAmount+(
									SELECT Balance 
									  FROM Accounts
									 WHERE Id=@AccountId 
									)
		WHERE @AccountId=Id
	
END 

--EXEC usp_DepositMoney 1002,100

--SELECT * FROM Accounts