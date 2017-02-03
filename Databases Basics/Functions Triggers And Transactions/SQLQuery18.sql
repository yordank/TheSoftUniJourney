--CREATE TABLE NotificationEmails
--(
-- Id INT PRIMARY KEY IDENTITY,
-- Recipient INT,
-- Subject NVARCHAR(MAX),
-- Body NVARCHAR(MAX)
--)

CREATE TRIGGER tr_NotificationRecords
ON Logs
AFTER INSERT
AS
BEGIN
	
	DECLARE @recipient INT=(SELECT AccountId FROM inserted)
	DECLARE @oldSum MONEY =(SELECT oldSum FROM inserted) 
	DECLARE @newSum MONEY=(SELECT newSum FROM inserted)
	DECLARE @date NVARCHAR(100)=FORMAT(GETDATE(),'MMM dd yyyy h:mm tt', 'en-us')
	INSERT INTO NotificationEmails(Recipient,Subject,Body)
	VALUES (@recipient,'Balance change for account: '+CONVERT(varchar(10),@recipient),'On '+@date+' your balance was changed from '+CONVERT(varchar(10),@oldSum)+' to '+CONVERT(varchar(10),@newSum)+'.')

END


 --SELECT * FROM NotificationEmails

  --UPDATE Accounts
  --SET Balance=12.122
  --WHERE Id=1003

  --SELECT * FROM Logs