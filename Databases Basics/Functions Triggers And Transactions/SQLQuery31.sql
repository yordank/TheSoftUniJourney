SELECT 
	   c.CountryName,
	   ct.ContinentName,
	   COUNT(r.RiverName),
	   CASE
	    WHEN SUM(r.Length)>0 THEN SUM(r.Length) 
		ELSE 0
	   END
	   	
  FROM CountriesRivers AS cr
  JOIN Rivers AS r
    ON cr.RiverId=r.Id
  RIGHT JOIN Countries AS c
    ON c.CountryCode=cr.CountryCode
  JOIN Continents AS ct
    ON ct.ContinentCode=c.ContinentCode
 GROUP BY c.CountryName,ct.ContinentName
 ORDER BY COUNT(r.RiverName) DESC,SUM(r.Length) DESC,c.CountryName ASC
