SELECT a.AirportID,a.AirportName  ,Count(t.TicketId) AS Count
   FROM  Tickets AS t
   JOIN Flights AS f
     ON t.FlightID=f.FlightID
   JOIN Airports AS a
	 ON a.AirportID=f.OriginAirportID
  WHERE f.Status='Departing'
  GROUP BY a.AirportID,a.AirportName
  ORDER BY AirportID
 