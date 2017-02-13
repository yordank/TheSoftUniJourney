UPDATE t
SET t.Price=t.Price+t.Price*0.5
FROM Tickets AS t
JOIN Flights AS f
  ON t.FlightID=f.FlightID
WHERE f.AirlineID=
(SELECT AirlineID FROM Airlines
WHERE Rating =(SELECT MAX(Rating) FROM Airlines))