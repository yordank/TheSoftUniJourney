SELECT * FROM
(
SELECT TOP 5
       f.FlightID,
	   f.DepartureTime,
	   f.ArrivalTime,
	   a.AirportName AS Origin,
	   a2.AirportName AS Destination
  FROM Flights AS f
  JOIN Airports AS a
    ON f.OriginAirportID=a.AirportID
  JOIN Airports AS a2
    ON f.DestinationAirportID=a2.AirportID
 WHERE f.Status='Departing'
 ORDER BY f.DepartureTime DESC,f.FlightID
)AS tabl
ORDER BY tabl.DepartureTime 