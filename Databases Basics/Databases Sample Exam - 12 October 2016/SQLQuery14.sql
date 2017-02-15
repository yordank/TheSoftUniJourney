SELECT c.CustomerID,
       c.FirstName,
	   a.StartDate
  FROM Customers AS c
  LEFT JOIN Accounts AS a
    ON c.CustomerID=a.CustomerID 
 WHERE a.StartDate=(SELECT MIN(StartDate) FROM Accounts)