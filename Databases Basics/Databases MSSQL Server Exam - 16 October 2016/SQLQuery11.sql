SELECT t.TicketId
      ,a.AirportName,
	   c.FirstName+' '+c.LastName 
  FROM Tickets AS t
  JOIN Customers AS c
    ON t.CustomerID=c.CustomerID
  JOIN Flights AS f
    ON f.FlightID=t.FlightID
  JOIN Airports AS a
    ON f.DestinationAirportID=a.AirportID
 WHERE Class='First' AND Price<5000
 ORDER BY t.TicketId