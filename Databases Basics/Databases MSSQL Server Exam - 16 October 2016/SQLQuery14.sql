SELECT TOP 3
       c.CustomerID,
       c.FirstName+' '+c.LastName,
	   t.Price,
	   A.AirportName 
 FROM Customers AS c
 LEFT JOIN Tickets AS t
   ON t.CustomerID=c.CustomerID
 JOIN Flights AS f
   ON f.FlightID=t.FlightID
 JOIN Airports AS a
   ON f.DestinationAirportID=a.AirportID
WHERE f.Status='Delayed'
ORDER BY t.price DESC