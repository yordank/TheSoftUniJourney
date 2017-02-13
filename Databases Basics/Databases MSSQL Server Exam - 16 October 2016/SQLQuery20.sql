CREATE TRIGGER tr 
ON Flights
AFTER
UPDATE
AS
BEGIN
     if(COLUMNS_UPDATED ( )&8)>0
     BEGIN 
			   
			  INSERT  INTO ArrivedFlights
		         SELECT f.FlightID,
				        f.ArrivalTime,
						a.AirportName,
						aa.AirportName,
						COUNT(t.TicketId) AS count1
				   FROM Flights AS f
				   LEFT JOIN Tickets AS t
				     ON f.FlightID=t.FlightID
					 JOIN Airports AS a
					 ON a.AirportID=f.OriginAirportID
					 JOIN Airports AS aa
					 ON aa.AirportID=f.DestinationAirportID
					 WHERE f.FlightID IN (SELECT FlightID FROM inserted WHERE f.Status='Arrived')
					 GROUP BY f.FlightID,
				           f.ArrivalTime,
						   a.AirportName,
						   aa.AirportName 
                     HAVING COUNT(t.TicketId) >=0
 
     END
END
