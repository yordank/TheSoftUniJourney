SELECT  Distinct 
        c.CustomerID,
        c.FirstName+' '+c.LastName,
	    -DATEDIFF(YEAR,'2016-01-01',c.DateOfBirth) 
 FROM Tickets AS t
 JOIN Customers AS c
   ON t.CustomerID=c.CustomerID
 JOIN Flights AS f
   ON f.FlightID=t.FlightID
 WHERE f.Status='Departing'
 ORDER BY -DATEDIFF(YEAR,'2016-01-01',c.DateOfBirth) ,c.CustomerID