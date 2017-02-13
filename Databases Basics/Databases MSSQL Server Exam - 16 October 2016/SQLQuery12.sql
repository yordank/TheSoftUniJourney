SELECT c.CustomerID,
       c.FirstName+' '+c.LastName,
	   t.TownName 
  FROM Customers AS C
  JOIN Towns AS t
    ON c.HomeTownID=t.TownID
  LEFT JOIN Tickets AS tt
	ON tt.CustomerID=c.CustomerID
  JOIN Flights AS f
    ON f.FlightID=tt.FlightID
  JOIN Airports AS a
    ON f.OriginAirportID=a.AirportID
  JOIN Towns as t2
    ON t2.TownID=a.TownID
 WHERE t2.TownName=t.TownName
   AND f.Status='Departing'  
 ORDER BY c.CustomerID