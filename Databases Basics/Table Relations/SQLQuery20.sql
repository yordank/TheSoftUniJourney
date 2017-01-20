SELECT TOP 5
       c.CountryName,
	   MAX(m1.Elevation) HighestPeakElevation,
	   MAX(r.Length) AS LongestRiverLength
 FROM Countries AS c
 LEFT JOIN CountriesRivers AS cr
 ON c.CountryCode=cr.CountryCode
 LEFT JOIN Rivers AS r
 ON r.Id=cr.RiverId
 LEFT JOIN MountainsCountries AS mc
 ON mc.CountryCode=c.CountryCode
 LEFT JOIN (
			SELECT t1.Id,
			       t1.MountainRange,
				   t2.Elevation 
			FROM Mountains AS t1
			JOIN Peaks AS t2
			   ON t1.Id=t2.MountainId
			 
		    )AS m1
 ON m1.Id=mc.MountainId
 GROUP BY c.CountryName     
 ORDER BY MAX(m1.Elevation) DESC, MAX(r.Length) DESC,c.CountryName