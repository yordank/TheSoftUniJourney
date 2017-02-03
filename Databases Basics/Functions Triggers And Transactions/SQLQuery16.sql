CREATE PROCEDURE usp_TransferMoney(@senderId INT,@receiverId INT,@amount MONEY)
AS
BEGIN
	if(@amount>=0)
	BEGIN
	EXEC [dbo].[usp_DepositMoney] @receiverId,@amount
	EXEC [dbo].[usp_WithdrawMoney] @senderId,@amount
	END
	ELSE
	BEGIN
	EXEC [dbo].[usp_DepositMoney] @senderId,@amount
	EXEC [dbo].[usp_WithdrawMoney] @receiverId,@amount
	END
END 


--EXEC usp_TransferMoney 2,3,100
 

-- SELECT * FROM Accounts