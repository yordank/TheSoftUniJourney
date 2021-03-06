--SELECT AVG(Mind) AS 'AVG(Mind)',
--       AVG(Luck) AS 'AVG(Luck)',
--	   AVG(Speed) AS 'AVG(Speed)' 
--  FROM Items AS i
--  JOIN [Statistics] AS s
--    ON i.StatisticId=s.Id

SELECT i.Name,
	   i.Price,
	   i.MinLevel,
	   s.Strength,
	   s.Defence,
	   s.Speed,
	   s.Luck,
	   s.Mind	 
  FROM Items AS i
  JOIN [Statistics] AS s
	ON i.StatisticId=s.Id 
 WHERE s.Speed>9 AND s.Mind>9 AND s.Luck>9
 ORDER BY i.Name ASC