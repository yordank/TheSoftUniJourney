SELECT TOP 5 
		a.AirlineID,
		AirlineName,
		a.Nationality,
		MAX(a.Rating)
 FROM
   Flights AS f
 JOIN 
      Airlines AS a
   ON f.AirlineID=a.AirlineID
GROUP BY a.AirlineName,a.Nationality,a.AirlineID
ORDER BY MAX(a.Rating) DESC,a.AirlineID