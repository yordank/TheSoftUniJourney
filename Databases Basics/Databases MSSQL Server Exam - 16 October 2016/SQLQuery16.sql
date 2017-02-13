SELECT DISTINCT
       c.CustomerID,
       c.FirstName+' '+c.LastName,
	   DATEDIFF(YEAR,DateOfBirth,'2016-01-01')
 FROM Customers AS c
 LEFT JOIN Tickets AS t
   ON c.CustomerID=t.CustomerID
 JOIN Flights AS f
   ON f.FlightID=t.FlightID 
WHERE f.Status='Arrived'
  AND DATEDIFF(YEAR,DateOfBirth,'2016-01-01')<21
ORDER BY DATEDIFF(YEAR,DateOfBirth,'2016-01-01') DESC,c.CustomerID