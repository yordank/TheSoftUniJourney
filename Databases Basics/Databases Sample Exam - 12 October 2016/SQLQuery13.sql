SELECT TOP 5
       l.CustomerID,
	   l.Amount AS Amount 
  FROM Customers AS c
  LEFT JOIN Loans AS l
    ON c.CustomerID=l.CustomerID
 
 WHERE l.Amount >=(SELECT AVG(Amount) 
					  FROM Customers AS c
					  LEFT JOIN Loans AS l
						ON c.CustomerID=l.CustomerID
					 WHERE Gender='M'
					 )
 ORDER BY c.LastName ASC
 	  