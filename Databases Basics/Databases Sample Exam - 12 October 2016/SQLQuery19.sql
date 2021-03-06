  --CREATE TABLE AccountLogs
  --(
  --AccountID INT,
  --AccountNumber CHAR(12),
  --StartDate DATE,
  --CustomerID INT
  --)

  CREATE TRIGGER t2 
  ON Accounts
  INSTEAD OF DELETE
  AS
  BEGIN
     DELETE FROM EmployeesAccounts 
	 WHERE AccountID IN (SELECT AccountID FROM deleted)

	 DELETE FROM Accounts
	 WHERE AccountID IN  (SELECT AccountID FROM deleted)

     INSERT INTO AccountLogs SELECT * FROM deleted
  END

  --DELETE FROM [dbo].[Accounts] WHERE CustomerID = 4