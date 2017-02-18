SELECT a.Title,
       t.Name AS Town 
  FROM Ads AS a
  LEFT JOIN Towns AS t
    ON a.TownId=t.Id
  ORDER BY a.Id