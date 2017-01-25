CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@money MONEY)
AS
BEGIN

SELECT   
		table2.FirstName,
		table2.LastName
  FROM   
 
 (	
  SELECT a.AccountHolderId,
         SUM(a.Balance) AS Total
  FROM Accounts AS a
 GROUP BY a.AccountHolderId
  )
  AS table1
  JOIN 
  AccountHolders AS table2
    ON table1.AccountHolderId=table2.Id
  WHERE table1.Total>@money
  ORDER BY table2.LastName,table2.FirstName 
END

--EXEC usp_GetHoldersWithBalanceHigherThan 1000


