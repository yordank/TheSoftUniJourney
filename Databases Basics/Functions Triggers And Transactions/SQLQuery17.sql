--CREATE TABLE Logs
--(
--LogId INT PRIMARY KEY IDENTITY,
--AccountId INT,
--OldSum MONEY,
--NewSum MONEY
--)

CREATE TRIGGER tr_LogRecords
ON Accounts
INSTEAD OF UPDATE
AS
BEGIN
	 
  	
   
  DECLARE @newBalance MONEY=(SELECT Balance FROM inserted)
  DECLARE @id INT =(SELECT id FROM inserted) 
  DECLARE @oldBalance MONEY=(SELECT Balance FROM Accounts WHERE id=@id)

  UPDATE Accounts
  SET Balance=@newBalance
  WHERE id=@id

  INSERT INTO Logs(AccountId,OldSum,NewSum)
  VALUES (@id,@oldBalance,@newBalance)

END

--SELECT TOP (1000) [Id]
--      ,[AccountHolderId]
--      ,[Balance]
--  FROM [BANK_EXERCISE].[dbo].[Accounts]

--  UPDATE Accounts
--  SET Balance=2
--  WHERE Id=1003

--  SELECT * FROM Logs