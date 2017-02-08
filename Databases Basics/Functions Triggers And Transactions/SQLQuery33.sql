SELECT ct.ContinentName,
	   SUM(c.AreaInSqKm) AS CountriesArea,
       SUM(CAST( c.Population AS BIGINT )) AS CountriesPopulation
  FROM Continents AS ct
  LEFT JOIN Countries AS c
    ON ct.ContinentCode=c.ContinentCode
 GROUP BY ct.ContinentName
 ORDER BY SUM(CAST( c.Population AS BIGINT )) DESC