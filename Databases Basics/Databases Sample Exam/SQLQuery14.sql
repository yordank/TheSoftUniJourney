SELECT 
	   COUNT(a.Id) AS AdsCount,
       CASE 
	       WHEN t.Name  IS NULL THEN '(no town)'
		   ELSE t.name
		END AS Town
        
  FROM Ads AS a
  LEFT JOIN Towns AS t
    ON a.TownId=t.Id
  GROUP BY t.Name 
 HAVING COUNT(a.Id) IN (2,3)
 ORDER BY t.Name